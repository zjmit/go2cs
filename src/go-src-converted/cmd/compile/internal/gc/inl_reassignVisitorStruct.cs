//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:27:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct reassignVisitor
        {
            // Constructors
            public reassignVisitor(NilType _)
            {
                this.name = default;
            }

            public reassignVisitor(ref ptr<Node> name = default)
            {
                this.name = name;
            }

            // Enable comparisons between nil and reassignVisitor struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(reassignVisitor value, NilType nil) => value.Equals(default(reassignVisitor));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(reassignVisitor value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, reassignVisitor value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, reassignVisitor value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator reassignVisitor(NilType nil) => default(reassignVisitor);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static reassignVisitor reassignVisitor_cast(dynamic value)
        {
            return new reassignVisitor(ref value.name);
        }
    }
}}}}