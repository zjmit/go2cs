//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:24:21 UTC
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
        private partial struct elfPhdr
        {
            // Constructors
            public elfPhdr(NilType _)
            {
                this.p_type = default;
                this.p_flags = default;
                this.p_offset = default;
                this.p_vaddr = default;
                this.p_paddr = default;
                this.p_filesz = default;
                this.p_memsz = default;
                this.p_align = default;
            }

            public elfPhdr(uint p_type = default, uint p_flags = default, ulong p_offset = default, ulong p_vaddr = default, ulong p_paddr = default, ulong p_filesz = default, ulong p_memsz = default, ulong p_align = default)
            {
                this.p_type = p_type;
                this.p_flags = p_flags;
                this.p_offset = p_offset;
                this.p_vaddr = p_vaddr;
                this.p_paddr = p_paddr;
                this.p_filesz = p_filesz;
                this.p_memsz = p_memsz;
                this.p_align = p_align;
            }

            // Enable comparisons between nil and elfPhdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(elfPhdr value, NilType nil) => value.Equals(default(elfPhdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(elfPhdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, elfPhdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, elfPhdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator elfPhdr(NilType nil) => default(elfPhdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static elfPhdr elfPhdr_cast(dynamic value)
        {
            return new elfPhdr(value.p_type, value.p_flags, value.p_offset, value.p_vaddr, value.p_paddr, value.p_filesz, value.p_memsz, value.p_align);
        }
    }
}