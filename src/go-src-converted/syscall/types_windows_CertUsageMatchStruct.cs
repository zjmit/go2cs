//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:27:53 UTC
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
        public partial struct CertUsageMatch
        {
            // Constructors
            public CertUsageMatch(NilType _)
            {
                this.Type = default;
                this.Usage = default;
            }

            public CertUsageMatch(uint Type = default, CertEnhKeyUsage Usage = default)
            {
                this.Type = Type;
                this.Usage = Usage;
            }

            // Enable comparisons between nil and CertUsageMatch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CertUsageMatch value, NilType nil) => value.Equals(default(CertUsageMatch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CertUsageMatch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CertUsageMatch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CertUsageMatch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CertUsageMatch(NilType nil) => default(CertUsageMatch);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CertUsageMatch CertUsageMatch_cast(dynamic value)
        {
            return new CertUsageMatch(value.Type, value.Usage);
        }
    }
}