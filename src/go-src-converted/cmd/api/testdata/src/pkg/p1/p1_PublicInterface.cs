//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:04:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ptwo = go.p2_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace api {
namespace testdata {
namespace src {
namespace pkg
{
    public static partial class p1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Public
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Public As<T>(in T target) => (Public<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Public As<T>(ptr<T> target_ptr) => (Public<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Public? As(object target) =>
                typeof(Public<>).CreateInterfaceHandler<Public>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Public<T> : Public
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

            public Public(in T target) => m_target = target;

            public Public(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void XByPtr(ptr<T> value);
            private delegate void XByVal(T value);

            private static readonly XByPtr s_XByPtr;
            private static readonly XByVal s_XByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void X()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_XByPtr is null || !m_target_is_ptr)
                {
                    s_XByVal!(target);
                    return;
                }

                s_XByPtr(m_target_ptr);
                return;
                
            }

            private delegate void YByPtr(ptr<T> value);
            private delegate void YByVal(T value);

            private static readonly YByPtr s_YByPtr;
            private static readonly YByVal s_YByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Y()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_YByPtr is null || !m_target_is_ptr)
                {
                    s_YByVal!(target);
                    return;
                }

                s_YByPtr(m_target_ptr);
                return;
                
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Public()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("X");

                if (!(extensionMethod is null))
                    s_XByPtr = extensionMethod.CreateStaticDelegate(typeof(XByPtr)) as XByPtr;

                extensionMethod = targetType.GetExtensionMethod("X");

                if (!(extensionMethod is null))
                    s_XByVal = extensionMethod.CreateStaticDelegate(typeof(XByVal)) as XByVal;

                if (s_XByPtr is null && s_XByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Public.X method", new Exception("X"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Y");

                if (!(extensionMethod is null))
                    s_YByPtr = extensionMethod.CreateStaticDelegate(typeof(YByPtr)) as YByPtr;

                extensionMethod = targetType.GetExtensionMethod("Y");

                if (!(extensionMethod is null))
                    s_YByVal = extensionMethod.CreateStaticDelegate(typeof(YByVal)) as YByVal;

                if (s_YByPtr is null && s_YByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Public.Y method", new Exception("Y"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Public<T>(in ptr<T> target_ptr) => new Public<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Public<T>(in T target) => new Public<T>(target);

            // Enable comparisons between nil and Public<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Public<T> value, NilType nil) => Activator.CreateInstance<Public<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Public<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Public<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Public<T> value) => value != nil;
        }
    }
}}}}}}

namespace go
{
    public static class p1_PublicExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.api.testdata.src.pkg.p1_package.Public target)
        {
            try
            {
                return ((go.cmd.api.testdata.src.pkg.p1_package.Public<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.api.testdata.src.pkg.p1_package.Public target, out T result)
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
        public static object? _(this go.cmd.api.testdata.src.pkg.p1_package.Public target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.api.testdata.src.pkg.p1_package.Public<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.api.testdata.src.pkg.p1_package.Public target, Type type, out object? result)
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