//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:36:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace crypto {
namespace x509
{
    public static partial class macOS_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CFString
        {
            // Value of the CFString struct
            private readonly CFRef m_value;

            public CFString(CFRef value) => m_value = value;

            // Enable implicit conversions between CFRef and CFString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CFString(CFRef value) => new CFString(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CFRef(CFString value) => value.m_value;
            
            // Enable comparisons between nil and CFString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CFString value, NilType nil) => value.Equals(default(CFString));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CFString value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CFString value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CFString value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CFString(NilType nil) => default(CFString);
        }
    }
}}}
