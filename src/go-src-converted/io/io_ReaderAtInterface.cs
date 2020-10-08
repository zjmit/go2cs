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
        public partial interface ReaderAt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ReaderAt As<T>(in T target) => (ReaderAt<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ReaderAt As<T>(ptr<T> target_ptr) => (ReaderAt<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ReaderAt? As(object target) =>
                typeof(ReaderAt<>).CreateInterfaceHandler<ReaderAt>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class ReaderAt<T> : ReaderAt
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

            public ReaderAt(in T target) => m_target = target;

            public ReaderAt(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (long, error) ReadAtByPtr(ptr<T> value, slice<byte> p, long off);
            private delegate (long, error) ReadAtByVal(T value, slice<byte> p, long off);

            private static readonly ReadAtByPtr s_ReadAtByPtr;
            private static readonly ReadAtByVal s_ReadAtByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) ReadAt(slice<byte> p, long off)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReadAtByPtr is null || !m_target_is_ptr)
                    return s_ReadAtByVal!(target, p, off);

                return s_ReadAtByPtr(m_target_ptr, p, off);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static ReaderAt()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ReadAt");

                if (!(extensionMethod is null))
                    s_ReadAtByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadAtByPtr)) as ReadAtByPtr;

                extensionMethod = targetType.GetExtensionMethod("ReadAt");

                if (!(extensionMethod is null))
                    s_ReadAtByVal = extensionMethod.CreateStaticDelegate(typeof(ReadAtByVal)) as ReadAtByVal;

                if (s_ReadAtByPtr is null && s_ReadAtByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement ReaderAt.ReadAt method", new Exception("ReadAt"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator ReaderAt<T>(in ptr<T> target_ptr) => new ReaderAt<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator ReaderAt<T>(in T target) => new ReaderAt<T>(target);

            // Enable comparisons between nil and ReaderAt<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ReaderAt<T> value, NilType nil) => Activator.CreateInstance<ReaderAt<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ReaderAt<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ReaderAt<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ReaderAt<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class io_ReaderAtExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.io_package.ReaderAt target)
        {
            try
            {
                return ((go.io_package.ReaderAt<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.io_package.ReaderAt target, out T result)
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
        public static object? _(this go.io_package.ReaderAt target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.io_package.ReaderAt<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.io_package.ReaderAt target, Type type, out object? result)
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