//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:33 UTC
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
        private partial struct vdsoTimekeep
        {
            // Constructors
            public vdsoTimekeep(NilType _)
            {
                this.ver = default;
                this.enabled = default;
                this.current = default;
                this.pad_cgo_0 = default;
            }

            public vdsoTimekeep(uint ver = default, uint enabled = default, uint current = default, array<byte> pad_cgo_0 = default)
            {
                this.ver = ver;
                this.enabled = enabled;
                this.current = current;
                this.pad_cgo_0 = pad_cgo_0;
            }

            // Enable comparisons between nil and vdsoTimekeep struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(vdsoTimekeep value, NilType nil) => value.Equals(default(vdsoTimekeep));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(vdsoTimekeep value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, vdsoTimekeep value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, vdsoTimekeep value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator vdsoTimekeep(NilType nil) => default(vdsoTimekeep);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static vdsoTimekeep vdsoTimekeep_cast(dynamic value)
        {
            return new vdsoTimekeep(value.ver, value.enabled, value.current, value.pad_cgo_0);
        }
    }
}