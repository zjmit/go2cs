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
        public partial struct CryptoUserAlg
        {
            // Constructors
            public CryptoUserAlg(NilType _)
            {
                this.Name = default;
                this.Driver_name = default;
                this.Module_name = default;
                this.Type = default;
                this.Mask = default;
                this.Refcnt = default;
                this.Flags = default;
            }

            public CryptoUserAlg(array<sbyte> Name = default, array<sbyte> Driver_name = default, array<sbyte> Module_name = default, uint Type = default, uint Mask = default, uint Refcnt = default, uint Flags = default)
            {
                this.Name = Name;
                this.Driver_name = Driver_name;
                this.Module_name = Module_name;
                this.Type = Type;
                this.Mask = Mask;
                this.Refcnt = Refcnt;
                this.Flags = Flags;
            }

            // Enable comparisons between nil and CryptoUserAlg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptoUserAlg value, NilType nil) => value.Equals(default(CryptoUserAlg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptoUserAlg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptoUserAlg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptoUserAlg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptoUserAlg(NilType nil) => default(CryptoUserAlg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CryptoUserAlg CryptoUserAlg_cast(dynamic value)
        {
            return new CryptoUserAlg(value.Name, value.Driver_name, value.Module_name, value.Type, value.Mask, value.Refcnt, value.Flags);
        }
    }
}}}}}}