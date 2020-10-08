//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:43:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using gob = go.encoding.gob_package;
using errors = go.errors_package;
using io = go.io_package;
using log = go.log_package;
using net = go.net_package;
using http = go.net.http_package;
using sync = go.sync_package;
using go;

namespace go {
namespace net
{
    public static partial class rpc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Call
        {
            // Constructors
            public Call(NilType _)
            {
                this.ServiceMethod = default;
                this.Error = default;
                this.Done = default;
            }

            public Call(@string ServiceMethod = default, error Error = default, channel<ptr<Call>> Done = default)
            {
                this.ServiceMethod = ServiceMethod;
                this.Error = Error;
                this.Done = Done;
            }

            // Enable comparisons between nil and Call struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Call value, NilType nil) => value.Equals(default(Call));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Call value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Call value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Call value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Call(NilType nil) => default(Call);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Call Call_cast(dynamic value)
        {
            return new Call(value.ServiceMethod, value.Error, value.Done);
        }
    }
}}