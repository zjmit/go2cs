//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:28 UTC
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
        private partial struct siginfo
        {
            // Constructors
            public siginfo(NilType _)
            {
                this._signo = default;
                this._code = default;
                this._errno = default;
                this._reason = default;
                this._reasonx = default;
            }

            public siginfo(int _signo = default, int _code = default, int _errno = default, System.UIntPtr _reason = default, array<byte> _reasonx = default)
            {
                this._signo = _signo;
                this._code = _code;
                this._errno = _errno;
                this._reason = _reason;
                this._reasonx = _reasonx;
            }

            // Enable comparisons between nil and siginfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(siginfo value, NilType nil) => value.Equals(default(siginfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(siginfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, siginfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, siginfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator siginfo(NilType nil) => default(siginfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static siginfo siginfo_cast(dynamic value)
        {
            return new siginfo(value._signo, value._code, value._errno, value._reason, value._reasonx);
        }
    }
}