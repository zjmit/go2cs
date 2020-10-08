//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:31:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace @internal
{
    public static partial class nettrace_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Trace
        {
            // Constructors
            public Trace(NilType _)
            {
                this.DNSStart = default;
                this.DNSDone = default;
                this.ConnectStart = default;
                this.ConnectDone = default;
            }

            public Trace(Action<@string> DNSStart = default, Action<slice<object>, bool, error> DNSDone = default, Action<@string, @string> ConnectStart = default, Action<@string, @string, error> ConnectDone = default)
            {
                this.DNSStart = DNSStart;
                this.DNSDone = DNSDone;
                this.ConnectStart = ConnectStart;
                this.ConnectDone = ConnectDone;
            }

            // Enable comparisons between nil and Trace struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Trace value, NilType nil) => value.Equals(default(Trace));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Trace value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Trace value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Trace value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Trace(NilType nil) => default(Trace);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Trace Trace_cast(dynamic value)
        {
            return new Trace(value.DNSStart, value.DNSDone, value.ConnectStart, value.ConnectDone);
        }
    }
}}