//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Flock_t
        {
            // Constructors
            public Flock_t(NilType _)
            {
                this.Type = default;
                this.Whence = default;
                this.Sysid = default;
                this.Pid = default;
                this.Vfs = default;
                this.Start = default;
                this.Len = default;
            }

            public Flock_t(short Type = default, short Whence = default, uint Sysid = default, int Pid = default, int Vfs = default, long Start = default, long Len = default)
            {
                this.Type = Type;
                this.Whence = Whence;
                this.Sysid = Sysid;
                this.Pid = Pid;
                this.Vfs = Vfs;
                this.Start = Start;
                this.Len = Len;
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
            return new Flock_t(value.Type, value.Whence, value.Sysid, value.Pid, value.Vfs, value.Start, value.Len);
        }
    }
}