//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:40:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using sym = go.cmd.oldlink.@internal.sym_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using go;

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct deadcodepass
        {
            // Constructors
            public deadcodepass(NilType _)
            {
                this.ctxt = default;
                this.markQueue = default;
                this.ifaceMethod = default;
                this.markableMethods = default;
                this.reflectMethod = default;
            }

            public deadcodepass(ref ptr<Link> ctxt = default, slice<ptr<sym.Symbol>> markQueue = default, map<methodsig, bool> ifaceMethod = default, slice<methodref> markableMethods = default, bool reflectMethod = default)
            {
                this.ctxt = ctxt;
                this.markQueue = markQueue;
                this.ifaceMethod = ifaceMethod;
                this.markableMethods = markableMethods;
                this.reflectMethod = reflectMethod;
            }

            // Enable comparisons between nil and deadcodepass struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(deadcodepass value, NilType nil) => value.Equals(default(deadcodepass));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(deadcodepass value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, deadcodepass value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, deadcodepass value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator deadcodepass(NilType nil) => default(deadcodepass);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static deadcodepass deadcodepass_cast(dynamic value)
        {
            return new deadcodepass(ref value.ctxt, value.markQueue, value.ifaceMethod, value.markableMethods, value.reflectMethod);
        }
    }
}}}}