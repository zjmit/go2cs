//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:35:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using cipher = go.crypto.cipher_package;
using subtleoverlap = go.crypto.@internal.subtle_package;
using subtle = go.crypto.subtle_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using cpu = go.@internal.cpu_package;
using go;

namespace go {
namespace crypto
{
    public static partial class aes_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gcmAsm
        {
            // Constructors
            public gcmAsm(NilType _)
            {
                this.block = default;
                this.hashKey = default;
                this.nonceSize = default;
                this.tagSize = default;
            }

            public gcmAsm(ref ptr<aesCipherAsm> block = default, gcmHashKey hashKey = default, long nonceSize = default, long tagSize = default)
            {
                this.block = block;
                this.hashKey = hashKey;
                this.nonceSize = nonceSize;
                this.tagSize = tagSize;
            }

            // Enable comparisons between nil and gcmAsm struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gcmAsm value, NilType nil) => value.Equals(default(gcmAsm));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gcmAsm value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gcmAsm value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gcmAsm value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gcmAsm(NilType nil) => default(gcmAsm);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gcmAsm gcmAsm_cast(dynamic value)
        {
            return new gcmAsm(ref value.block, value.hashKey, value.nonceSize, value.tagSize);
        }
    }
}}