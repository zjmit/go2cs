//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:38 UTC
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
        public partial struct CryptoReportCipher
        {
            // Constructors
            public CryptoReportCipher(NilType _)
            {
                this.Type = default;
                this.Blocksize = default;
                this.Min_keysize = default;
                this.Max_keysize = default;
            }

            public CryptoReportCipher(array<sbyte> Type = default, uint Blocksize = default, uint Min_keysize = default, uint Max_keysize = default)
            {
                this.Type = Type;
                this.Blocksize = Blocksize;
                this.Min_keysize = Min_keysize;
                this.Max_keysize = Max_keysize;
            }

            // Enable comparisons between nil and CryptoReportCipher struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptoReportCipher value, NilType nil) => value.Equals(default(CryptoReportCipher));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptoReportCipher value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptoReportCipher value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptoReportCipher value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptoReportCipher(NilType nil) => default(CryptoReportCipher);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CryptoReportCipher CryptoReportCipher_cast(dynamic value)
        {
            return new CryptoReportCipher(value.Type, value.Blocksize, value.Min_keysize, value.Max_keysize);
        }
    }
}}}}}}