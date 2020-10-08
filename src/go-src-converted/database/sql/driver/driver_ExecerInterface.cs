//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:58:46 UTC
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
using reflect = go.reflect_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace database {
namespace sql
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Execer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Execer As<T>(in T target) => (Execer<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Execer As<T>(ptr<T> target_ptr) => (Execer<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Execer? As(object target) =>
                typeof(Execer<>).CreateInterfaceHandler<Execer>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Execer<T> : Execer
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

            public Execer(in T target) => m_target = target;

            public Execer(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (Result, error) ExecByPtr(ptr<T> value, @string query, slice<Value> args);
            private delegate (Result, error) ExecByVal(T value, @string query, slice<Value> args);

            private static readonly ExecByPtr s_ExecByPtr;
            private static readonly ExecByVal s_ExecByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (Result, error) Exec(@string query, slice<Value> args)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ExecByPtr is null || !m_target_is_ptr)
                    return s_ExecByVal!(target, query, args);

                return s_ExecByPtr(m_target_ptr, query, args);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Execer()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Exec");

                if (!(extensionMethod is null))
                    s_ExecByPtr = extensionMethod.CreateStaticDelegate(typeof(ExecByPtr)) as ExecByPtr;

                extensionMethod = targetType.GetExtensionMethod("Exec");

                if (!(extensionMethod is null))
                    s_ExecByVal = extensionMethod.CreateStaticDelegate(typeof(ExecByVal)) as ExecByVal;

                if (s_ExecByPtr is null && s_ExecByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Execer.Exec method", new Exception("Exec"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Execer<T>(in ptr<T> target_ptr) => new Execer<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Execer<T>(in T target) => new Execer<T>(target);

            // Enable comparisons between nil and Execer<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Execer<T> value, NilType nil) => Activator.CreateInstance<Execer<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Execer<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Execer<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Execer<T> value) => value != nil;
        }
    }
}}}

namespace go
{
    public static class driver_ExecerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.database.sql.driver_package.Execer target)
        {
            try
            {
                return ((go.database.sql.driver_package.Execer<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.database.sql.driver_package.Execer target, out T result)
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
        public static object? _(this go.database.sql.driver_package.Execer target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.database.sql.driver_package.Execer<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.database.sql.driver_package.Execer target, Type type, out object? result)
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