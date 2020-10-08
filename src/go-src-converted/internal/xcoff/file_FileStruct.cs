//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:02:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using dwarf = go.debug.dwarf_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using strings = go.strings_package;
using go;

namespace go {
namespace @internal
{
    public static partial class xcoff_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(FileHeader))]
        public partial struct File
        {
            // FileHeader structure promotion - sourced from value copy
            private readonly ptr<FileHeader> m_FileHeaderRef;

            private ref FileHeader FileHeader_val => ref m_FileHeaderRef.Value;

            public ref ushort TargetMachine => ref m_FileHeaderRef.Value.TargetMachine;

            // Constructors
            public File(NilType _)
            {
                this.m_FileHeaderRef = new ptr<FileHeader>(new FileHeader(nil));
                this.Sections = default;
                this.Symbols = default;
                this.StringTable = default;
                this.LibraryPaths = default;
                this.closer = default;
            }

            public File(FileHeader FileHeader = default, slice<ptr<Section>> Sections = default, slice<ptr<Symbol>> Symbols = default, slice<byte> StringTable = default, slice<@string> LibraryPaths = default, io.Closer closer = default)
            {
                this.m_FileHeaderRef = new ptr<FileHeader>(FileHeader);
                this.Sections = Sections;
                this.Symbols = Symbols;
                this.StringTable = StringTable;
                this.LibraryPaths = LibraryPaths;
                this.closer = closer;
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
            return new File(value.FileHeader, value.Sections, value.Symbols, value.StringTable, value.LibraryPaths, value.closer);
        }
    }
}}