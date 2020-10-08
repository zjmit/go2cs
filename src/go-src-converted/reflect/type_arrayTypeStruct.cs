//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:24:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using unsafeheader = go.@internal.unsafeheader_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(rtype))]
        private partial struct arrayType
        {
            // rtype structure promotion - sourced from value copy
            private readonly ptr<rtype> m_rtypeRef;

            private ref rtype rtype_val => ref m_rtypeRef.Value;

            public ref System.UIntPtr size => ref m_rtypeRef.Value.size;

            public ref System.UIntPtr ptrdata => ref m_rtypeRef.Value.ptrdata;

            public ref uint hash => ref m_rtypeRef.Value.hash;

            public ref tflag tflag => ref m_rtypeRef.Value.tflag;

            public ref byte align => ref m_rtypeRef.Value.align;

            public ref byte fieldAlign => ref m_rtypeRef.Value.fieldAlign;

            public ref byte kind => ref m_rtypeRef.Value.kind;

            public ref Func<unsafe.Pointer, unsafe.Pointer, bool> equal => ref m_rtypeRef.Value.equal;

            public ref ptr<byte> gcdata => ref m_rtypeRef.Value.gcdata;

            public ref nameOff str => ref m_rtypeRef.Value.str;

            public ref typeOff ptrToThis => ref m_rtypeRef.Value.ptrToThis;

            // Constructors
            public arrayType(NilType _)
            {
                this.m_rtypeRef = new ptr<rtype>(new rtype(nil));
                this.elem = default;
                this.slice = default;
                this.len = default;
            }

            public arrayType(rtype rtype = default, ref ptr<rtype> elem = default, ref ptr<rtype> slice = default, System.UIntPtr len = default)
            {
                this.m_rtypeRef = new ptr<rtype>(rtype);
                this.elem = elem;
                this.slice = slice;
                this.len = len;
            }

            // Enable comparisons between nil and arrayType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(arrayType value, NilType nil) => value.Equals(default(arrayType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(arrayType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, arrayType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, arrayType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator arrayType(NilType nil) => default(arrayType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static arrayType arrayType_cast(dynamic value)
        {
            return new arrayType(value.rtype, ref value.elem, ref value.slice, value.len);
        }
    }
}