//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:35:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using subtleoverlap = go.crypto.@internal.subtle_package;
using subtle = go.crypto.subtle_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using go;

namespace go {
namespace crypto
{
    public static partial class cipher_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gcm
        {
            // Constructors
            public gcm(NilType _)
            {
                this.cipher = default;
                this.nonceSize = default;
                this.tagSize = default;
                this.productTable = default;
            }

            public gcm(Block cipher = default, long nonceSize = default, long tagSize = default, array<gcmFieldElement> productTable = default)
            {
                this.cipher = cipher;
                this.nonceSize = nonceSize;
                this.tagSize = tagSize;
                this.productTable = productTable;
            }

            // Enable comparisons between nil and gcm struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gcm value, NilType nil) => value.Equals(default(gcm));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gcm value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gcm value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gcm value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gcm(NilType nil) => default(gcm);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gcm gcm_cast(dynamic value)
        {
            return new gcm(value.cipher, value.nonceSize, value.tagSize, value.productTable);
        }
    }
}}