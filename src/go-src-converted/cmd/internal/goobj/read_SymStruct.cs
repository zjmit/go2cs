//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:50:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using goobj2 = go.cmd.@internal.goobj2_package;
using objabi = go.cmd.@internal.objabi_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class goobj_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(SymID))]
        public partial struct Sym
        {
            // SymID structure promotion - sourced from value copy
            private readonly ptr<SymID> m_SymIDRef;

            private ref SymID SymID_val => ref m_SymIDRef.Value;

            public ref @string Name => ref m_SymIDRef.Value.Name;

            public ref long Version => ref m_SymIDRef.Value.Version;

            // Constructors
            public Sym(NilType _)
            {
                this.m_SymIDRef = new ptr<SymID>(new SymID(nil));
                this.Kind = default;
                this.DupOK = default;
                this.Size = default;
                this.m_TypeRef = new ptr<SymID>(new SymID(nil));
                this.Data = default;
                this.Reloc = default;
                this.Func = default;
            }

            public Sym(SymID SymID = default, objabi.SymKind Kind = default, bool DupOK = default, long Size = default, SymID Type = default, Data Data = default, slice<Reloc> Reloc = default, ref ptr<Func> Func = default)
            {
                this.m_SymIDRef = new ptr<SymID>(SymID);
                this.Kind = Kind;
                this.DupOK = DupOK;
                this.Size = Size;
                this.m_TypeRef = new ptr<SymID>(Type);
                this.Data = Data;
                this.Reloc = Reloc;
                this.Func = Func;
            }

            // Enable comparisons between nil and Sym struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Sym value, NilType nil) => value.Equals(default(Sym));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Sym value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Sym value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Sym value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Sym(NilType nil) => default(Sym);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Sym Sym_cast(dynamic value)
        {
            return new Sym(value.SymID, value.Kind, value.DupOK, value.Size, value.Type, value.Data, value.Reloc, ref value.Func);
        }
    }
}}}