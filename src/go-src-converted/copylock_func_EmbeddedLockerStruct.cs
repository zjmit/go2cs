//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace passes {
namespace copylock {
namespace testdata {
namespace src
{
    public static partial class a_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct EmbeddedLocker
        {
            // Locker.Lock function promotion
            private delegate void LockByVal(T value);
            private delegate void LockByRef(ref T value);

            private static readonly LockByVal s_LockByVal;
            private static readonly LockByRef s_LockByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Lock() => s_LockByRef?.Invoke(ref this) ?? s_LockByVal?.Invoke(this) ?? Locker?.Lock() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);

            // Locker.Unlock function promotion
            private delegate void UnlockByVal(T value);
            private delegate void UnlockByRef(ref T value);

            private static readonly UnlockByVal s_UnlockByVal;
            private static readonly UnlockByRef s_UnlockByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Unlock() => s_UnlockByRef?.Invoke(ref this) ?? s_UnlockByVal?.Invoke(this) ?? Locker?.Unlock() ?? throw new PanicException(RuntimeErrorPanic.NilPointerDereference);
            
            [DebuggerStepperBoundary]
            static EmbeddedLocker()
            {
                Type targetType = typeof(EmbeddedLocker);
                MethodInfo extensionMethod;
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Lock");

                if ((object)extensionMethod != null)
                {
                    s_LockByRef = extensionMethod.CreateStaticDelegate(typeof(LockByRef)) as LockByRef;

                    if ((object)s_LockByRef == null)
                        s_LockByVal = extensionMethod.CreateStaticDelegate(typeof(LockByVal)) as LockByVal;
                }
                
                extensionMethod = targetType.GetExtensionMethodSearchingPromotions("Unlock");

                if ((object)extensionMethod != null)
                {
                    s_UnlockByRef = extensionMethod.CreateStaticDelegate(typeof(UnlockByRef)) as UnlockByRef;

                    if ((object)s_UnlockByRef == null)
                        s_UnlockByVal = extensionMethod.CreateStaticDelegate(typeof(UnlockByVal)) as UnlockByVal;
                }
            }

            // Constructors
            public EmbeddedLocker(NilType _)
            {
                this.Locker = default;
            }

            public EmbeddedLocker(sync.Locker Locker = default)
            {
                this.Locker = Locker;
            }

            // Enable comparisons between nil and EmbeddedLocker struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(EmbeddedLocker value, NilType nil) => value.Equals(default(EmbeddedLocker));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(EmbeddedLocker value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, EmbeddedLocker value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, EmbeddedLocker value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator EmbeddedLocker(NilType nil) => default(EmbeddedLocker);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static EmbeddedLocker EmbeddedLocker_cast(dynamic value)
        {
            return new EmbeddedLocker(value.Locker);
        }
    }
}}}}}}}}}}