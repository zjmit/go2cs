//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:26:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SysProcAttr
        {
            // Constructors
            public SysProcAttr(NilType _)
            {
                this.Rfork = default;
            }

            public SysProcAttr(long Rfork = default)
            {
                this.Rfork = Rfork;
            }

            // Enable comparisons between nil and SysProcAttr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SysProcAttr value, NilType nil) => value.Equals(default(SysProcAttr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SysProcAttr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SysProcAttr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SysProcAttr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SysProcAttr(NilType nil) => default(SysProcAttr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SysProcAttr SysProcAttr_cast(dynamic value)
        {
            return new SysProcAttr(value.Rfork);
        }
    }
}