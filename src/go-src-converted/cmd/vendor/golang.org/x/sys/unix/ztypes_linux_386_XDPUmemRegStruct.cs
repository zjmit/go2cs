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
        public partial struct XDPUmemReg
        {
            // Constructors
            public XDPUmemReg(NilType _)
            {
                this.Addr = default;
                this.Len = default;
                this.Size = default;
                this.Headroom = default;
                this.Flags = default;
            }

            public XDPUmemReg(ulong Addr = default, ulong Len = default, uint Size = default, uint Headroom = default, uint Flags = default)
            {
                this.Addr = Addr;
                this.Len = Len;
                this.Size = Size;
                this.Headroom = Headroom;
                this.Flags = Flags;
            }

            // Enable comparisons between nil and XDPUmemReg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(XDPUmemReg value, NilType nil) => value.Equals(default(XDPUmemReg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(XDPUmemReg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, XDPUmemReg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, XDPUmemReg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator XDPUmemReg(NilType nil) => default(XDPUmemReg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static XDPUmemReg XDPUmemReg_cast(dynamic value)
        {
            return new XDPUmemReg(value.Addr, value.Len, value.Size, value.Headroom, value.Flags);
        }
    }
}}}}}}