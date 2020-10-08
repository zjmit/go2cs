//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:49:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using os = go.os_package;
using path = go.path_package;
using time = go.time_package;
using go;

namespace go {
namespace archive
{
    public static partial class zip_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FileHeader
        {
            // Constructors
            public FileHeader(NilType _)
            {
                this.Name = default;
                this.Comment = default;
                this.NonUTF8 = default;
                this.CreatorVersion = default;
                this.ReaderVersion = default;
                this.Flags = default;
                this.Method = default;
                this.Modified = default;
                this.ModifiedTime = default;
                this.ModifiedDate = default;
                this.CRC32 = default;
                this.CompressedSize = default;
                this.UncompressedSize = default;
                this.CompressedSize64 = default;
                this.UncompressedSize64 = default;
                this.Extra = default;
                this.ExternalAttrs = default;
            }

            public FileHeader(@string Name = default, @string Comment = default, bool NonUTF8 = default, ushort CreatorVersion = default, ushort ReaderVersion = default, ushort Flags = default, ushort Method = default, time.Time Modified = default, ushort ModifiedTime = default, ushort ModifiedDate = default, uint CRC32 = default, uint CompressedSize = default, uint UncompressedSize = default, ulong CompressedSize64 = default, ulong UncompressedSize64 = default, slice<byte> Extra = default, uint ExternalAttrs = default)
            {
                this.Name = Name;
                this.Comment = Comment;
                this.NonUTF8 = NonUTF8;
                this.CreatorVersion = CreatorVersion;
                this.ReaderVersion = ReaderVersion;
                this.Flags = Flags;
                this.Method = Method;
                this.Modified = Modified;
                this.ModifiedTime = ModifiedTime;
                this.ModifiedDate = ModifiedDate;
                this.CRC32 = CRC32;
                this.CompressedSize = CompressedSize;
                this.UncompressedSize = UncompressedSize;
                this.CompressedSize64 = CompressedSize64;
                this.UncompressedSize64 = UncompressedSize64;
                this.Extra = Extra;
                this.ExternalAttrs = ExternalAttrs;
            }

            // Enable comparisons between nil and FileHeader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FileHeader value, NilType nil) => value.Equals(default(FileHeader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FileHeader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FileHeader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FileHeader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FileHeader(NilType nil) => default(FileHeader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FileHeader FileHeader_cast(dynamic value)
        {
            return new FileHeader(value.Name, value.Comment, value.NonUTF8, value.CreatorVersion, value.ReaderVersion, value.Flags, value.Method, value.Modified, value.ModifiedTime, value.ModifiedDate, value.CRC32, value.CompressedSize, value.UncompressedSize, value.CompressedSize64, value.UncompressedSize64, value.Extra, value.ExternalAttrs);
        }
    }
}}