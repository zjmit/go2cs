//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:36:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class sumdb_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct testHashes
        {
            // Value of the testHashes struct
            private readonly slice<tlog.Hash> m_value;

            public testHashes(slice<tlog.Hash> value) => m_value = value;

            // Enable implicit conversions between slice<tlog.Hash> and testHashes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator testHashes(slice<tlog.Hash> value) => new testHashes(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<tlog.Hash>(testHashes value) => value.m_value;
            
            // Enable comparisons between nil and testHashes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(testHashes value, NilType nil) => value.Equals(default(testHashes));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(testHashes value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, testHashes value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, testHashes value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator testHashes(NilType nil) => default(testHashes);
        }
    }
}}}}
