//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:42:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using encoding = go.encoding_package;
using base64 = go.encoding.base64_package;
using fmt = go.fmt_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf16 = go.unicode.utf16_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace encoding
{
    public static partial class json_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct UnmarshalTypeError
        {
            // Constructors
            public UnmarshalTypeError(NilType _)
            {
                this.Value = default;
                this.Type = default;
                this.Offset = default;
                this.Struct = default;
                this.Field = default;
            }

            public UnmarshalTypeError(@string Value = default, reflect.Type Type = default, long Offset = default, @string Struct = default, @string Field = default)
            {
                this.Value = Value;
                this.Type = Type;
                this.Offset = Offset;
                this.Struct = Struct;
                this.Field = Field;
            }

            // Enable comparisons between nil and UnmarshalTypeError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnmarshalTypeError value, NilType nil) => value.Equals(default(UnmarshalTypeError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnmarshalTypeError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnmarshalTypeError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnmarshalTypeError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnmarshalTypeError(NilType nil) => default(UnmarshalTypeError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static UnmarshalTypeError UnmarshalTypeError_cast(dynamic value)
        {
            return new UnmarshalTypeError(value.Value, value.Type, value.Offset, value.Struct, value.Field);
        }
    }
}}