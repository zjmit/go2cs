//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:48:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using sync = go.sync_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class strings_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface replacer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static replacer As<T>(in T target) => (replacer<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static replacer As<T>(ptr<T> target_ptr) => (replacer<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static replacer? As(object target) =>
                typeof(replacer<>).CreateInterfaceHandler<replacer>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class replacer<T> : replacer
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

            public replacer(in T target) => m_target = target;

            public replacer(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (long, error) ReplaceByPtr(ptr<T> value, @string s);
            private delegate (long, error) ReplaceByVal(T value, @string s);

            private static readonly ReplaceByPtr s_ReplaceByPtr;
            private static readonly ReplaceByVal s_ReplaceByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Replace(@string s)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReplaceByPtr is null || !m_target_is_ptr)
                    return s_ReplaceByVal!(target, s);

                return s_ReplaceByPtr(m_target_ptr, s);
            }

            private delegate (long, error) WriteStringByPtr(ptr<T> value, io.Writer w, @string s);
            private delegate (long, error) WriteStringByVal(T value, io.Writer w, @string s);

            private static readonly WriteStringByPtr s_WriteStringByPtr;
            private static readonly WriteStringByVal s_WriteStringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) WriteString(io.Writer w, @string s)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_WriteStringByPtr is null || !m_target_is_ptr)
                    return s_WriteStringByVal!(target, w, s);

                return s_WriteStringByPtr(m_target_ptr, w, s);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static replacer()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Replace");

                if (!(extensionMethod is null))
                    s_ReplaceByPtr = extensionMethod.CreateStaticDelegate(typeof(ReplaceByPtr)) as ReplaceByPtr;

                extensionMethod = targetType.GetExtensionMethod("Replace");

                if (!(extensionMethod is null))
                    s_ReplaceByVal = extensionMethod.CreateStaticDelegate(typeof(ReplaceByVal)) as ReplaceByVal;

                if (s_ReplaceByPtr is null && s_ReplaceByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement replacer.Replace method", new Exception("Replace"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("WriteString");

                if (!(extensionMethod is null))
                    s_WriteStringByPtr = extensionMethod.CreateStaticDelegate(typeof(WriteStringByPtr)) as WriteStringByPtr;

                extensionMethod = targetType.GetExtensionMethod("WriteString");

                if (!(extensionMethod is null))
                    s_WriteStringByVal = extensionMethod.CreateStaticDelegate(typeof(WriteStringByVal)) as WriteStringByVal;

                if (s_WriteStringByPtr is null && s_WriteStringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement replacer.WriteString method", new Exception("WriteString"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator replacer<T>(in ptr<T> target_ptr) => new replacer<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator replacer<T>(in T target) => new replacer<T>(target);

            // Enable comparisons between nil and replacer<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(replacer<T> value, NilType nil) => Activator.CreateInstance<replacer<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(replacer<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, replacer<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, replacer<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class strings_replacerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.strings_package.replacer target)
        {
            try
            {
                return ((go.strings_package.replacer<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.strings_package.replacer target, out T result)
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
        public static object? _(this go.strings_package.replacer target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.strings_package.replacer<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.strings_package.replacer target, Type type, out object? result)
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