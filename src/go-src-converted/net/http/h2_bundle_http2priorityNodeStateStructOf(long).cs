//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:39:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2priorityNodeState
        {
            // Value of the http2priorityNodeState struct
            private readonly long m_value;

            public http2priorityNodeState(long value) => m_value = value;

            // Enable implicit conversions between long and http2priorityNodeState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2priorityNodeState(long value) => new http2priorityNodeState(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(http2priorityNodeState value) => value.m_value;
            
            // Enable comparisons between nil and http2priorityNodeState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2priorityNodeState value, NilType nil) => value.Equals(default(http2priorityNodeState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2priorityNodeState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2priorityNodeState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2priorityNodeState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2priorityNodeState(NilType nil) => default(http2priorityNodeState);
        }
    }
}}
