//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:46:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using zip = go.archive.zip_package;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using module = go.golang.org.x.mod.module_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class zip_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pathInfo
        {
            // Constructors
            public pathInfo(NilType _)
            {
                this.path = default;
                this.isDir = default;
            }

            public pathInfo(@string path = default, bool isDir = default)
            {
                this.path = path;
                this.isDir = isDir;
            }

            // Enable comparisons between nil and pathInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pathInfo value, NilType nil) => value.Equals(default(pathInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pathInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pathInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pathInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pathInfo(NilType nil) => default(pathInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pathInfo pathInfo_cast(dynamic value)
        {
            return new pathInfo(value.path, value.isDir);
        }
    }
}}}}}}