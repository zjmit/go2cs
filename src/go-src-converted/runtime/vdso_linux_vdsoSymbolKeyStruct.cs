//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:24:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct vdsoSymbolKey
        {
            // Constructors
            public vdsoSymbolKey(NilType _)
            {
                this.name = default;
                this.symHash = default;
                this.gnuHash = default;
                this.ptr = default;
            }

            public vdsoSymbolKey(@string name = default, uint symHash = default, uint gnuHash = default, ref ptr<System.UIntPtr> ptr = default)
            {
                this.name = name;
                this.symHash = symHash;
                this.gnuHash = gnuHash;
                this.ptr = ptr;
            }

            // Enable comparisons between nil and vdsoSymbolKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(vdsoSymbolKey value, NilType nil) => value.Equals(default(vdsoSymbolKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(vdsoSymbolKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, vdsoSymbolKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, vdsoSymbolKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator vdsoSymbolKey(NilType nil) => default(vdsoSymbolKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static vdsoSymbolKey vdsoSymbolKey_cast(dynamic value)
        {
            return new vdsoSymbolKey(value.name, value.symHash, value.gnuHash, ref value.ptr);
        }
    }
}