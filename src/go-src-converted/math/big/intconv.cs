// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// This file implements int-to-string conversion functions.

// package big -- go2cs converted at 2020 October 08 03:25:41 UTC
// import "math/big" ==> using big = go.math.big_package
// Original source: C:\Go\src\math\big\intconv.go
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using static go.builtin;

namespace go {
namespace math
{
    public static partial class big_package
    {
        // Text returns the string representation of x in the given base.
        // Base must be between 2 and 62, inclusive. The result uses the
        // lower-case letters 'a' to 'z' for digit values 10 to 35, and
        // the upper-case letters 'A' to 'Z' for digit values 36 to 61.
        // No prefix (such as "0x") is added to the string. If x is a nil
        // pointer it returns "<nil>".
        private static @string Text(this ptr<Int> _addr_x, long @base)
        {
            ref Int x = ref _addr_x.val;

            if (x == null)
            {
                return "<nil>";
            }
            return string(x.abs.itoa(x.neg, base));

        }

        // Append appends the string representation of x, as generated by
        // x.Text(base), to buf and returns the extended buffer.
        private static slice<byte> Append(this ptr<Int> _addr_x, slice<byte> buf, long @base)
        {
            ref Int x = ref _addr_x.val;

            if (x == null)
            {
                return append(buf, "<nil>");
            }

            return append(buf, x.abs.itoa(x.neg, base));

        }

        // String returns the decimal representation of x as generated by
        // x.Text(10).
        private static @string String(this ptr<Int> _addr_x)
        {
            ref Int x = ref _addr_x.val;

            return x.Text(10L);
        }

        // write count copies of text to s
        private static void writeMultiple(fmt.State s, @string text, long count)
        {
            if (len(text) > 0L)
            {
                slice<byte> b = (slice<byte>)text;
                while (count > 0L)
                {
                    s.Write(b);
                    count--;
                }


            }

        }

        private static fmt.Formatter _ = intOne; // *Int must implement fmt.Formatter

        // Format implements fmt.Formatter. It accepts the formats
        // 'b' (binary), 'o' (octal with 0 prefix), 'O' (octal with 0o prefix),
        // 'd' (decimal), 'x' (lowercase hexadecimal), and
        // 'X' (uppercase hexadecimal).
        // Also supported are the full suite of package fmt's format
        // flags for integral types, including '+' and ' ' for sign
        // control, '#' for leading zero in octal and for hexadecimal,
        // a leading "0x" or "0X" for "%#x" and "%#X" respectively,
        // specification of minimum digits precision, output field
        // width, space or zero padding, and '-' for left or right
        // justification.
        //
        private static void Format(this ptr<Int> _addr_x, fmt.State s, int ch)
        {
            ref Int x = ref _addr_x.val;
 
            // determine base
            long @base = default;
            switch (ch)
            {
                case 'b': 
                    base = 2L;
                    break;
                case 'o': 

                case 'O': 
                    base = 8L;
                    break;
                case 'd': 

                case 's': 

                case 'v': 
                    base = 10L;
                    break;
                case 'x': 

                case 'X': 
                    base = 16L;
                    break;
                default: 
                    // unknown format
                    fmt.Fprintf(s, "%%!%c(big.Int=%s)", ch, x.String());
                    return ;
                    break;
            }

            if (x == null)
            {
                fmt.Fprint(s, "<nil>");
                return ;
            } 

            // determine sign character
            @string sign = "";

            if (x.neg) 
                sign = "-";
            else if (s.Flag('+')) // supersedes ' ' when both specified
                sign = "+";
            else if (s.Flag(' ')) 
                sign = " ";
            // determine prefix characters for indicating output base
            @string prefix = "";
            if (s.Flag('#'))
            {
                switch (ch)
                {
                    case 'b': // binary
                        prefix = "0b";
                        break;
                    case 'o': // octal
                        prefix = "0";
                        break;
                    case 'x': // hexadecimal
                        prefix = "0x";
                        break;
                    case 'X': 
                        prefix = "0X";
                        break;
                }

            }

            if (ch == 'O')
            {
                prefix = "0o";
            }

            var digits = x.abs.utoa(base);
            if (ch == 'X')
            { 
                // faster than bytes.ToUpper
                {
                    var d__prev1 = d;

                    foreach (var (__i, __d) in digits)
                    {
                        i = __i;
                        d = __d;
                        if ('a' <= d && d <= 'z')
                        {
                            digits[i] = 'A' + (d - 'a');
                        }

                    }

                    d = d__prev1;
                }
            } 

            // number of characters for the three classes of number padding
            long left = default; // space characters to left of digits for right justification ("%8d")
            long zeros = default; // zero characters (actually cs[0]) as left-most digits ("%.8d")
            long right = default; // space characters to right of digits for left justification ("%-8d")

            // determine number padding from precision: the least number of digits to output
            var (precision, precisionSet) = s.Precision();
            if (precisionSet)
            {

                if (len(digits) < precision) 
                    zeros = precision - len(digits); // count of zero padding
                else if (len(digits) == 1L && digits[0L] == '0' && precision == 0L) 
                    return ; // print nothing if zero value (x == 0) and zero precision ("." or ".0")
                            } 

            // determine field pad from width: the least number of characters to output
            var length = len(sign) + len(prefix) + zeros + len(digits);
            {
                var (width, widthSet) = s.Width();

                if (widthSet && length < width)
                { // pad as specified
                    {
                        var d__prev1 = d;

                        var d = width - length;


                        if (s.Flag('-')) 
                            // pad on the right with spaces; supersedes '0' when both specified
                            right = d;
                        else if (s.Flag('0') && !precisionSet) 
                            // pad with zeros unless precision also specified
                            zeros = d;
                        else 
                            // pad on the left with spaces
                            left = d;


                        d = d__prev1;
                    }

                } 

                // print number as [left pad][sign][prefix][zero pad][digits][right pad]

            } 

            // print number as [left pad][sign][prefix][zero pad][digits][right pad]
            writeMultiple(s, " ", left);
            writeMultiple(s, sign, 1L);
            writeMultiple(s, prefix, 1L);
            writeMultiple(s, "0", zeros);
            s.Write(digits);
            writeMultiple(s, " ", right);

        }

        // scan sets z to the integer value corresponding to the longest possible prefix
        // read from r representing a signed integer number in a given conversion base.
        // It returns z, the actual conversion base used, and an error, if any. In the
        // error case, the value of z is undefined but the returned value is nil. The
        // syntax follows the syntax of integer literals in Go.
        //
        // The base argument must be 0 or a value from 2 through MaxBase. If the base
        // is 0, the string prefix determines the actual conversion base. A prefix of
        // ``0b'' or ``0B'' selects base 2; a ``0'', ``0o'', or ``0O'' prefix selects
        // base 8, and a ``0x'' or ``0X'' prefix selects base 16. Otherwise the selected
        // base is 10.
        //
        private static (ptr<Int>, long, error) scan(this ptr<Int> _addr_z, io.ByteScanner r, long @base)
        {
            ptr<Int> _p0 = default!;
            long _p0 = default;
            error _p0 = default!;
            ref Int z = ref _addr_z.val;
 
            // determine sign
            var (neg, err) = scanSign(r);
            if (err != null)
            {
                return (_addr_null!, 0L, error.As(err)!);
            } 

            // determine mantissa
            z.abs, base, _, err = z.abs.scan(r, base, false);
            if (err != null)
            {
                return (_addr_null!, base, error.As(err)!);
            }

            z.neg = len(z.abs) > 0L && neg; // 0 has no sign

            return (_addr_z!, base, error.As(null!)!);

        }

        private static (bool, error) scanSign(io.ByteScanner r)
        {
            bool neg = default;
            error err = default!;

            byte ch = default;
            ch, err = r.ReadByte();

            if (err != null)
            {
                return (false, error.As(err)!);
            }

            switch (ch)
            {
                case '-': 
                    neg = true;
                    break;
                case '+': 
                    break;
                default: 
                    r.UnreadByte();
                    break;
            }
            return ;

        }

        // byteReader is a local wrapper around fmt.ScanState;
        // it implements the ByteReader interface.
        private partial struct byteReader : fmt.ScanState
        {
            public ref fmt.ScanState ScanState => ref ScanState_val;
        }

        private static (byte, error) ReadByte(this byteReader r)
        {
            byte _p0 = default;
            error _p0 = default!;

            var (ch, size, err) = r.ReadRune();
            if (size != 1L && err == null)
            {
                err = fmt.Errorf("invalid rune %#U", ch);
            }

            return (byte(ch), error.As(err)!);

        }

        private static error UnreadByte(this byteReader r)
        {
            return error.As(r.UnreadRune())!;
        }

        private static fmt.Scanner _ = intOne; // *Int must implement fmt.Scanner

        // Scan is a support routine for fmt.Scanner; it sets z to the value of
        // the scanned number. It accepts the formats 'b' (binary), 'o' (octal),
        // 'd' (decimal), 'x' (lowercase hexadecimal), and 'X' (uppercase hexadecimal).
        private static error Scan(this ptr<Int> _addr_z, fmt.ScanState s, int ch)
        {
            ref Int z = ref _addr_z.val;

            s.SkipSpace(); // skip leading space characters
            long @base = 0L;
            switch (ch)
            {
                case 'b': 
                    base = 2L;
                    break;
                case 'o': 
                    base = 8L;
                    break;
                case 'd': 
                    base = 10L;
                    break;
                case 'x': 

                case 'X': 
                    base = 16L;
                    break;
                case 's': 

                case 'v': 
                    break;
                default: 
                    return error.As(errors.New("Int.Scan: invalid verb"))!;
                    break;
            }
            var (_, _, err) = z.scan(new byteReader(s), base);
            return error.As(err)!;

        }
    }
}}
