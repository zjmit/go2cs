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
        [PromotedStruct(typeof(decl))]
        public partial struct TypeDecl
        {
            // decl structure promotion - sourced from value copy
            private readonly ptr<decl> m_declRef;

            private ref decl decl_val => ref m_declRef.Value;

            // Constructors
            public TypeDecl(NilType _)
            {
                this.Group = default;
                this.Pragma = default;
                this.Name = default;
                this.Alias = default;
                this.Type = default;
                this.m_declRef = new ptr<decl>(new decl(nil));
            }

            public TypeDecl(ref ptr<Group> Group = default, Pragma Pragma = default, ref ptr<Name> Name = default, bool Alias = default, Expr Type = default, decl decl = default)
            {
                this.Group = Group;
                this.Pragma = Pragma;
                this.Name = Name;
                this.Alias = Alias;
                this.Type = Type;
                this.m_declRef = new ptr<decl>(decl);
            }

            // Enable comparisons between nil and TypeDecl struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TypeDecl value, NilType nil) => value.Equals(default(TypeDecl));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TypeDecl value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TypeDecl value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TypeDecl value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TypeDecl(NilType nil) => default(TypeDecl);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TypeDecl TypeDecl_cast(dynamic value)
        {
            return new TypeDecl(ref value.Group, value.Pragma, ref value.Name, value.Alias, value.Type, value.decl);
        }
    }
}}}}