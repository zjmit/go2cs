//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using gob = go.encoding.gob_package;
using fmt = go.fmt_package;
using types = go.go.types_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using sync = go.sync_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using objectpath = go.golang.org.x.tools.go.types.objectpath_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace @internal
{
    public static partial class facts_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gobFact
        {
            // Constructors
            public gobFact(NilType _)
            {
                this.PkgPath = default;
                this.Object = default;
                this.Fact = default;
            }

            public gobFact(@string PkgPath = default, objectpath.Path Object = default, analysis.Fact Fact = default)
            {
                this.PkgPath = PkgPath;
                this.Object = Object;
                this.Fact = Fact;
            }

            // Enable comparisons between nil and gobFact struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gobFact value, NilType nil) => value.Equals(default(gobFact));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gobFact value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gobFact value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gobFact value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gobFact(NilType nil) => default(gobFact);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gobFact gobFact_cast(dynamic value)
        {
            return new gobFact(value.PkgPath, value.Object, value.Fact);
        }
    }
}}}}}}}