//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TIPCServiceRange
        {
            // Constructors
            public TIPCServiceRange(NilType _)
            {
                this.Type = default;
                this.Lower = default;
                this.Upper = default;
            }

            public TIPCServiceRange(uint Type = default, uint Lower = default, uint Upper = default)
            {
                this.Type = Type;
                this.Lower = Lower;
                this.Upper = Upper;
            }

            // Enable comparisons between nil and TIPCServiceRange struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TIPCServiceRange value, NilType nil) => value.Equals(default(TIPCServiceRange));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TIPCServiceRange value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TIPCServiceRange value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TIPCServiceRange value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TIPCServiceRange(NilType nil) => default(TIPCServiceRange);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TIPCServiceRange TIPCServiceRange_cast(dynamic value)
        {
            return new TIPCServiceRange(value.Type, value.Lower, value.Upper);
        }
    }
}}}}}}