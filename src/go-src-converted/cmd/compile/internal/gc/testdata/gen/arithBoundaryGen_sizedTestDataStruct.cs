//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:31:59 UTC
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
using format = go.go.format_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using template = go.text.template_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sizedTestData
        {
            // Constructors
            public sizedTestData(NilType _)
            {
                this.name = default;
                this.sn = default;
                this.u = default;
                this.i = default;
            }

            public sizedTestData(@string name = default, @string sn = default, slice<ulong> u = default, slice<long> i = default)
            {
                this.name = name;
                this.sn = sn;
                this.u = u;
                this.i = i;
            }

            // Enable comparisons between nil and sizedTestData struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sizedTestData value, NilType nil) => value.Equals(default(sizedTestData));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sizedTestData value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sizedTestData value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sizedTestData value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sizedTestData(NilType nil) => default(sizedTestData);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sizedTestData sizedTestData_cast(dynamic value)
        {
            return new sizedTestData(value.name, value.sn, value.u, value.i);
        }
    }
}