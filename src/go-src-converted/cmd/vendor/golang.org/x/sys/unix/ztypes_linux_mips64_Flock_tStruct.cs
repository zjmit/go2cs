//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:35 UTC
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
        public partial struct Flock_t
        {
            // Constructors
            public Flock_t(NilType _)
            {
                this.Type = default;
                this.Whence = default;
                this.Start = default;
                this.Len = default;
                this.Pid = default;
                this._ = default;
            }

            public Flock_t(short Type = default, short Whence = default, long Start = default, long Len = default, int Pid = default, array<byte> _ = default)
            {
                this.Type = Type;
                this.Whence = Whence;
                this.Start = Start;
                this.Len = Len;
                this.Pid = Pid;
                this._ = _;
            }

            // Enable comparisons between nil and Flock_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Flock_t value, NilType nil) => value.Equals(default(Flock_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Flock_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Flock_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Flock_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Flock_t(NilType nil) => default(Flock_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Flock_t Flock_t_cast(dynamic value)
        {
            return new Flock_t(value.Type, value.Whence, value.Start, value.Len, value.Pid, value._);
        }
    }
}}}}}}