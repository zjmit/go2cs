//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TRUSTEE
        {
            // Constructors
            public TRUSTEE(NilType _)
            {
                this.MultipleTrustee = default;
                this.MultipleTrusteeOperation = default;
                this.TrusteeForm = default;
                this.TrusteeType = default;
                this.TrusteeValue = default;
            }

            public TRUSTEE(ref ptr<TRUSTEE> MultipleTrustee = default, MULTIPLE_TRUSTEE_OPERATION MultipleTrusteeOperation = default, TRUSTEE_FORM TrusteeForm = default, TRUSTEE_TYPE TrusteeType = default, TrusteeValue TrusteeValue = default)
            {
                this.MultipleTrustee = MultipleTrustee;
                this.MultipleTrusteeOperation = MultipleTrusteeOperation;
                this.TrusteeForm = TrusteeForm;
                this.TrusteeType = TrusteeType;
                this.TrusteeValue = TrusteeValue;
            }

            // Enable comparisons between nil and TRUSTEE struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TRUSTEE value, NilType nil) => value.Equals(default(TRUSTEE));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TRUSTEE value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TRUSTEE value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TRUSTEE value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TRUSTEE(NilType nil) => default(TRUSTEE);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TRUSTEE TRUSTEE_cast(dynamic value)
        {
            return new TRUSTEE(ref value.MultipleTrustee, value.MultipleTrusteeOperation, value.TrusteeForm, value.TrusteeType, value.TrusteeValue);
        }
    }
}}}}}}