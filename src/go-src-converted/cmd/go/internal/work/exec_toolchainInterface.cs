//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:01:28 UTC
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
using json = go.encoding.json_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using @base = go.cmd.go.@internal.@base_package;
using cache = go.cmd.go.@internal.cache_package;
using cfg = go.cmd.go.@internal.cfg_package;
using load = go.cmd.go.@internal.load_package;
using str = go.cmd.go.@internal.str_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class work_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial interface toolchain
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static toolchain As<T>(in T target) => (toolchain<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static toolchain As<T>(ptr<T> target_ptr) => (toolchain<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static toolchain? As(object target) =>
                typeof(toolchain<>).CreateInterfaceHandler<toolchain>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private class toolchain<T> : toolchain
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

            public toolchain(in T target) => m_target = target;

            public toolchain(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate @string gcByRef(ref T value, ref Builder b, ref Action a, @string archive, slice<byte> importcfg, bool asmhdr, slice<@string> gofiles);
            private delegate @string gcByVal(T value, ref Builder b, ref Action a, @string archive, slice<byte> importcfg, bool asmhdr, slice<@string> gofiles);

            private static readonly gcByRef s_gcByRef;
            private static readonly gcByVal s_gcByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string gc(ref Builder b, ref Action a, @string archive, slice<byte> importcfg, bool asmhdr, slice<@string> gofiles)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_gcByRef is null)
                    return s_gcByVal!(target, b, a, archive, importcfg, asmhdr, gofiles);

                return s_gcByRef(ref target, b, a, archive, importcfg, asmhdr, gofiles);
            }

            private delegate @string ccByRef(ref T value, ref Builder b, ref Action a, @string ofile, @string cfile);
            private delegate @string ccByVal(T value, ref Builder b, ref Action a, @string ofile, @string cfile);

            private static readonly ccByRef s_ccByRef;
            private static readonly ccByVal s_ccByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string cc(ref Builder b, ref Action a, @string ofile, @string cfile)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ccByRef is null)
                    return s_ccByVal!(target, b, a, ofile, cfile);

                return s_ccByRef(ref target, b, a, ofile, cfile);
            }

            private delegate @string asmByRef(ref T value, ref Builder b, ref Action a, slice<@string> sfiles);
            private delegate @string asmByVal(T value, ref Builder b, ref Action a, slice<@string> sfiles);

            private static readonly asmByRef s_asmByRef;
            private static readonly asmByVal s_asmByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string asm(ref Builder b, ref Action a, slice<@string> sfiles)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_asmByRef is null)
                    return s_asmByVal!(target, b, a, sfiles);

                return s_asmByRef(ref target, b, a, sfiles);
            }

            private delegate @string packByRef(ref T value, ref Builder b, ref Action a, @string afile, slice<@string> ofiles);
            private delegate @string packByVal(T value, ref Builder b, ref Action a, @string afile, slice<@string> ofiles);

            private static readonly packByRef s_packByRef;
            private static readonly packByVal s_packByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string pack(ref Builder b, ref Action a, @string afile, slice<@string> ofiles)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_packByRef is null)
                    return s_packByVal!(target, b, a, afile, ofiles);

                return s_packByRef(ref target, b, a, afile, ofiles);
            }

            private delegate @string ldByRef(ref T value, ref Builder b, ref Action root, @string @out, @string importcfg, @string mainpkg);
            private delegate @string ldByVal(T value, ref Builder b, ref Action root, @string @out, @string importcfg, @string mainpkg);

            private static readonly ldByRef s_ldByRef;
            private static readonly ldByVal s_ldByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string ld(ref Builder b, ref Action root, @string @out, @string importcfg, @string mainpkg)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ldByRef is null)
                    return s_ldByVal!(target, b, root, @out, importcfg, mainpkg);

                return s_ldByRef(ref target, b, root, @out, importcfg, mainpkg);
            }

            private delegate @string ldSharedByRef(ref T value, ref Builder b, ref Action root, slice<ref Action> toplevelactions, @string @out, @string importcfg, slice<ref Action> allactions);
            private delegate @string ldSharedByVal(T value, ref Builder b, ref Action root, slice<ref Action> toplevelactions, @string @out, @string importcfg, slice<ref Action> allactions);

            private static readonly ldSharedByRef s_ldSharedByRef;
            private static readonly ldSharedByVal s_ldSharedByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string ldShared(ref Builder b, ref Action root, slice<ref Action> toplevelactions, @string @out, @string importcfg, slice<ref Action> allactions)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ldSharedByRef is null)
                    return s_ldSharedByVal!(target, b, root, toplevelactions, @out, importcfg, allactions);

                return s_ldSharedByRef(ref target, b, root, toplevelactions, @out, importcfg, allactions);
            }

            private delegate @string compilerByRef(ref T value);
            private delegate @string compilerByVal(T value);

            private static readonly compilerByRef s_compilerByRef;
            private static readonly compilerByVal s_compilerByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string compiler()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_compilerByRef is null)
                    return s_compilerByVal!(target);

                return s_compilerByRef(ref target);
            }

            private delegate @string linkerByRef(ref T value);
            private delegate @string linkerByVal(T value);

            private static readonly linkerByRef s_linkerByRef;
            private static readonly linkerByVal s_linkerByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string linker()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_linkerByRef is null)
                    return s_linkerByVal!(target);

                return s_linkerByRef(ref target);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static toolchain()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("gc");

                if (!(extensionMethod is null))
                    s_gcByRef = extensionMethod.CreateStaticDelegate(typeof(gcByRef)) as gcByRef;

                if (s_gcByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("gc");

                    if (!(extensionMethod is null))
                        s_gcByVal = extensionMethod.CreateStaticDelegate(typeof(gcByVal)) as gcByVal;
                }

                if (s_gcByRef is null && s_gcByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement toolchain.gc method", new Exception("gc"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("cc");

                if (!(extensionMethod is null))
                    s_ccByRef = extensionMethod.CreateStaticDelegate(typeof(ccByRef)) as ccByRef;

                if (s_ccByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("cc");

                    if (!(extensionMethod is null))
                        s_ccByVal = extensionMethod.CreateStaticDelegate(typeof(ccByVal)) as ccByVal;
                }

                if (s_ccByRef is null && s_ccByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement toolchain.cc method", new Exception("cc"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("asm");

                if (!(extensionMethod is null))
                    s_asmByRef = extensionMethod.CreateStaticDelegate(typeof(asmByRef)) as asmByRef;

                if (s_asmByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("asm");

                    if (!(extensionMethod is null))
                        s_asmByVal = extensionMethod.CreateStaticDelegate(typeof(asmByVal)) as asmByVal;
                }

                if (s_asmByRef is null && s_asmByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement toolchain.asm method", new Exception("asm"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("pack");

                if (!(extensionMethod is null))
                    s_packByRef = extensionMethod.CreateStaticDelegate(typeof(packByRef)) as packByRef;

                if (s_packByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("pack");

                    if (!(extensionMethod is null))
                        s_packByVal = extensionMethod.CreateStaticDelegate(typeof(packByVal)) as packByVal;
                }

                if (s_packByRef is null && s_packByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement toolchain.pack method", new Exception("pack"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("ld");

                if (!(extensionMethod is null))
                    s_ldByRef = extensionMethod.CreateStaticDelegate(typeof(ldByRef)) as ldByRef;

                if (s_ldByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("ld");

                    if (!(extensionMethod is null))
                        s_ldByVal = extensionMethod.CreateStaticDelegate(typeof(ldByVal)) as ldByVal;
                }

                if (s_ldByRef is null && s_ldByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement toolchain.ld method", new Exception("ld"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("ldShared");

                if (!(extensionMethod is null))
                    s_ldSharedByRef = extensionMethod.CreateStaticDelegate(typeof(ldSharedByRef)) as ldSharedByRef;

                if (s_ldSharedByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("ldShared");

                    if (!(extensionMethod is null))
                        s_ldSharedByVal = extensionMethod.CreateStaticDelegate(typeof(ldSharedByVal)) as ldSharedByVal;
                }

                if (s_ldSharedByRef is null && s_ldSharedByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement toolchain.ldShared method", new Exception("ldShared"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("compiler");

                if (!(extensionMethod is null))
                    s_compilerByRef = extensionMethod.CreateStaticDelegate(typeof(compilerByRef)) as compilerByRef;

                if (s_compilerByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("compiler");

                    if (!(extensionMethod is null))
                        s_compilerByVal = extensionMethod.CreateStaticDelegate(typeof(compilerByVal)) as compilerByVal;
                }

                if (s_compilerByRef is null && s_compilerByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement toolchain.compiler method", new Exception("compiler"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("linker");

                if (!(extensionMethod is null))
                    s_linkerByRef = extensionMethod.CreateStaticDelegate(typeof(linkerByRef)) as linkerByRef;

                if (s_linkerByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("linker");

                    if (!(extensionMethod is null))
                        s_linkerByVal = extensionMethod.CreateStaticDelegate(typeof(linkerByVal)) as linkerByVal;
                }

                if (s_linkerByRef is null && s_linkerByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement toolchain.linker method", new Exception("linker"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator toolchain<T>(in ptr<T> target_ptr) => new toolchain<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator toolchain<T>(in T target) => new toolchain<T>(target);

            // Enable comparisons between nil and toolchain<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(toolchain<T> value, NilType nil) => Activator.CreateInstance<toolchain<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(toolchain<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, toolchain<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, toolchain<T> value) => value != nil;
        }
    }
}}}}

namespace go
{
    public static class work_toolchainExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.cmd.go.@internal.work_package.toolchain target)
        {
            try
            {
                return ((go.cmd.go.@internal.work_package.toolchain<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.cmd.go.@internal.work_package.toolchain target, out T result)
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
        public static object? _(this go.cmd.go.@internal.work_package.toolchain target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.cmd.go.@internal.work_package.toolchain<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.cmd.go.@internal.work_package.toolchain target, Type type, out object? result)
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