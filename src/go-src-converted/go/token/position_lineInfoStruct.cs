//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:43:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using sort = go.sort_package;
using sync = go.sync_package;
using go;

namespace go {
namespace go
{
    public static partial class token_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct lineInfo
        {
            // Constructors
            public lineInfo(NilType _)
            {
                this.Offset = default;
                this.Filename = default;
                this.Line = default;
                this.Column = default;
            }

            public lineInfo(long Offset = default, @string Filename = default, long Line = default, long Column = default)
            {
                this.Offset = Offset;
                this.Filename = Filename;
                this.Line = Line;
                this.Column = Column;
            }

            // Enable comparisons between nil and lineInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lineInfo value, NilType nil) => value.Equals(default(lineInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lineInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lineInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lineInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lineInfo(NilType nil) => default(lineInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static lineInfo lineInfo_cast(dynamic value)
        {
            return new lineInfo(value.Offset, value.Filename, value.Line, value.Column);
        }
    }
}}