//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:45:23 UTC
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
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace archive
{
    public static partial class tar_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface fileReader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static fileReader As<T>(in T target) => (fileReader<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static fileReader As<T>(ptr<T> target_ptr) => (fileReader<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static fileReader? As(object target) =>
                typeof(fileReader<>).CreateInterfaceHandler<fileReader>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class fileReader<T> : fileReader
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

            public fileReader(in T target) => m_target = target;

            public fileReader(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (long, error) WriteToByRef(ref T value, io.Writer _p0);
            private delegate (long, error) WriteToByVal(T value, io.Writer _p0);

            private static readonly WriteToByRef s_WriteToByRef;
            private static readonly WriteToByVal s_WriteToByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) WriteTo(io.Writer _p0)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_WriteToByRef is null)
                    return s_WriteToByVal!(target, _p0);

                return s_WriteToByRef(ref target, _p0);
            }

            private delegate (long, error) ReadByRef(ref T value, slice<byte> p);
            private delegate (long, error) ReadByVal(T value, slice<byte> p);

            private static readonly ReadByRef s_ReadByRef;
            private static readonly ReadByVal s_ReadByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Read(slice<byte> p)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ReadByRef is null)
                    return s_ReadByVal!(target, p);

                return s_ReadByRef(ref target, p);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static fileReader()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("WriteTo");

                if (!(extensionMethod is null))
                    s_WriteToByRef = extensionMethod.CreateStaticDelegate(typeof(WriteToByRef)) as WriteToByRef;

                if (s_WriteToByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("WriteTo");

                    if (!(extensionMethod is null))
                        s_WriteToByVal = extensionMethod.CreateStaticDelegate(typeof(WriteToByVal)) as WriteToByVal;
                }

                if (s_WriteToByRef is null && s_WriteToByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement fileReader.WriteTo method", new Exception("WriteTo"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Read");

                if (!(extensionMethod is null))
                    s_ReadByRef = extensionMethod.CreateStaticDelegate(typeof(ReadByRef)) as ReadByRef;

                if (s_ReadByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Read");

                    if (!(extensionMethod is null))
                        s_ReadByVal = extensionMethod.CreateStaticDelegate(typeof(ReadByVal)) as ReadByVal;
                }

                if (s_ReadByRef is null && s_ReadByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement fileReader.Read method", new Exception("Read"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator fileReader<T>(in ptr<T> target_ptr) => new fileReader<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator fileReader<T>(in T target) => new fileReader<T>(target);

            // Enable comparisons between nil and fileReader<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fileReader<T> value, NilType nil) => Activator.CreateInstance<fileReader<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fileReader<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fileReader<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fileReader<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class tar_fileReaderExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.archive.tar_package.fileReader target)
        {
            try
            {
                return ((go.archive.tar_package.fileReader<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.archive.tar_package.fileReader target, out T result)
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
        public static object? _(this go.archive.tar_package.fileReader target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.archive.tar_package.fileReader<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.archive.tar_package.fileReader target, Type type, out object? result)
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