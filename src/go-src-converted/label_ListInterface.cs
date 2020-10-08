//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:54:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using @unsafe = go.@unsafe_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event
{
    public static partial class label_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface List
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static List As<T>(in T target) => (List<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static List As<T>(ptr<T> target_ptr) => (List<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static List? As(object target) =>
                typeof(List<>).CreateInterfaceHandler<List>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class List<T> : List
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

            public List(in T target) => m_target = target;

            public List(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate Label ValidByPtr(ptr<T> value, long index);
            private delegate Label ValidByVal(T value, long index);

            private static readonly ValidByPtr s_ValidByPtr;
            private static readonly ValidByVal s_ValidByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Label Valid(long index)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ValidByPtr is null || !m_target_is_ptr)
                    return s_ValidByVal!(target, index);

                return s_ValidByPtr(m_target_ptr, index);
            }

            private delegate Label LabelByPtr(ptr<T> value, long index);
            private delegate Label LabelByVal(T value, long index);

            private static readonly LabelByPtr s_LabelByPtr;
            private static readonly LabelByVal s_LabelByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Label Label(long index)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_LabelByPtr is null || !m_target_is_ptr)
                    return s_LabelByVal!(target, index);

                return s_LabelByPtr(m_target_ptr, index);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static List()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Valid");

                if (!(extensionMethod is null))
                    s_ValidByPtr = extensionMethod.CreateStaticDelegate(typeof(ValidByPtr)) as ValidByPtr;

                extensionMethod = targetType.GetExtensionMethod("Valid");

                if (!(extensionMethod is null))
                    s_ValidByVal = extensionMethod.CreateStaticDelegate(typeof(ValidByVal)) as ValidByVal;

                if (s_ValidByPtr is null && s_ValidByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement List.Valid method", new Exception("Valid"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Label");

                if (!(extensionMethod is null))
                    s_LabelByPtr = extensionMethod.CreateStaticDelegate(typeof(LabelByPtr)) as LabelByPtr;

                extensionMethod = targetType.GetExtensionMethod("Label");

                if (!(extensionMethod is null))
                    s_LabelByVal = extensionMethod.CreateStaticDelegate(typeof(LabelByVal)) as LabelByVal;

                if (s_LabelByPtr is null && s_LabelByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement List.Label method", new Exception("Label"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator List<T>(in ptr<T> target_ptr) => new List<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator List<T>(in T target) => new List<T>(target);

            // Enable comparisons between nil and List<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(List<T> value, NilType nil) => Activator.CreateInstance<List<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(List<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, List<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, List<T> value) => value != nil;
        }
    }
}}}}}}

namespace go
{
    public static class label_ListExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.golang.org.x.tools.@internal.@event.label_package.List target)
        {
            try
            {
                return ((go.golang.org.x.tools.@internal.@event.label_package.List<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.golang.org.x.tools.@internal.@event.label_package.List target, out T result)
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
        public static object? _(this go.golang.org.x.tools.@internal.@event.label_package.List target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.golang.org.x.tools.@internal.@event.label_package.List<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.golang.org.x.tools.@internal.@event.label_package.List target, Type type, out object? result)
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