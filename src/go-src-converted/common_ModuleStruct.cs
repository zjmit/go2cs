//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event {
namespace export {
namespace ocagent
{
    public static partial class wire_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Module
        {
            // Constructors
            public Module(NilType _)
            {
                this.Module = default;
                this.BuildID = default;
            }

            public Module(ref ptr<TruncatableString> Module = default, ref ptr<TruncatableString> BuildID = default)
            {
                this.Module = Module;
                this.BuildID = BuildID;
            }

            // Enable comparisons between nil and Module struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Module value, NilType nil) => value.Equals(default(Module));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Module value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Module value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Module value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Module(NilType nil) => default(Module);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Module Module_cast(dynamic value)
        {
            return new Module(ref value.Module, ref value.BuildID);
        }
    }
}}}}}}}}