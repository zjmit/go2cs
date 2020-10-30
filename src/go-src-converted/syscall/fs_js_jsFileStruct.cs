//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:01:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using io = go.io_package;
using sync = go.sync_package;
using js = go.syscall.js_package;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct jsFile
        {
            // Constructors
            public jsFile(NilType _)
            {
                this.path = default;
                this.entries = default;
                this.dirIdx = default;
                this.pos = default;
                this.seeked = default;
            }

            public jsFile(@string path = default, slice<@string> entries = default, long dirIdx = default, long pos = default, bool seeked = default)
            {
                this.path = path;
                this.entries = entries;
                this.dirIdx = dirIdx;
                this.pos = pos;
                this.seeked = seeked;
            }

            // Enable comparisons between nil and jsFile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(jsFile value, NilType nil) => value.Equals(default(jsFile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(jsFile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, jsFile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, jsFile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator jsFile(NilType nil) => default(jsFile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static jsFile jsFile_cast(dynamic value)
        {
            return new jsFile(value.path, value.entries, value.dirIdx, value.pos, value.seeked);
        }
    }
}