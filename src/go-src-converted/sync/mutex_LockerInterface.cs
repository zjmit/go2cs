//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 00:34:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using race = go.@internal.race_package;
using atomic = go.sync.atomic_package;
using @unsafe = go.@unsafe_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class sync_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Locker
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Locker As<T>(in T target) => (Locker<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Locker As<T>(ptr<T> target_ptr) => (Locker<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Locker? As(object target) =>
                typeof(Locker<>).CreateInterfaceHandler<Locker>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Locker<T> : Locker
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

            public Locker(in T target) => m_target = target;

            public Locker(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void LockByPtr(ptr<T> value);
            private delegate void LockByVal(T value);

            private static readonly LockByPtr s_LockByPtr;
            private static readonly LockByVal s_LockByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Lock()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_LockByPtr is null || !m_target_is_ptr)
                {
                    s_LockByVal!(target);
                    return;
                }

                s_LockByPtr(m_target_ptr);
                return;
                
            }

            private delegate void UnlockByPtr(ptr<T> value);
            private delegate void UnlockByVal(T value);

            private static readonly UnlockByPtr s_UnlockByPtr;
            private static readonly UnlockByVal s_UnlockByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Unlock()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_UnlockByPtr is null || !m_target_is_ptr)
                {
                    s_UnlockByVal!(target);
                    return;
                }

                s_UnlockByPtr(m_target_ptr);
                return;
                
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Locker()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Lock");

                if (!(extensionMethod is null))
                    s_LockByPtr = extensionMethod.CreateStaticDelegate(typeof(LockByPtr)) as LockByPtr;

                extensionMethod = targetType.GetExtensionMethod("Lock");

                if (!(extensionMethod is null))
                    s_LockByVal = extensionMethod.CreateStaticDelegate(typeof(LockByVal)) as LockByVal;

                if (s_LockByPtr is null && s_LockByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Locker.Lock method", new Exception("Lock"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Unlock");

                if (!(extensionMethod is null))
                    s_UnlockByPtr = extensionMethod.CreateStaticDelegate(typeof(UnlockByPtr)) as UnlockByPtr;

                extensionMethod = targetType.GetExtensionMethod("Unlock");

                if (!(extensionMethod is null))
                    s_UnlockByVal = extensionMethod.CreateStaticDelegate(typeof(UnlockByVal)) as UnlockByVal;

                if (s_UnlockByPtr is null && s_UnlockByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Locker.Unlock method", new Exception("Unlock"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Locker<T>(in ptr<T> target_ptr) => new Locker<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Locker<T>(in T target) => new Locker<T>(target);

            // Enable comparisons between nil and Locker<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Locker<T> value, NilType nil) => Activator.CreateInstance<Locker<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Locker<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Locker<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Locker<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class sync_LockerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.sync_package.Locker target)
        {
            try
            {
                return ((go.sync_package.Locker<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.sync_package.Locker target, out T result)
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
        public static object? _(this go.sync_package.Locker target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.sync_package.Locker<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.sync_package.Locker target, Type type, out object? result)
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