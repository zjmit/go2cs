//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:34:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using errors = go.errors_package;
using io = go.io_package;
using os = go.os_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using time = go.time_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct DNSError
        {
            // Constructors
            public DNSError(NilType _)
            {
                this.Err = default;
                this.Name = default;
                this.Server = default;
                this.IsTimeout = default;
                this.IsTemporary = default;
                this.IsNotFound = default;
            }

            public DNSError(@string Err = default, @string Name = default, @string Server = default, bool IsTimeout = default, bool IsTemporary = default, bool IsNotFound = default)
            {
                this.Err = Err;
                this.Name = Name;
                this.Server = Server;
                this.IsTimeout = IsTimeout;
                this.IsTemporary = IsTemporary;
                this.IsNotFound = IsNotFound;
            }

            // Enable comparisons between nil and DNSError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(DNSError value, NilType nil) => value.Equals(default(DNSError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(DNSError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, DNSError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, DNSError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator DNSError(NilType nil) => default(DNSError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static DNSError DNSError_cast(dynamic value)
        {
            return new DNSError(value.Err, value.Name, value.Server, value.IsTimeout, value.IsTemporary, value.IsNotFound);
        }
    }
}