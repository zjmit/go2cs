//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:07:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace ppc64
{
    public static partial class ppc64asm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Label
        {
            // Value of the Label struct
            private readonly uint m_value;

            public Label(uint value) => m_value = value;

            // Enable implicit conversions between uint and Label struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Label(uint value) => new Label(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(Label value) => value.m_value;
            
            // Enable comparisons between nil and Label struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Label value, NilType nil) => value.Equals(default(Label));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Label value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Label value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Label value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Label(NilType nil) => default(Label);
        }
    }
}}}}}}}