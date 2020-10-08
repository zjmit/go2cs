//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:26:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using @unsafe = go.@unsafe_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace syscall
{
    public static partial class js_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Wrapper
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Wrapper As<T>(in T target) => (Wrapper<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Wrapper As<T>(ptr<T> target_ptr) => (Wrapper<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Wrapper? As(object target) =>
                typeof(Wrapper<>).CreateInterfaceHandler<Wrapper>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Wrapper<T> : Wrapper
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

            public Wrapper(in T target) => m_target = target;

            public Wrapper(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate Value JSValueByPtr(ptr<T> value);
            private delegate Value JSValueByVal(T value);

            private static readonly JSValueByPtr s_JSValueByPtr;
            private static readonly JSValueByVal s_JSValueByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Value JSValue()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_JSValueByPtr is null || !m_target_is_ptr)
                    return s_JSValueByVal!(target);

                return s_JSValueByPtr(m_target_ptr);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Wrapper()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("JSValue");

                if (!(extensionMethod is null))
                    s_JSValueByPtr = extensionMethod.CreateStaticDelegate(typeof(JSValueByPtr)) as JSValueByPtr;

                extensionMethod = targetType.GetExtensionMethod("JSValue");

                if (!(extensionMethod is null))
                    s_JSValueByVal = extensionMethod.CreateStaticDelegate(typeof(JSValueByVal)) as JSValueByVal;

                if (s_JSValueByPtr is null && s_JSValueByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Wrapper.JSValue method", new Exception("JSValue"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Wrapper<T>(in ptr<T> target_ptr) => new Wrapper<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Wrapper<T>(in T target) => new Wrapper<T>(target);

            // Enable comparisons between nil and Wrapper<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Wrapper<T> value, NilType nil) => Activator.CreateInstance<Wrapper<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Wrapper<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Wrapper<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Wrapper<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class js_WrapperExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.syscall.js_package.Wrapper target)
        {
            try
            {
                return ((go.syscall.js_package.Wrapper<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.syscall.js_package.Wrapper target, out T result)
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
        public static object? _(this go.syscall.js_package.Wrapper target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.syscall.js_package.Wrapper<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.syscall.js_package.Wrapper target, Type type, out object? result)
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