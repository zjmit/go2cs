//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:40:29 UTC
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
namespace oldlink {
namespace @internal
{
    public static partial class sym_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Library
        {
            // Constructors
            public Library(NilType _)
            {
                this.Objref = default;
                this.Srcref = default;
                this.File = default;
                this.Pkg = default;
                this.Shlib = default;
                this.Hash = default;
                this.ImportStrings = default;
                this.Imports = default;
                this.Textp = default;
                this.DupTextSyms = default;
                this.Main = default;
                this.Safe = default;
                this.Units = default;
            }

            public Library(@string Objref = default, @string Srcref = default, @string File = default, @string Pkg = default, @string Shlib = default, @string Hash = default, slice<@string> ImportStrings = default, slice<ptr<Library>> Imports = default, slice<ptr<Symbol>> Textp = default, slice<ptr<Symbol>> DupTextSyms = default, bool Main = default, bool Safe = default, slice<ptr<CompilationUnit>> Units = default)
            {
                this.Objref = Objref;
                this.Srcref = Srcref;
                this.File = File;
                this.Pkg = Pkg;
                this.Shlib = Shlib;
                this.Hash = Hash;
                this.ImportStrings = ImportStrings;
                this.Imports = Imports;
                this.Textp = Textp;
                this.DupTextSyms = DupTextSyms;
                this.Main = Main;
                this.Safe = Safe;
                this.Units = Units;
            }

            // Enable comparisons between nil and Library struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Library value, NilType nil) => value.Equals(default(Library));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Library value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Library value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Library value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Library(NilType nil) => default(Library);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Library Library_cast(dynamic value)
        {
            return new Library(value.Objref, value.Srcref, value.File, value.Pkg, value.Shlib, value.Hash, value.ImportStrings, value.Imports, value.Textp, value.DupTextSyms, value.Main, value.Safe, value.Units);
        }
    }
}}}}