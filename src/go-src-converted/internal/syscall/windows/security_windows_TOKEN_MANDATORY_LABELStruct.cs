//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:32:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace @internal {
namespace syscall
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TOKEN_MANDATORY_LABEL
        {
            // Constructors
            public TOKEN_MANDATORY_LABEL(NilType _)
            {
                this.Label = default;
            }

            public TOKEN_MANDATORY_LABEL(SID_AND_ATTRIBUTES Label = default)
            {
                this.Label = Label;
            }

            // Enable comparisons between nil and TOKEN_MANDATORY_LABEL struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TOKEN_MANDATORY_LABEL value, NilType nil) => value.Equals(default(TOKEN_MANDATORY_LABEL));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TOKEN_MANDATORY_LABEL value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TOKEN_MANDATORY_LABEL value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TOKEN_MANDATORY_LABEL value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TOKEN_MANDATORY_LABEL(NilType nil) => default(TOKEN_MANDATORY_LABEL);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TOKEN_MANDATORY_LABEL TOKEN_MANDATORY_LABEL_cast(dynamic value)
        {
            return new TOKEN_MANDATORY_LABEL(value.Label);
        }
    }
}}}