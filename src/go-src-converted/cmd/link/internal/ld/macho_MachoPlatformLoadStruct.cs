//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:39:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using macho = go.debug.macho_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MachoPlatformLoad
        {
            // Constructors
            public MachoPlatformLoad(NilType _)
            {
                this.platform = default;
                this.cmd = default;
            }

            public MachoPlatformLoad(MachoPlatform platform = default, MachoLoad cmd = default)
            {
                this.platform = platform;
                this.cmd = cmd;
            }

            // Enable comparisons between nil and MachoPlatformLoad struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MachoPlatformLoad value, NilType nil) => value.Equals(default(MachoPlatformLoad));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MachoPlatformLoad value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MachoPlatformLoad value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MachoPlatformLoad value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MachoPlatformLoad(NilType nil) => default(MachoPlatformLoad);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static MachoPlatformLoad MachoPlatformLoad_cast(dynamic value)
        {
            return new MachoPlatformLoad(value.platform, value.cmd);
        }
    }
}}}}