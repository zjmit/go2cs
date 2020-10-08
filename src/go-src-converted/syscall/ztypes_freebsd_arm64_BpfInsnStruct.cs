//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:34 UTC
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
        public partial struct BpfInsn
        {
            // Constructors
            public BpfInsn(NilType _)
            {
                this.Code = default;
                this.Jt = default;
                this.Jf = default;
                this.K = default;
            }

            public BpfInsn(ushort Code = default, byte Jt = default, byte Jf = default, uint K = default)
            {
                this.Code = Code;
                this.Jt = Jt;
                this.Jf = Jf;
                this.K = K;
            }

            // Enable comparisons between nil and BpfInsn struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BpfInsn value, NilType nil) => value.Equals(default(BpfInsn));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BpfInsn value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BpfInsn value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BpfInsn value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BpfInsn(NilType nil) => default(BpfInsn);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BpfInsn BpfInsn_cast(dynamic value)
        {
            return new BpfInsn(value.Code, value.Jt, value.Jf, value.K);
        }
    }
}