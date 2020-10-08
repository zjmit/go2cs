// Copyright 2018 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package math -- go2cs converted at 2020 October 08 03:25:23 UTC
// import "math" ==> using math = go.math_package
// Original source: C:\Go\src\math\trig_reduce.go
using bits = go.math.bits_package;
using static go.builtin;

namespace go
{
    public static partial class math_package
    {
        // reduceThreshold is the maximum value of x where the reduction using Pi/4
        // in 3 float64 parts still gives accurate results. This threshold
        // is set by y*C being representable as a float64 without error
        // where y is given by y = floor(x * (4 / Pi)) and C is the leading partial
        // terms of 4/Pi. Since the leading terms (PI4A and PI4B in sin.go) have 30
        // and 32 trailing zero bits, y should have less than 30 significant bits.
        //    y < 1<<30  -> floor(x*4/Pi) < 1<<30 -> x < (1<<30 - 1) * Pi/4
        // So, conservatively we can take x < 1<<29.
        // Above this threshold Payne-Hanek range reduction must be used.
        private static readonly long reduceThreshold = (long)1L << (int)(29L);

        // trigReduce implements Payne-Hanek range reduction by Pi/4
        // for x > 0. It returns the integer part mod 8 (j) and
        // the fractional part (z) of x / (Pi/4).
        // The implementation is based on:
        // "ARGUMENT REDUCTION FOR HUGE ARGUMENTS: Good to the Last Bit"
        // K. C. Ng et al, March 24, 1992
        // The simulated multi-precision calculation of x*B uses 64-bit integer arithmetic.


        // trigReduce implements Payne-Hanek range reduction by Pi/4
        // for x > 0. It returns the integer part mod 8 (j) and
        // the fractional part (z) of x / (Pi/4).
        // The implementation is based on:
        // "ARGUMENT REDUCTION FOR HUGE ARGUMENTS: Good to the Last Bit"
        // K. C. Ng et al, March 24, 1992
        // The simulated multi-precision calculation of x*B uses 64-bit integer arithmetic.
        private static (ulong, double) trigReduce(double x)
        {
            ulong j = default;
            double z = default;

            const var PI4 = (var)Pi / 4L;

            if (x < PI4)
            {
                return (0L, x);
            } 
            // Extract out the integer and exponent such that,
            // x = ix * 2 ** exp.
            var ix = Float64bits(x);
            var exp = int(ix >> (int)(shift) & mask) - bias - shift;
            ix &= mask << (int)(shift);
            ix |= 1L << (int)(shift); 
            // Use the exponent to extract the 3 appropriate uint64 digits from mPi4,
            // B ~ (z0, z1, z2), such that the product leading digit has the exponent -61.
            // Note, exp >= -53 since x >= PI4 and exp < 971 for maximum float64.
            var digit = uint(exp + 61L) / 64L;
            var bitshift = uint(exp + 61L) % 64L;
            var z0 = (mPi4[digit] << (int)(bitshift)) | (mPi4[digit + 1L] >> (int)((64L - bitshift)));
            var z1 = (mPi4[digit + 1L] << (int)(bitshift)) | (mPi4[digit + 2L] >> (int)((64L - bitshift)));
            var z2 = (mPi4[digit + 2L] << (int)(bitshift)) | (mPi4[digit + 3L] >> (int)((64L - bitshift))); 
            // Multiply mantissa by the digits and extract the upper two digits (hi, lo).
            var (z2hi, _) = bits.Mul64(z2, ix);
            var (z1hi, z1lo) = bits.Mul64(z1, ix);
            var z0lo = z0 * ix;
            var (lo, c) = bits.Add64(z1lo, z2hi, 0L);
            var (hi, _) = bits.Add64(z0lo, z1hi, c); 
            // The top 3 bits are j.
            j = hi >> (int)(61L); 
            // Extract the fraction and find its magnitude.
            hi = hi << (int)(3L) | lo >> (int)(61L);
            var lz = uint(bits.LeadingZeros64(hi));
            var e = uint64(bias - (lz + 1L)); 
            // Clear implicit mantissa bit and shift into place.
            hi = (hi << (int)((lz + 1L))) | (lo >> (int)((64L - (lz + 1L))));
            hi >>= 64L - shift; 
            // Include the exponent and convert to a float.
            hi |= e << (int)(shift);
            z = Float64frombits(hi); 
            // Map zeros to origin.
            if (j & 1L == 1L)
            {
                j++;
                j &= 7L;
                z--;
            } 
            // Multiply the fractional part by pi/4.
            return (j, z * PI4);

        }

        // mPi4 is the binary digits of 4/pi as a uint64 array,
        // that is, 4/pi = Sum mPi4[i]*2^(-64*i)
        // 19 64-bit digits and the leading one bit give 1217 bits
        // of precision to handle the largest possible float64 exponent.
        private static array<ulong> mPi4 = new array<ulong>(new ulong[] { 0x0000000000000001, 0x45f306dc9c882a53, 0xf84eafa3ea69bb81, 0xb6c52b3278872083, 0xfca2c757bd778ac3, 0x6e48dc74849ba5c0, 0x0c925dd413a32439, 0xfc3bd63962534e7d, 0xd1046bea5d768909, 0xd338e04d68befc82, 0x7323ac7306a673e9, 0x3908bf177bf25076, 0x3ff12fffbc0b301f, 0xde5e2316b414da3e, 0xda6cfd9e4f96136e, 0x9e8c7ecd3cbfd45a, 0xea4f758fd7cbe2f6, 0x7a0e73ef14a525d4, 0xd7f6bf623f1aba10, 0xac06608df8f6d757 });
    }
}
