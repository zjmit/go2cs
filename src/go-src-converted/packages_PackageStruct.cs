//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using parser = go.go.parser_package;
using scanner = go.go.scanner_package;
using token = go.go.token_package;
using types = go.go.types_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using gcexportdata = go.golang.org.x.tools.go.gcexportdata_package;
using gocommand = go.golang.org.x.tools.@internal.gocommand_package;
using packagesinternal = go.golang.org.x.tools.@internal.packagesinternal_package;
using typesinternal = go.golang.org.x.tools.@internal.typesinternal_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class packages_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Package
        {
            // Constructors
            public Package(NilType _)
            {
                this.ID = default;
                this.Name = default;
                this.PkgPath = default;
                this.Errors = default;
                this.GoFiles = default;
                this.CompiledGoFiles = default;
                this.OtherFiles = default;
                this.ExportFile = default;
                this.Imports = default;
                this.Types = default;
                this.Fset = default;
                this.IllTyped = default;
                this.Syntax = default;
                this.TypesInfo = default;
                this.TypesSizes = default;
                this.forTest = default;
                this.Module = default;
            }

            public Package(@string ID = default, @string Name = default, @string PkgPath = default, slice<Error> Errors = default, slice<@string> GoFiles = default, slice<@string> CompiledGoFiles = default, slice<@string> OtherFiles = default, @string ExportFile = default, map<@string, ptr<Package>> Imports = default, ref ptr<types.Package> Types = default, ref ptr<token.FileSet> Fset = default, bool IllTyped = default, slice<ptr<ast.File>> Syntax = default, ref ptr<types.Info> TypesInfo = default, types.Sizes TypesSizes = default, @string forTest = default, ref ptr<Module> Module = default)
            {
                this.ID = ID;
                this.Name = Name;
                this.PkgPath = PkgPath;
                this.Errors = Errors;
                this.GoFiles = GoFiles;
                this.CompiledGoFiles = CompiledGoFiles;
                this.OtherFiles = OtherFiles;
                this.ExportFile = ExportFile;
                this.Imports = Imports;
                this.Types = Types;
                this.Fset = Fset;
                this.IllTyped = IllTyped;
                this.Syntax = Syntax;
                this.TypesInfo = TypesInfo;
                this.TypesSizes = TypesSizes;
                this.forTest = forTest;
                this.Module = Module;
            }

            // Enable comparisons between nil and Package struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Package value, NilType nil) => value.Equals(default(Package));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Package value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Package value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Package value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Package(NilType nil) => default(Package);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Package Package_cast(dynamic value)
        {
            return new Package(value.ID, value.Name, value.PkgPath, value.Errors, value.GoFiles, value.CompiledGoFiles, value.OtherFiles, value.ExportFile, value.Imports, ref value.Types, ref value.Fset, value.IllTyped, value.Syntax, ref value.TypesInfo, value.TypesSizes, value.forTest, ref value.Module);
        }
    }
}}}}}