// Copyright 2012 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package x509 -- go2cs converted at 2020 October 08 03:36:47 UTC
// import "crypto/x509" ==> using x509 = go.crypto.x509_package
// Original source: C:\Go\src\crypto\x509\pem_decrypt.go
// RFC 1423 describes the encryption of PEM blocks. The algorithm used to
// generate a key from the password was derived by looking at the OpenSSL
// implementation.

using aes = go.crypto.aes_package;
using cipher = go.crypto.cipher_package;
using des = go.crypto.des_package;
using md5 = go.crypto.md5_package;
using hex = go.encoding.hex_package;
using pem = go.encoding.pem_package;
using errors = go.errors_package;
using io = go.io_package;
using strings = go.strings_package;
using static go.builtin;
using System;

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        public partial struct PEMCipher // : long
        {
        }

        // Possible values for the EncryptPEMBlock encryption algorithm.
        private static readonly PEMCipher _ = (PEMCipher)iota;
        public static readonly var PEMCipherDES = (var)0;
        public static readonly var PEMCipher3DES = (var)1;
        public static readonly var PEMCipherAES128 = (var)2;
        public static readonly var PEMCipherAES192 = (var)3;
        public static readonly var PEMCipherAES256 = (var)4;


        // rfc1423Algo holds a method for enciphering a PEM block.
        private partial struct rfc1423Algo
        {
            public PEMCipher cipher;
            public @string name;
            public Func<slice<byte>, (cipher.Block, error)> cipherFunc;
            public long keySize;
            public long blockSize;
        }

        // rfc1423Algos holds a slice of the possible ways to encrypt a PEM
        // block. The ivSize numbers were taken from the OpenSSL source.
        private static rfc1423Algo rfc1423Algos = new slice<rfc1423Algo>(new rfc1423Algo[] { {cipher:PEMCipherDES,name:"DES-CBC",cipherFunc:des.NewCipher,keySize:8,blockSize:des.BlockSize,}, {cipher:PEMCipher3DES,name:"DES-EDE3-CBC",cipherFunc:des.NewTripleDESCipher,keySize:24,blockSize:des.BlockSize,}, {cipher:PEMCipherAES128,name:"AES-128-CBC",cipherFunc:aes.NewCipher,keySize:16,blockSize:aes.BlockSize,}, {cipher:PEMCipherAES192,name:"AES-192-CBC",cipherFunc:aes.NewCipher,keySize:24,blockSize:aes.BlockSize,}, {cipher:PEMCipherAES256,name:"AES-256-CBC",cipherFunc:aes.NewCipher,keySize:32,blockSize:aes.BlockSize,} });

        // deriveKey uses a key derivation function to stretch the password into a key
        // with the number of bits our cipher requires. This algorithm was derived from
        // the OpenSSL source.
        private static slice<byte> deriveKey(this rfc1423Algo c, slice<byte> password, slice<byte> salt)
        {
            var hash = md5.New();
            var @out = make_slice<byte>(c.keySize);
            slice<byte> digest = default;

            {
                long i = 0L;

                while (i < len(out))
                {
                    hash.Reset();
                    hash.Write(digest);
                    hash.Write(password);
                    hash.Write(salt);
                    digest = hash.Sum(digest[..0L]);
                    copy(out[i..], digest);
                    i += len(digest);
                }

            }
            return out;

        }

        // IsEncryptedPEMBlock returns if the PEM block is password encrypted.
        public static bool IsEncryptedPEMBlock(ptr<pem.Block> _addr_b)
        {
            ref pem.Block b = ref _addr_b.val;

            var (_, ok) = b.Headers["DEK-Info"];
            return ok;
        }

        // IncorrectPasswordError is returned when an incorrect password is detected.
        public static var IncorrectPasswordError = errors.New("x509: decryption password incorrect");

        // DecryptPEMBlock takes a password encrypted PEM block and the password used to
        // encrypt it and returns a slice of decrypted DER encoded bytes. It inspects
        // the DEK-Info header to determine the algorithm used for decryption. If no
        // DEK-Info header is present, an error is returned. If an incorrect password
        // is detected an IncorrectPasswordError is returned. Because of deficiencies
        // in the encrypted-PEM format, it's not always possible to detect an incorrect
        // password. In these cases no error will be returned but the decrypted DER
        // bytes will be random noise.
        public static (slice<byte>, error) DecryptPEMBlock(ptr<pem.Block> _addr_b, slice<byte> password)
        {
            slice<byte> _p0 = default;
            error _p0 = default!;
            ref pem.Block b = ref _addr_b.val;

            var (dek, ok) = b.Headers["DEK-Info"];
            if (!ok)
            {
                return (null, error.As(errors.New("x509: no DEK-Info header in block"))!);
            }

            var idx = strings.Index(dek, ",");
            if (idx == -1L)
            {
                return (null, error.As(errors.New("x509: malformed DEK-Info header"))!);
            }

            var mode = dek[..idx];
            var hexIV = dek[idx + 1L..];
            var ciph = cipherByName(mode);
            if (ciph == null)
            {
                return (null, error.As(errors.New("x509: unknown encryption mode"))!);
            }

            var (iv, err) = hex.DecodeString(hexIV);
            if (err != null)
            {
                return (null, error.As(err)!);
            }

            if (len(iv) != ciph.blockSize)
            {
                return (null, error.As(errors.New("x509: incorrect IV size"))!);
            } 

            // Based on the OpenSSL implementation. The salt is the first 8 bytes
            // of the initialization vector.
            var key = ciph.deriveKey(password, iv[..8L]);
            var (block, err) = ciph.cipherFunc(key);
            if (err != null)
            {
                return (null, error.As(err)!);
            }

            if (len(b.Bytes) % block.BlockSize() != 0L)
            {
                return (null, error.As(errors.New("x509: encrypted PEM data is not a multiple of the block size"))!);
            }

            var data = make_slice<byte>(len(b.Bytes));
            var dec = cipher.NewCBCDecrypter(block, iv);
            dec.CryptBlocks(data, b.Bytes); 

            // Blocks are padded using a scheme where the last n bytes of padding are all
            // equal to n. It can pad from 1 to blocksize bytes inclusive. See RFC 1423.
            // For example:
            //    [x y z 2 2]
            //    [x y 7 7 7 7 7 7 7]
            // If we detect a bad padding, we assume it is an invalid password.
            var dlen = len(data);
            if (dlen == 0L || dlen % ciph.blockSize != 0L)
            {
                return (null, error.As(errors.New("x509: invalid padding"))!);
            }

            var last = int(data[dlen - 1L]);
            if (dlen < last)
            {
                return (null, error.As(IncorrectPasswordError)!);
            }

            if (last == 0L || last > ciph.blockSize)
            {
                return (null, error.As(IncorrectPasswordError)!);
            }

            foreach (var (_, val) in data[dlen - last..])
            {
                if (int(val) != last)
                {
                    return (null, error.As(IncorrectPasswordError)!);
                }

            }
            return (data[..dlen - last], error.As(null!)!);

        }

        // EncryptPEMBlock returns a PEM block of the specified type holding the
        // given DER-encoded data encrypted with the specified algorithm and
        // password.
        public static (ptr<pem.Block>, error) EncryptPEMBlock(io.Reader rand, @string blockType, slice<byte> data, slice<byte> password, PEMCipher alg)
        {
            ptr<pem.Block> _p0 = default!;
            error _p0 = default!;

            var ciph = cipherByKey(alg);
            if (ciph == null)
            {
                return (_addr_null!, error.As(errors.New("x509: unknown encryption mode"))!);
            }

            var iv = make_slice<byte>(ciph.blockSize);
            {
                var (_, err) = io.ReadFull(rand, iv);

                if (err != null)
                {
                    return (_addr_null!, error.As(errors.New("x509: cannot generate IV: " + err.Error()))!);
                } 
                // The salt is the first 8 bytes of the initialization vector,
                // matching the key derivation in DecryptPEMBlock.

            } 
            // The salt is the first 8 bytes of the initialization vector,
            // matching the key derivation in DecryptPEMBlock.
            var key = ciph.deriveKey(password, iv[..8L]);
            var (block, err) = ciph.cipherFunc(key);
            if (err != null)
            {
                return (_addr_null!, error.As(err)!);
            }

            var enc = cipher.NewCBCEncrypter(block, iv);
            var pad = ciph.blockSize - len(data) % ciph.blockSize;
            var encrypted = make_slice<byte>(len(data), len(data) + pad); 
            // We could save this copy by encrypting all the whole blocks in
            // the data separately, but it doesn't seem worth the additional
            // code.
            copy(encrypted, data); 
            // See RFC 1423, Section 1.1.
            for (long i = 0L; i < pad; i++)
            {
                encrypted = append(encrypted, byte(pad));
            }

            enc.CryptBlocks(encrypted, encrypted);

            return (addr(new pem.Block(Type:blockType,Headers:map[string]string{"Proc-Type":"4,ENCRYPTED","DEK-Info":ciph.name+","+hex.EncodeToString(iv),},Bytes:encrypted,)), error.As(null!)!);

        }

        private static ptr<rfc1423Algo> cipherByName(@string name)
        {
            foreach (var (i) in rfc1423Algos)
            {
                var alg = _addr_rfc1423Algos[i];
                if (alg.name == name)
                {
                    return _addr_alg!;
                }

            }
            return _addr_null!;

        }

        private static ptr<rfc1423Algo> cipherByKey(PEMCipher key)
        {
            foreach (var (i) in rfc1423Algos)
            {
                var alg = _addr_rfc1423Algos[i];
                if (alg.cipher == key)
                {
                    return _addr_alg!;
                }

            }
            return _addr_null!;

        }
    }
}}
