//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 05:00:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using go;

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net {
namespace dns
{
    public static partial class dnsmessage_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Question
        {
            // Constructors
            public Question(NilType _)
            {
                this.Name = default;
                this.Type = default;
                this.Class = default;
            }

            public Question(Name Name = default, Type Type = default, Class Class = default)
            {
                this.Name = Name;
                this.Type = Type;
                this.Class = Class;
            }

            // Enable comparisons between nil and Question struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Question value, NilType nil) => value.Equals(default(Question));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Question value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Question value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Question value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Question(NilType nil) => default(Question);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Question Question_cast(dynamic value)
        {
            return new Question(value.Name, value.Type, value.Class);
        }
    }
}}}}}}