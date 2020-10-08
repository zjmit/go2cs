//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:34:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using os = go.os_package;
using sync = go.sync_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class lockedfile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Mutex
        {
            // Constructors
            public Mutex(NilType _)
            {
                this.Path = default;
                this.mu = default;
            }

            public Mutex(@string Path = default, sync.Mutex mu = default)
            {
                this.Path = Path;
                this.mu = mu;
            }

            // Enable comparisons between nil and Mutex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Mutex value, NilType nil) => value.Equals(default(Mutex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Mutex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Mutex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Mutex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Mutex(NilType nil) => default(Mutex);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Mutex Mutex_cast(dynamic value)
        {
            return new Mutex(value.Path, value.mu);
        }
    }
}}}}