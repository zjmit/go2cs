//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 August 06 03:29:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using time = go.time_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial struct MyError : EmptyInterface
        {
            // Constructors
            public MyError(NilType _)
            {
                this.When = default;
                this.What = default;
            }

            public MyError(time.Time When, @string What)
            {
                this.When = When;
                this.What = What;
            }

            // Enable comparisons between nil and MyError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MyError value, NilType nil) => value.Equals(default(MyError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MyError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MyError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MyError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyError(NilType nil) => default(MyError);
        }

        [GeneratedCode("go2cs", "0.1.1.0")]
        public static MyError MyError_cast(dynamic value)
        {
            return new MyError(value.When, value.What);
        }
    }
}