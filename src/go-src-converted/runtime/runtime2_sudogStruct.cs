//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:22:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using cpu = go.@internal.cpu_package;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sudog
        {
            // Constructors
            public sudog(NilType _)
            {
                this.g = default;
                this.next = default;
                this.prev = default;
                this.elem = default;
                this.acquiretime = default;
                this.releasetime = default;
                this.ticket = default;
                this.isSelect = default;
                this.parent = default;
                this.waitlink = default;
                this.waittail = default;
                this.c = default;
            }

            public sudog(ref ptr<g> g = default, ref ptr<sudog> next = default, ref ptr<sudog> prev = default, unsafe.Pointer elem = default, long acquiretime = default, long releasetime = default, uint ticket = default, bool isSelect = default, ref ptr<sudog> parent = default, ref ptr<sudog> waitlink = default, ref ptr<sudog> waittail = default, ref ptr<hchan> c = default)
            {
                this.g = g;
                this.next = next;
                this.prev = prev;
                this.elem = elem;
                this.acquiretime = acquiretime;
                this.releasetime = releasetime;
                this.ticket = ticket;
                this.isSelect = isSelect;
                this.parent = parent;
                this.waitlink = waitlink;
                this.waittail = waittail;
                this.c = c;
            }

            // Enable comparisons between nil and sudog struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sudog value, NilType nil) => value.Equals(default(sudog));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sudog value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sudog value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sudog value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sudog(NilType nil) => default(sudog);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sudog sudog_cast(dynamic value)
        {
            return new sudog(ref value.g, ref value.next, ref value.prev, value.elem, value.acquiretime, value.releasetime, value.ticket, value.isSelect, ref value.parent, ref value.waitlink, ref value.waittail, ref value.c);
        }
    }
}