//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:33:49 UTC
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
using elf = go.debug.elf_package;
using macho = go.debug.macho_package;
using pe = go.debug.pe_package;
using fmt = go.fmt_package;
using xcoff = go.@internal.xcoff_package;
using io = go.io_package;
using os = go.os_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class version_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface exe
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static exe As<T>(in T target) => (exe<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static exe As<T>(ptr<T> target_ptr) => (exe<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static exe? As(object target) =>
                typeof(exe<>).CreateInterfaceHandler<exe>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class exe<T> : exe
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

            public exe(in T target) => m_target = target;

            public exe(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate ulong CloseByPtr(ptr<T> value);
            private delegate ulong CloseByVal(T value);

            private static readonly CloseByPtr s_CloseByPtr;
            private static readonly CloseByVal s_CloseByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ulong Close()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_CloseByPtr is null || !m_target_is_ptr)
                    return s_CloseByVal!(target);

                return s_CloseByPtr(m_target_ptr);
            }

            private delegate ulong ReadDataByPtr(ptr<T> value, ulong addr, ulong size);
            private delegate ulong ReadDataByVal(T value, ulong addr, ulong size);

            private static readonly ReadDataByPtr s_ReadDataByPtr;
            private static readonly ReadDataByVal s_ReadDataByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ulong ReadData(ulong addr, ulong size)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReadDataByPtr is null || !m_target_is_ptr)
                    return s_ReadDataByVal!(target, addr, size);

                return s_ReadDataByPtr(m_target_ptr, addr, size);
            }

            private delegate ulong DataStartByPtr(ptr<T> value);
            private delegate ulong DataStartByVal(T value);

            private static readonly DataStartByPtr s_DataStartByPtr;
            private static readonly DataStartByVal s_DataStartByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ulong DataStart()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_DataStartByPtr is null || !m_target_is_ptr)
                    return s_DataStartByVal!(target);

                return s_DataStartByPtr(m_target_ptr);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static exe()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Close");

                if (!(extensionMethod is null))
                    s_CloseByPtr = extensionMethod.CreateStaticDelegate(typeof(CloseByPtr)) as CloseByPtr;

                extensionMethod = targetType.GetExtensionMethod("Close");

                if (!(extensionMethod is null))
                    s_CloseByVal = extensionMethod.CreateStaticDelegate(typeof(CloseByVal)) as CloseByVal;

                if (s_CloseByPtr is null && s_CloseByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement exe.Close method", new Exception("Close"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ReadData");

                if (!(extensionMethod is null))
                    s_ReadDataByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadDataByPtr)) as ReadDataByPtr;

                extensionMethod = targetType.GetExtensionMethod("ReadData");

                if (!(extensionMethod is null))
                    s_ReadDataByVal = extensionMethod.CreateStaticDelegate(typeof(ReadDataByVal)) as ReadDataByVal;

                if (s_ReadDataByPtr is null && s_ReadDataByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement exe.ReadData method", new Exception("ReadData"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("DataStart");

                if (!(extensionMethod is null))
                    s_DataStartByPtr = extensionMethod.CreateStaticDelegate(typeof(DataStartByPtr)) as DataStartByPtr;

                extensionMethod = targetType.GetExtensionMethod("DataStart");

                if (!(extensionMethod is null))
                    s_DataStartByVal = extensionMethod.CreateStaticDelegate(typeof(DataStartByVal)) as DataStartByVal;

                if (s_DataStartByPtr is null && s_DataStartByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement exe.DataStart method", new Exception("DataStart"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator exe<T>(in ptr<T> target_ptr) => new exe<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator exe<T>(in T target) => new exe<T>(target);

            // Enable comparisons between nil and exe<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(exe<T> value, NilType nil) => Activator.CreateInstance<exe<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(exe<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, exe<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, exe<T> value) => value != nil;
        }
    }
}}}}

namespace go
{
    public static class version_exeExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.go.@internal.version_package.exe target)
        {
            try
            {
                return ((go.cmd.go.@internal.version_package.exe<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.go.@internal.version_package.exe target, out T result)
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
        public static object? _(this go.cmd.go.@internal.version_package.exe target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.go.@internal.version_package.exe<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.go.@internal.version_package.exe target, Type type, out object? result)
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