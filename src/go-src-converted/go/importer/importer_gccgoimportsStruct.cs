//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:56:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using build = go.go.build_package;
using gccgoimporter = go.go.@internal.gccgoimporter_package;
using gcimporter = go.go.@internal.gcimporter_package;
using srcimporter = go.go.@internal.srcimporter_package;
using token = go.go.token_package;
using types = go.go.types_package;
using io = go.io_package;
using runtime = go.runtime_package;
using go;

namespace go {
namespace go
{
    public static partial class importer_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gccgoimports
        {
            // Constructors
            public gccgoimports(NilType _)
            {
                this.packages = default;
                this.importer = default;
                this.lookup = default;
            }

            public gccgoimports(map<@string, ptr<types.Package>> packages = default, gccgoimporter.Importer importer = default, Lookup lookup = default)
            {
                this.packages = packages;
                this.importer = importer;
                this.lookup = lookup;
            }

            // Enable comparisons between nil and gccgoimports struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gccgoimports value, NilType nil) => value.Equals(default(gccgoimports));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gccgoimports value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gccgoimports value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gccgoimports value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gccgoimports(NilType nil) => default(gccgoimports);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gccgoimports gccgoimports_cast(dynamic value)
        {
            return new gccgoimports(value.packages, value.importer, value.lookup);
        }
    }
}}