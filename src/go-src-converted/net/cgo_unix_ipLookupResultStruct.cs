//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:31:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using C = go.C_package;
using context = go.context_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ipLookupResult
        {
            // Constructors
            public ipLookupResult(NilType _)
            {
                this.addrs = default;
                this.cname = default;
                this.err = default;
            }

            public ipLookupResult(slice<IPAddr> addrs = default, @string cname = default, error err = default)
            {
                this.addrs = addrs;
                this.cname = cname;
                this.err = err;
            }

            // Enable comparisons between nil and ipLookupResult struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ipLookupResult value, NilType nil) => value.Equals(default(ipLookupResult));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ipLookupResult value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ipLookupResult value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ipLookupResult value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ipLookupResult(NilType nil) => default(ipLookupResult);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ipLookupResult ipLookupResult_cast(dynamic value)
        {
            return new ipLookupResult(value.addrs, value.cname, value.err);
        }
    }
}