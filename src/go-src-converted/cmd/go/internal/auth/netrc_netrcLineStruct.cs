//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:34:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class auth_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct netrcLine
        {
            // Constructors
            public netrcLine(NilType _)
            {
                this.machine = default;
                this.login = default;
                this.password = default;
            }

            public netrcLine(@string machine = default, @string login = default, @string password = default)
            {
                this.machine = machine;
                this.login = login;
                this.password = password;
            }

            // Enable comparisons between nil and netrcLine struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(netrcLine value, NilType nil) => value.Equals(default(netrcLine));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(netrcLine value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, netrcLine value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, netrcLine value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator netrcLine(NilType nil) => default(netrcLine);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static netrcLine netrcLine_cast(dynamic value)
        {
            return new netrcLine(value.machine, value.login, value.password);
        }
    }
}}}}