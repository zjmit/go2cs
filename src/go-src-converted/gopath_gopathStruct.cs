//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using path = go.path_package;
using filepath = go.path.filepath_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace packages
{
    public static partial class packagestest_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gopath
        {
            // Constructors
            public gopath(NilType _)
            {
            }
            // Enable comparisons between nil and gopath struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gopath value, NilType nil) => value.Equals(default(gopath));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gopath value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gopath value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gopath value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gopath(NilType nil) => default(gopath);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gopath gopath_cast(dynamic value)
        {
            return new gopath();
        }
    }
}}}}}}