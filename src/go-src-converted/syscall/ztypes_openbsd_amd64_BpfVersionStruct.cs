//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:41 UTC
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
        public partial struct BpfVersion
        {
            // Constructors
            public BpfVersion(NilType _)
            {
                this.Major = default;
                this.Minor = default;
            }

            public BpfVersion(ushort Major = default, ushort Minor = default)
            {
                this.Major = Major;
                this.Minor = Minor;
            }

            // Enable comparisons between nil and BpfVersion struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BpfVersion value, NilType nil) => value.Equals(default(BpfVersion));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BpfVersion value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BpfVersion value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BpfVersion value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BpfVersion(NilType nil) => default(BpfVersion);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BpfVersion BpfVersion_cast(dynamic value)
        {
            return new BpfVersion(value.Major, value.Minor);
        }
    }
}