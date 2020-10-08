//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:41:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using io = go.io_package;
using syntax = go.regexp.syntax_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;

namespace go
{
    public static partial class regexp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Regexp
        {
            // Constructors
            public Regexp(NilType _)
            {
                this.expr = default;
                this.prog = default;
                this.onepass = default;
                this.numSubexp = default;
                this.maxBitStateLen = default;
                this.subexpNames = default;
                this.prefix = default;
                this.prefixBytes = default;
                this.prefixRune = default;
                this.prefixEnd = default;
                this.mpool = default;
                this.matchcap = default;
                this.prefixComplete = default;
                this.cond = default;
                this.minInputLen = default;
                this.longest = default;
            }

            public Regexp(@string expr = default, ref ptr<syntax.Prog> prog = default, ref ptr<onePassProg> onepass = default, long numSubexp = default, long maxBitStateLen = default, slice<@string> subexpNames = default, @string prefix = default, slice<byte> prefixBytes = default, int prefixRune = default, uint prefixEnd = default, long mpool = default, long matchcap = default, bool prefixComplete = default, syntax.EmptyOp cond = default, long minInputLen = default, bool longest = default)
            {
                this.expr = expr;
                this.prog = prog;
                this.onepass = onepass;
                this.numSubexp = numSubexp;
                this.maxBitStateLen = maxBitStateLen;
                this.subexpNames = subexpNames;
                this.prefix = prefix;
                this.prefixBytes = prefixBytes;
                this.prefixRune = prefixRune;
                this.prefixEnd = prefixEnd;
                this.mpool = mpool;
                this.matchcap = matchcap;
                this.prefixComplete = prefixComplete;
                this.cond = cond;
                this.minInputLen = minInputLen;
                this.longest = longest;
            }

            // Enable comparisons between nil and Regexp struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Regexp value, NilType nil) => value.Equals(default(Regexp));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Regexp value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Regexp value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Regexp value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Regexp(NilType nil) => default(Regexp);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Regexp Regexp_cast(dynamic value)
        {
            return new Regexp(value.expr, ref value.prog, ref value.onepass, value.numSubexp, value.maxBitStateLen, value.subexpNames, value.prefix, value.prefixBytes, value.prefixRune, value.prefixEnd, value.mpool, value.matchcap, value.prefixComplete, value.cond, value.minInputLen, value.longest);
        }
    }
}