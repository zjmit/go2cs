//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:31:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct policyTable
        {
            // Value of the policyTable struct
            private readonly slice<policyTableEntry> m_value;

            public policyTable(slice<policyTableEntry> value) => m_value = value;

            // Enable implicit conversions between slice<policyTableEntry> and policyTable struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator policyTable(slice<policyTableEntry> value) => new policyTable(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<policyTableEntry>(policyTable value) => value.m_value;
            
            // Enable comparisons between nil and policyTable struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(policyTable value, NilType nil) => value.Equals(default(policyTable));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(policyTable value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, policyTable value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, policyTable value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator policyTable(NilType nil) => default(policyTable);
        }
    }
}
