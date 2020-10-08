//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:39:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using gzip = go.compress.gzip_package;
using context = go.context_package;
using rand = go.crypto.rand_package;
using tls = go.crypto.tls_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using math = go.math_package;
using mathrand = go.math.rand_package;
using net = go.net_package;
using httptrace = go.net.http.httptrace_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using hpack = go.golang.org.x.net.http2.hpack_package;
using idna = go.golang.org.x.net.idna_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface http2headersOrContinuation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static http2headersOrContinuation As<T>(in T target) => (http2headersOrContinuation<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static http2headersOrContinuation As<T>(ptr<T> target_ptr) => (http2headersOrContinuation<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static http2headersOrContinuation? As(object target) =>
                typeof(http2headersOrContinuation<>).CreateInterfaceHandler<http2headersOrContinuation>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class http2headersOrContinuation<T> : http2headersOrContinuation
        {
            private T m_target;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.val;

                    return ref m_target;
                }
            }

            public http2headersOrContinuation(in T target) => m_target = target;

            public http2headersOrContinuation(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate slice<byte> HeaderBlockFragmentByPtr(ptr<T> value);
            private delegate slice<byte> HeaderBlockFragmentByVal(T value);

            private static readonly HeaderBlockFragmentByPtr s_HeaderBlockFragmentByPtr;
            private static readonly HeaderBlockFragmentByVal s_HeaderBlockFragmentByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public slice<byte> HeaderBlockFragment()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_HeaderBlockFragmentByPtr is null || !m_target_is_ptr)
                    return s_HeaderBlockFragmentByVal!(target);

                return s_HeaderBlockFragmentByPtr(m_target_ptr);
            }

            private delegate bool HeadersEndedByPtr(ptr<T> value);
            private delegate bool HeadersEndedByVal(T value);

            private static readonly HeadersEndedByPtr s_HeadersEndedByPtr;
            private static readonly HeadersEndedByVal s_HeadersEndedByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool HeadersEnded()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_HeadersEndedByPtr is null || !m_target_is_ptr)
                    return s_HeadersEndedByVal!(target);

                return s_HeadersEndedByPtr(m_target_ptr);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static http2headersOrContinuation()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("HeaderBlockFragment");

                if (!(extensionMethod is null))
                    s_HeaderBlockFragmentByPtr = extensionMethod.CreateStaticDelegate(typeof(HeaderBlockFragmentByPtr)) as HeaderBlockFragmentByPtr;

                extensionMethod = targetType.GetExtensionMethod("HeaderBlockFragment");

                if (!(extensionMethod is null))
                    s_HeaderBlockFragmentByVal = extensionMethod.CreateStaticDelegate(typeof(HeaderBlockFragmentByVal)) as HeaderBlockFragmentByVal;

                if (s_HeaderBlockFragmentByPtr is null && s_HeaderBlockFragmentByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement http2headersOrContinuation.HeaderBlockFragment method", new Exception("HeaderBlockFragment"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("HeadersEnded");

                if (!(extensionMethod is null))
                    s_HeadersEndedByPtr = extensionMethod.CreateStaticDelegate(typeof(HeadersEndedByPtr)) as HeadersEndedByPtr;

                extensionMethod = targetType.GetExtensionMethod("HeadersEnded");

                if (!(extensionMethod is null))
                    s_HeadersEndedByVal = extensionMethod.CreateStaticDelegate(typeof(HeadersEndedByVal)) as HeadersEndedByVal;

                if (s_HeadersEndedByPtr is null && s_HeadersEndedByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement http2headersOrContinuation.HeadersEnded method", new Exception("HeadersEnded"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator http2headersOrContinuation<T>(in ptr<T> target_ptr) => new http2headersOrContinuation<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator http2headersOrContinuation<T>(in T target) => new http2headersOrContinuation<T>(target);

            // Enable comparisons between nil and http2headersOrContinuation<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2headersOrContinuation<T> value, NilType nil) => Activator.CreateInstance<http2headersOrContinuation<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2headersOrContinuation<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2headersOrContinuation<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2headersOrContinuation<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class http_http2headersOrContinuationExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.net.http_package.http2headersOrContinuation target)
        {
            try
            {
                return ((go.net.http_package.http2headersOrContinuation<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.net.http_package.http2headersOrContinuation target, out T result)
        {
            try
            {
                result = target._<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default!;
                return false;
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object? _(this go.net.http_package.http2headersOrContinuation target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.net.http_package.http2headersOrContinuation<>).GetExplicitGenericConversionOperator(type));

                if (conversionOperator is null)
                    throw new PanicException($"interface conversion: failed to create converter for {GetGoTypeName(target.GetType())} to {GetGoTypeName(type)}");

                dynamic? result = conversionOperator.Invoke(null, new object[] { target });
                return result?.Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(type)}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _(this go.net.http_package.http2headersOrContinuation target, Type type, out object? result)
        {
            try
            {
                result = target._(type);
                return true;
            }
            catch (PanicException)
            {
                result = type.IsValueType ? Activator.CreateInstance(type) : null;
                return false;
            }
        }
    }
}