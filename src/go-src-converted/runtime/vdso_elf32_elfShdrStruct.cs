//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:24:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct elfShdr
        {
            // Constructors
            public elfShdr(NilType _)
            {
                this.sh_name = default;
                this.sh_type = default;
                this.sh_flags = default;
                this.sh_addr = default;
                this.sh_offset = default;
                this.sh_size = default;
                this.sh_link = default;
                this.sh_info = default;
                this.sh_addralign = default;
                this.sh_entsize = default;
            }

            public elfShdr(uint sh_name = default, uint sh_type = default, uint sh_flags = default, uint sh_addr = default, uint sh_offset = default, uint sh_size = default, uint sh_link = default, uint sh_info = default, uint sh_addralign = default, uint sh_entsize = default)
            {
                this.sh_name = sh_name;
                this.sh_type = sh_type;
                this.sh_flags = sh_flags;
                this.sh_addr = sh_addr;
                this.sh_offset = sh_offset;
                this.sh_size = sh_size;
                this.sh_link = sh_link;
                this.sh_info = sh_info;
                this.sh_addralign = sh_addralign;
                this.sh_entsize = sh_entsize;
            }

            // Enable comparisons between nil and elfShdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(elfShdr value, NilType nil) => value.Equals(default(elfShdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(elfShdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, elfShdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, elfShdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator elfShdr(NilType nil) => default(elfShdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static elfShdr elfShdr_cast(dynamic value)
        {
            return new elfShdr(value.sh_name, value.sh_type, value.sh_flags, value.sh_addr, value.sh_offset, value.sh_size, value.sh_link, value.sh_info, value.sh_addralign, value.sh_entsize);
        }
    }
}