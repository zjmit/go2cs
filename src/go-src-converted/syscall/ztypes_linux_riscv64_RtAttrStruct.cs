//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RtAttr
        {
            // Constructors
            public RtAttr(NilType _)
            {
                this.Len = default;
                this.Type = default;
            }

            public RtAttr(ushort Len = default, ushort Type = default)
            {
                this.Len = Len;
                this.Type = Type;
            }

            // Enable comparisons between nil and RtAttr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RtAttr value, NilType nil) => value.Equals(default(RtAttr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RtAttr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RtAttr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RtAttr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RtAttr(NilType nil) => default(RtAttr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RtAttr RtAttr_cast(dynamic value)
        {
            return new RtAttr(value.Len, value.Type);
        }
    }
}