//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:45:58 UTC
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
using http = go.net.http_package;
using os = go.os_package;
using strings = go.strings_package;
using lazyregexp = go.golang.org.x.mod.@internal.lazyregexp_package;
using module = go.golang.org.x.mod.module_package;
using tlog = go.golang.org.x.mod.sumdb.tlog_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class sumdb_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface ServerOps
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ServerOps As<T>(in T target) => (ServerOps<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ServerOps As<T>(ptr<T> target_ptr) => (ServerOps<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static ServerOps? As(object target) =>
                typeof(ServerOps<>).CreateInterfaceHandler<ServerOps>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class ServerOps<T> : ServerOps
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

            public ServerOps(in T target) => m_target = target;

            public ServerOps(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (slice<byte>, error) SignedByPtr(ptr<T> value, context.Context ctx);
            private delegate (slice<byte>, error) SignedByVal(T value, context.Context ctx);

            private static readonly SignedByPtr s_SignedByPtr;
            private static readonly SignedByVal s_SignedByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) Signed(context.Context ctx)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_SignedByPtr is null || !m_target_is_ptr)
                    return s_SignedByVal!(target, ctx);

                return s_SignedByPtr(m_target_ptr, ctx);
            }

            private delegate (slice<byte>, error) ReadRecordsByPtr(ptr<T> value, context.Context ctx, long id, long n);
            private delegate (slice<byte>, error) ReadRecordsByVal(T value, context.Context ctx, long id, long n);

            private static readonly ReadRecordsByPtr s_ReadRecordsByPtr;
            private static readonly ReadRecordsByVal s_ReadRecordsByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) ReadRecords(context.Context ctx, long id, long n)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReadRecordsByPtr is null || !m_target_is_ptr)
                    return s_ReadRecordsByVal!(target, ctx, id, n);

                return s_ReadRecordsByPtr(m_target_ptr, ctx, id, n);
            }

            private delegate (slice<byte>, error) LookupByPtr(ptr<T> value, context.Context ctx, module.Version m);
            private delegate (slice<byte>, error) LookupByVal(T value, context.Context ctx, module.Version m);

            private static readonly LookupByPtr s_LookupByPtr;
            private static readonly LookupByVal s_LookupByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) Lookup(context.Context ctx, module.Version m)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_LookupByPtr is null || !m_target_is_ptr)
                    return s_LookupByVal!(target, ctx, m);

                return s_LookupByPtr(m_target_ptr, ctx, m);
            }

            private delegate (slice<byte>, error) ReadTileDataByPtr(ptr<T> value, context.Context ctx, tlog.Tile t);
            private delegate (slice<byte>, error) ReadTileDataByVal(T value, context.Context ctx, tlog.Tile t);

            private static readonly ReadTileDataByPtr s_ReadTileDataByPtr;
            private static readonly ReadTileDataByVal s_ReadTileDataByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (slice<byte>, error) ReadTileData(context.Context ctx, tlog.Tile t)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ReadTileDataByPtr is null || !m_target_is_ptr)
                    return s_ReadTileDataByVal!(target, ctx, t);

                return s_ReadTileDataByPtr(m_target_ptr, ctx, t);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static ServerOps()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Signed");

                if (!(extensionMethod is null))
                    s_SignedByPtr = extensionMethod.CreateStaticDelegate(typeof(SignedByPtr)) as SignedByPtr;

                extensionMethod = targetType.GetExtensionMethod("Signed");

                if (!(extensionMethod is null))
                    s_SignedByVal = extensionMethod.CreateStaticDelegate(typeof(SignedByVal)) as SignedByVal;

                if (s_SignedByPtr is null && s_SignedByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement ServerOps.Signed method", new Exception("Signed"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ReadRecords");

                if (!(extensionMethod is null))
                    s_ReadRecordsByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadRecordsByPtr)) as ReadRecordsByPtr;

                extensionMethod = targetType.GetExtensionMethod("ReadRecords");

                if (!(extensionMethod is null))
                    s_ReadRecordsByVal = extensionMethod.CreateStaticDelegate(typeof(ReadRecordsByVal)) as ReadRecordsByVal;

                if (s_ReadRecordsByPtr is null && s_ReadRecordsByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement ServerOps.ReadRecords method", new Exception("ReadRecords"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Lookup");

                if (!(extensionMethod is null))
                    s_LookupByPtr = extensionMethod.CreateStaticDelegate(typeof(LookupByPtr)) as LookupByPtr;

                extensionMethod = targetType.GetExtensionMethod("Lookup");

                if (!(extensionMethod is null))
                    s_LookupByVal = extensionMethod.CreateStaticDelegate(typeof(LookupByVal)) as LookupByVal;

                if (s_LookupByPtr is null && s_LookupByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement ServerOps.Lookup method", new Exception("Lookup"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("ReadTileData");

                if (!(extensionMethod is null))
                    s_ReadTileDataByPtr = extensionMethod.CreateStaticDelegate(typeof(ReadTileDataByPtr)) as ReadTileDataByPtr;

                extensionMethod = targetType.GetExtensionMethod("ReadTileData");

                if (!(extensionMethod is null))
                    s_ReadTileDataByVal = extensionMethod.CreateStaticDelegate(typeof(ReadTileDataByVal)) as ReadTileDataByVal;

                if (s_ReadTileDataByPtr is null && s_ReadTileDataByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement ServerOps.ReadTileData method", new Exception("ReadTileData"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator ServerOps<T>(in ptr<T> target_ptr) => new ServerOps<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator ServerOps<T>(in T target) => new ServerOps<T>(target);

            // Enable comparisons between nil and ServerOps<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ServerOps<T> value, NilType nil) => Activator.CreateInstance<ServerOps<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ServerOps<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ServerOps<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ServerOps<T> value) => value != nil;
        }
    }
}}}}}}

namespace go
{
    public static class sumdb_ServerOpsExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.vendor.golang.org.x.mod.sumdb_package.ServerOps target)
        {
            try
            {
                return ((go.cmd.vendor.golang.org.x.mod.sumdb_package.ServerOps<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.vendor.golang.org.x.mod.sumdb_package.ServerOps target, out T result)
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
        public static object? _(this go.cmd.vendor.golang.org.x.mod.sumdb_package.ServerOps target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.vendor.golang.org.x.mod.sumdb_package.ServerOps<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.vendor.golang.org.x.mod.sumdb_package.ServerOps target, Type type, out object? result)
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