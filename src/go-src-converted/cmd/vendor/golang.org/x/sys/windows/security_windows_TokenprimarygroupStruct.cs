//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:48 UTC
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
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Tokenprimarygroup
        {
            // Constructors
            public Tokenprimarygroup(NilType _)
            {
                this.PrimaryGroup = default;
            }

            public Tokenprimarygroup(ref ptr<SID> PrimaryGroup = default)
            {
                this.PrimaryGroup = PrimaryGroup;
            }

            // Enable comparisons between nil and Tokenprimarygroup struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Tokenprimarygroup value, NilType nil) => value.Equals(default(Tokenprimarygroup));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Tokenprimarygroup value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Tokenprimarygroup value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Tokenprimarygroup value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tokenprimarygroup(NilType nil) => default(Tokenprimarygroup);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Tokenprimarygroup Tokenprimarygroup_cast(dynamic value)
        {
            return new Tokenprimarygroup(ref value.PrimaryGroup);
        }
    }
}}}}}}