//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Sigset_t
        {
            // Constructors
            public Sigset_t(NilType _)
            {
                this.Val = default;
            }

            public Sigset_t(array<uint> Val = default)
            {
                this.Val = Val;
            }

            // Enable comparisons between nil and Sigset_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Sigset_t value, NilType nil) => value.Equals(default(Sigset_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Sigset_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Sigset_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Sigset_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Sigset_t(NilType nil) => default(Sigset_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Sigset_t Sigset_t_cast(dynamic value)
        {
            return new Sigset_t(value.Val);
        }
    }
}}}}}}