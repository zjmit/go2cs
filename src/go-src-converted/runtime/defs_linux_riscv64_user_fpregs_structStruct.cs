//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct user_fpregs_struct
        {
            // Constructors
            public user_fpregs_struct(NilType _)
            {
                this.f = default;
            }

            public user_fpregs_struct(array<byte> f = default)
            {
                this.f = f;
            }

            // Enable comparisons between nil and user_fpregs_struct struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(user_fpregs_struct value, NilType nil) => value.Equals(default(user_fpregs_struct));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(user_fpregs_struct value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, user_fpregs_struct value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, user_fpregs_struct value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator user_fpregs_struct(NilType nil) => default(user_fpregs_struct);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static user_fpregs_struct user_fpregs_struct_cast(dynamic value)
        {
            return new user_fpregs_struct(value.f);
        }
    }
}