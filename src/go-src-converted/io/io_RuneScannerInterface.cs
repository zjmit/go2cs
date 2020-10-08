//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 01:30:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class io_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface RuneScanner
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static RuneScanner As<T>(in T target) => (RuneScanner<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static RuneScanner As<T>(ptr<T> target_ptr) => (RuneScanner<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static RuneScanner? As(object target) =>
                typeof(RuneScanner<>).CreateInterfaceHandler<RuneScanner>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class RuneScanner<T> : RuneScanner
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

            public RuneScanner(in T target) => m_target = target;

            public RuneScanner(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate error UnreadRuneByPtr(ptr<T> value);
            private delegate error UnreadRuneByVal(T value);

            private static readonly UnreadRuneByPtr s_UnreadRuneByPtr;
            private static readonly UnreadRuneByVal s_UnreadRuneByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error UnreadRune()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_UnreadRuneByPtr is null || !m_target_is_ptr)
                    return s_UnreadRuneByVal!(target);

                return s_UnreadRuneByPtr(m_target_ptr);
            }

            private delegate (int, long, error) ReadRuneByPtr(ptr<T> value);
            private delegate (int, long, error) ReadRuneByVal(T value);

            private static readonly ReadRuneByPtr s_ReadRuneByPtr;
            private static readonly ReadRuneByVal s_ReadRuneByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (int, long, error) ReadRune()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReadRuneByPtr is null || !m_target_is_ptr)
                    return s_ReadRuneByVal!(target);

                return s_ReadRuneByPtr(m_target_ptr);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static RuneScanner()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("UnreadRune");

                if (!(extensionMethod is null))
                    s_UnreadRuneByPtr = extensionMethod.CreateStaticDelegate(typeof(UnreadRuneByPtr)) as UnreadRuneByPtr;

                extensionMethod = targetType.GetExtensionMethod("UnreadRune");

                if (!(extensionMethod is null))
                    s_UnreadRuneByVal = extensionMethod.CreateStaticDelegate(typeof(UnreadRuneByVal)) as UnreadRuneByVal;

                if (s_UnreadRuneByPtr is null && s_UnreadRuneByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement RuneScanner.UnreadRune method", new Exception("UnreadRune"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ReadRune");

                if (!(extensionMethod is null))
                    s_ReadRuneByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadRuneByPtr)) as ReadRuneByPtr;

                extensionMethod = targetType.GetExtensionMethod("ReadRune");

                if (!(extensionMethod is null))
                    s_ReadRuneByVal = extensionMethod.CreateStaticDelegate(typeof(ReadRuneByVal)) as ReadRuneByVal;

                if (s_ReadRuneByPtr is null && s_ReadRuneByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement RuneScanner.ReadRune method", new Exception("ReadRune"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator RuneScanner<T>(in ptr<T> target_ptr) => new RuneScanner<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator RuneScanner<T>(in T target) => new RuneScanner<T>(target);

            // Enable comparisons between nil and RuneScanner<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RuneScanner<T> value, NilType nil) => Activator.CreateInstance<RuneScanner<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RuneScanner<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RuneScanner<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RuneScanner<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class io_RuneScannerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.io_package.RuneScanner target)
        {
            try
            {
                return ((go.io_package.RuneScanner<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.io_package.RuneScanner target, out T result)
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
        public static object? _(this go.io_package.RuneScanner target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.io_package.RuneScanner<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.io_package.RuneScanner target, Type type, out object? result)
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