//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:58:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using driver = go.database.sql.driver_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

namespace go {
namespace database
{
    public static partial class sql_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct connStmt
        {
            // Constructors
            public connStmt(NilType _)
            {
                this.dc = default;
                this.ds = default;
            }

            public connStmt(ref ptr<driverConn> dc = default, ref ptr<driverStmt> ds = default)
            {
                this.dc = dc;
                this.ds = ds;
            }

            // Enable comparisons between nil and connStmt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(connStmt value, NilType nil) => value.Equals(default(connStmt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(connStmt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, connStmt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, connStmt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator connStmt(NilType nil) => default(connStmt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static connStmt connStmt_cast(dynamic value)
        {
            return new connStmt(ref value.dc, ref value.ds);
        }
    }
}}