//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:35:13 UTC
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
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace net
{
    public static partial class url_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct URL
        {
            // Constructors
            public URL(NilType _)
            {
                this.Scheme = default;
                this.Opaque = default;
                this.User = default;
                this.Host = default;
                this.Path = default;
                this.RawPath = default;
                this.ForceQuery = default;
                this.RawQuery = default;
                this.Fragment = default;
                this.RawFragment = default;
            }

            public URL(@string Scheme = default, @string Opaque = default, ref ptr<Userinfo> User = default, @string Host = default, @string Path = default, @string RawPath = default, bool ForceQuery = default, @string RawQuery = default, @string Fragment = default, @string RawFragment = default)
            {
                this.Scheme = Scheme;
                this.Opaque = Opaque;
                this.User = User;
                this.Host = Host;
                this.Path = Path;
                this.RawPath = RawPath;
                this.ForceQuery = ForceQuery;
                this.RawQuery = RawQuery;
                this.Fragment = Fragment;
                this.RawFragment = RawFragment;
            }

            // Enable comparisons between nil and URL struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(URL value, NilType nil) => value.Equals(default(URL));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(URL value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, URL value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, URL value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator URL(NilType nil) => default(URL);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static URL URL_cast(dynamic value)
        {
            return new URL(value.Scheme, value.Opaque, ref value.User, value.Host, value.Path, value.RawPath, value.ForceQuery, value.RawQuery, value.Fragment, value.RawFragment);
        }
    }
}}