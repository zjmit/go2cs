//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:43:51 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace ianlancetaylor
{
    public static partial class demangle_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SizeofArgs
        {
            // Constructors
            public SizeofArgs(NilType _)
            {
                this.Args = default;
            }

            public SizeofArgs(slice<AST> Args = default)
            {
                this.Args = Args;
            }

            // Enable comparisons between nil and SizeofArgs struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SizeofArgs value, NilType nil) => value.Equals(default(SizeofArgs));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SizeofArgs value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SizeofArgs value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SizeofArgs value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SizeofArgs(NilType nil) => default(SizeofArgs);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SizeofArgs SizeofArgs_cast(dynamic value)
        {
            return new SizeofArgs(value.Args);
        }
    }
}}}}}