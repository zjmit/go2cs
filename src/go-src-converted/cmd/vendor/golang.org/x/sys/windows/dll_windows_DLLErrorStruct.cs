//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
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
        public partial struct DLLError
        {
            // Constructors
            public DLLError(NilType _)
            {
                this.Err = default;
                this.ObjName = default;
                this.Msg = default;
            }

            public DLLError(error Err = default, @string ObjName = default, @string Msg = default)
            {
                this.Err = Err;
                this.ObjName = ObjName;
                this.Msg = Msg;
            }

            // Enable comparisons between nil and DLLError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(DLLError value, NilType nil) => value.Equals(default(DLLError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(DLLError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, DLLError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, DLLError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator DLLError(NilType nil) => default(DLLError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static DLLError DLLError_cast(dynamic value)
        {
            return new DLLError(value.Err, value.ObjName, value.Msg);
        }
    }
}}}}}}