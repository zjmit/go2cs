//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FsverityDigest
        {
            // Constructors
            public FsverityDigest(NilType _)
            {
                this.Algorithm = default;
                this.Size = default;
            }

            public FsverityDigest(ushort Algorithm = default, ushort Size = default)
            {
                this.Algorithm = Algorithm;
                this.Size = Size;
            }

            // Enable comparisons between nil and FsverityDigest struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FsverityDigest value, NilType nil) => value.Equals(default(FsverityDigest));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FsverityDigest value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FsverityDigest value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FsverityDigest value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FsverityDigest(NilType nil) => default(FsverityDigest);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FsverityDigest FsverityDigest_cast(dynamic value)
        {
            return new FsverityDigest(value.Algorithm, value.Size);
        }
    }
}}}}}}