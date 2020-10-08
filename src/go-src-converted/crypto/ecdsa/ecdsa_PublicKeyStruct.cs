//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:35:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using crypto = go.crypto_package;
using aes = go.crypto.aes_package;
using cipher = go.crypto.cipher_package;
using elliptic = go.crypto.elliptic_package;
using randutil = go.crypto.@internal.randutil_package;
using sha512 = go.crypto.sha512_package;
using errors = go.errors_package;
using io = go.io_package;
using big = go.math.big_package;
using cryptobyte = go.golang.org.x.crypto.cryptobyte_package;
using asn1 = go.golang.org.x.crypto.cryptobyte.asn1_package;
using go;

namespace go {
namespace crypto
{
    public static partial class ecdsa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PublicKey
        {
            // Curve.Params function promotion
            private delegate (ptr<big.Int>, ptr<big.Int>) ParamsByVal(T value);
            private delegate (ptr<big.Int>, ptr<big.Int>) ParamsByRef(ref T value);

            private static readonly ParamsByVal s_ParamsByVal;
            private static readonly ParamsByRef s_ParamsByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (ptr<big.Int>, ptr<big.Int>) Params() => s_ParamsByRef?.Invoke(ref this) ?? s_ParamsByVal?.Invoke(this) ?? Curve?.Params() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Curve.IsOnCurve function promotion
            private delegate (ptr<big.Int>, ptr<big.Int>) IsOnCurveByVal(T value, ptr<big.Int> x, ptr<big.Int> y);
            private delegate (ptr<big.Int>, ptr<big.Int>) IsOnCurveByRef(ref T value, ptr<big.Int> x, ptr<big.Int> y);

            private static readonly IsOnCurveByVal s_IsOnCurveByVal;
            private static readonly IsOnCurveByRef s_IsOnCurveByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (ptr<big.Int>, ptr<big.Int>) IsOnCurve(ptr<big.Int> x, ptr<big.Int> y) => s_IsOnCurveByRef?.Invoke(ref this, x, y) ?? s_IsOnCurveByVal?.Invoke(this, x, y) ?? Curve?.IsOnCurve(x, y) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Curve.Add function promotion
            private delegate (ptr<big.Int>, ptr<big.Int>) AddByVal(T value, ptr<big.Int> x1, ptr<big.Int> y1, ptr<big.Int> x2, ptr<big.Int> y2);
            private delegate (ptr<big.Int>, ptr<big.Int>) AddByRef(ref T value, ptr<big.Int> x1, ptr<big.Int> y1, ptr<big.Int> x2, ptr<big.Int> y2);

            private static readonly AddByVal s_AddByVal;
            private static readonly AddByRef s_AddByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (ptr<big.Int>, ptr<big.Int>) Add(ptr<big.Int> x1, ptr<big.Int> y1, ptr<big.Int> x2, ptr<big.Int> y2) => s_AddByRef?.Invoke(ref this, x1, y1, x2, y2) ?? s_AddByVal?.Invoke(this, x1, y1, x2, y2) ?? Curve?.Add(x1, y1, x2, y2) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Curve.Double function promotion
            private delegate (ptr<big.Int>, ptr<big.Int>) DoubleByVal(T value, ptr<big.Int> x1, ptr<big.Int> y1);
            private delegate (ptr<big.Int>, ptr<big.Int>) DoubleByRef(ref T value, ptr<big.Int> x1, ptr<big.Int> y1);

            private static readonly DoubleByVal s_DoubleByVal;
            private static readonly DoubleByRef s_DoubleByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (ptr<big.Int>, ptr<big.Int>) Double(ptr<big.Int> x1, ptr<big.Int> y1) => s_DoubleByRef?.Invoke(ref this, x1, y1) ?? s_DoubleByVal?.Invoke(this, x1, y1) ?? Curve?.Double(x1, y1) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Curve.ScalarMult function promotion
            private delegate (ptr<big.Int>, ptr<big.Int>) ScalarMultByVal(T value, ptr<big.Int> x1, ptr<big.Int> y1, slice<byte> k);
            private delegate (ptr<big.Int>, ptr<big.Int>) ScalarMultByRef(ref T value, ptr<big.Int> x1, ptr<big.Int> y1, slice<byte> k);

            private static readonly ScalarMultByVal s_ScalarMultByVal;
            private static readonly ScalarMultByRef s_ScalarMultByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (ptr<big.Int>, ptr<big.Int>) ScalarMult(ptr<big.Int> x1, ptr<big.Int> y1, slice<byte> k) => s_ScalarMultByRef?.Invoke(ref this, x1, y1, k) ?? s_ScalarMultByVal?.Invoke(this, x1, y1, k) ?? Curve?.ScalarMult(x1, y1, k) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Curve.ScalarBaseMult function promotion
            private delegate (ptr<big.Int>, ptr<big.Int>) ScalarBaseMultByVal(T value, slice<byte> k);
            private delegate (ptr<big.Int>, ptr<big.Int>) ScalarBaseMultByRef(ref T value, slice<byte> k);

            private static readonly ScalarBaseMultByVal s_ScalarBaseMultByVal;
            private static readonly ScalarBaseMultByRef s_ScalarBaseMultByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (ptr<big.Int>, ptr<big.Int>) ScalarBaseMult(slice<byte> k) => s_ScalarBaseMultByRef?.Invoke(ref this, k) ?? s_ScalarBaseMultByVal?.Invoke(this, k) ?? Curve?.ScalarBaseMult(k) ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static PublicKey()
            {
                Type targetType = typeof(PublicKey);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Params");

                if ((object)extensionMethod != null)
                {
                    s_ParamsByRef = extensionMethod.CreateStaticDelegate(typeof(ParamsByRef)) as ParamsByRef;

                    if ((object)s_ParamsByRef == null)
                        s_ParamsByVal = extensionMethod.CreateStaticDelegate(typeof(ParamsByVal)) as ParamsByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("IsOnCurve");

                if ((object)extensionMethod != null)
                {
                    s_IsOnCurveByRef = extensionMethod.CreateStaticDelegate(typeof(IsOnCurveByRef)) as IsOnCurveByRef;

                    if ((object)s_IsOnCurveByRef == null)
                        s_IsOnCurveByVal = extensionMethod.CreateStaticDelegate(typeof(IsOnCurveByVal)) as IsOnCurveByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Add");

                if ((object)extensionMethod != null)
                {
                    s_AddByRef = extensionMethod.CreateStaticDelegate(typeof(AddByRef)) as AddByRef;

                    if ((object)s_AddByRef == null)
                        s_AddByVal = extensionMethod.CreateStaticDelegate(typeof(AddByVal)) as AddByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Double");

                if ((object)extensionMethod != null)
                {
                    s_DoubleByRef = extensionMethod.CreateStaticDelegate(typeof(DoubleByRef)) as DoubleByRef;

                    if ((object)s_DoubleByRef == null)
                        s_DoubleByVal = extensionMethod.CreateStaticDelegate(typeof(DoubleByVal)) as DoubleByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("ScalarMult");

                if ((object)extensionMethod != null)
                {
                    s_ScalarMultByRef = extensionMethod.CreateStaticDelegate(typeof(ScalarMultByRef)) as ScalarMultByRef;

                    if ((object)s_ScalarMultByRef == null)
                        s_ScalarMultByVal = extensionMethod.CreateStaticDelegate(typeof(ScalarMultByVal)) as ScalarMultByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("ScalarBaseMult");

                if ((object)extensionMethod != null)
                {
                    s_ScalarBaseMultByRef = extensionMethod.CreateStaticDelegate(typeof(ScalarBaseMultByRef)) as ScalarBaseMultByRef;

                    if ((object)s_ScalarBaseMultByRef == null)
                        s_ScalarBaseMultByVal = extensionMethod.CreateStaticDelegate(typeof(ScalarBaseMultByVal)) as ScalarBaseMultByVal;
                }
            }

            // Constructors
            public PublicKey(NilType _)
            {
                this.Curve = default;
                this.X = default;
                this.Y = default;
            }

            public PublicKey(elliptic.Curve Curve = default, ref ptr<big.Int> X = default, ref ptr<big.Int> Y = default)
            {
                this.Curve = Curve;
                this.X = X;
                this.Y = Y;
            }

            // Enable comparisons between nil and PublicKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PublicKey value, NilType nil) => value.Equals(default(PublicKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PublicKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PublicKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PublicKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PublicKey(NilType nil) => default(PublicKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PublicKey PublicKey_cast(dynamic value)
        {
            return new PublicKey(value.Curve, ref value.X, ref value.Y);
        }
    }
}}