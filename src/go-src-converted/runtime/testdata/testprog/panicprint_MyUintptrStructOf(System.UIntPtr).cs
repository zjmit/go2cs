//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:43:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MyUintptr
        {
            // Value of the MyUintptr struct
            private readonly System.UIntPtr m_value;

            public MyUintptr(System.UIntPtr value) => m_value = value;

            // Enable implicit conversions between System.UIntPtr and MyUintptr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyUintptr(System.UIntPtr value) => new MyUintptr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.UIntPtr(MyUintptr value) => value.m_value;
            
            // Enable comparisons between nil and MyUintptr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MyUintptr value, NilType nil) => value.Equals(default(MyUintptr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MyUintptr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MyUintptr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MyUintptr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyUintptr(NilType nil) => default(MyUintptr);
        }
    }
}
