//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:42:51 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using encoding = go.encoding_package;
using base64 = go.encoding.base64_package;
using fmt = go.fmt_package;
using math = go.math_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace encoding
{
    public static partial class json_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct jsonError
        {
            // error.Error function promotion
            private delegate @string ErrorByVal(T value);
            private delegate @string ErrorByRef(ref T value);

            private static readonly ErrorByVal s_ErrorByVal;
            private static readonly ErrorByRef s_ErrorByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Error() => s_ErrorByRef?.Invoke(ref this) ?? s_ErrorByVal?.Invoke(this) ?? error?.Error() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static jsonError()
            {
                Type targetType = typeof(jsonError);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Error");

                if ((object)extensionMethod != null)
                {
                    s_ErrorByRef = extensionMethod.CreateStaticDelegate(typeof(ErrorByRef)) as ErrorByRef;

                    if ((object)s_ErrorByRef == null)
                        s_ErrorByVal = extensionMethod.CreateStaticDelegate(typeof(ErrorByVal)) as ErrorByVal;
                }
            }

            // Constructors
            public jsonError(NilType _)
            {
                this.error = default;
            }

            public jsonError(error error = default)
            {
                this.error = error;
            }

            // Enable comparisons between nil and jsonError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(jsonError value, NilType nil) => value.Equals(default(jsonError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(jsonError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, jsonError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, jsonError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator jsonError(NilType nil) => default(jsonError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static jsonError jsonError_cast(dynamic value)
        {
            return new jsonError(value.error);
        }
    }
}}