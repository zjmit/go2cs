//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:54:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal
{
    public static partial class span_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct URI
        {
            // Value of the URI struct
            private readonly @string m_value;

            public URI(@string value) => m_value = value;

            // Enable implicit conversions between @string and URI struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator URI(@string value) => new URI(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(URI value) => value.m_value;
            
            // Enable comparisons between nil and URI struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(URI value, NilType nil) => value.Equals(default(URI));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(URI value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, URI value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, URI value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator URI(NilType nil) => default(URI);
        }
    }
}}}}}
