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
        public partial struct TpacketReq3
        {
            // Constructors
            public TpacketReq3(NilType _)
            {
                this.Block_size = default;
                this.Block_nr = default;
                this.Frame_size = default;
                this.Frame_nr = default;
                this.Retire_blk_tov = default;
                this.Sizeof_priv = default;
                this.Feature_req_word = default;
            }

            public TpacketReq3(uint Block_size = default, uint Block_nr = default, uint Frame_size = default, uint Frame_nr = default, uint Retire_blk_tov = default, uint Sizeof_priv = default, uint Feature_req_word = default)
            {
                this.Block_size = Block_size;
                this.Block_nr = Block_nr;
                this.Frame_size = Frame_size;
                this.Frame_nr = Frame_nr;
                this.Retire_blk_tov = Retire_blk_tov;
                this.Sizeof_priv = Sizeof_priv;
                this.Feature_req_word = Feature_req_word;
            }

            // Enable comparisons between nil and TpacketReq3 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TpacketReq3 value, NilType nil) => value.Equals(default(TpacketReq3));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TpacketReq3 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TpacketReq3 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TpacketReq3 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TpacketReq3(NilType nil) => default(TpacketReq3);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TpacketReq3 TpacketReq3_cast(dynamic value)
        {
            return new TpacketReq3(value.Block_size, value.Block_nr, value.Frame_size, value.Frame_nr, value.Retire_blk_tov, value.Sizeof_priv, value.Feature_req_word);
        }
    }
}}}}}}