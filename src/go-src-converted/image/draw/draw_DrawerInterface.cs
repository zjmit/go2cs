//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:09:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using image = go.image_package;
using color = go.image.color_package;
using imageutil = go.image.@internal.imageutil_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace image
{
    public static partial class draw_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Drawer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Drawer As<T>(in T target) => (Drawer<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Drawer As<T>(ptr<T> target_ptr) => (Drawer<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Drawer? As(object target) =>
                typeof(Drawer<>).CreateInterfaceHandler<Drawer>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Drawer<T> : Drawer
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

            public Drawer(in T target) => m_target = target;

            public Drawer(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void DrawByRef(ref T value, Image dst, image.Rectangle r, image.Image src, image.Point sp);
            private delegate void DrawByVal(T value, Image dst, image.Rectangle r, image.Image src, image.Point sp);

            private static readonly DrawByRef s_DrawByRef;
            private static readonly DrawByVal s_DrawByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Draw(Image dst, image.Rectangle r, image.Image src, image.Point sp)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_DrawByRef is null)
                {
                    s_DrawByVal!(target, dst, r, src, sp);
                    return;
                }

                s_DrawByRef(ref target, dst, r, src, sp);
                return;
                
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Drawer()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("Draw");

                if (!(extensionMethod is null))
                    s_DrawByRef = extensionMethod.CreateStaticDelegate(typeof(DrawByRef)) as DrawByRef;

                if (s_DrawByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Draw");

                    if (!(extensionMethod is null))
                        s_DrawByVal = extensionMethod.CreateStaticDelegate(typeof(DrawByVal)) as DrawByVal;
                }

                if (s_DrawByRef is null && s_DrawByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Drawer.Draw method", new Exception("Draw"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Drawer<T>(in ptr<T> target_ptr) => new Drawer<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Drawer<T>(in T target) => new Drawer<T>(target);

            // Enable comparisons between nil and Drawer<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Drawer<T> value, NilType nil) => Activator.CreateInstance<Drawer<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Drawer<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Drawer<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Drawer<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class draw_DrawerExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.image.draw_package.Drawer target)
        {
            try
            {
                return ((go.image.draw_package.Drawer<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.image.draw_package.Drawer target, out T result)
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
        public static object? _(this go.image.draw_package.Drawer target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.image.draw_package.Drawer<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.image.draw_package.Drawer target, Type type, out object? result)
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