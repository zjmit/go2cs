//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:43:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class graph_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct edgeList
        {
            // Value of the edgeList struct
            private readonly slice<ptr<Edge>> m_value;

            public edgeList(slice<ptr<Edge>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<Edge>> and edgeList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator edgeList(slice<ptr<Edge>> value) => new edgeList(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<Edge>>(edgeList value) => value.m_value;
            
            // Enable comparisons between nil and edgeList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(edgeList value, NilType nil) => value.Equals(default(edgeList));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(edgeList value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, edgeList value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, edgeList value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator edgeList(NilType nil) => default(edgeList);
        }
    }
}}}}}}}
