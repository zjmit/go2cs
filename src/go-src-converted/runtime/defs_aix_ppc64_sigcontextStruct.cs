//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sigcontext
        {
            // Constructors
            public sigcontext(NilType _)
            {
                this.sc_onstack = default;
                this.pad_cgo_0 = default;
                this.sc_mask = default;
                this.sc_uerror = default;
                this.sc_jmpbuf = default;
            }

            public sigcontext(int sc_onstack = default, array<byte> pad_cgo_0 = default, sigset sc_mask = default, int sc_uerror = default, context64 sc_jmpbuf = default)
            {
                this.sc_onstack = sc_onstack;
                this.pad_cgo_0 = pad_cgo_0;
                this.sc_mask = sc_mask;
                this.sc_uerror = sc_uerror;
                this.sc_jmpbuf = sc_jmpbuf;
            }

            // Enable comparisons between nil and sigcontext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sigcontext value, NilType nil) => value.Equals(default(sigcontext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sigcontext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sigcontext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sigcontext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sigcontext(NilType nil) => default(sigcontext);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sigcontext sigcontext_cast(dynamic value)
        {
            return new sigcontext(value.sc_onstack, value.pad_cgo_0, value.sc_mask, value.sc_uerror, value.sc_jmpbuf);
        }
    }
}