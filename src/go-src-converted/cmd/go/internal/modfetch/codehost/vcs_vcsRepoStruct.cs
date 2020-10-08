//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:35:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using lazyregexp = go.@internal.lazyregexp_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using lockedfile = go.cmd.go.@internal.lockedfile_package;
using par = go.cmd.go.@internal.par_package;
using str = go.cmd.go.@internal.str_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal {
namespace modfetch
{
    public static partial class codehost_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct vcsRepo
        {
            // Constructors
            public vcsRepo(NilType _)
            {
                this.mu = default;
                this.remote = default;
                this.cmd = default;
                this.dir = default;
                this.tagsOnce = default;
                this.tags = default;
                this.branchesOnce = default;
                this.branches = default;
                this.fetchOnce = default;
                this.fetchErr = default;
            }

            public vcsRepo(lockedfile.Mutex mu = default, @string remote = default, ref ptr<vcsCmd> cmd = default, @string dir = default, sync.Once tagsOnce = default, map<@string, bool> tags = default, sync.Once branchesOnce = default, map<@string, bool> branches = default, sync.Once fetchOnce = default, error fetchErr = default)
            {
                this.mu = mu;
                this.remote = remote;
                this.cmd = cmd;
                this.dir = dir;
                this.tagsOnce = tagsOnce;
                this.tags = tags;
                this.branchesOnce = branchesOnce;
                this.branches = branches;
                this.fetchOnce = fetchOnce;
                this.fetchErr = fetchErr;
            }

            // Enable comparisons between nil and vcsRepo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(vcsRepo value, NilType nil) => value.Equals(default(vcsRepo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(vcsRepo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, vcsRepo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, vcsRepo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator vcsRepo(NilType nil) => default(vcsRepo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static vcsRepo vcsRepo_cast(dynamic value)
        {
            return new vcsRepo(value.mu, value.remote, ref value.cmd, value.dir, value.tagsOnce, value.tags, value.branchesOnce, value.branches, value.fetchOnce, value.fetchErr);
        }
    }
}}}}}