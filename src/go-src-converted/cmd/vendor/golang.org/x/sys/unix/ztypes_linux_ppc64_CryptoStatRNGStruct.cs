//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:36 UTC
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
        public partial struct CryptoStatRNG
        {
            // Constructors
            public CryptoStatRNG(NilType _)
            {
                this.Type = default;
                this.Generate_cnt = default;
                this.Generate_tlen = default;
                this.Seed_cnt = default;
                this.Err_cnt = default;
            }

            public CryptoStatRNG(array<byte> Type = default, ulong Generate_cnt = default, ulong Generate_tlen = default, ulong Seed_cnt = default, ulong Err_cnt = default)
            {
                this.Type = Type;
                this.Generate_cnt = Generate_cnt;
                this.Generate_tlen = Generate_tlen;
                this.Seed_cnt = Seed_cnt;
                this.Err_cnt = Err_cnt;
            }

            // Enable comparisons between nil and CryptoStatRNG struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptoStatRNG value, NilType nil) => value.Equals(default(CryptoStatRNG));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptoStatRNG value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptoStatRNG value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptoStatRNG value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptoStatRNG(NilType nil) => default(CryptoStatRNG);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CryptoStatRNG CryptoStatRNG_cast(dynamic value)
        {
            return new CryptoStatRNG(value.Type, value.Generate_cnt, value.Generate_tlen, value.Seed_cnt, value.Err_cnt);
        }
    }
}}}}}}