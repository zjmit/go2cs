//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:41 UTC
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
        public partial struct Clockinfo
        {
            // Constructors
            public Clockinfo(NilType _)
            {
                this.Hz = default;
                this.Tick = default;
                this.Tickadj = default;
                this.Stathz = default;
                this.Profhz = default;
            }

            public Clockinfo(int Hz = default, int Tick = default, int Tickadj = default, int Stathz = default, int Profhz = default)
            {
                this.Hz = Hz;
                this.Tick = Tick;
                this.Tickadj = Tickadj;
                this.Stathz = Stathz;
                this.Profhz = Profhz;
            }

            // Enable comparisons between nil and Clockinfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Clockinfo value, NilType nil) => value.Equals(default(Clockinfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Clockinfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Clockinfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Clockinfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Clockinfo(NilType nil) => default(Clockinfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Clockinfo Clockinfo_cast(dynamic value)
        {
            return new Clockinfo(value.Hz, value.Tick, value.Tickadj, value.Stathz, value.Profhz);
        }
    }
}}}}}}