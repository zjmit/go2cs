//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:12 UTC
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
        public partial struct Header
        {
            // Value of the Header struct
            private readonly map<@string, slice<@string>> m_value;

            public Header(map<@string, slice<@string>> value) => m_value = value;

            // Enable implicit conversions between map<@string, slice<@string>> and Header struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Header(map<@string, slice<@string>> value) => new Header(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<@string, slice<@string>>(Header value) => value.m_value;
            
            // Enable comparisons between nil and Header struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Header value, NilType nil) => value.Equals(default(Header));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Header value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Header value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Header value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Header(NilType nil) => default(Header);
        }
    }
}}
