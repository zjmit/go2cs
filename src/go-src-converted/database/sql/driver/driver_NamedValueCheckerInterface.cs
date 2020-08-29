//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:47 UTC
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
        public partial interface NamedValueChecker
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static NamedValueChecker As<T>(in T target) => (NamedValueChecker<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static NamedValueChecker As<T>(ptr<T> target_ptr) => (NamedValueChecker<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static NamedValueChecker? As(object target) =>
                typeof(NamedValueChecker<>).CreateInterfaceHandler<NamedValueChecker>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class NamedValueChecker<T> : NamedValueChecker
        {
            private T m_target;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.Value;

                    return ref m_target;
                }
            }

            public NamedValueChecker(in T target) => m_target = target;

            public NamedValueChecker(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate error CheckNamedValueByRef(ref T value, ref NamedValue _p0);
            private delegate error CheckNamedValueByVal(T value, ref NamedValue _p0);

            private static readonly CheckNamedValueByRef s_CheckNamedValueByRef;
            private static readonly CheckNamedValueByVal s_CheckNamedValueByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error CheckNamedValue(ref NamedValue _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_CheckNamedValueByRef is null)
                    return s_CheckNamedValueByVal!(target, _p0);

                return s_CheckNamedValueByRef(ref target, _p0);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static NamedValueChecker()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("CheckNamedValue");

                if (!(extensionMethod is null))
                    s_CheckNamedValueByRef = extensionMethod.CreateStaticDelegate(typeof(CheckNamedValueByRef)) as CheckNamedValueByRef;

                if (s_CheckNamedValueByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("CheckNamedValue");

                    if (!(extensionMethod is null))
                        s_CheckNamedValueByVal = extensionMethod.CreateStaticDelegate(typeof(CheckNamedValueByVal)) as CheckNamedValueByVal;
                }

                if (s_CheckNamedValueByRef is null && s_CheckNamedValueByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement NamedValueChecker.CheckNamedValue method", new Exception("CheckNamedValue"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator NamedValueChecker<T>(in ptr<T> target_ptr) => new NamedValueChecker<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator NamedValueChecker<T>(in T target) => new NamedValueChecker<T>(target);

            // Enable comparisons between nil and NamedValueChecker<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NamedValueChecker<T> value, NilType nil) => Activator.CreateInstance<NamedValueChecker<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NamedValueChecker<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NamedValueChecker<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NamedValueChecker<T> value) => value != nil;
        }
    }
}}}

namespace go
{
    public static class driver_NamedValueCheckerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.database.sql.driver_package.NamedValueChecker target)
        {
            try
            {
                return ((go.database.sql.driver_package.NamedValueChecker<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.database.sql.driver_package.NamedValueChecker target, out T result)
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
        public static object? _(this go.database.sql.driver_package.NamedValueChecker target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.database.sql.driver_package.NamedValueChecker<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.database.sql.driver_package.NamedValueChecker target, Type type, out object? result)
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