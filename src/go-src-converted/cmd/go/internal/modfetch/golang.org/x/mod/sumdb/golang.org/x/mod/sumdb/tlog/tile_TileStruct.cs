//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:36:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace mod {
namespace sumdb
{
    public static partial class tlog_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Tile
        {
            // Constructors
            public Tile(NilType _)
            {
                this.H = default;
                this.L = default;
                this.N = default;
                this.W = default;
            }

            public Tile(long H = default, long L = default, long N = default, long W = default)
            {
                this.H = H;
                this.L = L;
                this.N = N;
                this.W = W;
            }

            // Enable comparisons between nil and Tile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Tile value, NilType nil) => value.Equals(default(Tile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Tile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Tile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Tile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tile(NilType nil) => default(Tile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Tile Tile_cast(dynamic value)
        {
            return new Tile(value.H, value.L, value.N, value.W);
        }
    }
}}}}}