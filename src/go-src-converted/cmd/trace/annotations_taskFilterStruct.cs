//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using template = go.html.template_package;
using trace = go.@internal.trace_package;
using log = go.log_package;
using math = go.math_package;
using http = go.net.http_package;
using url = go.net.url_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct taskFilter
        {
            // Constructors
            public taskFilter(NilType _)
            {
                this.name = default;
                this.cond = default;
            }

            public taskFilter(@string name = default, slice<Func<ptr<taskDesc>, bool>> cond = default)
            {
                this.name = name;
                this.cond = cond;
            }

            // Enable comparisons between nil and taskFilter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(taskFilter value, NilType nil) => value.Equals(default(taskFilter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(taskFilter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, taskFilter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, taskFilter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator taskFilter(NilType nil) => default(taskFilter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static taskFilter taskFilter_cast(dynamic value)
        {
            return new taskFilter(value.name, value.cond);
        }
    }
}