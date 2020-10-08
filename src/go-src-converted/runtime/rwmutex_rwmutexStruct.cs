//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:22:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct rwmutex
        {
            // Constructors
            public rwmutex(NilType _)
            {
                this.rLock = default;
                this.readers = default;
                this.readerPass = default;
                this.wLock = default;
                this.writer = default;
                this.readerCount = default;
                this.readerWait = default;
            }

            public rwmutex(mutex rLock = default, muintptr readers = default, uint readerPass = default, mutex wLock = default, muintptr writer = default, uint readerCount = default, uint readerWait = default)
            {
                this.rLock = rLock;
                this.readers = readers;
                this.readerPass = readerPass;
                this.wLock = wLock;
                this.writer = writer;
                this.readerCount = readerCount;
                this.readerWait = readerWait;
            }

            // Enable comparisons between nil and rwmutex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rwmutex value, NilType nil) => value.Equals(default(rwmutex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rwmutex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rwmutex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rwmutex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rwmutex(NilType nil) => default(rwmutex);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rwmutex rwmutex_cast(dynamic value)
        {
            return new rwmutex(value.rLock, value.readers, value.readerPass, value.wLock, value.writer, value.readerCount, value.readerWait);
        }
    }
}