//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:43:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using filepath = go.path.filepath_package;
using sync = go.sync_package;
using template = go.text.template_package;
using parse = go.text.template.parse_package;
using go;

namespace go {
namespace html
{
    public static partial class template_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nameSpace
        {
            // Constructors
            public nameSpace(NilType _)
            {
                this.mu = default;
                this.set = default;
                this.escaped = default;
                this.esc = default;
            }

            public nameSpace(sync.Mutex mu = default, map<@string, ptr<Template>> set = default, bool escaped = default, escaper esc = default)
            {
                this.mu = mu;
                this.set = set;
                this.escaped = escaped;
                this.esc = esc;
            }

            // Enable comparisons between nil and nameSpace struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nameSpace value, NilType nil) => value.Equals(default(nameSpace));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nameSpace value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nameSpace value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nameSpace value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nameSpace(NilType nil) => default(nameSpace);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static nameSpace nameSpace_cast(dynamic value)
        {
            return new nameSpace(value.mu, value.set, value.escaped, value.esc);
        }
    }
}}