// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Package demangle defines functions that demangle GCC/LLVM C++ symbol names.
// This package recognizes names that were mangled according to the C++ ABI
// defined at http://codesourcery.com/cxx-abi/.
// package demangle -- go2cs converted at 2020 October 08 04:44:06 UTC
// import "cmd/vendor/github.com/ianlancetaylor/demangle" ==> using demangle = go.cmd.vendor.github.com.ianlancetaylor.demangle_package
// Original source: C:\Go\src\cmd\vendor\github.com\ianlancetaylor\demangle\demangle.go
using errors = go.errors_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using static go.builtin;
using System;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace ianlancetaylor
{
    public static partial class demangle_package
    {
        // ErrNotMangledName is returned by CheckedDemangle if the string does
        // not appear to be a C++ symbol name.
        public static var ErrNotMangledName = errors.New("not a C++ mangled name");

        // Option is the type of demangler options.
        public partial struct Option // : long
        {
        }

 
        // The NoParams option disables demangling of function parameters.
        public static readonly Option NoParams = (Option)iota; 

        // The NoTemplateParams option disables demangling of template parameters.
        public static readonly var NoTemplateParams = (var)0; 

        // The NoClones option disables inclusion of clone suffixes.
        // NoParams implies NoClones.
        public static readonly var NoClones = (var)1; 

        // The Verbose option turns on more verbose demangling.
        public static readonly var Verbose = (var)2;


        // Filter demangles a C++ symbol name, returning the human-readable C++ name.
        // If any error occurs during demangling, the input string is returned.
        public static @string Filter(@string name, params Option[] options)
        {
            options = options.Clone();

            var (ret, err) = ToString(name, options);
            if (err != null)
            {
                return name;
            }

            return ret;

        }

        // ToString demangles a C++ symbol name, returning human-readable C++
        // name or an error.
        // If the name does not appear to be a C++ symbol name at all, the
        // error will be ErrNotMangledName.
        public static (@string, error) ToString(@string name, params Option[] options)
        {
            @string _p0 = default;
            error _p0 = default!;
            options = options.Clone();

            var (a, err) = ToAST(name, options);
            if (err != null)
            {
                return ("", error.As(err)!);
            }

            return (ASTToString(a, options), error.As(null!)!);

        }

        // ToAST demangles a C++ symbol name into an abstract syntax tree
        // representing the symbol.
        // If the NoParams option is passed, and the name has a function type,
        // the parameter types are not demangled.
        // If the name does not appear to be a C++ symbol name at all, the
        // error will be ErrNotMangledName.
        public static (AST, error) ToAST(@string name, params Option[] options)
        {
            AST _p0 = default;
            error _p0 = default!;
            options = options.Clone();

            if (strings.HasPrefix(name, "_Z"))
            {
                var (a, err) = doDemangle(name[2L..], options);
                return (a, error.As(adjustErr(err, 2L))!);
            }

            const @string prefix = (@string)"_GLOBAL_";

            if (strings.HasPrefix(name, prefix))
            { 
                // The standard demangler ignores NoParams for global
                // constructors.  We are compatible.
                long i = 0L;
                while (i < len(options))
                {
                    if (options[i] == NoParams)
                    {
                        options = append(options[..i], options[i + 1L..]);
                    }
                    else
                    {
                        i++;
                    }

                }

                (a, err) = globalCDtorName(name[len(prefix)..], options);
                return (a, error.As(adjustErr(err, len(prefix)))!);

            }

            return (null, error.As(ErrNotMangledName)!);

        }

        // globalCDtorName demangles a global constructor/destructor symbol name.
        // The parameter is the string following the "_GLOBAL_" prefix.
        private static (AST, error) globalCDtorName(@string name, params Option[] options)
        {
            AST _p0 = default;
            error _p0 = default!;
            options = options.Clone();

            if (len(name) < 4L)
            {
                return (null, error.As(ErrNotMangledName)!);
            }

            switch (name[0L])
            {
                case '.': 

                case '_': 

                case '$': 
                    break;
                default: 
                    return (null, error.As(ErrNotMangledName)!);
                    break;
            }

            bool ctor = default;
            switch (name[1L])
            {
                case 'I': 
                    ctor = true;
                    break;
                case 'D': 
                    ctor = false;
                    break;
                default: 
                    return (null, error.As(ErrNotMangledName)!);
                    break;
            }

            if (name[2L] != '_')
            {
                return (null, error.As(ErrNotMangledName)!);
            }

            if (!strings.HasPrefix(name[3L..], "_Z"))
            {
                return (addr(new GlobalCDtor(Ctor:ctor,Key:&Name{Name:name})), error.As(null!)!);
            }
            else
            {
                var (a, err) = doDemangle(name[5L..], options);
                if (err != null)
                {
                    return (null, error.As(adjustErr(err, 5L))!);
                }

                return (addr(new GlobalCDtor(Ctor:ctor,Key:a)), error.As(null!)!);

            }

        }

        // The doDemangle function is the entry point into the demangler proper.
        private static (AST, error) doDemangle(@string name, params Option[] options) => func((defer, panic, _) =>
        {
            AST ret = default;
            error err = default!;
            options = options.Clone();
 
            // When the demangling routines encounter an error, they panic
            // with a value of type demangleErr.
            defer(() =>
            {
                {
                    var r = recover();

                    if (r != null)
                    {
                        {
                            demangleErr (de, ok) = r._<demangleErr>();

                            if (ok)
                            {
                                ret = null;
                                err = de;
                                return ;
                            }

                        }

                        panic(r);

                    }

                }

            }());

            var @params = true;
            var clones = true;
            var verbose = false;
            foreach (var (_, o) in options)
            {

                if (o == NoParams) 
                    params = false;
                    clones = false;
                else if (o == NoTemplateParams)                 else if (o == NoClones) 
                    clones = false;
                else if (o == Verbose) 
                    verbose = true;
                else 
                    return (null, error.As(fmt.Errorf("unrecognized demangler option %v", o))!);
                
            }
            ptr<state> st = addr(new state(str:name,verbose:verbose));
            var a = st.encoding(params, notForLocalName); 

            // Accept a clone suffix.
            if (clones)
            {
                while (len(st.str) > 1L && st.str[0L] == '.' && (isLower(st.str[1L]) || st.str[1L] == '_' || isDigit(st.str[1L])))
                {
                    a = st.cloneSuffix(a);
                }


            }

            if (clones && len(st.str) > 0L)
            {
                st.fail("unparsed characters at end of mangled name");
            }

            return (a, error.As(null!)!);

        });

        // A state holds the current state of demangling a string.
        private partial struct state
        {
            public @string str; // remainder of string to demangle
            public bool verbose; // whether to use verbose demangling
            public long off; // offset of str within original string
            public substitutions subs; // substitutions
            public slice<ptr<Template>> templates; // templates being processed
        }

        // copy returns a copy of the current state.
        private static ptr<state> copy(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            ptr<state> n = @new<state>();
            n.val = st.val;
            return _addr_n!;
        }

        // fail panics with demangleErr, to be caught in doDemangle.
        private static void fail(this ptr<state> _addr_st, @string err) => func((_, panic, __) =>
        {
            ref state st = ref _addr_st.val;

            panic(new demangleErr(err:err,off:st.off));
        });

        // failEarlier is like fail, but decrements the offset to indicate
        // that the point of failure occurred earlier in the string.
        private static void failEarlier(this ptr<state> _addr_st, @string err, long dec) => func((_, panic, __) =>
        {
            ref state st = ref _addr_st.val;

            if (st.off < dec)
            {
                panic("internal error");
            }

            panic(new demangleErr(err:err,off:st.off-dec));

        });

        // advance advances the current string offset.
        private static void advance(this ptr<state> _addr_st, long add) => func((_, panic, __) =>
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) < add)
            {
                panic("internal error");
            }

            st.str = st.str[add..];
            st.off += add;

        });

        // checkChar requires that the next character in the string be c, and
        // advances past it.
        private static void checkChar(this ptr<state> _addr_st, byte c) => func((_, panic, __) =>
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) == 0L || st.str[0L] != c)
            {
                panic("internal error");
            }

            st.advance(1L);

        });

        // A demangleErr is an error at a specific offset in the mangled
        // string.
        private partial struct demangleErr
        {
            public @string err;
            public long off;
        }

        // Error implements the builtin error interface for demangleErr.
        private static @string Error(this demangleErr de)
        {
            return fmt.Sprintf("%s at %d", de.err, de.off);
        }

        // adjustErr adjusts the position of err, if it is a demangleErr,
        // and returns err.
        private static error adjustErr(error err, long adj)
        {
            if (err == null)
            {
                return error.As(null!)!;
            }

            {
                demangleErr (de, ok) = err._<demangleErr>();

                if (ok)
                {
                    de.off += adj;
                    return error.As(de)!;
                }

            }

            return error.As(err)!;

        }

        private partial struct forLocalNameType // : long
        {
        }

        private static readonly forLocalNameType forLocalName = (forLocalNameType)iota;
        private static readonly var notForLocalName = (var)0;


        // encoding ::= <(function) name> <bare-function-type>
        //              <(data) name>
        //              <special-name>
        private static AST encoding(this ptr<state> _addr_st, bool @params, forLocalNameType local)
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) < 1L)
            {
                st.fail("expected encoding");
            }

            if (st.str[0L] == 'G' || st.str[0L] == 'T')
            {
                return st.specialName();
            }

            var a = st.name();
            a = simplify(a);

            if (!params)
            { 
                // Don't demangle the parameters.

                // Strip CV-qualifiers, as they apply to the 'this'
                // parameter, and are not output by the standard
                // demangler without parameters.
                {
                    ptr<MethodWithQualifiers> mwq__prev2 = mwq;

                    ptr<MethodWithQualifiers> (mwq, ok) = a._<ptr<MethodWithQualifiers>>();

                    if (ok)
                    {
                        a = mwq.Method;
                    } 

                    // If this is a local name, there may be CV-qualifiers
                    // on the name that really apply to the top level, and
                    // therefore must be discarded when discarding
                    // parameters.  This can happen when parsing a class
                    // that is local to a function.

                    mwq = mwq__prev2;

                } 

                // If this is a local name, there may be CV-qualifiers
                // on the name that really apply to the top level, and
                // therefore must be discarded when discarding
                // parameters.  This can happen when parsing a class
                // that is local to a function.
                {
                    ptr<Qualified> q__prev2 = q;

                    ptr<Qualified> (q, ok) = a._<ptr<Qualified>>();

                    if (ok && q.LocalName)
                    {
                        var p = _addr_q.Name;
                        {
                            ptr<DefaultArg> da__prev3 = da;

                            ptr<DefaultArg> (da, ok) = (p.val)._<ptr<DefaultArg>>();

                            if (ok)
                            {
                                p = _addr_da.Arg;
                            }

                            da = da__prev3;

                        }

                        {
                            ptr<MethodWithQualifiers> mwq__prev3 = mwq;

                            (mwq, ok) = (p.val)._<ptr<MethodWithQualifiers>>();

                            if (ok)
                            {
                                p.val = mwq.Method;
                            }

                            mwq = mwq__prev3;

                        }

                    }

                    q = q__prev2;

                }


                return a;

            }

            if (len(st.str) == 0L || st.str[0L] == 'E')
            { 
                // There are no parameters--this is a data symbol, not
                // a function symbol.
                return a;

            }

            var check = a;
            ptr<MethodWithQualifiers> (mwq, _) = check._<ptr<MethodWithQualifiers>>();
            if (mwq != null)
            {
                check = mwq.Method;
            }

            ptr<Template> (template, _) = check._<ptr<Template>>();
            if (template != null)
            {
                st.templates = append(st.templates, template);
            }

            var ft = st.bareFunctionType(hasReturnType(a));

            if (template != null)
            {
                st.templates = st.templates[..len(st.templates) - 1L];
            }

            ft = simplify(ft); 

            // For a local name, discard the return type, so that it
            // doesn't get confused with the top level return type.
            if (local == forLocalName)
            {
                {
                    ptr<FunctionType> (functype, ok) = ft._<ptr<FunctionType>>();

                    if (ok)
                    {
                        functype.Return = null;
                    }

                }

            } 

            // Any top-level qualifiers belong to the function type.
            if (mwq != null)
            {
                a = mwq.Method;
                mwq.Method = ft;
                ft = mwq;
            }

            {
                ptr<Qualified> q__prev1 = q;

                (q, ok) = a._<ptr<Qualified>>();

                if (ok && q.LocalName)
                {
                    p = _addr_q.Name;
                    {
                        ptr<DefaultArg> da__prev2 = da;

                        (da, ok) = (p.val)._<ptr<DefaultArg>>();

                        if (ok)
                        {
                            p = _addr_da.Arg;
                        }

                        da = da__prev2;

                    }

                    {
                        ptr<MethodWithQualifiers> mwq__prev2 = mwq;

                        (mwq, ok) = (p.val)._<ptr<MethodWithQualifiers>>();

                        if (ok)
                        {
                            p.val = mwq.Method;
                            mwq.Method = ft;
                            ft = mwq;
                        }

                        mwq = mwq__prev2;

                    }

                }

                q = q__prev1;

            }


            return addr(new Typed(Name:a,Type:ft));

        }

        // hasReturnType returns whether the mangled form of a will have a
        // return type.
        private static bool hasReturnType(AST a)
        {
            switch (a.type())
            {
                case ptr<Template> a:
                    return !isCDtorConversion(a.Name);
                    break;
                case ptr<TypeWithQualifiers> a:
                    return hasReturnType(a.Base);
                    break;
                case ptr<MethodWithQualifiers> a:
                    return hasReturnType(a.Method);
                    break;
                default:
                {
                    var a = a.type();
                    return false;
                    break;
                }
            }

        }

        // isCDtorConversion returns when an AST is a constructor, a
        // destructor, or a conversion operator.
        private static bool isCDtorConversion(AST a)
        {
            switch (a.type())
            {
                case ptr<Qualified> a:
                    return isCDtorConversion(a.Name);
                    break;
                case ptr<Constructor> a:
                    return true;
                    break;
                case ptr<Destructor> a:
                    return true;
                    break;
                case ptr<Cast> a:
                    return true;
                    break;
                default:
                {
                    var a = a.type();
                    return false;
                    break;
                }
            }

        }

        // <tagged-name> ::= <name> B <source-name>
        private static AST taggedName(this ptr<state> _addr_st, AST a)
        {
            ref state st = ref _addr_st.val;

            while (len(st.str) > 0L && st.str[0L] == 'B')
            {
                st.advance(1L);
                var tag = st.sourceName();
                a = addr(new TaggedName(Name:a,Tag:tag));
            }

            return a;

        }

        // <name> ::= <nested-name>
        //        ::= <unscoped-name>
        //        ::= <unscoped-template-name> <template-args>
        //        ::= <local-name>
        //
        // <unscoped-name> ::= <unqualified-name>
        //                 ::= St <unqualified-name>
        //
        // <unscoped-template-name> ::= <unscoped-name>
        //                          ::= <substitution>
        private static AST name(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) < 1L)
            {
                st.fail("expected name");
            }

            switch (st.str[0L])
            {
                case 'N': 
                    return st.nestedName();
                    break;
                case 'Z': 
                    return st.localName();
                    break;
                case 'U': 
                    var (a, isCast) = st.unqualifiedName();
                    if (isCast)
                    {
                        st.setTemplate(a, null);
                    }

                    return a;
                    break;
                case 'S': 
                    if (len(st.str) < 2L)
                    {
                        st.advance(1L);
                        st.fail("expected substitution index");
                    }

                    AST a = default;
                    var isCast = false;
                    var subst = false;
                    if (st.str[1L] == 't')
                    {
                        st.advance(2L);
                        a, isCast = st.unqualifiedName();
                        a = addr(new Qualified(Scope:&Name{Name:"std"},Name:a,LocalName:false));
                    }
                    else
                    {
                        a = st.substitution(false);
                        subst = true;
                    }

                    if (len(st.str) > 0L && st.str[0L] == 'I')
                    { 
                        // This can only happen if we saw
                        // <unscoped-template-name> and are about to see
                        // <template-args>.  <unscoped-template-name> is a
                        // substitution candidate if it did not come from a
                        // substitution.
                        if (!subst)
                        {
                            st.subs.add(a);
                        }

                        var args = st.templateArgs();
                        ptr<Template> tmpl = addr(new Template(Name:a,Args:args));
                        if (isCast)
                        {
                            st.setTemplate(a, tmpl);
                            st.clearTemplateArgs(args);
                            isCast = false;
                        }

                        a = tmpl;

                    }

                    if (isCast)
                    {
                        st.setTemplate(a, null);
                    }

                    return a;
                    break;
                default: 
                    (a, isCast) = st.unqualifiedName();
                    if (len(st.str) > 0L && st.str[0L] == 'I')
                    {
                        st.subs.add(a);
                        args = st.templateArgs();
                        tmpl = addr(new Template(Name:a,Args:args));
                        if (isCast)
                        {
                            st.setTemplate(a, tmpl);
                            st.clearTemplateArgs(args);
                            isCast = false;
                        }

                        a = tmpl;

                    }

                    if (isCast)
                    {
                        st.setTemplate(a, null);
                    }

                    return a;
                    break;
            }

        }

        // <nested-name> ::= N [<CV-qualifiers>] [<ref-qualifier>] <prefix> <unqualified-name> E
        //               ::= N [<CV-qualifiers>] [<ref-qualifier>] <template-prefix> <template-args> E
        private static AST nestedName(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            st.checkChar('N');
            var q = st.cvQualifiers();
            var r = st.refQualifier();
            var a = st.prefix();
            if (len(q) > 0L || r != "")
            {
                a = addr(new MethodWithQualifiers(Method:a,Qualifiers:q,RefQualifier:r));
            }

            if (len(st.str) == 0L || st.str[0L] != 'E')
            {
                st.fail("expected E after nested name");
            }

            st.advance(1L);
            return a;

        }

        // <prefix> ::= <prefix> <unqualified-name>
        //          ::= <template-prefix> <template-args>
        //          ::= <template-param>
        //          ::= <decltype>
        //          ::=
        //          ::= <substitution>
        //
        // <template-prefix> ::= <prefix> <(template) unqualified-name>
        //                   ::= <template-param>
        //                   ::= <substitution>
        //
        // <decltype> ::= Dt <expression> E
        //            ::= DT <expression> E
        private static AST prefix(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            AST a = default; 

            // The last name seen, for a constructor/destructor.
            AST last = default;

            Func<AST, AST> getLast = a =>
            {
                while (true)
                {
                    {
                        ptr<Template> t__prev1 = t;

                        ptr<Template> (t, ok) = a._<ptr<Template>>();

                        if (ok)
                        {
                            a = t.Name;
                        }                        {
                            ptr<Qualified> (q, ok) = a._<ptr<Qualified>>();


                            else if (ok)
                            {
                                a = q.Name;
                            }                            {
                                ptr<Template> t__prev3 = t;

                                (t, ok) = a._<ptr<TaggedName>>();


                                else if (ok)
                                {
                                    a = t.Name;
                                }
                                else
                                {
                                    return a;
                                }

                                t = t__prev3;

                            }


                        }


                        t = t__prev1;

                    }

                }


            }
;

            var isCast = false;
            while (true)
            {
                if (len(st.str) == 0L)
                {
                    st.fail("expected prefix");
                }

                AST next = default;

                var c = st.str[0L];
                if (isDigit(c) || isLower(c) || c == 'U' || c == 'L')
                {
                    var (un, isUnCast) = st.unqualifiedName();
                    next = un;
                    if (isUnCast)
                    {
                        isCast = true;
                    }

                }
                else
                {
                    switch (st.str[0L])
                    {
                        case 'C': 
                            var inheriting = false;
                            st.advance(1L);
                            if (len(st.str) > 0L && st.str[0L] == 'I')
                            {
                                inheriting = true;
                                st.advance(1L);
                            }

                            if (len(st.str) < 1L)
                            {
                                st.fail("expected constructor type");
                            }

                            if (last == null)
                            {
                                st.fail("constructor before name is seen");
                            }

                            st.advance(1L);
                            if (inheriting)
                            {
                                last = st.demangleType(false);
                            }

                            next = addr(new Constructor(Name:getLast(last)));
                            break;
                        case 'D': 
                            if (len(st.str) > 1L && (st.str[1L] == 'T' || st.str[1L] == 't'))
                            {
                                next = st.demangleType(false);
                            }
                            else
                            {
                                if (len(st.str) < 2L)
                                {
                                    st.fail("expected destructor type");
                                }

                                if (last == null)
                                {
                                    st.fail("destructor before name is seen");
                                }

                                st.advance(2L);
                                next = addr(new Destructor(Name:getLast(last)));

                            }

                            break;
                        case 'S': 
                            next = st.substitution(true);
                            break;
                        case 'I': 
                            if (a == null)
                            {
                                st.fail("unexpected template arguments");
                            }

                            slice<AST> args = default;
                            args = st.templateArgs();
                            ptr<Template> tmpl = addr(new Template(Name:a,Args:args));
                            if (isCast)
                            {
                                st.setTemplate(a, tmpl);
                                st.clearTemplateArgs(args);
                                isCast = false;
                            }

                            a = null;
                            next = tmpl;
                            break;
                        case 'T': 
                            next = st.templateParam();
                            break;
                        case 'E': 
                            if (a == null)
                            {
                                st.fail("expected prefix");
                            }

                            if (isCast)
                            {
                                st.setTemplate(a, null);
                            }

                            return a;
                            break;
                        case 'M': 
                            if (a == null)
                            {
                                st.fail("unexpected lambda initializer");
                            } 
                            // This is the initializer scope for a
                            // lambda.  We don't need to record
                            // it.  The normal code will treat the
                            // variable has a type scope, which
                            // gives appropriate output.
                            st.advance(1L);
                            continue;
                            break;
                        default: 
                            st.fail("unrecognized letter in prefix");
                            break;
                    }

                }

                last = next;
                if (a == null)
                {
                    a = next;
                }
                else
                {
                    a = addr(new Qualified(Scope:a,Name:next,LocalName:false));
                }

                if (c != 'S' && (len(st.str) == 0L || st.str[0L] != 'E'))
                {
                    st.subs.add(a);
                }

            }


        }

        // <unqualified-name> ::= <operator-name>
        //                    ::= <ctor-dtor-name>
        //                    ::= <source-name>
        //                    ::= <local-source-name>
        //
        //  <local-source-name>    ::= L <source-name> <discriminator>
        private static (AST, bool) unqualifiedName(this ptr<state> _addr_st)
        {
            AST r = default;
            bool isCast = default;
            ref state st = ref _addr_st.val;

            if (len(st.str) < 1L)
            {
                st.fail("expected unqualified name");
            }

            AST a = default;
            isCast = false;
            var c = st.str[0L];
            if (isDigit(c))
            {
                a = st.sourceName();
            }
            else if (isLower(c))
            {
                a, _ = st.operatorName(false);
                {
                    ptr<Cast> (_, ok) = a._<ptr<Cast>>();

                    if (ok)
                    {
                        isCast = true;
                    }

                }

                {
                    ptr<Operator> (op, ok) = a._<ptr<Operator>>();

                    if (ok && op.Name == "operator\"\" ")
                    {
                        var n = st.sourceName();
                        a = addr(new Unary(Op:op,Expr:n,Suffix:false,SizeofType:false));
                    }

                }

            }
            else
            {
                switch (c)
                {
                    case 'C': 

                    case 'D': 
                        st.fail("constructor/destructor not in nested name");
                        break;
                    case 'L': 
                        st.advance(1L);
                        a = st.sourceName();
                        a = st.discriminator(a);
                        break;
                    case 'U': 
                        if (len(st.str) < 2L)
                        {
                            st.advance(1L);
                            st.fail("expected closure or unnamed type");
                        }

                        c = st.str[1L];
                        switch (c)
                        {
                            case 'l': 
                                a = st.closureTypeName();
                                break;
                            case 't': 
                                a = st.unnamedTypeName();
                                break;
                            default: 
                                st.advance(1L);
                                st.fail("expected closure or unnamed type");
                                break;
                        }
                        break;
                    default: 
                        st.fail("expected unqualified name");
                        break;
                }

            }

            if (len(st.str) > 0L && st.str[0L] == 'B')
            {
                a = st.taggedName(a);
            }

            return (a, isCast);

        }

        // <source-name> ::= <(positive length) number> <identifier>
        // identifier ::= <(unqualified source code identifier)>
        private static AST sourceName(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            var val = st.number();
            if (val <= 0L)
            {
                st.fail("expected positive number");
            }

            if (len(st.str) < val)
            {
                st.fail("not enough characters for identifier");
            }

            var id = st.str[..val];
            st.advance(val); 

            // Look for GCC encoding of anonymous namespace, and make it
            // more friendly.
            const @string anonPrefix = (@string)"_GLOBAL_";

            if (strings.HasPrefix(id, anonPrefix) && len(id) > len(anonPrefix) + 2L)
            {
                var c1 = id[len(anonPrefix)];
                var c2 = id[len(anonPrefix) + 1L];
                if ((c1 == '.' || c1 == '_' || c1 == '$') && c2 == 'N')
                {
                    id = "(anonymous namespace)";
                }

            }

            ptr<Name> n = addr(new Name(Name:id));
            return n;

        }

        // number ::= [n] <(non-negative decimal integer)>
        private static long number(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            var neg = false;
            if (len(st.str) > 0L && st.str[0L] == 'n')
            {
                neg = true;
                st.advance(1L);
            }

            if (len(st.str) == 0L || !isDigit(st.str[0L]))
            {
                st.fail("missing number");
            }

            long val = 0L;
            while (len(st.str) > 0L && isDigit(st.str[0L]))
            { 
                // Number picked to ensure we can't overflow with 32-bit int.
                // Any very large number here is bogus.
                if (val >= 0x80000000UL / 10L - 10L)
                {
                    st.fail("numeric overflow");
                }

                val = val * 10L + int(st.str[0L] - '0');
                st.advance(1L);

            }

            if (neg)
            {
                val = -val;
            }

            return val;

        }

        // An operator is the demangled name, and the number of arguments it
        // takes in an expression.
        private partial struct @operator
        {
            public @string name;
            public long args;
        }

        // The operators map maps the mangled operator names to information
        // about them.
        private static map operators = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<@string, operator>{"aN":{"&=",2},"aS":{"=",2},"aa":{"&&",2},"ad":{"&",1},"an":{"&",2},"at":{"alignof ",1},"az":{"alignof ",1},"cc":{"const_cast",2},"cl":{"()",2},"cm":{",",2},"co":{"~",1},"dV":{"/=",2},"da":{"delete[] ",1},"dc":{"dynamic_cast",2},"de":{"*",1},"dl":{"delete ",1},"ds":{".*",2},"dt":{".",2},"dv":{"/",2},"eO":{"^=",2},"eo":{"^",2},"eq":{"==",2},"fl":{"...",2},"fr":{"...",2},"fL":{"...",3},"fR":{"...",3},"ge":{">=",2},"gs":{"::",1},"gt":{">",2},"ix":{"[]",2},"lS":{"<<=",2},"le":{"<=",2},"li":{`operator"" `,1},"ls":{"<<",2},"lt":{"<",2},"mI":{"-=",2},"mL":{"*=",2},"mi":{"-",2},"ml":{"*",2},"mm":{"--",1},"na":{"new[]",3},"ne":{"!=",2},"ng":{"-",1},"nt":{"!",1},"nw":{"new",3},"oR":{"|=",2},"oo":{"||",2},"or":{"|",2},"pL":{"+=",2},"pl":{"+",2},"pm":{"->*",2},"pp":{"++",1},"ps":{"+",1},"pt":{"->",2},"qu":{"?",3},"rM":{"%=",2},"rS":{">>=",2},"rc":{"reinterpret_cast",2},"rm":{"%",2},"rs":{">>",2},"sc":{"static_cast",2},"st":{"sizeof ",1},"sz":{"sizeof ",1},"tr":{"throw",0},"tw":{"throw ",1},};

        // operator_name ::= many different two character encodings.
        //               ::= cv <type>
        //               ::= v <digit> <source-name>
        //
        // We need to know whether we are in an expression because it affects
        // how we handle template parameters in the type of a cast operator.
        private static (AST, long) operatorName(this ptr<state> _addr_st, bool inExpression) => func((_, panic, __) =>
        {
            AST _p0 = default;
            long _p0 = default;
            ref state st = ref _addr_st.val;

            if (len(st.str) < 2L)
            {
                st.fail("missing operator code");
            }

            var code = st.str[..2L];
            st.advance(2L);
            if (code[0L] == 'v' && isDigit(code[1L]))
            {
                var name = st.sourceName();
                return (addr(new Operator(Name:name.(*Name).Name)), int(code[1L] - '0'));
            }
            else if (code == "cv")
            { 
                // Push a nil on templates to indicate that template
                // parameters will have their template filled in
                // later.
                if (!inExpression)
                {
                    st.templates = append(st.templates, null);
                }

                var t = st.demangleType(!inExpression);

                if (!inExpression)
                {
                    st.templates = st.templates[..len(st.templates) - 1L];
                }

                return (addr(new Cast(To:t)), 1L);

            }            {
                var (op, ok) = operators[code];


                else if (ok)
                {
                    return (addr(new Operator(Name:op.name)), op.args);
                }
                else
                {
                    st.failEarlier("unrecognized operator code", 2L);
                    panic("not reached");
                }

            }

        });

        // <local-name> ::= Z <(function) encoding> E <(entity) name> [<discriminator>]
        //              ::= Z <(function) encoding> E s [<discriminator>]
        //              ::= Z <(function) encoding> E d [<parameter> number>] _ <entity name>
        private static AST localName(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            st.checkChar('Z');
            var fn = st.encoding(true, forLocalName);
            if (len(st.str) == 0L || st.str[0L] != 'E')
            {
                st.fail("expected E after local name");
            }

            st.advance(1L);
            if (len(st.str) > 0L && st.str[0L] == 's')
            {
                st.advance(1L);
                AST n = addr(new Name(Name:"string literal"));
                n = st.discriminator(n);
                return addr(new Qualified(Scope:fn,Name:n,LocalName:true));
            }
            else
            {
                long num = -1L;
                if (len(st.str) > 0L && st.str[0L] == 'd')
                { 
                    // Default argument scope.
                    st.advance(1L);
                    num = st.compactNumber();

                }

                n = st.name();
                n = st.discriminator(n);
                if (num >= 0L)
                {
                    n = addr(new DefaultArg(Num:num,Arg:n));
                }

                return addr(new Qualified(Scope:fn,Name:n,LocalName:true));

            }

        }

        // Parse a Java resource special-name.
        private static AST javaResource(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            var off = st.off;
            var ln = st.number();
            if (ln <= 1L)
            {
                st.failEarlier("java resource length less than 1", st.off - off);
            }

            if (len(st.str) == 0L || st.str[0L] != '_')
            {
                st.fail("expected _ after number");
            }

            st.advance(1L);
            ln--;
            if (len(st.str) < ln)
            {
                st.fail("not enough characters for java resource length");
            }

            var str = st.str[..ln];
            @string final = "";
            st.advance(ln);
            for (long i = 0L; i < len(str); i++)
            {
                if (str[i] != '$')
                {
                    final += string(str[i]);
                }
                else
                {
                    if (len(str) <= i + 1L)
                    {
                        st.failEarlier("java resource escape at end of string", 1L);
                    }

                    i++;
                    map (r, ok) = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<byte, @string>{'S':"/",'_':".",'$':"$",}[str[i]];
                    if (!ok)
                    {
                        st.failEarlier("unrecognized java resource escape", ln - i - 1L);
                    }

                    final += r;

                }

            }

            return addr(new Special(Prefix:"java resource ",Val:&Name{Name:final}));

        }

        // <special-name> ::= TV <type>
        //                ::= TT <type>
        //                ::= TI <type>
        //                ::= TS <type>
        //                ::= GV <(object) name>
        //                ::= T <call-offset> <(base) encoding>
        //                ::= Tc <call-offset> <call-offset> <(base) encoding>
        // Also g++ extensions:
        //                ::= TC <type> <(offset) number> _ <(base) type>
        //                ::= TF <type>
        //                ::= TJ <type>
        //                ::= GR <name>
        //                ::= GA <encoding>
        //                ::= Gr <resource name>
        //                ::= GTt <encoding>
        //                ::= GTn <encoding>
        private static AST specialName(this ptr<state> _addr_st) => func((_, panic, __) =>
        {
            ref state st = ref _addr_st.val;

            if (st.str[0L] == 'T')
            {
                st.advance(1L);
                if (len(st.str) == 0L)
                {
                    st.fail("expected special name code");
                }

                var c = st.str[0L];
                st.advance(1L);
                switch (c)
                {
                    case 'V': 
                        var t = st.demangleType(false);
                        return addr(new Special(Prefix:"vtable for ",Val:t));
                        break;
                    case 'T': 
                        t = st.demangleType(false);
                        return addr(new Special(Prefix:"VTT for ",Val:t));
                        break;
                    case 'I': 
                        t = st.demangleType(false);
                        return addr(new Special(Prefix:"typeinfo for ",Val:t));
                        break;
                    case 'S': 
                        t = st.demangleType(false);
                        return addr(new Special(Prefix:"typeinfo name for ",Val:t));
                        break;
                    case 'h': 
                        st.callOffset('h');
                        var v = st.encoding(true, notForLocalName);
                        return addr(new Special(Prefix:"non-virtual thunk to ",Val:v));
                        break;
                    case 'v': 
                        st.callOffset('v');
                        v = st.encoding(true, notForLocalName);
                        return addr(new Special(Prefix:"virtual thunk to ",Val:v));
                        break;
                    case 'c': 
                        st.callOffset(0L);
                        st.callOffset(0L);
                        v = st.encoding(true, notForLocalName);
                        return addr(new Special(Prefix:"covariant return thunk to ",Val:v));
                        break;
                    case 'C': 
                        var derived = st.demangleType(false);
                        var off = st.off;
                        var offset = st.number();
                        if (offset < 0L)
                        {
                            st.failEarlier("expected positive offset", st.off - off);
                        }

                        if (len(st.str) == 0L || st.str[0L] != '_')
                        {
                            st.fail("expected _ after number");
                        }

                        st.advance(1L);
                        var @base = st.demangleType(false);
                        return addr(new Special2(Prefix:"construction vtable for ",Val1:base,Middle:"-in-",Val2:derived));
                        break;
                    case 'F': 
                        t = st.demangleType(false);
                        return addr(new Special(Prefix:"typeinfo fn for ",Val:t));
                        break;
                    case 'J': 
                        t = st.demangleType(false);
                        return addr(new Special(Prefix:"java Class for ",Val:t));
                        break;
                    case 'H': 
                        var n = st.name();
                        return addr(new Special(Prefix:"TLS init function for ",Val:n));
                        break;
                    case 'W': 
                        n = st.name();
                        return addr(new Special(Prefix:"TLS wrapper function for ",Val:n));
                        break;
                    default: 
                        st.fail("unrecognized special T name code");
                        panic("not reached");
                        break;
                }

            }
            else
            {
                st.checkChar('G');
                if (len(st.str) == 0L)
                {
                    st.fail("expected special name code");
                }

                c = st.str[0L];
                st.advance(1L);
                switch (c)
                {
                    case 'V': 
                        n = st.name();
                        return addr(new Special(Prefix:"guard variable for ",Val:n));
                        break;
                    case 'R': 
                        n = st.name();
                        var i = st.number();
                        return addr(new Special(Prefix:fmt.Sprintf("reference temporary #%d for ",i),Val:n));
                        break;
                    case 'A': 
                        v = st.encoding(true, notForLocalName);
                        return addr(new Special(Prefix:"hidden alias for ",Val:v));
                        break;
                    case 'T': 
                        if (len(st.str) == 0L)
                        {
                            st.fail("expected special GT name code");
                        }

                        c = st.str[0L];
                        st.advance(1L);
                        v = st.encoding(true, notForLocalName);
                        switch (c)
                        {
                            case 'n': 
                                return addr(new Special(Prefix:"non-transaction clone for ",Val:v));
                                break;
                            case 't': 
                                return addr(new Special(Prefix:"transaction clone for ",Val:v));
                                break;
                            default: 
                                // The proposal is that different
                                // letters stand for different types
                                // of transactional cloning.  Treat
                                // them all the same for now.
                                break;
                        }
                        break;
                    case 'r': 
                        return st.javaResource();
                        break;
                    default: 
                        st.fail("unrecognized special G name code");
                        panic("not reached");
                        break;
                }

            }

        });

        // <call-offset> ::= h <nv-offset> _
        //               ::= v <v-offset> _
        //
        // <nv-offset> ::= <(offset) number>
        //
        // <v-offset> ::= <(offset) number> _ <(virtual offset) number>
        //
        // The c parameter, if not 0, is a character we just read which is the
        // start of the <call-offset>.
        //
        // We don't display the offset information anywhere.
        private static void callOffset(this ptr<state> _addr_st, byte c)
        {
            ref state st = ref _addr_st.val;

            if (c == 0L)
            {
                if (len(st.str) == 0L)
                {
                    st.fail("missing call offset");
                }

                c = st.str[0L];
                st.advance(1L);

            }

            switch (c)
            {
                case 'h': 
                    st.number();
                    break;
                case 'v': 
                    st.number();
                    if (len(st.str) == 0L || st.str[0L] != '_')
                    {
                        st.fail("expected _ after number");
                    }

                    st.advance(1L);
                    st.number();
                    break;
                default: 
                    st.failEarlier("unrecognized call offset code", 1L);
                    break;
            }
            if (len(st.str) == 0L || st.str[0L] != '_')
            {
                st.fail("expected _ after call offset");
            }

            st.advance(1L);

        }

        // builtinTypes maps the type letter to the type name.
        private static map builtinTypes = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<byte, @string>{'a':"signed char",'b':"bool",'c':"char",'d':"double",'e':"long double",'f':"float",'g':"__float128",'h':"unsigned char",'i':"int",'j':"unsigned int",'l':"long",'m':"unsigned long",'n':"__int128",'o':"unsigned __int128",'s':"short",'t':"unsigned short",'v':"void",'w':"wchar_t",'x':"long long",'y':"unsigned long long",'z':"...",};

        // <type> ::= <builtin-type>
        //        ::= <function-type>
        //        ::= <class-enum-type>
        //        ::= <array-type>
        //        ::= <pointer-to-member-type>
        //        ::= <template-param>
        //        ::= <template-template-param> <template-args>
        //        ::= <substitution>
        //        ::= <CV-qualifiers> <type>
        //        ::= P <type>
        //        ::= R <type>
        //        ::= O <type> (C++0x)
        //        ::= C <type>
        //        ::= G <type>
        //        ::= U <source-name> <type>
        //
        // <builtin-type> ::= various one letter codes
        //                ::= u <source-name>
        private static AST demangleType(this ptr<state> _addr_st, bool isCast)
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) == 0L)
            {
                st.fail("expected type");
            }

            var addSubst = true;

            var q = st.cvQualifiers();
            if (len(q) > 0L)
            {
                if (len(st.str) == 0L)
                {
                    st.fail("expected type");
                } 

                // CV-qualifiers before a function type apply to
                // 'this', so avoid adding the unqualified function
                // type to the substitution list.
                if (st.str[0L] == 'F')
                {
                    addSubst = false;
                }

            }

            AST ret = default; 

            // Use correct substitution for a template parameter.
            AST sub = default;

            {
                var (btype, ok) = builtinTypes[st.str[0L]];

                if (ok)
                {
                    ret = addr(new BuiltinType(Name:btype));
                    st.advance(1L);
                    if (len(q) > 0L)
                    {
                        ret = addr(new TypeWithQualifiers(Base:ret,Qualifiers:q));
                        st.subs.add(ret);
                    }

                    return ret;

                }

            }

            var c = st.str[0L];
            switch (c)
            {
                case 'u': 
                    st.advance(1L);
                    ret = st.sourceName();
                    break;
                case 'F': 
                    ret = st.functionType();
                    break;
                case 'N': 

                case 'Z': 

                case '0': 

                case '1': 

                case '2': 

                case '3': 

                case '4': 

                case '5': 

                case '6': 

                case '7': 

                case '8': 

                case '9': 
                    ret = st.name();
                    break;
                case 'A': 
                    ret = st.arrayType(isCast);
                    break;
                case 'M': 
                    ret = st.pointerToMemberType(isCast);
                    break;
                case 'T': 
                    ret = st.templateParam();
                    if (len(st.str) > 0L && st.str[0L] == 'I')
                    { 
                        // See the function comment to explain this.
                        if (!isCast)
                        {
                            st.subs.add(ret);
                            var args = st.templateArgs();
                            ret = addr(new Template(Name:ret,Args:args));
                        }
                        else
                        {
                            ret = st.demangleCastTemplateArgs(ret, true);
                        }

                    }

                    break;
                case 'S': 
                    // If this is a special substitution, then it
                    // is the start of <class-enum-type>.
                    byte c2 = default;
                    if (len(st.str) > 1L)
                    {
                        c2 = st.str[1L];
                    }

                    if (isDigit(c2) || c2 == '_' || isUpper(c2))
                    {
                        ret = st.substitution(false);
                        if (len(st.str) == 0L || st.str[0L] != 'I')
                        {
                            addSubst = false;
                        }
                        else
                        { 
                            // See the function comment to explain this.
                            {
                                ptr<TemplateParam> (_, ok) = ret._<ptr<TemplateParam>>();

                                if (!ok || !isCast)
                                {
                                    args = st.templateArgs();
                                    ret = addr(new Template(Name:ret,Args:args));
                                }
                                else
                                {
                                    var next = st.demangleCastTemplateArgs(ret, false);
                                    if (next == ret)
                                    {
                                        addSubst = false;
                                    }

                                    ret = next;

                                }

                            }

                        }

                    }
                    else
                    {
                        ret = st.name(); 
                        // This substitution is not itself a
                        // substitution candidate, unless template
                        // arguments were added.
                        if (ret == subAST[c2] || ret == verboseAST[c2])
                        {
                            addSubst = false;
                        }

                    }

                    break;
                case 'O': 

                case 'P': 

                case 'R': 

                case 'C': 

                case 'G': 
                    st.advance(1L);
                    var t = st.demangleType(isCast);
                    switch (c)
                    {
                        case 'O': 
                            ret = addr(new RvalueReferenceType(Base:t));
                            break;
                        case 'P': 
                            ret = addr(new PointerType(Base:t));
                            break;
                        case 'R': 
                            ret = addr(new ReferenceType(Base:t));
                            break;
                        case 'C': 
                            ret = addr(new ComplexType(Base:t));
                            break;
                        case 'G': 
                            ret = addr(new ImaginaryType(Base:t));
                            break;
                    }
                    break;
                case 'U': 
                    if (len(st.str) < 2L)
                    {
                        st.fail("expected source name or unnamed type");
                    }

                    switch (st.str[1L])
                    {
                        case 'l': 
                            ret = st.closureTypeName();
                            addSubst = false;
                            break;
                        case 't': 
                            ret = st.unnamedTypeName();
                            addSubst = false;
                            break;
                        default: 
                            st.advance(1L);
                            var n = st.sourceName();
                            if (len(st.str) > 0L && st.str[0L] == 'I')
                            {
                                args = st.templateArgs();
                                n = addr(new Template(Name:n,Args:args));
                            }

                            t = st.demangleType(isCast);
                            ret = addr(new VendorQualifier(Qualifier:n,Type:t));
                            break;
                    }
                    break;
                case 'D': 
                    st.advance(1L);
                    if (len(st.str) == 0L)
                    {
                        st.fail("expected D code for type");
                    }

                    addSubst = false;
                    c2 = st.str[0L];
                    st.advance(1L);
                    switch (c2)
                    {
                        case 'T': 
                            // decltype(expression)

                        case 't': 
                            // decltype(expression)
                            ret = st.expression();
                            if (len(st.str) == 0L || st.str[0L] != 'E')
                            {
                                st.fail("expected E after expression in type");
                            }

                            st.advance(1L);
                            ret = addr(new Decltype(Expr:ret));
                            addSubst = true;
                            break;
                        case 'p': 
                            t = st.demangleType(isCast);
                            var pack = st.findArgumentPack(t);
                            ret = addr(new PackExpansion(Base:t,Pack:pack));
                            addSubst = true;
                            break;
                        case 'a': 
                            ret = addr(new Name(Name:"auto"));
                            break;
                        case 'f': 
                            ret = addr(new BuiltinType(Name:"decimal32"));
                            break;
                        case 'd': 
                            ret = addr(new BuiltinType(Name:"decimal64"));
                            break;
                        case 'e': 
                            ret = addr(new BuiltinType(Name:"decimal128"));
                            break;
                        case 'h': 
                            ret = addr(new BuiltinType(Name:"half"));
                            break;
                        case 's': 
                            ret = addr(new BuiltinType(Name:"char16_t"));
                            break;
                        case 'i': 
                            ret = addr(new BuiltinType(Name:"char32_t"));
                            break;
                        case 'n': 
                            ret = addr(new BuiltinType(Name:"decltype(nullptr)"));
                            break;
                        case 'F': 
                            var accum = false;
                            if (len(st.str) > 0L && isDigit(st.str[0L]))
                            {
                                accum = true; 
                                // We don't care about the bits.
                                _ = st.number();

                            }

                            var @base = st.demangleType(isCast);
                            if (len(st.str) > 0L && isDigit(st.str[0L]))
                            { 
                                // We don't care about the bits.
                                st.number();

                            }

                            var sat = false;
                            if (len(st.str) > 0L)
                            {
                                if (st.str[0L] == 's')
                                {
                                    sat = true;
                                }

                                st.advance(1L);

                            }

                            ret = addr(new FixedType(Base:base,Accum:accum,Sat:sat));
                            break;
                        case 'v': 
                            ret = st.vectorType(isCast);
                            addSubst = true;
                            break;
                        default: 
                            st.fail("unrecognized D code in type");
                            break;
                    }
                    break;
                default: 
                    st.fail("unrecognized type code");
                    break;
            }

            if (addSubst)
            {
                if (sub != null)
                {
                    st.subs.add(sub);
                }
                else
                {
                    st.subs.add(ret);
                }

            }

            if (len(q) > 0L)
            {
                {
                    (_, ok) = ret._<ptr<FunctionType>>();

                    if (ok)
                    {
                        ret = addr(new MethodWithQualifiers(Method:ret,Qualifiers:q,RefQualifier:""));
                    }                    {
                        ptr<MethodWithQualifiers> (mwq, ok) = ret._<ptr<MethodWithQualifiers>>();


                        else if (ok)
                        { 
                            // Merge adjacent qualifiers.  This case
                            // happens with a function with a trailing
                            // ref-qualifier.
                            mwq.Qualifiers = mergeQualifiers(q, mwq.Qualifiers);

                        }
                        else
                        { 
                            // Merge adjacent qualifiers.  This case
                            // happens with multi-dimensional array types.
                            {
                                ptr<TypeWithQualifiers> (qsub, ok) = ret._<ptr<TypeWithQualifiers>>();

                                if (ok)
                                {
                                    q = mergeQualifiers(q, qsub.Qualifiers);
                                    ret = qsub.Base;
                                }

                            }

                            ret = addr(new TypeWithQualifiers(Base:ret,Qualifiers:q));

                        }

                    }


                }

                st.subs.add(ret);

            }

            return ret;

        }

        // demangleCastTemplateArgs is for a rather hideous parse.  When we
        // see a template-param followed by a template-args, we need to decide
        // whether we have a template-param or a template-template-param.
        // Normally it is template-template-param, meaning that we pick up the
        // template arguments here.  But, if we are parsing the type for a
        // cast operator, then the only way this can be template-template-param
        // is if there is another set of template-args immediately after this
        // set.  That would look like this:
        //
        // <nested-name>
        // -> <template-prefix> <template-args>
        // -> <prefix> <template-unqualified-name> <template-args>
        // -> <unqualified-name> <template-unqualified-name> <template-args>
        // -> <source-name> <template-unqualified-name> <template-args>
        // -> <source-name> <operator-name> <template-args>
        // -> <source-name> cv <type> <template-args>
        // -> <source-name> cv <template-template-param> <template-args> <template-args>
        //
        // Otherwise, we have this derivation:
        //
        // <nested-name>
        // -> <template-prefix> <template-args>
        // -> <prefix> <template-unqualified-name> <template-args>
        // -> <unqualified-name> <template-unqualified-name> <template-args>
        // -> <source-name> <template-unqualified-name> <template-args>
        // -> <source-name> <operator-name> <template-args>
        // -> <source-name> cv <type> <template-args>
        // -> <source-name> cv <template-param> <template-args>
        //
        // in which the template-args are actually part of the prefix.  For
        // the special case where this arises, demangleType is called with
        // isCast as true.  This function is then responsible for checking
        // whether we see <template-param> <template-args> but there is not
        // another following <template-args>.  In that case, we reset the
        // parse and just return the <template-param>.
        private static AST demangleCastTemplateArgs(this ptr<state> _addr_st, AST tp, bool addSubst) => func((defer, panic, _) =>
        {
            ref state st = ref _addr_st.val;

            var save = st.copy();

            slice<AST> args = default;
            var failed = false;
            () =>
            {
                defer(() =>
                {
                    {
                        var r = recover();

                        if (r != null)
                        {
                            {
                                demangleErr (_, ok) = r._<demangleErr>();

                                if (ok)
                                {
                                    failed = true;
                                }
                                else
                                {
                                    panic(r);
                                }

                            }

                        }

                    }

                }());

                args = st.templateArgs();

            }();

            if (!failed && len(st.str) > 0L && st.str[0L] == 'I')
            {
                if (addSubst)
                {
                    st.subs.add(tp);
                }

                return addr(new Template(Name:tp,Args:args));

            } 
            // Reset back to before we started reading the template arguments.
            // They will be read again by st.prefix.
            st.val = save.val;
            return tp;

        });

        // mergeQualifiers merges two qualifer lists into one.
        private static Qualifiers mergeQualifiers(Qualifiers q1, Qualifiers q2)
        {
            var m = make_map<@string, bool>();
            {
                var qual__prev1 = qual;

                foreach (var (_, __qual) in q1)
                {
                    qual = __qual;
                    m[qual] = true;
                }

                qual = qual__prev1;
            }

            {
                var qual__prev1 = qual;

                foreach (var (_, __qual) in q2)
                {
                    qual = __qual;
                    if (!m[qual])
                    {
                        q1 = append(q1, qual);
                        m[qual] = true;
                    }

                }

                qual = qual__prev1;
            }

            return q1;

        }

        // qualifiers maps from the character used in the mangled name to the
        // string to print.
        private static map qualifiers = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<byte, @string>{'r':"restrict",'V':"volatile",'K':"const",};

        // <CV-qualifiers> ::= [r] [V] [K]
        private static Qualifiers cvQualifiers(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            Qualifiers q = default;
            while (len(st.str) > 0L)
            {
                {
                    var (qv, ok) = qualifiers[st.str[0L]];

                    if (ok)
                    {
                        q = append(new slice<@string>(new @string[] { qv }), q);
                        st.advance(1L);
                    }
                    else if (len(st.str) > 1L && st.str[..2L] == "Dx")
                    {
                        q = append(new slice<@string>(new @string[] { "transaction_safe" }), q);
                        st.advance(2L);
                    }
                    else
                    {
                        break;
                    }


                }

            }

            return q;

        }

        // <ref-qualifier> ::= R
        //                 ::= O
        private static @string refQualifier(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) > 0L)
            {
                switch (st.str[0L])
                {
                    case 'R': 
                        st.advance(1L);
                        return "&";
                        break;
                    case 'O': 
                        st.advance(1L);
                        return "&&";
                        break;
                }

            }

            return "";

        }

        // <type>+
        private static slice<AST> parmlist(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            slice<AST> ret = default;
            while (true)
            {
                if (len(st.str) < 1L)
                {
                    break;
                }

                if (st.str[0L] == 'E' || st.str[0L] == '.')
                {
                    break;
                }

                if ((st.str[0L] == 'R' || st.str[0L] == 'O') && len(st.str) > 1L && st.str[1L] == 'E')
                { 
                    // This is a function ref-qualifier.
                    break;

                }

                var ptype = st.demangleType(false);
                ret = append(ret, ptype);

            } 

            // There should always be at least one type.  A function that
            // takes no arguments will have a single parameter type
            // "void".
 

            // There should always be at least one type.  A function that
            // takes no arguments will have a single parameter type
            // "void".
            if (len(ret) == 0L)
            {
                st.fail("expected at least one type in type list");
            } 

            // Omit a single parameter type void.
            if (len(ret) == 1L)
            {
                {
                    ptr<BuiltinType> (bt, ok) = ret[0L]._<ptr<BuiltinType>>();

                    if (ok && bt.Name == "void")
                    {
                        ret = null;
                    }

                }

            }

            return ret;

        }

        // <function-type> ::= F [Y] <bare-function-type> [<ref-qualifier>] E
        private static AST functionType(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            st.checkChar('F');
            if (len(st.str) > 0L && st.str[0L] == 'Y')
            { 
                // Function has C linkage.  We don't print this.
                st.advance(1L);

            }

            var ret = st.bareFunctionType(true);
            var r = st.refQualifier();
            if (r != "")
            {
                ret = addr(new MethodWithQualifiers(Method:ret,Qualifiers:nil,RefQualifier:r));
            }

            if (len(st.str) == 0L || st.str[0L] != 'E')
            {
                st.fail("expected E after function type");
            }

            st.advance(1L);
            return ret;

        }

        // <bare-function-type> ::= [J]<type>+
        private static AST bareFunctionType(this ptr<state> _addr_st, bool hasReturnType)
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) > 0L && st.str[0L] == 'J')
            {
                hasReturnType = true;
                st.advance(1L);
            }

            AST returnType = default;
            if (hasReturnType)
            {
                returnType = st.demangleType(false);
            }

            var types = st.parmlist();
            return addr(new FunctionType(Return:returnType,Args:types));

        }

        // <array-type> ::= A <(positive dimension) number> _ <(element) type>
        //              ::= A [<(dimension) expression>] _ <(element) type>
        private static AST arrayType(this ptr<state> _addr_st, bool isCast)
        {
            ref state st = ref _addr_st.val;

            st.checkChar('A');

            if (len(st.str) == 0L)
            {
                st.fail("missing array dimension");
            }

            AST dim = default;
            if (st.str[0L] == '_')
            {
                dim = addr(new Name(Name:""));
            }
            else if (isDigit(st.str[0L]))
            {
                long i = 1L;
                while (len(st.str) > i && isDigit(st.str[i]))
                {
                    i++;
                }
            else

                dim = addr(new Name(Name:st.str[:i]));
                st.advance(i);

            }            {
                dim = st.expression();
            }

            if (len(st.str) == 0L || st.str[0L] != '_')
            {
                st.fail("expected _ after dimension");
            }

            st.advance(1L);

            var t = st.demangleType(isCast);

            ptr<ArrayType> arr = addr(new ArrayType(Dimension:dim,Element:t)); 

            // Qualifiers on the element of an array type go on the whole
            // array type.
            {
                ptr<TypeWithQualifiers> (q, ok) = arr.Element._<ptr<TypeWithQualifiers>>();

                if (ok)
                {
                    return addr(new TypeWithQualifiers(Base:&ArrayType{Dimension:dim,Element:q.Base},Qualifiers:q.Qualifiers));
                }

            }


            return arr;

        }

        // <vector-type> ::= Dv <number> _ <type>
        //               ::= Dv _ <expression> _ <type>
        private static AST vectorType(this ptr<state> _addr_st, bool isCast)
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) == 0L)
            {
                st.fail("expected vector dimension");
            }

            AST dim = default;
            if (st.str[0L] == '_')
            {
                st.advance(1L);
                dim = st.expression();
            }
            else
            {
                var num = st.number();
                dim = addr(new Name(Name:fmt.Sprintf("%d",num)));
            }

            if (len(st.str) == 0L || st.str[0L] != '_')
            {
                st.fail("expected _ after vector dimension");
            }

            st.advance(1L);

            var t = st.demangleType(isCast);

            return addr(new VectorType(Dimension:dim,Base:t));

        }

        // <pointer-to-member-type> ::= M <(class) type> <(member) type>
        private static AST pointerToMemberType(this ptr<state> _addr_st, bool isCast)
        {
            ref state st = ref _addr_st.val;

            st.checkChar('M');
            var cl = st.demangleType(false); 

            // The ABI says, "The type of a non-static member function is
            // considered to be different, for the purposes of
            // substitution, from the type of a namespace-scope or static
            // member function whose type appears similar. The types of
            // two non-static member functions are considered to be
            // different, for the purposes of substitution, if the
            // functions are members of different classes. In other words,
            // for the purposes of substitution, the class of which the
            // function is a member is considered part of the type of
            // function."
            //
            // For a pointer to member function, this call to demangleType
            // will end up adding a (possibly qualified) non-member
            // function type to the substitution table, which is not
            // correct; however, the member function type will never be
            // used in a substitution, so putting the wrong type in the
            // substitution table is harmless.
            var mem = st.demangleType(isCast);
            return addr(new PtrMem(Class:cl,Member:mem));

        }

        // <non-negative number> _ */
        private static long compactNumber(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) == 0L)
            {
                st.fail("missing index");
            }

            if (st.str[0L] == '_')
            {
                st.advance(1L);
                return 0L;
            }
            else if (st.str[0L] == 'n')
            {
                st.fail("unexpected negative number");
            }

            var n = st.number();
            if (len(st.str) == 0L || st.str[0L] != '_')
            {
                st.fail("missing underscore after number");
            }

            st.advance(1L);
            return n + 1L;

        }

        // <template-param> ::= T_
        //                  ::= T <(parameter-2 non-negative) number> _
        //
        // When a template parameter is a substitution candidate, any
        // reference to that substitution refers to the template parameter
        // with the same index in the currently active template, not to
        // whatever the template parameter would be expanded to here.  We sort
        // this out in substitution and simplify.
        private static AST templateParam(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            if (len(st.templates) == 0L)
            {
                st.fail("template parameter not in scope of template");
            }

            var off = st.off;

            st.checkChar('T');
            var n = st.compactNumber();

            var template = st.templates[len(st.templates) - 1L];

            if (template == null)
            { 
                // We are parsing a cast operator.  If the cast is
                // itself a template, then this is a forward
                // reference.  Fill it in later.
                return addr(new TemplateParam(Index:n,Template:nil));

            }

            if (n >= len(template.Args))
            {
                st.failEarlier(fmt.Sprintf("template index out of range (%d >= %d)", n, len(template.Args)), st.off - off);
            }

            return addr(new TemplateParam(Index:n,Template:template));

        }

        // setTemplate sets the Template field of any TemplateParam's in a.
        // This handles the forward referencing template parameters found in
        // cast operators.
        private static void setTemplate(this ptr<state> _addr_st, AST a, ptr<Template> _addr_tmpl)
        {
            ref state st = ref _addr_st.val;
            ref Template tmpl = ref _addr_tmpl.val;

            slice<AST> seen = default;
            a.Traverse(a =>
            {
                switch (a.type())
                {
                    case ptr<TemplateParam> a:
                        if (a.Template != null)
                        {
                            if (tmpl != null)
                            {
                                st.fail("duplicate template parameters");
                            }

                            return false;

                        }

                        if (tmpl == null)
                        {
                            st.fail("cast template parameter not in scope of template");
                        }

                        if (a.Index >= len(tmpl.Args))
                        {
                            st.fail(fmt.Sprintf("cast template index out of range (%d >= %d)", a.Index, len(tmpl.Args)));
                        }

                        a.Template = tmpl;
                        return false;
                        break;
                    default:
                    {
                        var a = a.type();
                        foreach (var (_, v) in seen)
                        {
                            if (v == a)
                            {
                                return false;
                            }

                        }
                        seen = append(seen, a);
                        return true;
                        break;
                    }
                }

            });

        }

        // clearTemplateArgs gives an error for any unset Template field in
        // args.  This handles erroneous cases where a cast operator with a
        // forward referenced template is in the scope of another cast
        // operator.
        private static void clearTemplateArgs(this ptr<state> _addr_st, slice<AST> args)
        {
            ref state st = ref _addr_st.val;

            foreach (var (_, a) in args)
            {
                st.setTemplate(a, null);
            }

        }

        // <template-args> ::= I <template-arg>+ E
        private static slice<AST> templateArgs(this ptr<state> _addr_st) => func((_, panic, __) =>
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) == 0L || (st.str[0L] != 'I' && st.str[0L] != 'J'))
            {
                panic("internal error");
            }

            st.advance(1L);

            slice<AST> ret = default;
            while (len(st.str) == 0L || st.str[0L] != 'E')
            {
                var arg = st.templateArg();
                ret = append(ret, arg);
            }

            st.advance(1L);
            return ret;

        });

        // <template-arg> ::= <type>
        //                ::= X <expression> E
        //                ::= <expr-primary>
        private static AST templateArg(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) == 0L)
            {
                st.fail("missing template argument");
            }

            switch (st.str[0L])
            {
                case 'X': 
                    st.advance(1L);
                    var expr = st.expression();
                    if (len(st.str) == 0L || st.str[0L] != 'E')
                    {
                        st.fail("missing end of expression");
                    }

                    st.advance(1L);
                    return expr;
                    break;
                case 'L': 
                    return st.exprPrimary();
                    break;
                case 'I': 

                case 'J': 
                    var args = st.templateArgs();
                    return addr(new ArgumentPack(Args:args));
                    break;
                default: 
                    return st.demangleType(false);
                    break;
            }

        }

        // exprList parses a sequence of expressions up to a terminating character.
        private static AST exprList(this ptr<state> _addr_st, byte stop)
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) > 0L && st.str[0L] == stop)
            {
                st.advance(1L);
                return addr(new ExprList(Exprs:nil));
            }

            slice<AST> exprs = default;
            while (true)
            {
                var e = st.expression();
                exprs = append(exprs, e);
                if (len(st.str) > 0L && st.str[0L] == stop)
                {
                    st.advance(1L);
                    break;
                }

            }

            return addr(new ExprList(Exprs:exprs));

        }

        // <expression> ::= <(unary) operator-name> <expression>
        //              ::= <(binary) operator-name> <expression> <expression>
        //              ::= <(trinary) operator-name> <expression> <expression> <expression>
        //              ::= cl <expression>+ E
        //              ::= st <type>
        //              ::= <template-param>
        //              ::= sr <type> <unqualified-name>
        //              ::= sr <type> <unqualified-name> <template-args>
        //              ::= <expr-primary>
        private static AST expression(this ptr<state> _addr_st) => func((_, panic, __) =>
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) == 0L)
            {
                st.fail("expected expression");
            }

            if (st.str[0L] == 'L')
            {
                return st.exprPrimary();
            }
            else if (st.str[0L] == 'T')
            {
                return st.templateParam();
            }
            else if (st.str[0L] == 's' && len(st.str) > 1L && st.str[1L] == 'r')
            {
                st.advance(2L);
                if (len(st.str) == 0L)
                {
                    st.fail("expected unresolved type");
                }

                switch (st.str[0L])
                {
                    case 'T': 

                    case 'D': 

                    case 'S': 
                        var t = st.demangleType(false);
                        var n = st.baseUnresolvedName();
                        n = addr(new Qualified(Scope:t,Name:n,LocalName:false));
                        if (len(st.str) > 0L && st.str[0L] == 'I')
                        {
                            var args = st.templateArgs();
                            n = addr(new Template(Name:n,Args:args));
                        }

                        return n;
                        break;
                    default: 
                        AST s = default;
                        if (st.str[0L] == 'N')
                        {
                            st.advance(1L);
                            s = st.demangleType(false);
                        }

                        while (len(st.str) == 0L || st.str[0L] != 'E')
                        { 
                            // GCC does not seem to follow the ABI here.
                            // It can emit type/name without an 'E'.
                            if (s != null && len(st.str) > 0L && !isDigit(st.str[0L]))
                            {
                                {
                                    ptr<Qualified> (q, ok) = s._<ptr<Qualified>>();

                                    if (ok)
                                    {
                                        var a = q.Scope;
                                        {
                                            var t__prev6 = t;

                                            ptr<Template> (t, ok) = a._<ptr<Template>>();

                                            if (ok)
                                            {
                                                st.subs.add(t.Name);
                                                st.subs.add(t);
                                            }
                                            else
                                            {
                                                st.subs.add(a);
                                            }

                                            t = t__prev6;

                                        }

                                        return s;

                                    }

                                }

                            }

                            n = st.sourceName();
                            if (len(st.str) > 0L && st.str[0L] == 'I')
                            {
                                st.subs.add(n);
                                args = st.templateArgs();
                                n = addr(new Template(Name:n,Args:args));
                            }

                            if (s == null)
                            {
                                s = n;
                            }
                            else
                            {
                                s = addr(new Qualified(Scope:s,Name:n,LocalName:false));
                            }

                            st.subs.add(s);

                        }

                        if (s == null)
                        {
                            st.fail("missing scope in unresolved name");
                        }

                        st.advance(1L);
                        n = st.baseUnresolvedName();
                        return addr(new Qualified(Scope:s,Name:n,LocalName:false));
                        break;
                }

            }
            else if (st.str[0L] == 's' && len(st.str) > 1L && st.str[1L] == 'p')
            {
                st.advance(2L);
                var e = st.expression();
                var pack = st.findArgumentPack(e);
                return addr(new PackExpansion(Base:e,Pack:pack));
            }
            else if (st.str[0L] == 's' && len(st.str) > 1L && st.str[1L] == 'Z')
            {
                st.advance(2L);
                var off = st.off;
                e = st.expression();
                var ap = st.findArgumentPack(e);
                if (ap == null)
                {
                    st.failEarlier("missing argument pack", st.off - off);
                }

                return addr(new SizeofPack(Pack:ap));

            }
            else if (st.str[0L] == 's' && len(st.str) > 1L && st.str[1L] == 'P')
            {
                st.advance(2L);
                args = default;
                while (len(st.str) == 0L || st.str[0L] != 'E')
                {
                    var arg = st.templateArg();
                    args = append(args, arg);
                }

                st.advance(1L);
                return addr(new SizeofArgs(Args:args));

            }
            else if (st.str[0L] == 'f' && len(st.str) > 1L && st.str[1L] == 'p')
            {
                st.advance(2L);
                if (len(st.str) > 0L && st.str[0L] == 'T')
                {
                    st.advance(1L);
                    return addr(new FunctionParam(Index:0));
                }
                else
                {
                    var index = st.compactNumber();
                    return addr(new FunctionParam(Index:index+1));
                }

            }
            else if (isDigit(st.str[0L]) || (st.str[0L] == 'o' && len(st.str) > 1L && st.str[1L] == 'n'))
            {
                if (st.str[0L] == 'o')
                { 
                    // Skip operator function ID.
                    st.advance(2L);

                }

                var (n, _) = st.unqualifiedName();
                if (len(st.str) > 0L && st.str[0L] == 'I')
                {
                    args = st.templateArgs();
                    n = addr(new Template(Name:n,Args:args));
                }

                return n;

            }
            else if ((st.str[0L] == 'i' || st.str[0L] == 't') && len(st.str) > 1L && st.str[1L] == 'l')
            { 
                // Brace-enclosed initializer list.
                var c = st.str[0L];
                st.advance(2L);
                t = default;
                if (c == 't')
                {
                    t = st.demangleType(false);
                }

                var exprs = st.exprList('E');
                return addr(new InitializerList(Type:t,Exprs:exprs));

            }
            else if (st.str[0L] == 's' && len(st.str) > 1L && st.str[1L] == 't')
            {
                var (o, _) = st.operatorName(true);
                t = st.demangleType(false);
                return addr(new Unary(Op:o,Expr:t,Suffix:false,SizeofType:true));
            }
            else
            {
                if (len(st.str) < 2L)
                {
                    st.fail("missing operator code");
                }

                var code = st.str[..2L];
                var (o, args) = st.operatorName(true);
                switch (args)
                {
                    case 0L: 
                        return addr(new Nullary(Op:o));
                        break;
                    case 1L: 
                        var suffix = false;
                        if (code == "pp" || code == "mm")
                        {
                            if (len(st.str) > 0L && st.str[0L] == '_')
                            {
                                st.advance(1L);
                            }
                            else
                            {
                                suffix = true;
                            }

                        }

                        AST operand = default;
                        {
                            ptr<Cast> (_, ok) = o._<ptr<Cast>>();

                            if (ok && len(st.str) > 0L && st.str[0L] == '_')
                            {
                                st.advance(1L);
                                operand = st.exprList('E');
                            }
                            else
                            {
                                operand = st.expression();
                            }

                        }

                        return addr(new Unary(Op:o,Expr:operand,Suffix:suffix,SizeofType:false));
                        break;
                    case 2L: 
                        AST left = default;                    AST right = default;

                        if (code == "sc" || code == "dc" || code == "cc" || code == "rc")
                        {
                            left = st.demangleType(false);
                        }
                        else if (code[0L] == 'f')
                        {
                            left, _ = st.operatorName(true);
                            right = st.expression();
                            return addr(new Fold(Left:code[1]=='l',Op:left,Arg1:right,Arg2:nil));
                        }
                        else
                        {
                            left = st.expression();
                        }

                        if (code == "cl")
                        {
                            right = st.exprList('E');
                        }
                        else if (code == "dt" || code == "pt")
                        {
                            right, _ = st.unqualifiedName();
                            if (len(st.str) > 0L && st.str[0L] == 'I')
                            {
                                args = st.templateArgs();
                                right = addr(new Template(Name:right,Args:args));
                            }

                        }
                        else
                        {
                            right = st.expression();
                        }

                        return addr(new Binary(Op:o,Left:left,Right:right));
                        break;
                    case 3L: 
                        if (code[0L] == 'n')
                        {
                            if (code[1L] != 'w' && code[1L] != 'a')
                            {
                                panic("internal error");
                            }

                            var place = st.exprList('_');
                            if (place._<ptr<ExprList>>().Exprs == null)
                            {
                                place = null;
                            }

                            t = st.demangleType(false);
                            AST ini = default;
                            if (len(st.str) > 0L && st.str[0L] == 'E')
                            {
                                st.advance(1L);
                            }
                            else if (len(st.str) > 1L && st.str[0L] == 'p' && st.str[1L] == 'i')
                            { 
                                // Parenthesized initializer.
                                st.advance(2L);
                                ini = st.exprList('E');

                            }
                            else if (len(st.str) > 1L && st.str[0L] == 'i' && st.str[1L] == 'l')
                            { 
                                // Initializer list.
                                ini = st.expression();

                            }
                            else
                            {
                                st.fail("unrecognized new initializer");
                            }

                            return addr(new New(Op:o,Place:place,Type:t,Init:ini));

                        }
                        else if (code[0L] == 'f')
                        {
                            var (first, _) = st.operatorName(true);
                            var second = st.expression();
                            var third = st.expression();
                            return addr(new Fold(Left:code[1]=='L',Op:first,Arg1:second,Arg2:third));
                        }
                        else
                        {
                            var first = st.expression();
                            second = st.expression();
                            third = st.expression();
                            return addr(new Trinary(Op:o,First:first,Second:second,Third:third));
                        }

                        break;
                    default: 
                        st.fail(fmt.Sprintf("unsupported number of operator arguments: %d", args));
                        panic("not reached");
                        break;
                }

            }

        });

        // <base-unresolved-name> ::= <simple-id>
        //                        ::= on <operator-name>
        //                        ::= on <operator-name> <template-args>
        //                        ::= dn <destructor-name>
        //
        //<simple-id> ::= <source-name> [ <template-args> ]
        private static AST baseUnresolvedName(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            AST n = default;
            if (len(st.str) >= 2L && st.str[..2L] == "on")
            {
                st.advance(2L);
                n, _ = st.operatorName(true);
            }
            else if (len(st.str) >= 2L && st.str[..2L] == "dn")
            {
                st.advance(2L);
                if (len(st.str) > 0L && isDigit(st.str[0L]))
                {
                    n = st.sourceName();
                }
                else
                {
                    n = st.demangleType(false);
                }

                n = addr(new Destructor(Name:n));

            }
            else if (len(st.str) > 0L && isDigit(st.str[0L]))
            {
                n = st.sourceName();
            }
            else
            { 
                // GCC seems to not follow the ABI here: it can have
                // an operator name without on.
                // See https://gcc.gnu.org/PR70182.
                n, _ = st.operatorName(true);

            }

            if (len(st.str) > 0L && st.str[0L] == 'I')
            {
                var args = st.templateArgs();
                n = addr(new Template(Name:n,Args:args));
            }

            return n;

        }

        // <expr-primary> ::= L <type> <(value) number> E
        //                ::= L <type> <(value) float> E
        //                ::= L <mangled-name> E
        private static AST exprPrimary(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            st.checkChar('L');
            if (len(st.str) == 0L)
            {
                st.fail("expected primary expression");
            } 

            // Check for 'Z' here because g++ incorrectly omitted the
            // underscore until -fabi-version=3.
            AST ret = default;
            if (st.str[0L] == '_' || st.str[0L] == 'Z')
            {
                if (st.str[0L] == '_')
                {
                    st.advance(1L);
                }

                if (len(st.str) == 0L || st.str[0L] != 'Z')
                {
                    st.fail("expected mangled name");
                }

                st.advance(1L);
                ret = st.encoding(true, notForLocalName);

            }
            else
            {
                var t = st.demangleType(false);

                var neg = false;
                if (len(st.str) > 0L && st.str[0L] == 'n')
                {
                    neg = true;
                    st.advance(1L);
                }

                if (len(st.str) > 0L && st.str[0L] == 'E')
                {
                    st.fail("missing literal value");
                }

                long i = 0L;
                while (len(st.str) > i && st.str[i] != 'E')
                {
                    i++;
                }

                var val = st.str[..i];
                st.advance(i);
                ret = addr(new Literal(Type:t,Val:val,Neg:neg));

            }

            if (len(st.str) == 0L || st.str[0L] != 'E')
            {
                st.fail("expected E after literal");
            }

            st.advance(1L);
            return ret;

        }

        // <discriminator> ::= _ <(non-negative) number>
        private static AST discriminator(this ptr<state> _addr_st, AST a)
        {
            ref state st = ref _addr_st.val;

            if (len(st.str) == 0L || st.str[0L] != '_')
            {
                return a;
            }

            var off = st.off;
            st.advance(1L);
            var d = st.number();
            if (d < 0L)
            {
                st.failEarlier("invalid negative discriminator", st.off - off);
            } 
            // We don't currently print out the discriminator, so we don't
            // save it.
            return a;

        }

        // <closure-type-name> ::= Ul <lambda-sig> E [ <nonnegative number> ] _
        private static AST closureTypeName(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            st.checkChar('U');
            st.checkChar('l');
            var types = st.parmlist();
            if (len(st.str) == 0L || st.str[0L] != 'E')
            {
                st.fail("expected E after closure type name");
            }

            st.advance(1L);
            var num = st.compactNumber();
            ptr<Closure> ret = addr(new Closure(Types:types,Num:num));
            st.subs.add(ret);
            return ret;

        }

        // <unnamed-type-name> ::= Ut [ <nonnegative number> ] _
        private static AST unnamedTypeName(this ptr<state> _addr_st)
        {
            ref state st = ref _addr_st.val;

            st.checkChar('U');
            st.checkChar('t');
            var num = st.compactNumber();
            ptr<UnnamedType> ret = addr(new UnnamedType(Num:num));
            st.subs.add(ret);
            return ret;
        }

        // Recognize a clone suffix.  These are not part of the mangling API,
        // but are added by GCC when cloning functions.
        private static AST cloneSuffix(this ptr<state> _addr_st, AST a)
        {
            ref state st = ref _addr_st.val;

            long i = 0L;
            if (len(st.str) > 1L && st.str[0L] == '.' && (isLower(st.str[1L]) || st.str[1L] == '_'))
            {
                i += 2L;
                while (len(st.str) > i && (isLower(st.str[i]) || st.str[i] == '_'))
                {
                    i++;
                }


            }

            while (len(st.str) > i + 1L && st.str[i] == '.' && isDigit(st.str[i + 1L]))
            {
                i += 2L;
                while (len(st.str) > i && isDigit(st.str[i]))
                {
                    i++;
                }


            }

            var suffix = st.str[..i];
            st.advance(i);
            return addr(new Clone(Base:a,Suffix:suffix));

        }

        // substitutions is the list of substitution candidates that may
        // appear later in the string.
        private partial struct substitutions // : slice<AST>
        {
        }

        // add adds a new substitution candidate.
        private static void add(this ptr<substitutions> _addr_subs, AST a)
        {
            ref substitutions subs = ref _addr_subs.val;

            subs.val = append(subs.val, a);
        }

        // subAST maps standard substitution codes to the corresponding AST.
        private static map subAST = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<byte, AST>{'t':&Name{Name:"std"},'a':&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"allocator"}},'b':&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"basic_string"}},'s':&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"string"}},'i':&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"istream"}},'o':&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"ostream"}},'d':&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"iostream"}},};

        // verboseAST maps standard substitution codes to the long form of the
        // corresponding AST.  We use this when the Verbose option is used, to
        // match the standard demangler.
        private static map verboseAST = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<byte, AST>{'t':&Name{Name:"std"},'a':&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"allocator"}},'b':&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"basic_string"}},'s':&Template{Name:&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"basic_string"}},Args:[]AST{&BuiltinType{Name:"char"},&Template{Name:&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"char_traits"}},Args:[]AST{&BuiltinType{Name:"char"}}},&Template{Name:&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"allocator"}},Args:[]AST{&BuiltinType{Name:"char"}}}}},'i':&Template{Name:&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"basic_istream"}},Args:[]AST{&BuiltinType{Name:"char"},&Template{Name:&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"char_traits"}},Args:[]AST{&BuiltinType{Name:"char"}}}}},'o':&Template{Name:&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"basic_ostream"}},Args:[]AST{&BuiltinType{Name:"char"},&Template{Name:&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"char_traits"}},Args:[]AST{&BuiltinType{Name:"char"}}}}},'d':&Template{Name:&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"basic_iostream"}},Args:[]AST{&BuiltinType{Name:"char"},&Template{Name:&Qualified{Scope:&Name{Name:"std"},Name:&Name{Name:"char_traits"}},Args:[]AST{&BuiltinType{Name:"char"}}}}},};

        // <substitution> ::= S <seq-id> _
        //                ::= S_
        //                ::= St
        //                ::= Sa
        //                ::= Sb
        //                ::= Ss
        //                ::= Si
        //                ::= So
        //                ::= Sd
        private static AST substitution(this ptr<state> _addr_st, bool forPrefix)
        {
            ref state st = ref _addr_st.val;

            st.checkChar('S');
            if (len(st.str) == 0L)
            {
                st.fail("missing substitution index");
            }

            var c = st.str[0L];
            st.advance(1L);
            long dec = 1L;
            if (c == '_' || isDigit(c) || isUpper(c))
            {
                long id = 0L;
                if (c != '_')
                {
                    while (c != '_')
                    { 
                        // Don't overflow a 32-bit int.
                        if (id >= 0x80000000UL / 36L - 36L)
                        {
                            st.fail("substitution index overflow");
                        }

                        if (isDigit(c))
                        {
                            id = id * 36L + int(c - '0');
                        }
                        else if (isUpper(c))
                        {
                            id = id * 36L + int(c - 'A') + 10L;
                        }
                        else
                        {
                            st.fail("invalid character in substitution index");
                        }

                        if (len(st.str) == 0L)
                        {
                            st.fail("missing end to substitution index");
                        }

                        c = st.str[0L];
                        st.advance(1L);
                        dec++;

                    }

                    id++;

                }
            else


                if (id >= len(st.subs))
                {
                    st.failEarlier(fmt.Sprintf("substitution index out of range (%d >= %d)", id, len(st.subs)), dec);
                }

                var ret = st.subs[id]; 

                // We need to update any references to template
                // parameters to refer to the currently active
                // template.
                Func<AST, AST> copy = a =>
                {
                    ptr<TemplateParam> (tp, ok) = a._<ptr<TemplateParam>>();
                    if (!ok)
                    {
                        return null;
                    }

                    if (len(st.templates) == 0L)
                    {
                        st.failEarlier("substituted template parameter not in scope of template", dec);
                    }

                    var template = st.templates[len(st.templates) - 1L];
                    if (template == null)
                    { 
                        // This template parameter is within
                        // the scope of a cast operator.
                        return addr(new TemplateParam(Index:tp.Index,Template:nil));

                    }

                    if (tp.Index >= len(template.Args))
                    {
                        st.failEarlier(fmt.Sprintf("substituted template index out of range (%d >= %d)", tp.Index, len(template.Args)), dec);
                    }

                    return addr(new TemplateParam(Index:tp.Index,Template:template));

                }
;
                slice<AST> seen = default;
                Func<AST, bool> skip = a =>
                {
                    {
                        ptr<Typed> (_, ok) = a._<ptr<Typed>>();

                        if (ok)
                        {
                            return true;
                        }

                    }

                    foreach (var (_, v) in seen)
                    {
                        if (v == a)
                        {
                            return true;
                        }

                    }
                    seen = append(seen, a);
                    return false;

                }
;
                {
                    var c__prev2 = c;

                    c = ret.Copy(copy, skip);

                    if (c != null)
                    {
                        return c;
                    }

                    c = c__prev2;

                }


                return ret;

            }            {
                var m = subAST;
                if (st.verbose)
                {
                    m = verboseAST;
                } 
                // For compatibility with the standard demangler, use
                // a longer name for a constructor or destructor.
                if (forPrefix && len(st.str) > 0L && (st.str[0L] == 'C' || st.str[0L] == 'D'))
                {
                    m = verboseAST;
                }

                var (a, ok) = m[c];
                if (!ok)
                {
                    st.failEarlier("unrecognized substitution code", 1L);
                }

                if (len(st.str) > 0L && st.str[0L] == 'B')
                {
                    a = st.taggedName(a);
                }

                return a;

            }

        }

        // isDigit returns whetner c is a digit for demangling purposes.
        private static bool isDigit(byte c)
        {
            return c >= '0' && c <= '9';
        }

        // isUpper returns whether c is an upper case letter for demangling purposes.
        private static bool isUpper(byte c)
        {
            return c >= 'A' && c <= 'Z';
        }

        // isLower returns whether c is a lower case letter for demangling purposes.
        private static bool isLower(byte c)
        {
            return c >= 'a' && c <= 'z';
        }

        // simplify replaces template parameters with their expansions, and
        // merges qualifiers.
        private static AST simplify(AST a)
        {
            slice<AST> seen = default;
            Func<AST, bool> skip = a =>
            {
                foreach (var (_, v) in seen)
                {
                    if (v == a)
                    {
                        return true;
                    }

                }
                seen = append(seen, a);
                return false;

            }
;
            {
                var r = a.Copy(simplifyOne, skip);

                if (r != null)
                {
                    return r;
                }

            }

            return a;

        }

        // simplifyOne simplifies a single AST.  It returns nil if there is
        // nothing to do.
        private static AST simplifyOne(AST a)
        {
            switch (a.type())
            {
                case ptr<TemplateParam> a:
                    if (a.Template != null && a.Index < len(a.Template.Args))
                    {
                        return a.Template.Args[a.Index];
                    }

                    break;
                case ptr<MethodWithQualifiers> a:
                    {
                        ptr<MethodWithQualifiers> m__prev1 = m;

                        ptr<MethodWithQualifiers> (m, ok) = a.Method._<ptr<MethodWithQualifiers>>();

                        if (ok)
                        {
                            var @ref = a.RefQualifier;
                            if (ref == "")
                            {
                                ref = m.RefQualifier;
                            }
                            else if (m.RefQualifier != "")
                            {
                                if (ref == "&" || m.RefQualifier == "&")
                                {
                                    ref = "&";
                                }

                            }

                            return addr(new MethodWithQualifiers(Method:m.Method,Qualifiers:mergeQualifiers(a.Qualifiers,m.Qualifiers),RefQualifier:ref));

                        }

                        m = m__prev1;

                    }

                    {
                        ptr<TypeWithQualifiers> t__prev1 = t;

                        ptr<TypeWithQualifiers> (t, ok) = a.Method._<ptr<TypeWithQualifiers>>();

                        if (ok)
                        {
                            return addr(new MethodWithQualifiers(Method:t.Base,Qualifiers:mergeQualifiers(a.Qualifiers,t.Qualifiers),RefQualifier:a.RefQualifier));
                        }

                        t = t__prev1;

                    }

                    break;
                case ptr<TypeWithQualifiers> a:
                    {
                        ptr<FunctionType> (ft, ok) = a.Base._<ptr<FunctionType>>();

                        if (ok)
                        {
                            return addr(new MethodWithQualifiers(Method:ft,Qualifiers:a.Qualifiers,RefQualifier:""));
                        }

                    }

                    {
                        ptr<TypeWithQualifiers> t__prev1 = t;

                        (t, ok) = a.Base._<ptr<TypeWithQualifiers>>();

                        if (ok)
                        {
                            return addr(new TypeWithQualifiers(Base:t.Base,Qualifiers:mergeQualifiers(a.Qualifiers,t.Qualifiers)));
                        }

                        t = t__prev1;

                    }

                    {
                        ptr<MethodWithQualifiers> m__prev1 = m;

                        (m, ok) = a.Base._<ptr<MethodWithQualifiers>>();

                        if (ok)
                        {
                            return addr(new MethodWithQualifiers(Method:m.Method,Qualifiers:mergeQualifiers(a.Qualifiers,m.Qualifiers),RefQualifier:m.RefQualifier));
                        }

                        m = m__prev1;

                    }

                    break;
                case ptr<ReferenceType> a:
                    {
                        ptr<ReferenceType> rt__prev1 = rt;

                        ptr<ReferenceType> (rt, ok) = a.Base._<ptr<ReferenceType>>();

                        if (ok)
                        {
                            return rt;
                        }

                        rt = rt__prev1;

                    }

                    {
                        ptr<RvalueReferenceType> rrt__prev1 = rrt;

                        ptr<RvalueReferenceType> (rrt, ok) = a.Base._<ptr<RvalueReferenceType>>();

                        if (ok)
                        {
                            return addr(new ReferenceType(Base:rrt.Base));
                        }

                        rrt = rrt__prev1;

                    }

                    break;
                case ptr<RvalueReferenceType> a:
                    {
                        ptr<RvalueReferenceType> rrt__prev1 = rrt;

                        (rrt, ok) = a.Base._<ptr<RvalueReferenceType>>();

                        if (ok)
                        {
                            return rrt;
                        }

                        rrt = rrt__prev1;

                    }

                    {
                        ptr<ReferenceType> rt__prev1 = rt;

                        (rt, ok) = a.Base._<ptr<ReferenceType>>();

                        if (ok)
                        {
                            return rt;
                        }

                        rt = rt__prev1;

                    }

                    break;
                case ptr<ArrayType> a:
                    {
                        ptr<TypeWithQualifiers> (q, ok) = a.Element._<ptr<TypeWithQualifiers>>();

                        if (ok)
                        {
                            return addr(new TypeWithQualifiers(Base:&ArrayType{Dimension:a.Dimension,Element:q.Base},Qualifiers:q.Qualifiers,));
                        }

                    }

                    break;
                case ptr<PackExpansion> a:
                    if (a.Pack != null)
                    {
                        var exprs = make_slice<AST>(len(a.Pack.Args));
                        foreach (var (i, arg) in a.Pack.Args)
                        {
                            Func<AST, AST> copy = sub =>
                            { 
                                // Replace the ArgumentPack
                                // with a specific argument.
                                if (sub == a.Pack)
                                {
                                    return arg;
                                } 
                                // Copy everything else.
                                return null;

                            }
;

                            slice<AST> seen = default;
                            Func<AST, bool> skip = sub =>
                            { 
                                // Don't traverse into another
                                // pack expansion.
                                {
                                    ptr<PackExpansion> (_, ok) = sub._<ptr<PackExpansion>>();

                                    if (ok)
                                    {
                                        return true;
                                    }

                                }

                                foreach (var (_, v) in seen)
                                {
                                    if (v == sub)
                                    {
                                        return true;
                                    }

                                }
                                seen = append(seen, sub);
                                return false;

                            }
;

                            var b = a.Base.Copy(copy, skip);
                            if (b == null)
                            {
                                b = a.Base;
                            }

                            exprs[i] = simplify(b);

                        }
                        return addr(new ExprList(Exprs:exprs));

                    }

                    break;
            }
            return null;

        }

        // findArgumentPack walks the AST looking for the argument pack for a
        // pack expansion.  We find it via a template parameter.
        private static ptr<ArgumentPack> findArgumentPack(this ptr<state> _addr_st, AST a)
        {
            ref state st = ref _addr_st.val;

            slice<AST> seen = default;
            ptr<ArgumentPack> ret;
            a.Traverse(a =>
            {
                if (ret != null)
                {
                    return _addr_false!;
                }

                switch (a.type())
                {
                    case ptr<TemplateParam> a:
                        if (a.Template == null || a.Index >= len(a.Template.Args))
                        {
                            return _addr_true!;
                        }

                        {
                            ptr<ArgumentPack> (pack, ok) = a.Template.Args[a.Index]._<ptr<ArgumentPack>>();

                            if (ok)
                            {
                                ret = pack;
                                return _addr_false!;
                            }

                        }

                        break;
                    case ptr<PackExpansion> a:
                        return _addr_false!;
                        break;
                    case ptr<Closure> a:
                        return _addr_false!;
                        break;
                    case ptr<Name> a:
                        return _addr_false!;
                        break;
                    case ptr<TaggedName> a:
                        return _addr_false!;
                        break;
                    case ptr<Operator> a:
                        return _addr_false!;
                        break;
                    case ptr<BuiltinType> a:
                        return _addr_false!;
                        break;
                    case ptr<FunctionParam> a:
                        return _addr_false!;
                        break;
                    case ptr<UnnamedType> a:
                        return _addr_false!;
                        break;
                    case ptr<FixedType> a:
                        return _addr_false!;
                        break;
                    case ptr<DefaultArg> a:
                        return _addr_false!;
                        break;
                }
                foreach (var (_, v) in seen)
                {
                    if (v == a)
                    {
                        return _addr_false!;
                    }

                }
                seen = append(seen, a);
                return _addr_true!;

            });
            return _addr_ret!;

        }
    }
}}}}}
