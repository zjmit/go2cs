//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:26:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmtsort = go.@internal.fmtsort_package;
using io = go.io_package;
using os = go.os_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using utf8 = go.unicode.utf8_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class fmt_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Formatter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Formatter As<T>(in T target) => (Formatter<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Formatter As<T>(ptr<T> target_ptr) => (Formatter<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Formatter? As(object target) =>
                typeof(Formatter<>).CreateInterfaceHandler<Formatter>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Formatter<T> : Formatter
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

            public Formatter(in T target) => m_target = target;

            public Formatter(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void FormatByPtr(ptr<T> value, State f, int c);
            private delegate void FormatByVal(T value, State f, int c);

            private static readonly FormatByPtr s_FormatByPtr;
            private static readonly FormatByVal s_FormatByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Format(State f, int c)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_FormatByPtr is null || !m_target_is_ptr)
                {
                    s_FormatByVal!(target, f, c);
                    return;
                }

                s_FormatByPtr(m_target_ptr, f, c);
                return;
                
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Formatter()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Format");

                if (!(extensionMethod is null))
                    s_FormatByPtr = extensionMethod.CreateStaticDelegate(typeof(FormatByPtr)) as FormatByPtr;

                extensionMethod = targetType.GetExtensionMethod("Format");

                if (!(extensionMethod is null))
                    s_FormatByVal = extensionMethod.CreateStaticDelegate(typeof(FormatByVal)) as FormatByVal;

                if (s_FormatByPtr is null && s_FormatByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Formatter.Format method", new Exception("Format"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Formatter<T>(in ptr<T> target_ptr) => new Formatter<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Formatter<T>(in T target) => new Formatter<T>(target);

            // Enable comparisons between nil and Formatter<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Formatter<T> value, NilType nil) => Activator.CreateInstance<Formatter<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Formatter<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Formatter<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Formatter<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class fmt_FormatterExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.fmt_package.Formatter target)
        {
            try
            {
                return ((go.fmt_package.Formatter<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.fmt_package.Formatter target, out T result)
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
        public static object? _(this go.fmt_package.Formatter target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.fmt_package.Formatter<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.fmt_package.Formatter target, Type type, out object? result)
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