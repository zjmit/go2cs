//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ast = go.go.ast_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace @internal
{
    public static partial class exports_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface T14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static T14 As<T>(in T target) => (T14<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static T14 As<T>(ptr<T> target_ptr) => (T14<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static T14? As(object target) =>
                typeof(T14<>).CreateInterfaceHandler<T14>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class T14<T> : T14
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

            public T14(in T target) => m_target = target;

            public T14(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate slice<T9> m3ByPtr(ptr<T> value, params object[] x);
            private delegate slice<T9> m3ByVal(T value, params object[] x);

            private static readonly m3ByPtr s_m3ByPtr;
            private static readonly m3ByVal s_m3ByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public slice<T9> m3(params object[] x)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_m3ByPtr is null || !m_target_is_ptr)
                    return s_m3ByVal!(target, x);

                return s_m3ByPtr(m_target_ptr, x);
            }

            private delegate float m1ByPtr(ptr<T> value);
            private delegate float m1ByVal(T value);

            private static readonly m1ByPtr s_m1ByPtr;
            private static readonly m1ByVal s_m1ByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public float m1()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_m1ByPtr is null || !m_target_is_ptr)
                    return s_m1ByVal!(target);

                return s_m1ByPtr(m_target_ptr);
            }

            private delegate float m2ByPtr(ptr<T> value, long _p0);
            private delegate float m2ByVal(T value, long _p0);

            private static readonly m2ByPtr s_m2ByPtr;
            private static readonly m2ByVal s_m2ByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public float m2(long _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_m2ByPtr is null || !m_target_is_ptr)
                    return s_m2ByVal!(target, _p0);

                return s_m2ByPtr(m_target_ptr, _p0);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static T14()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("m3");

                if (!(extensionMethod is null))
                    s_m3ByPtr = extensionMethod.CreateStaticDelegate(typeof(m3ByPtr)) as m3ByPtr;

                extensionMethod = targetType.GetExtensionMethod("m3");

                if (!(extensionMethod is null))
                    s_m3ByVal = extensionMethod.CreateStaticDelegate(typeof(m3ByVal)) as m3ByVal;

                if (s_m3ByPtr is null && s_m3ByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement T14.m3 method", new Exception("m3"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("m1");

                if (!(extensionMethod is null))
                    s_m1ByPtr = extensionMethod.CreateStaticDelegate(typeof(m1ByPtr)) as m1ByPtr;

                extensionMethod = targetType.GetExtensionMethod("m1");

                if (!(extensionMethod is null))
                    s_m1ByVal = extensionMethod.CreateStaticDelegate(typeof(m1ByVal)) as m1ByVal;

                if (s_m1ByPtr is null && s_m1ByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement T14.m1 method", new Exception("m1"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("m2");

                if (!(extensionMethod is null))
                    s_m2ByPtr = extensionMethod.CreateStaticDelegate(typeof(m2ByPtr)) as m2ByPtr;

                extensionMethod = targetType.GetExtensionMethod("m2");

                if (!(extensionMethod is null))
                    s_m2ByVal = extensionMethod.CreateStaticDelegate(typeof(m2ByVal)) as m2ByVal;

                if (s_m2ByPtr is null && s_m2ByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement T14.m2 method", new Exception("m2"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator T14<T>(in ptr<T> target_ptr) => new T14<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator T14<T>(in T target) => new T14<T>(target);

            // Enable comparisons between nil and T14<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T14<T> value, NilType nil) => Activator.CreateInstance<T14<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T14<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T14<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T14<T> value) => value != nil;
        }
    }
}}}}}}

namespace go
{
    public static class exports_T14Extensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.golang.org.x.tools.go.@internal.gcimporter.exports_package.T14 target)
        {
            try
            {
                return ((go.golang.org.x.tools.go.@internal.gcimporter.exports_package.T14<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.golang.org.x.tools.go.@internal.gcimporter.exports_package.T14 target, out T result)
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
        public static object? _(this go.golang.org.x.tools.go.@internal.gcimporter.exports_package.T14 target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.golang.org.x.tools.go.@internal.gcimporter.exports_package.T14<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.golang.org.x.tools.go.@internal.gcimporter.exports_package.T14 target, Type type, out object? result)
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