//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:46:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class zip_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct collisionChecker
        {
            // Value of the collisionChecker struct
            private readonly map<@string, pathInfo> m_value;

            public collisionChecker(map<@string, pathInfo> value) => m_value = value;

            // Enable implicit conversions between map<@string, pathInfo> and collisionChecker struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator collisionChecker(map<@string, pathInfo> value) => new collisionChecker(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<@string, pathInfo>(collisionChecker value) => value.m_value;
            
            // Enable comparisons between nil and collisionChecker struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(collisionChecker value, NilType nil) => value.Equals(default(collisionChecker));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(collisionChecker value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, collisionChecker value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, collisionChecker value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator collisionChecker(NilType nil) => default(collisionChecker);
        }
    }
}}}}}}
