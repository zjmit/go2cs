//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:31 UTC
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
        public partial struct FscryptKeySpecifier
        {
            // Constructors
            public FscryptKeySpecifier(NilType _)
            {
                this.Type = default;
                this._ = default;
                this.U = default;
            }

            public FscryptKeySpecifier(uint Type = default, uint _ = default, array<byte> U = default)
            {
                this.Type = Type;
                this._ = _;
                this.U = U;
            }

            // Enable comparisons between nil and FscryptKeySpecifier struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FscryptKeySpecifier value, NilType nil) => value.Equals(default(FscryptKeySpecifier));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FscryptKeySpecifier value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FscryptKeySpecifier value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FscryptKeySpecifier value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FscryptKeySpecifier(NilType nil) => default(FscryptKeySpecifier);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FscryptKeySpecifier FscryptKeySpecifier_cast(dynamic value)
        {
            return new FscryptKeySpecifier(value.Type, value._, value.U);
        }
    }
}}}}}}