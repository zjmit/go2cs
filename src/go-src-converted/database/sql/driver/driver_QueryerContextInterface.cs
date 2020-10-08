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
        public partial interface QueryerContext
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static QueryerContext As<T>(in T target) => (QueryerContext<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static QueryerContext As<T>(ptr<T> target_ptr) => (QueryerContext<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static QueryerContext? As(object target) =>
                typeof(QueryerContext<>).CreateInterfaceHandler<QueryerContext>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class QueryerContext<T> : QueryerContext
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

            public QueryerContext(in T target) => m_target = target;

            public QueryerContext(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (Rows, error) QueryContextByPtr(ptr<T> value, context.Context ctx, @string query, slice<NamedValue> args);
            private delegate (Rows, error) QueryContextByVal(T value, context.Context ctx, @string query, slice<NamedValue> args);

            private static readonly QueryContextByPtr s_QueryContextByPtr;
            private static readonly QueryContextByVal s_QueryContextByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (Rows, error) QueryContext(context.Context ctx, @string query, slice<NamedValue> args)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_QueryContextByPtr is null || !m_target_is_ptr)
                    return s_QueryContextByVal!(target, ctx, query, args);

                return s_QueryContextByPtr(m_target_ptr, ctx, query, args);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static QueryerContext()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("QueryContext");

                if (!(extensionMethod is null))
                    s_QueryContextByPtr = extensionMethod.CreateStaticDelegate(typeof(QueryContextByPtr)) as QueryContextByPtr;

                extensionMethod = targetType.GetExtensionMethod("QueryContext");

                if (!(extensionMethod is null))
                    s_QueryContextByVal = extensionMethod.CreateStaticDelegate(typeof(QueryContextByVal)) as QueryContextByVal;

                if (s_QueryContextByPtr is null && s_QueryContextByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement QueryerContext.QueryContext method", new Exception("QueryContext"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator QueryerContext<T>(in ptr<T> target_ptr) => new QueryerContext<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator QueryerContext<T>(in T target) => new QueryerContext<T>(target);

            // Enable comparisons between nil and QueryerContext<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(QueryerContext<T> value, NilType nil) => Activator.CreateInstance<QueryerContext<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(QueryerContext<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, QueryerContext<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, QueryerContext<T> value) => value != nil;
        }
    }
}}}

namespace go
{
    public static class driver_QueryerContextExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.database.sql.driver_package.QueryerContext target)
        {
            try
            {
                return ((go.database.sql.driver_package.QueryerContext<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.database.sql.driver_package.QueryerContext target, out T result)
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
        public static object? _(this go.database.sql.driver_package.QueryerContext target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.database.sql.driver_package.QueryerContext<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.database.sql.driver_package.QueryerContext target, Type type, out object? result)
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