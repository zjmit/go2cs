//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:28:07 UTC
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
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(node))]
        public partial struct File
        {
            // node structure promotion - sourced from value copy
            private readonly ptr<node> m_nodeRef;

            private ref node node_val => ref m_nodeRef.Value;

            public ref Pos pos => ref m_nodeRef.Value.pos;

            // Constructors
            public File(NilType _)
            {
                this.Pragma = default;
                this.PkgName = default;
                this.DeclList = default;
                this.Lines = default;
                this.m_nodeRef = new ptr<node>(new node(nil));
            }

            public File(Pragma Pragma = default, ref ptr<Name> PkgName = default, slice<Decl> DeclList = default, ulong Lines = default, node node = default)
            {
                this.Pragma = Pragma;
                this.PkgName = PkgName;
                this.DeclList = DeclList;
                this.Lines = Lines;
                this.m_nodeRef = new ptr<node>(node);
            }

            // Enable comparisons between nil and File struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(File value, NilType nil) => value.Equals(default(File));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(File value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, File value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, File value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator File(NilType nil) => default(File);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static File File_cast(dynamic value)
        {
            return new File(value.Pragma, ref value.PkgName, value.DeclList, value.Lines, value.node);
        }
    }
}}}}