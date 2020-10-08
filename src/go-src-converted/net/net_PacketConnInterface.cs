//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:34:02 UTC
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
using io = go.io_package;
using os = go.os_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using time = go.time_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface PacketConn
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static PacketConn As<T>(in T target) => (PacketConn<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static PacketConn As<T>(ptr<T> target_ptr) => (PacketConn<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static PacketConn? As(object target) =>
                typeof(PacketConn<>).CreateInterfaceHandler<PacketConn>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class PacketConn<T> : PacketConn
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

            public PacketConn(in T target) => m_target = target;

            public PacketConn(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate error ReadFromByPtr(ptr<T> value, slice<byte> p);
            private delegate error ReadFromByVal(T value, slice<byte> p);

            private static readonly ReadFromByPtr s_ReadFromByPtr;
            private static readonly ReadFromByVal s_ReadFromByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error ReadFrom(slice<byte> p)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReadFromByPtr is null || !m_target_is_ptr)
                    return s_ReadFromByVal!(target, p);

                return s_ReadFromByPtr(m_target_ptr, p);
            }

            private delegate error WriteToByPtr(ptr<T> value, slice<byte> p, Addr addr);
            private delegate error WriteToByVal(T value, slice<byte> p, Addr addr);

            private static readonly WriteToByPtr s_WriteToByPtr;
            private static readonly WriteToByVal s_WriteToByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error WriteTo(slice<byte> p, Addr addr)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_WriteToByPtr is null || !m_target_is_ptr)
                    return s_WriteToByVal!(target, p, addr);

                return s_WriteToByPtr(m_target_ptr, p, addr);
            }

            private delegate error CloseByPtr(ptr<T> value);
            private delegate error CloseByVal(T value);

            private static readonly CloseByPtr s_CloseByPtr;
            private static readonly CloseByVal s_CloseByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Close()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_CloseByPtr is null || !m_target_is_ptr)
                    return s_CloseByVal!(target);

                return s_CloseByPtr(m_target_ptr);
            }

            private delegate error LocalAddrByPtr(ptr<T> value);
            private delegate error LocalAddrByVal(T value);

            private static readonly LocalAddrByPtr s_LocalAddrByPtr;
            private static readonly LocalAddrByVal s_LocalAddrByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error LocalAddr()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_LocalAddrByPtr is null || !m_target_is_ptr)
                    return s_LocalAddrByVal!(target);

                return s_LocalAddrByPtr(m_target_ptr);
            }

            private delegate error SetDeadlineByPtr(ptr<T> value, time.Time t);
            private delegate error SetDeadlineByVal(T value, time.Time t);

            private static readonly SetDeadlineByPtr s_SetDeadlineByPtr;
            private static readonly SetDeadlineByVal s_SetDeadlineByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error SetDeadline(time.Time t)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_SetDeadlineByPtr is null || !m_target_is_ptr)
                    return s_SetDeadlineByVal!(target, t);

                return s_SetDeadlineByPtr(m_target_ptr, t);
            }

            private delegate error SetReadDeadlineByPtr(ptr<T> value, time.Time t);
            private delegate error SetReadDeadlineByVal(T value, time.Time t);

            private static readonly SetReadDeadlineByPtr s_SetReadDeadlineByPtr;
            private static readonly SetReadDeadlineByVal s_SetReadDeadlineByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error SetReadDeadline(time.Time t)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_SetReadDeadlineByPtr is null || !m_target_is_ptr)
                    return s_SetReadDeadlineByVal!(target, t);

                return s_SetReadDeadlineByPtr(m_target_ptr, t);
            }

            private delegate error SetWriteDeadlineByPtr(ptr<T> value, time.Time t);
            private delegate error SetWriteDeadlineByVal(T value, time.Time t);

            private static readonly SetWriteDeadlineByPtr s_SetWriteDeadlineByPtr;
            private static readonly SetWriteDeadlineByVal s_SetWriteDeadlineByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error SetWriteDeadline(time.Time t)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_SetWriteDeadlineByPtr is null || !m_target_is_ptr)
                    return s_SetWriteDeadlineByVal!(target, t);

                return s_SetWriteDeadlineByPtr(m_target_ptr, t);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static PacketConn()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ReadFrom");

                if (!(extensionMethod is null))
                    s_ReadFromByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadFromByPtr)) as ReadFromByPtr;

                extensionMethod = targetType.GetExtensionMethod("ReadFrom");

                if (!(extensionMethod is null))
                    s_ReadFromByVal = extensionMethod.CreateStaticDelegate(typeof(ReadFromByVal)) as ReadFromByVal;

                if (s_ReadFromByPtr is null && s_ReadFromByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement PacketConn.ReadFrom method", new Exception("ReadFrom"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("WriteTo");

                if (!(extensionMethod is null))
                    s_WriteToByPtr = extensionMethod.CreateStaticDelegate(typeof(WriteToByPtr)) as WriteToByPtr;

                extensionMethod = targetType.GetExtensionMethod("WriteTo");

                if (!(extensionMethod is null))
                    s_WriteToByVal = extensionMethod.CreateStaticDelegate(typeof(WriteToByVal)) as WriteToByVal;

                if (s_WriteToByPtr is null && s_WriteToByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement PacketConn.WriteTo method", new Exception("WriteTo"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Close");

                if (!(extensionMethod is null))
                    s_CloseByPtr = extensionMethod.CreateStaticDelegate(typeof(CloseByPtr)) as CloseByPtr;

                extensionMethod = targetType.GetExtensionMethod("Close");

                if (!(extensionMethod is null))
                    s_CloseByVal = extensionMethod.CreateStaticDelegate(typeof(CloseByVal)) as CloseByVal;

                if (s_CloseByPtr is null && s_CloseByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement PacketConn.Close method", new Exception("Close"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("LocalAddr");

                if (!(extensionMethod is null))
                    s_LocalAddrByPtr = extensionMethod.CreateStaticDelegate(typeof(LocalAddrByPtr)) as LocalAddrByPtr;

                extensionMethod = targetType.GetExtensionMethod("LocalAddr");

                if (!(extensionMethod is null))
                    s_LocalAddrByVal = extensionMethod.CreateStaticDelegate(typeof(LocalAddrByVal)) as LocalAddrByVal;

                if (s_LocalAddrByPtr is null && s_LocalAddrByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement PacketConn.LocalAddr method", new Exception("LocalAddr"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("SetDeadline");

                if (!(extensionMethod is null))
                    s_SetDeadlineByPtr = extensionMethod.CreateStaticDelegate(typeof(SetDeadlineByPtr)) as SetDeadlineByPtr;

                extensionMethod = targetType.GetExtensionMethod("SetDeadline");

                if (!(extensionMethod is null))
                    s_SetDeadlineByVal = extensionMethod.CreateStaticDelegate(typeof(SetDeadlineByVal)) as SetDeadlineByVal;

                if (s_SetDeadlineByPtr is null && s_SetDeadlineByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement PacketConn.SetDeadline method", new Exception("SetDeadline"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("SetReadDeadline");

                if (!(extensionMethod is null))
                    s_SetReadDeadlineByPtr = extensionMethod.CreateStaticDelegate(typeof(SetReadDeadlineByPtr)) as SetReadDeadlineByPtr;

                extensionMethod = targetType.GetExtensionMethod("SetReadDeadline");

                if (!(extensionMethod is null))
                    s_SetReadDeadlineByVal = extensionMethod.CreateStaticDelegate(typeof(SetReadDeadlineByVal)) as SetReadDeadlineByVal;

                if (s_SetReadDeadlineByPtr is null && s_SetReadDeadlineByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement PacketConn.SetReadDeadline method", new Exception("SetReadDeadline"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("SetWriteDeadline");

                if (!(extensionMethod is null))
                    s_SetWriteDeadlineByPtr = extensionMethod.CreateStaticDelegate(typeof(SetWriteDeadlineByPtr)) as SetWriteDeadlineByPtr;

                extensionMethod = targetType.GetExtensionMethod("SetWriteDeadline");

                if (!(extensionMethod is null))
                    s_SetWriteDeadlineByVal = extensionMethod.CreateStaticDelegate(typeof(SetWriteDeadlineByVal)) as SetWriteDeadlineByVal;

                if (s_SetWriteDeadlineByPtr is null && s_SetWriteDeadlineByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement PacketConn.SetWriteDeadline method", new Exception("SetWriteDeadline"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator PacketConn<T>(in ptr<T> target_ptr) => new PacketConn<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator PacketConn<T>(in T target) => new PacketConn<T>(target);

            // Enable comparisons between nil and PacketConn<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PacketConn<T> value, NilType nil) => Activator.CreateInstance<PacketConn<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PacketConn<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PacketConn<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PacketConn<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class net_PacketConnExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.net_package.PacketConn target)
        {
            try
            {
                return ((go.net_package.PacketConn<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.net_package.PacketConn target, out T result)
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
        public static object? _(this go.net_package.PacketConn target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.net_package.PacketConn<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.net_package.PacketConn target, Type type, out object? result)
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