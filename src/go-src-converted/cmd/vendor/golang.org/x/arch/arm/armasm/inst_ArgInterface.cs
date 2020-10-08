//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:44:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace arm
{
    public static partial class armasm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Arg
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Arg As<T>(in T target) => (Arg<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Arg As<T>(ptr<T> target_ptr) => (Arg<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Arg? As(object target) =>
                typeof(Arg<>).CreateInterfaceHandler<Arg>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Arg<T> : Arg
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

            public Arg(in T target) => m_target = target;

            public Arg(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate @string IsArgByPtr(ptr<T> value);
            private delegate @string IsArgByVal(T value);

            private static readonly IsArgByPtr s_IsArgByPtr;
            private static readonly IsArgByVal s_IsArgByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string IsArg()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_IsArgByPtr is null || !m_target_is_ptr)
                    return s_IsArgByVal!(target);

                return s_IsArgByPtr(m_target_ptr);
            }

            private delegate @string StringByPtr(ptr<T> value);
            private delegate @string StringByVal(T value);

            private static readonly StringByPtr s_StringByPtr;
            private static readonly StringByVal s_StringByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string String()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_StringByPtr is null || !m_target_is_ptr)
                    return s_StringByVal!(target);

                return s_StringByPtr(m_target_ptr);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Arg()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("IsArg");

                if (!(extensionMethod is null))
                    s_IsArgByPtr = extensionMethod.CreateStaticDelegate(typeof(IsArgByPtr)) as IsArgByPtr;

                extensionMethod = targetType.GetExtensionMethod("IsArg");

                if (!(extensionMethod is null))
                    s_IsArgByVal = extensionMethod.CreateStaticDelegate(typeof(IsArgByVal)) as IsArgByVal;

                if (s_IsArgByPtr is null && s_IsArgByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Arg.IsArg method", new Exception("IsArg"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("String");

                if (!(extensionMethod is null))
                    s_StringByPtr = extensionMethod.CreateStaticDelegate(typeof(StringByPtr)) as StringByPtr;

                extensionMethod = targetType.GetExtensionMethod("String");

                if (!(extensionMethod is null))
                    s_StringByVal = extensionMethod.CreateStaticDelegate(typeof(StringByVal)) as StringByVal;

                if (s_StringByPtr is null && s_StringByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Arg.String method", new Exception("String"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Arg<T>(in ptr<T> target_ptr) => new Arg<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Arg<T>(in T target) => new Arg<T>(target);

            // Enable comparisons between nil and Arg<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Arg<T> value, NilType nil) => Activator.CreateInstance<Arg<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Arg<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Arg<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Arg<T> value) => value != nil;
        }
    }
}}}}}}}

namespace go
{
    public static class armasm_ArgExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.vendor.golang.org.x.arch.arm.armasm_package.Arg target)
        {
            try
            {
                return ((go.cmd.vendor.golang.org.x.arch.arm.armasm_package.Arg<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.vendor.golang.org.x.arch.arm.armasm_package.Arg target, out T result)
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
        public static object? _(this go.cmd.vendor.golang.org.x.arch.arm.armasm_package.Arg target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.vendor.golang.org.x.arch.arm.armasm_package.Arg<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.vendor.golang.org.x.arch.arm.armasm_package.Arg target, Type type, out object? result)
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