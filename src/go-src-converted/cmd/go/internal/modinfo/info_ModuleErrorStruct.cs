//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:34:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using time = go.time_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modinfo_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ModuleError
        {
            // Constructors
            public ModuleError(NilType _)
            {
                this.Err = default;
            }

            public ModuleError(@string Err = default)
            {
                this.Err = Err;
            }

            // Enable comparisons between nil and ModuleError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ModuleError value, NilType nil) => value.Equals(default(ModuleError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ModuleError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ModuleError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ModuleError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ModuleError(NilType nil) => default(ModuleError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ModuleError ModuleError_cast(dynamic value)
        {
            return new ModuleError(value.Err);
        }
    }
}}}}