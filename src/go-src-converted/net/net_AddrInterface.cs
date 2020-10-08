//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:34:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using errors = go.errors_package;
using io = go.io_package;
using os = go.os_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using time = go.time_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Addr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Addr As<T>(in T target) => (Addr<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Addr As<T>(ptr<T> target_ptr) => (Addr<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Addr? As(object target) =>
                typeof(Addr<>).CreateInterfaceHandler<Addr>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Addr<T> : Addr
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

            public Addr(in T target) => m_target = target;

            public Addr(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate @string NetworkByPtr(ptr<T> value);
            private delegate @string NetworkByVal(T value);

            private static readonly NetworkByPtr s_NetworkByPtr;
            private static readonly NetworkByVal s_NetworkByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Network()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_NetworkByPtr is null || !m_target_is_ptr)
                    return s_NetworkByVal!(target);

                return s_NetworkByPtr(m_target_ptr);
            }

            private delegate @string StringByPtr(ptr<T> value);
            private delegate @string StringByVal(T value);

            private static readonly StringByPtr s_StringByPtr;
            private static readonly StringByVal s_StringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string String()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_StringByPtr is null || !m_target_is_ptr)
                    return s_StringByVal!(target);

                return s_StringByPtr(m_target_ptr);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Addr()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Network");

                if (!(extensionMethod is null))
                    s_NetworkByPtr = extensionMethod.CreateStaticDelegate(typeof(NetworkByPtr)) as NetworkByPtr;

                extensionMethod = targetType.GetExtensionMethod("Network");

                if (!(extensionMethod is null))
                    s_NetworkByVal = extensionMethod.CreateStaticDelegate(typeof(NetworkByVal)) as NetworkByVal;

                if (s_NetworkByPtr is null && s_NetworkByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Addr.Network method", new Exception("Network"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("String");

                if (!(extensionMethod is null))
                    s_StringByPtr = extensionMethod.CreateStaticDelegate(typeof(StringByPtr)) as StringByPtr;

                extensionMethod = targetType.GetExtensionMethod("String");

                if (!(extensionMethod is null))
                    s_StringByVal = extensionMethod.CreateStaticDelegate(typeof(StringByVal)) as StringByVal;

                if (s_StringByPtr is null && s_StringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Addr.String method", new Exception("String"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Addr<T>(in ptr<T> target_ptr) => new Addr<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Addr<T>(in T target) => new Addr<T>(target);

            // Enable comparisons between nil and Addr<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Addr<T> value, NilType nil) => Activator.CreateInstance<Addr<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Addr<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Addr<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Addr<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class net_AddrExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.net_package.Addr target)
        {
            try
            {
                return ((go.net_package.Addr<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.net_package.Addr target, out T result)
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
        public static object? _(this go.net_package.Addr target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.net_package.Addr<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.net_package.Addr target, Type type, out object? result)
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