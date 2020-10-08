//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:36:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using json = go.encoding.json_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using url = go.net.url_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using codehost = go.cmd.go.@internal.modfetch.codehost_package;
using web = go.cmd.go.@internal.web_package;
using module = go.golang.org.x.mod.module_package;
using semver = go.golang.org.x.mod.semver_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modfetch_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct proxyRepo
        {
            // Constructors
            public proxyRepo(NilType _)
            {
                this.url = default;
                this.path = default;
            }

            public proxyRepo(ref ptr<url.URL> url = default, @string path = default)
            {
                this.url = url;
                this.path = path;
            }

            // Enable comparisons between nil and proxyRepo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(proxyRepo value, NilType nil) => value.Equals(default(proxyRepo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(proxyRepo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, proxyRepo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, proxyRepo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator proxyRepo(NilType nil) => default(proxyRepo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static proxyRepo proxyRepo_cast(dynamic value)
        {
            return new proxyRepo(ref value.url, value.path);
        }
    }
}}}}