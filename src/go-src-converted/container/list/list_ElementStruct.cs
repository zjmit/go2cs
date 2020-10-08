//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:37:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace container
{
    public static partial class list_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Element
        {
            // Constructors
            public Element(NilType _)
            {
                this.next = default;
                this.prev = default;
                this.list = default;
            }

            public Element(ref ptr<Element> next = default, ref ptr<Element> prev = default, ref ptr<List> list = default)
            {
                this.next = next;
                this.prev = prev;
                this.list = list;
            }

            // Enable comparisons between nil and Element struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Element value, NilType nil) => value.Equals(default(Element));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Element value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Element value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Element value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Element(NilType nil) => default(Element);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Element Element_cast(dynamic value)
        {
            return new Element(ref value.next, ref value.prev, ref value.list);
        }
    }
}}