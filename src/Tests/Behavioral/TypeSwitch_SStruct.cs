//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 August 06 03:29:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial struct S : EmptyInterface
        {
            // Constructors
            public S(NilType _)
            {
                this.name = default;
            }

            public S(@string name)
            {
                this.name = name;
            }

            // Enable comparisons between nil and S struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(S value, NilType nil) => value.Equals(default(S));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(S value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, S value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, S value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator S(NilType nil) => default(S);
        }

        [GeneratedCode("go2cs", "0.1.1.0")]
        public static S S_cast(dynamic value)
        {
            return new S(value.name);
        }
    }
}