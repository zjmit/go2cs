//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CryptoStatCompress
        {
            // Constructors
            public CryptoStatCompress(NilType _)
            {
                this.Type = default;
                this.Compress_cnt = default;
                this.Compress_tlen = default;
                this.Decompress_cnt = default;
                this.Decompress_tlen = default;
                this.Err_cnt = default;
            }

            public CryptoStatCompress(array<byte> Type = default, ulong Compress_cnt = default, ulong Compress_tlen = default, ulong Decompress_cnt = default, ulong Decompress_tlen = default, ulong Err_cnt = default)
            {
                this.Type = Type;
                this.Compress_cnt = Compress_cnt;
                this.Compress_tlen = Compress_tlen;
                this.Decompress_cnt = Decompress_cnt;
                this.Decompress_tlen = Decompress_tlen;
                this.Err_cnt = Err_cnt;
            }

            // Enable comparisons between nil and CryptoStatCompress struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptoStatCompress value, NilType nil) => value.Equals(default(CryptoStatCompress));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptoStatCompress value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptoStatCompress value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptoStatCompress value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptoStatCompress(NilType nil) => default(CryptoStatCompress);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CryptoStatCompress CryptoStatCompress_cast(dynamic value)
        {
            return new CryptoStatCompress(value.Type, value.Compress_cnt, value.Compress_tlen, value.Decompress_cnt, value.Decompress_tlen, value.Err_cnt);
        }
    }
}}}}}}