//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:45:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using unix = go.golang.org.x.sys.unix_package;
using io = go.io_package;
using syscall = go.syscall_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace crypto {
namespace ssh
{
    public static partial class terminal_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct State
        {
            // Constructors
            public State(NilType _)
            {
                this.termios = default;
            }

            public State(unix.Termios termios = default)
            {
                this.termios = termios;
            }

            // Enable comparisons between nil and State struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(State value, NilType nil) => value.Equals(default(State));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(State value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, State value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, State value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator State(NilType nil) => default(State);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static State State_cast(dynamic value)
        {
            return new State(value.termios);
        }
    }
}}}}}}}