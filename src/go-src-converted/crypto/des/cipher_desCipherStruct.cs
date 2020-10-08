//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:36:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using cipher = go.crypto.cipher_package;
using subtle = go.crypto.@internal.subtle_package;
using binary = go.encoding.binary_package;
using strconv = go.strconv_package;
using go;

namespace go {
namespace crypto
{
    public static partial class des_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct desCipher
        {
            // Constructors
            public desCipher(NilType _)
            {
                this.subkeys = default;
            }

            public desCipher(array<ulong> subkeys = default)
            {
                this.subkeys = subkeys;
            }

            // Enable comparisons between nil and desCipher struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(desCipher value, NilType nil) => value.Equals(default(desCipher));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(desCipher value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, desCipher value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, desCipher value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator desCipher(NilType nil) => default(desCipher);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static desCipher desCipher_cast(dynamic value)
        {
            return new desCipher(value.subkeys);
        }
    }
}}