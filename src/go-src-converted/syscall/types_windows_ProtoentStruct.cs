//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:27:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Protoent
        {
            // Constructors
            public Protoent(NilType _)
            {
                this.Name = default;
                this.Aliases = default;
                this.Proto = default;
            }

            public Protoent(ref ptr<byte> Name = default, ref ptr<ptr<byte>> Aliases = default, ushort Proto = default)
            {
                this.Name = Name;
                this.Aliases = Aliases;
                this.Proto = Proto;
            }

            // Enable comparisons between nil and Protoent struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Protoent value, NilType nil) => value.Equals(default(Protoent));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Protoent value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Protoent value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Protoent value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Protoent(NilType nil) => default(Protoent);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Protoent Protoent_cast(dynamic value)
        {
            return new Protoent(ref value.Name, ref value.Aliases, value.Proto);
        }
    }
}