//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:34:06 UTC
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
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using par = go.cmd.go.@internal.par_package;
using module = go.golang.org.x.mod.module_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class mvs_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Reqs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Reqs As<T>(in T target) => (Reqs<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Reqs As<T>(ptr<T> target_ptr) => (Reqs<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Reqs? As(object target) =>
                typeof(Reqs<>).CreateInterfaceHandler<Reqs>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Reqs<T> : Reqs
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

            public Reqs(in T target) => m_target = target;

            public Reqs(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (module.Version, error) RequiredByPtr(ptr<T> value, module.Version m);
            private delegate (module.Version, error) RequiredByVal(T value, module.Version m);

            private static readonly RequiredByPtr s_RequiredByPtr;
            private static readonly RequiredByVal s_RequiredByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (module.Version, error) Required(module.Version m)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_RequiredByPtr is null || !m_target_is_ptr)
                    return s_RequiredByVal!(target, m);

                return s_RequiredByPtr(m_target_ptr, m);
            }

            private delegate (module.Version, error) MaxByPtr(ptr<T> value, @string v1, @string v2);
            private delegate (module.Version, error) MaxByVal(T value, @string v1, @string v2);

            private static readonly MaxByPtr s_MaxByPtr;
            private static readonly MaxByVal s_MaxByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (module.Version, error) Max(@string v1, @string v2)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_MaxByPtr is null || !m_target_is_ptr)
                    return s_MaxByVal!(target, v1, v2);

                return s_MaxByPtr(m_target_ptr, v1, v2);
            }

            private delegate (module.Version, error) UpgradeByPtr(ptr<T> value, module.Version m);
            private delegate (module.Version, error) UpgradeByVal(T value, module.Version m);

            private static readonly UpgradeByPtr s_UpgradeByPtr;
            private static readonly UpgradeByVal s_UpgradeByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (module.Version, error) Upgrade(module.Version m)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_UpgradeByPtr is null || !m_target_is_ptr)
                    return s_UpgradeByVal!(target, m);

                return s_UpgradeByPtr(m_target_ptr, m);
            }

            private delegate (module.Version, error) PreviousByPtr(ptr<T> value, module.Version m);
            private delegate (module.Version, error) PreviousByVal(T value, module.Version m);

            private static readonly PreviousByPtr s_PreviousByPtr;
            private static readonly PreviousByVal s_PreviousByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (module.Version, error) Previous(module.Version m)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_PreviousByPtr is null || !m_target_is_ptr)
                    return s_PreviousByVal!(target, m);

                return s_PreviousByPtr(m_target_ptr, m);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Reqs()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Required");

                if (!(extensionMethod is null))
                    s_RequiredByPtr = extensionMethod.CreateStaticDelegate(typeof(RequiredByPtr)) as RequiredByPtr;

                extensionMethod = targetType.GetExtensionMethod("Required");

                if (!(extensionMethod is null))
                    s_RequiredByVal = extensionMethod.CreateStaticDelegate(typeof(RequiredByVal)) as RequiredByVal;

                if (s_RequiredByPtr is null && s_RequiredByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Reqs.Required method", new Exception("Required"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Max");

                if (!(extensionMethod is null))
                    s_MaxByPtr = extensionMethod.CreateStaticDelegate(typeof(MaxByPtr)) as MaxByPtr;

                extensionMethod = targetType.GetExtensionMethod("Max");

                if (!(extensionMethod is null))
                    s_MaxByVal = extensionMethod.CreateStaticDelegate(typeof(MaxByVal)) as MaxByVal;

                if (s_MaxByPtr is null && s_MaxByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Reqs.Max method", new Exception("Max"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Upgrade");

                if (!(extensionMethod is null))
                    s_UpgradeByPtr = extensionMethod.CreateStaticDelegate(typeof(UpgradeByPtr)) as UpgradeByPtr;

                extensionMethod = targetType.GetExtensionMethod("Upgrade");

                if (!(extensionMethod is null))
                    s_UpgradeByVal = extensionMethod.CreateStaticDelegate(typeof(UpgradeByVal)) as UpgradeByVal;

                if (s_UpgradeByPtr is null && s_UpgradeByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Reqs.Upgrade method", new Exception("Upgrade"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Previous");

                if (!(extensionMethod is null))
                    s_PreviousByPtr = extensionMethod.CreateStaticDelegate(typeof(PreviousByPtr)) as PreviousByPtr;

                extensionMethod = targetType.GetExtensionMethod("Previous");

                if (!(extensionMethod is null))
                    s_PreviousByVal = extensionMethod.CreateStaticDelegate(typeof(PreviousByVal)) as PreviousByVal;

                if (s_PreviousByPtr is null && s_PreviousByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Reqs.Previous method", new Exception("Previous"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Reqs<T>(in ptr<T> target_ptr) => new Reqs<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Reqs<T>(in T target) => new Reqs<T>(target);

            // Enable comparisons between nil and Reqs<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Reqs<T> value, NilType nil) => Activator.CreateInstance<Reqs<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Reqs<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Reqs<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Reqs<T> value) => value != nil;
        }
    }
}}}}

namespace go
{
    public static class mvs_ReqsExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.go.@internal.mvs_package.Reqs target)
        {
            try
            {
                return ((go.cmd.go.@internal.mvs_package.Reqs<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.go.@internal.mvs_package.Reqs target, out T result)
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
        public static object? _(this go.cmd.go.@internal.mvs_package.Reqs target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.go.@internal.mvs_package.Reqs<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.go.@internal.mvs_package.Reqs target, Type type, out object? result)
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