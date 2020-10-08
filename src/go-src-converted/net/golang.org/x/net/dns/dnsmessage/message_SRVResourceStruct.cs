//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:31:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace net {
namespace dns
{
    public static partial class dnsmessage_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SRVResource
        {
            // Constructors
            public SRVResource(NilType _)
            {
                this.Priority = default;
                this.Weight = default;
                this.Port = default;
                this.Target = default;
            }

            public SRVResource(ushort Priority = default, ushort Weight = default, ushort Port = default, Name Target = default)
            {
                this.Priority = Priority;
                this.Weight = Weight;
                this.Port = Port;
                this.Target = Target;
            }

            // Enable comparisons between nil and SRVResource struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SRVResource value, NilType nil) => value.Equals(default(SRVResource));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SRVResource value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SRVResource value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SRVResource value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SRVResource(NilType nil) => default(SRVResource);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SRVResource SRVResource_cast(dynamic value)
        {
            return new SRVResource(value.Priority, value.Weight, value.Port, value.Target);
        }
    }
}}}}}