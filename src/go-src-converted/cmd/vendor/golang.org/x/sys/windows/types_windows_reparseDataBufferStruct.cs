//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using net = go.net_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct reparseDataBuffer
        {
            // Constructors
            public reparseDataBuffer(NilType _)
            {
                this.ReparseTag = default;
                this.ReparseDataLength = default;
                this.Reserved = default;
                this.reparseBuffer = default;
            }

            public reparseDataBuffer(uint ReparseTag = default, ushort ReparseDataLength = default, ushort Reserved = default, byte reparseBuffer = default)
            {
                this.ReparseTag = ReparseTag;
                this.ReparseDataLength = ReparseDataLength;
                this.Reserved = Reserved;
                this.reparseBuffer = reparseBuffer;
            }

            // Enable comparisons between nil and reparseDataBuffer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(reparseDataBuffer value, NilType nil) => value.Equals(default(reparseDataBuffer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(reparseDataBuffer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, reparseDataBuffer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, reparseDataBuffer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator reparseDataBuffer(NilType nil) => default(reparseDataBuffer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static reparseDataBuffer reparseDataBuffer_cast(dynamic value)
        {
            return new reparseDataBuffer(value.ReparseTag, value.ReparseDataLength, value.Reserved, value.reparseBuffer);
        }
    }
}}}}}}