//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:42:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using encoding = go.encoding_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using os = go.os_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fieldType
        {
            // Constructors
            public fieldType(NilType _)
            {
                this.Name = default;
                this.Id = default;
            }

            public fieldType(@string Name = default, typeId Id = default)
            {
                this.Name = Name;
                this.Id = Id;
            }

            // Enable comparisons between nil and fieldType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fieldType value, NilType nil) => value.Equals(default(fieldType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fieldType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fieldType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fieldType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fieldType(NilType nil) => default(fieldType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fieldType fieldType_cast(dynamic value)
        {
            return new fieldType(value.Name, value.Id);
        }
    }
}}