// Copyright 2009 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Package draw provides image composition functions.
//
// See "The Go image/draw package" for an introduction to this package:
// https://golang.org/doc/articles/image_draw.html
// package draw -- go2cs converted at 2020 October 09 06:05:46 UTC
// import "image/draw" ==> using draw = go.image.draw_package
// Original source: C:\Go\src\image\draw\draw.go
using image = go.image_package;
using color = go.image.color_package;
using imageutil = go.image.@internal.imageutil_package;
using static go.builtin;
using System;

namespace go {
namespace image
{
    public static partial class draw_package
    {
        // m is the maximum color value returned by image.Color.RGBA.
        private static readonly long m = (long)1L << (int)(16L) - 1L;

        // Image is an image.Image with a Set method to change a single pixel.


        // Image is an image.Image with a Set method to change a single pixel.
        public partial interface Image : image.Image
        {
            void Set(long x, long y, color.Color c);
        }

        // Quantizer produces a palette for an image.
        public partial interface Quantizer
        {
            color.Palette Quantize(color.Palette p, image.Image m);
        }

        // Op is a Porter-Duff compositing operator.
        public partial struct Op // : long
        {
        }

 
        // Over specifies ``(src in mask) over dst''.
        public static readonly Op Over = (Op)iota; 
        // Src specifies ``src in mask''.
        public static readonly var Src = 0;


        // Draw implements the Drawer interface by calling the Draw function with this
        // Op.
        public static void Draw(this Op op, Image dst, image.Rectangle r, image.Image src, image.Point sp)
        {
            DrawMask(dst, r, src, sp, null, new image.Point(), op);
        }

        // Drawer contains the Draw method.
        public partial interface Drawer
        {
            void Draw(Image dst, image.Rectangle r, image.Image src, image.Point sp);
        }

        // FloydSteinberg is a Drawer that is the Src Op with Floyd-Steinberg error
        // diffusion.
        public static Drawer FloydSteinberg = Drawer.As(new floydSteinberg())!;

        private partial struct floydSteinberg
        {
        }

        private static void Draw(this floydSteinberg _p0, Image dst, image.Rectangle r, image.Image src, image.Point sp)
        {
            clip(dst, _addr_r, src, _addr_sp, null, _addr_null);
            if (r.Empty())
            {
                return ;
            }

            drawPaletted(dst, r, src, sp, true);

        }

        // clip clips r against each image's bounds (after translating into the
        // destination image's coordinate space) and shifts the points sp and mp by
        // the same amount as the change in r.Min.
        private static void clip(Image dst, ptr<image.Rectangle> _addr_r, image.Image src, ptr<image.Point> _addr_sp, image.Image mask, ptr<image.Point> _addr_mp)
        {
            ref image.Rectangle r = ref _addr_r.val;
            ref image.Point sp = ref _addr_sp.val;
            ref image.Point mp = ref _addr_mp.val;

            var orig = r.Min;
            r = r.Intersect(dst.Bounds());
            r = r.Intersect(src.Bounds().Add(orig.Sub(sp)));
            if (mask != null)
            {
                r = r.Intersect(mask.Bounds().Add(orig.Sub(mp)));
            }

            var dx = r.Min.X - orig.X;
            var dy = r.Min.Y - orig.Y;
            if (dx == 0L && dy == 0L)
            {
                return ;
            }

            sp.X += dx;
            sp.Y += dy;
            if (mp != null)
            {
                mp.X += dx;
                mp.Y += dy;
            }

        }

        private static bool processBackward(image.Image dst, image.Rectangle r, image.Image src, image.Point sp)
        {
            return dst == src && r.Overlaps(r.Add(sp.Sub(r.Min))) && (sp.Y < r.Min.Y || (sp.Y == r.Min.Y && sp.X < r.Min.X));
        }

        // Draw calls DrawMask with a nil mask.
        public static void Draw(Image dst, image.Rectangle r, image.Image src, image.Point sp, Op op)
        {
            DrawMask(dst, r, src, sp, null, new image.Point(), op);
        }

        // DrawMask aligns r.Min in dst with sp in src and mp in mask and then replaces the rectangle r
        // in dst with the result of a Porter-Duff composition. A nil mask is treated as opaque.
        public static void DrawMask(Image dst, image.Rectangle r, image.Image src, image.Point sp, image.Image mask, image.Point mp, Op op)
        {
            clip(dst, _addr_r, src, _addr_sp, mask, _addr_mp);
            if (r.Empty())
            {
                return ;
            } 

            // Fast paths for special cases. If none of them apply, then we fall back to a general but slow implementation.
            switch (dst.type())
            {
                case ptr<image.RGBA> dst0:
                    if (op == Over)
                    {
                        if (mask == null)
                        {
                            switch (src.type())
                            {
                                case ptr<image.Uniform> src0:
                                    var (sr, sg, sb, sa) = src0.RGBA();
                                    if (sa == 0xffffUL)
                                    {
                                        drawFillSrc(_addr_dst0, r, sr, sg, sb, sa);
                                    }
                                    else
                                    {
                                        drawFillOver(_addr_dst0, r, sr, sg, sb, sa);
                                    }

                                    return ;
                                    break;
                                case ptr<image.RGBA> src0:
                                    drawCopyOver(_addr_dst0, r, _addr_src0, sp);
                                    return ;
                                    break;
                                case ptr<image.NRGBA> src0:
                                    drawNRGBAOver(_addr_dst0, r, _addr_src0, sp);
                                    return ;
                                    break;
                                case ptr<image.YCbCr> src0:
                                    if (imageutil.DrawYCbCr(dst0, r, src0, sp))
                                    {
                                        return ;
                                    }

                                    break;
                                case ptr<image.Gray> src0:
                                    drawGray(_addr_dst0, r, _addr_src0, sp);
                                    return ;
                                    break;
                                case ptr<image.CMYK> src0:
                                    drawCMYK(_addr_dst0, r, _addr_src0, sp);
                                    return ;
                                    break;
                            }

                        }                        {
                            ptr<image.Alpha> (mask0, ok) = mask._<ptr<image.Alpha>>();


                            else if (ok)
                            {
                                switch (src.type())
                                {
                                    case ptr<image.Uniform> src0:
                                        drawGlyphOver(_addr_dst0, r, _addr_src0, mask0, mp);
                                        return ;
                                        break;
                                }

                            }

                        }

                    }
                    else
                    {
                        if (mask == null)
                        {
                            switch (src.type())
                            {
                                case ptr<image.Uniform> src0:
                                    (sr, sg, sb, sa) = src0.RGBA();
                                    drawFillSrc(_addr_dst0, r, sr, sg, sb, sa);
                                    return ;
                                    break;
                                case ptr<image.RGBA> src0:
                                    drawCopySrc(_addr_dst0, r, _addr_src0, sp);
                                    return ;
                                    break;
                                case ptr<image.NRGBA> src0:
                                    drawNRGBASrc(_addr_dst0, r, _addr_src0, sp);
                                    return ;
                                    break;
                                case ptr<image.YCbCr> src0:
                                    if (imageutil.DrawYCbCr(dst0, r, src0, sp))
                                    {
                                        return ;
                                    }

                                    break;
                                case ptr<image.Gray> src0:
                                    drawGray(_addr_dst0, r, _addr_src0, sp);
                                    return ;
                                    break;
                                case ptr<image.CMYK> src0:
                                    drawCMYK(_addr_dst0, r, _addr_src0, sp);
                                    return ;
                                    break;
                            }

                        }

                    }

                    drawRGBA(_addr_dst0, r, src, sp, mask, mp, op);
                    return ;
                    break;
                case ptr<image.Paletted> dst0:
                    if (op == Src && mask == null)
                    {
                        {
                            var src0__prev2 = src0;

                            ptr<image.Uniform> (src0, ok) = src._<ptr<image.Uniform>>();

                            if (ok)
                            {
                                var colorIndex = uint8(dst0.Palette.Index(src0.C));
                                var i0 = dst0.PixOffset(r.Min.X, r.Min.Y);
                                var i1 = i0 + r.Dx();
                                for (var i = i0; i < i1; i++)
                                {
                                    dst0.Pix[i] = colorIndex;
                                }

                                var firstRow = dst0.Pix[i0..i1];
                                {
                                    var y__prev1 = y;

                                    for (var y = r.Min.Y + 1L; y < r.Max.Y; y++)
                                    {
                                        i0 += dst0.Stride;
                                        i1 += dst0.Stride;
                                        copy(dst0.Pix[i0..i1], firstRow);
                                    }


                                    y = y__prev1;
                                }
                                return ;

                            }
                            else if (!processBackward(dst, r, src, sp))
                            {
                                drawPaletted(dst0, r, src, sp, false);
                                return ;
                            }


                            src0 = src0__prev2;

                        }

                    }

                    break;

            }

            var x0 = r.Min.X;
            var x1 = r.Max.X;
            long dx = 1L;
            var y0 = r.Min.Y;
            var y1 = r.Max.Y;
            long dy = 1L;
            if (processBackward(dst, r, src, sp))
            {
                x0 = x1 - 1L;
                x1 = x0 - 1L;
                dx = -1L;
                y0 = y1 - 1L;
                y1 = y0 - 1L;
                dy = -1L;

            }

            ref color.RGBA64 @out = ref heap(out ptr<color.RGBA64> _addr_@out);
            var sy = sp.Y + y0 - r.Min.Y;
            var my = mp.Y + y0 - r.Min.Y;
            {
                var y__prev1 = y;

                y = y0;

                while (y != y1)
                {
                    var sx = sp.X + x0 - r.Min.X;
                    var mx = mp.X + x0 - r.Min.X;
                    {
                        var x = x0;

                        while (x != x1)
                        {
                            var ma = uint32(m);
                            if (mask != null)
                            {
                                _, _, _, ma = mask.At(mx, my).RGBA();
                            x = x + dx;
                        sx = sx + dx;
                        mx = mx + dx;
                            }


                            if (ma == 0L) 
                                if (op == Over)
                                { 
                                    // No-op.
                    y = y + dy;
                sy = sy + dy;
                my = my + dy;
                                }
                                else
                                {
                                    dst.Set(x, y, color.Transparent);
                                }

                            else if (ma == m && op == Src) 
                                dst.Set(x, y, src.At(sx, sy));
                            else 
                                (sr, sg, sb, sa) = src.At(sx, sy).RGBA();
                                if (op == Over)
                                {
                                    var (dr, dg, db, da) = dst.At(x, y).RGBA();
                                    var a = m - (sa * ma / m);
                                    @out.R = uint16((dr * a + sr * ma) / m);
                                    @out.G = uint16((dg * a + sg * ma) / m);
                                    @out.B = uint16((db * a + sb * ma) / m);
                                    @out.A = uint16((da * a + sa * ma) / m);
                                }
                                else
                                {
                                    @out.R = uint16(sr * ma / m);
                                    @out.G = uint16(sg * ma / m);
                                    @out.B = uint16(sb * ma / m);
                                    @out.A = uint16(sa * ma / m);
                                } 
                                // The third argument is &out instead of out (and out is
                                // declared outside of the inner loop) to avoid the implicit
                                // conversion to color.Color here allocating memory in the
                                // inner loop if sizeof(color.RGBA64) > sizeof(uintptr).
                                dst.Set(x, y, _addr_out);
                            
                        }

                    }

                }


                y = y__prev1;
            }

        }

        private static void drawFillOver(ptr<image.RGBA> _addr_dst, image.Rectangle r, uint sr, uint sg, uint sb, uint sa)
        {
            ref image.RGBA dst = ref _addr_dst.val;
 
            // The 0x101 is here for the same reason as in drawRGBA.
            var a = (m - sa) * 0x101UL;
            var i0 = dst.PixOffset(r.Min.X, r.Min.Y);
            var i1 = i0 + r.Dx() * 4L;
            for (var y = r.Min.Y; y != r.Max.Y; y++)
            {
                {
                    var i = i0;

                    while (i < i1)
                    {
                        var dr = _addr_dst.Pix[i + 0L];
                        var dg = _addr_dst.Pix[i + 1L];
                        var db = _addr_dst.Pix[i + 2L];
                        var da = _addr_dst.Pix[i + 3L];

                        dr.val = uint8((uint32(dr.val) * a / m + sr) >> (int)(8L));
                        dg.val = uint8((uint32(dg.val) * a / m + sg) >> (int)(8L));
                        db.val = uint8((uint32(db.val) * a / m + sb) >> (int)(8L));
                        da.val = uint8((uint32(da.val) * a / m + sa) >> (int)(8L));
                        i += 4L;
                    }

                }
                i0 += dst.Stride;
                i1 += dst.Stride;

            }


        }

        private static void drawFillSrc(ptr<image.RGBA> _addr_dst, image.Rectangle r, uint sr, uint sg, uint sb, uint sa)
        {
            ref image.RGBA dst = ref _addr_dst.val;

            var sr8 = uint8(sr >> (int)(8L));
            var sg8 = uint8(sg >> (int)(8L));
            var sb8 = uint8(sb >> (int)(8L));
            var sa8 = uint8(sa >> (int)(8L)); 
            // The built-in copy function is faster than a straightforward for loop to fill the destination with
            // the color, but copy requires a slice source. We therefore use a for loop to fill the first row, and
            // then use the first row as the slice source for the remaining rows.
            var i0 = dst.PixOffset(r.Min.X, r.Min.Y);
            var i1 = i0 + r.Dx() * 4L;
            {
                var i = i0;

                while (i < i1)
                {
                    dst.Pix[i + 0L] = sr8;
                    dst.Pix[i + 1L] = sg8;
                    dst.Pix[i + 2L] = sb8;
                    dst.Pix[i + 3L] = sa8;
                    i += 4L;
                }

            }
            var firstRow = dst.Pix[i0..i1];
            for (var y = r.Min.Y + 1L; y < r.Max.Y; y++)
            {
                i0 += dst.Stride;
                i1 += dst.Stride;
                copy(dst.Pix[i0..i1], firstRow);
            }


        }

        private static void drawCopyOver(ptr<image.RGBA> _addr_dst, image.Rectangle r, ptr<image.RGBA> _addr_src, image.Point sp)
        {
            ref image.RGBA dst = ref _addr_dst.val;
            ref image.RGBA src = ref _addr_src.val;

            var dx = r.Dx();
            var dy = r.Dy();
            var d0 = dst.PixOffset(r.Min.X, r.Min.Y);
            var s0 = src.PixOffset(sp.X, sp.Y);
            long ddelta = default;            long sdelta = default;
            long i0 = default;            long i1 = default;            long idelta = default;

            if (r.Min.Y < sp.Y || r.Min.Y == sp.Y && r.Min.X <= sp.X)
            {
                ddelta = dst.Stride;
                sdelta = src.Stride;
                i0 = 0L;
                i1 = dx * 4L;
                idelta = +4L;

            }
            else
            { 
                // If the source start point is higher than the destination start point, or equal height but to the left,
                // then we compose the rows in right-to-left, bottom-up order instead of left-to-right, top-down.
                d0 += (dy - 1L) * dst.Stride;
                s0 += (dy - 1L) * src.Stride;
                ddelta = -dst.Stride;
                sdelta = -src.Stride;
                i0 = (dx - 1L) * 4L;
                i1 = -4L;
                idelta = -4L;

            }

            while (dy > 0L)
            {
                var dpix = dst.Pix[d0..];
                var spix = src.Pix[s0..];
                {
                    var i = i0;

                    while (i != i1)
                    {
                        var s = spix.slice(i, i + 4L, i + 4L); // Small cap improves performance, see https://golang.org/issue/27857
                        var sr = uint32(s[0L]) * 0x101UL;
                        var sg = uint32(s[1L]) * 0x101UL;
                        var sb = uint32(s[2L]) * 0x101UL;
                        var sa = uint32(s[3L]) * 0x101UL; 

                        // The 0x101 is here for the same reason as in drawRGBA.
                        var a = (m - sa) * 0x101UL;

                        var d = dpix.slice(i, i + 4L, i + 4L); // Small cap improves performance, see https://golang.org/issue/27857
                        d[0L] = uint8((uint32(d[0L]) * a / m + sr) >> (int)(8L));
                        d[1L] = uint8((uint32(d[1L]) * a / m + sg) >> (int)(8L));
                        d[2L] = uint8((uint32(d[2L]) * a / m + sb) >> (int)(8L));
                        d[3L] = uint8((uint32(d[3L]) * a / m + sa) >> (int)(8L));
                        i += idelta;
                    }

                }
                d0 += ddelta;
                s0 += sdelta;
                dy--;
            }


        }

        private static void drawCopySrc(ptr<image.RGBA> _addr_dst, image.Rectangle r, ptr<image.RGBA> _addr_src, image.Point sp)
        {
            ref image.RGBA dst = ref _addr_dst.val;
            ref image.RGBA src = ref _addr_src.val;

            long n = 4L * r.Dx();
            var dy = r.Dy();
            var d0 = dst.PixOffset(r.Min.X, r.Min.Y);
            var s0 = src.PixOffset(sp.X, sp.Y);
            long ddelta = default;            long sdelta = default;

            if (r.Min.Y <= sp.Y)
            {
                ddelta = dst.Stride;
                sdelta = src.Stride;
            }
            else
            { 
                // If the source start point is higher than the destination start
                // point, then we compose the rows in bottom-up order instead of
                // top-down. Unlike the drawCopyOver function, we don't have to check
                // the x coordinates because the built-in copy function can handle
                // overlapping slices.
                d0 += (dy - 1L) * dst.Stride;
                s0 += (dy - 1L) * src.Stride;
                ddelta = -dst.Stride;
                sdelta = -src.Stride;

            }

            while (dy > 0L)
            {
                copy(dst.Pix[d0..d0 + n], src.Pix[s0..s0 + n]);
                d0 += ddelta;
                s0 += sdelta;
                dy--;
            }


        }

        private static void drawNRGBAOver(ptr<image.RGBA> _addr_dst, image.Rectangle r, ptr<image.NRGBA> _addr_src, image.Point sp)
        {
            ref image.RGBA dst = ref _addr_dst.val;
            ref image.NRGBA src = ref _addr_src.val;

            var i0 = (r.Min.X - dst.Rect.Min.X) * 4L;
            var i1 = (r.Max.X - dst.Rect.Min.X) * 4L;
            var si0 = (sp.X - src.Rect.Min.X) * 4L;
            var yMax = r.Max.Y - dst.Rect.Min.Y;

            var y = r.Min.Y - dst.Rect.Min.Y;
            var sy = sp.Y - src.Rect.Min.Y;
            while (y != yMax)
            {
                var dpix = dst.Pix[y * dst.Stride..];
                var spix = src.Pix[sy * src.Stride..];

                {
                    var i = i0;
                    var si = si0;

                    while (i < i1)
                    { 
                        // Convert from non-premultiplied color to pre-multiplied color.
                        var s = spix.slice(si, si + 4L, si + 4L); // Small cap improves performance, see https://golang.org/issue/27857
                        var sa = uint32(s[3L]) * 0x101UL;
                        var sr = uint32(s[0L]) * sa / 0xffUL;
                        var sg = uint32(s[1L]) * sa / 0xffUL;
                        var sb = uint32(s[2L]) * sa / 0xffUL;

                        var d = dpix.slice(i, i + 4L, i + 4L); // Small cap improves performance, see https://golang.org/issue/27857
                        var dr = uint32(d[0L]);
                        var dg = uint32(d[1L]);
                        var db = uint32(d[2L]);
                        var da = uint32(d[3L]); 

                        // The 0x101 is here for the same reason as in drawRGBA.
                        var a = (m - sa) * 0x101UL;

                        d[0L] = uint8((dr * a / m + sr) >> (int)(8L));
                        d[1L] = uint8((dg * a / m + sg) >> (int)(8L));
                        d[2L] = uint8((db * a / m + sb) >> (int)(8L));
                        d[3L] = uint8((da * a / m + sa) >> (int)(8L));
                        i = i + 4L;
                    si = si + 4L;
                    }

                }
                y = y + 1L;
            sy = sy + 1L;
            }


        }

        private static void drawNRGBASrc(ptr<image.RGBA> _addr_dst, image.Rectangle r, ptr<image.NRGBA> _addr_src, image.Point sp)
        {
            ref image.RGBA dst = ref _addr_dst.val;
            ref image.NRGBA src = ref _addr_src.val;

            var i0 = (r.Min.X - dst.Rect.Min.X) * 4L;
            var i1 = (r.Max.X - dst.Rect.Min.X) * 4L;
            var si0 = (sp.X - src.Rect.Min.X) * 4L;
            var yMax = r.Max.Y - dst.Rect.Min.Y;

            var y = r.Min.Y - dst.Rect.Min.Y;
            var sy = sp.Y - src.Rect.Min.Y;
            while (y != yMax)
            {
                var dpix = dst.Pix[y * dst.Stride..];
                var spix = src.Pix[sy * src.Stride..];

                {
                    var i = i0;
                    var si = si0;

                    while (i < i1)
                    { 
                        // Convert from non-premultiplied color to pre-multiplied color.
                        var s = spix.slice(si, si + 4L, si + 4L); // Small cap improves performance, see https://golang.org/issue/27857
                        var sa = uint32(s[3L]) * 0x101UL;
                        var sr = uint32(s[0L]) * sa / 0xffUL;
                        var sg = uint32(s[1L]) * sa / 0xffUL;
                        var sb = uint32(s[2L]) * sa / 0xffUL;

                        var d = dpix.slice(i, i + 4L, i + 4L); // Small cap improves performance, see https://golang.org/issue/27857
                        d[0L] = uint8(sr >> (int)(8L));
                        d[1L] = uint8(sg >> (int)(8L));
                        d[2L] = uint8(sb >> (int)(8L));
                        d[3L] = uint8(sa >> (int)(8L));
                        i = i + 4L;
                    si = si + 4L;
                    }

                }
                y = y + 1L;
            sy = sy + 1L;
            }


        }

        private static void drawGray(ptr<image.RGBA> _addr_dst, image.Rectangle r, ptr<image.Gray> _addr_src, image.Point sp)
        {
            ref image.RGBA dst = ref _addr_dst.val;
            ref image.Gray src = ref _addr_src.val;

            var i0 = (r.Min.X - dst.Rect.Min.X) * 4L;
            var i1 = (r.Max.X - dst.Rect.Min.X) * 4L;
            var si0 = (sp.X - src.Rect.Min.X) * 1L;
            var yMax = r.Max.Y - dst.Rect.Min.Y;

            var y = r.Min.Y - dst.Rect.Min.Y;
            var sy = sp.Y - src.Rect.Min.Y;
            while (y != yMax)
            {
                var dpix = dst.Pix[y * dst.Stride..];
                var spix = src.Pix[sy * src.Stride..];

                {
                    var i = i0;
                    var si = si0;

                    while (i < i1)
                    {
                        var p = spix[si];
                        var d = dpix.slice(i, i + 4L, i + 4L); // Small cap improves performance, see https://golang.org/issue/27857
                        d[0L] = p;
                        d[1L] = p;
                        d[2L] = p;
                        d[3L] = 255L;
                        i = i + 4L;
                    si = si + 1L;
                    }

                }
                y = y + 1L;
            sy = sy + 1L;
            }


        }

        private static void drawCMYK(ptr<image.RGBA> _addr_dst, image.Rectangle r, ptr<image.CMYK> _addr_src, image.Point sp)
        {
            ref image.RGBA dst = ref _addr_dst.val;
            ref image.CMYK src = ref _addr_src.val;

            var i0 = (r.Min.X - dst.Rect.Min.X) * 4L;
            var i1 = (r.Max.X - dst.Rect.Min.X) * 4L;
            var si0 = (sp.X - src.Rect.Min.X) * 4L;
            var yMax = r.Max.Y - dst.Rect.Min.Y;

            var y = r.Min.Y - dst.Rect.Min.Y;
            var sy = sp.Y - src.Rect.Min.Y;
            while (y != yMax)
            {
                var dpix = dst.Pix[y * dst.Stride..];
                var spix = src.Pix[sy * src.Stride..];

                {
                    var i = i0;
                    var si = si0;

                    while (i < i1)
                    {
                        var s = spix.slice(si, si + 4L, si + 4L); // Small cap improves performance, see https://golang.org/issue/27857
                        var d = dpix.slice(i, i + 4L, i + 4L);
                        d[0L], d[1L], d[2L] = color.CMYKToRGB(s[0L], s[1L], s[2L], s[3L]);
                        d[3L] = 255L;
                        i = i + 4L;
                    si = si + 4L;
                    }

                }
                y = y + 1L;
            sy = sy + 1L;
            }


        }

        private static void drawGlyphOver(ptr<image.RGBA> _addr_dst, image.Rectangle r, ptr<image.Uniform> _addr_src, ptr<image.Alpha> _addr_mask, image.Point mp)
        {
            ref image.RGBA dst = ref _addr_dst.val;
            ref image.Uniform src = ref _addr_src.val;
            ref image.Alpha mask = ref _addr_mask.val;

            var i0 = dst.PixOffset(r.Min.X, r.Min.Y);
            var i1 = i0 + r.Dx() * 4L;
            var mi0 = mask.PixOffset(mp.X, mp.Y);
            var (sr, sg, sb, sa) = src.RGBA();
            {
                var y = r.Min.Y;
                var my = mp.Y;

                while (y != r.Max.Y)
                {
                    {
                        var i = i0;
                        var mi = mi0;

                        while (i < i1)
                        {
                            var ma = uint32(mask.Pix[mi]);
                            if (ma == 0L)
                            {
                                continue;
                            i = i + 4L;
                        mi = mi + 1L;
                            }

                            ma |= ma << (int)(8L); 

                            // The 0x101 is here for the same reason as in drawRGBA.
                            var a = (m - (sa * ma / m)) * 0x101UL;

                            var d = dst.Pix.slice(i, i + 4L, i + 4L); // Small cap improves performance, see https://golang.org/issue/27857
                            d[0L] = uint8((uint32(d[0L]) * a + sr * ma) / m >> (int)(8L));
                            d[1L] = uint8((uint32(d[1L]) * a + sg * ma) / m >> (int)(8L));
                            d[2L] = uint8((uint32(d[2L]) * a + sb * ma) / m >> (int)(8L));
                            d[3L] = uint8((uint32(d[3L]) * a + sa * ma) / m >> (int)(8L));
                    y = y + 1L;
                my = my + 1L;
                        }

                    }
                    i0 += dst.Stride;
                    i1 += dst.Stride;
                    mi0 += mask.Stride;

                }

            }

        }

        private static void drawRGBA(ptr<image.RGBA> _addr_dst, image.Rectangle r, image.Image src, image.Point sp, image.Image mask, image.Point mp, Op op)
        {
            ref image.RGBA dst = ref _addr_dst.val;

            var x0 = r.Min.X;
            var x1 = r.Max.X;
            long dx = 1L;
            var y0 = r.Min.Y;
            var y1 = r.Max.Y;
            long dy = 1L;
            if (image.Image(dst) == src && r.Overlaps(r.Add(sp.Sub(r.Min))))
            {
                if (sp.Y < r.Min.Y || sp.Y == r.Min.Y && sp.X < r.Min.X)
                {
                    x0 = x1 - 1L;
                    x1 = x0 - 1L;
                    dx = -1L;
                    y0 = y1 - 1L;
                    y1 = y0 - 1L;
                    dy = -1L;

                }

            }

            var sy = sp.Y + y0 - r.Min.Y;
            var my = mp.Y + y0 - r.Min.Y;
            var sx0 = sp.X + x0 - r.Min.X;
            var mx0 = mp.X + x0 - r.Min.X;
            var sx1 = sx0 + (x1 - x0);
            var i0 = dst.PixOffset(x0, y0);
            var di = dx * 4L;
            {
                var y = y0;

                while (y != y1)
                {
                    {
                        var i = i0;
                        var sx = sx0;
                        var mx = mx0;

                        while (sx != sx1)
                        {
                            var ma = uint32(m);
                            if (mask != null)
                            {
                                _, _, _, ma = mask.At(mx, my).RGBA();
                            i = i + di;
                        sx = sx + dx;
                        mx = mx + dx;
                            }

                            var (sr, sg, sb, sa) = src.At(sx, sy).RGBA();
                            var d = dst.Pix.slice(i, i + 4L, i + 4L); // Small cap improves performance, see https://golang.org/issue/27857
                            if (op == Over)
                            {
                                var dr = uint32(d[0L]);
                                var dg = uint32(d[1L]);
                                var db = uint32(d[2L]);
                                var da = uint32(d[3L]); 

                                // dr, dg, db and da are all 8-bit color at the moment, ranging in [0,255].
                                // We work in 16-bit color, and so would normally do:
                                // dr |= dr << 8
                                // and similarly for dg, db and da, but instead we multiply a
                                // (which is a 16-bit color, ranging in [0,65535]) by 0x101.
                                // This yields the same result, but is fewer arithmetic operations.
                                var a = (m - (sa * ma / m)) * 0x101UL;

                                d[0L] = uint8((dr * a + sr * ma) / m >> (int)(8L));
                                d[1L] = uint8((dg * a + sg * ma) / m >> (int)(8L));
                                d[2L] = uint8((db * a + sb * ma) / m >> (int)(8L));
                                d[3L] = uint8((da * a + sa * ma) / m >> (int)(8L));

                    y = y + dy;
                sy = sy + dy;
                my = my + dy;
                            }
                            else
                            {
                                d[0L] = uint8(sr * ma / m >> (int)(8L));
                                d[1L] = uint8(sg * ma / m >> (int)(8L));
                                d[2L] = uint8(sb * ma / m >> (int)(8L));
                                d[3L] = uint8(sa * ma / m >> (int)(8L));
                            }

                        }

                    }
                    i0 += dy * dst.Stride;

                }

            }

        }

        // clamp clamps i to the interval [0, 0xffff].
        private static int clamp(int i)
        {
            if (i < 0L)
            {
                return 0L;
            }

            if (i > 0xffffUL)
            {
                return 0xffffUL;
            }

            return i;

        }

        // sqDiff returns the squared-difference of x and y, shifted by 2 so that
        // adding four of those won't overflow a uint32.
        //
        // x and y are both assumed to be in the range [0, 0xffff].
        private static uint sqDiff(int x, int y)
        { 
            // This is an optimized code relying on the overflow/wrap around
            // properties of unsigned integers operations guaranteed by the language
            // spec. See sqDiff from the image/color package for more details.
            var d = uint32(x - y);
            return (d * d) >> (int)(2L);

        }

        private static void drawPaletted(Image dst, image.Rectangle r, image.Image src, image.Point sp, bool floydSteinberg)
        { 
            // TODO(nigeltao): handle the case where the dst and src overlap.
            // Does it even make sense to try and do Floyd-Steinberg whilst
            // walking the image backward (right-to-left bottom-to-top)?

            // If dst is an *image.Paletted, we have a fast path for dst.Set and
            // dst.At. The dst.Set equivalent is a batch version of the algorithm
            // used by color.Palette's Index method in image/color/color.go, plus
            // optional Floyd-Steinberg error diffusion.
            slice<array<int>> palette = (slice<array<int>>)null;
            slice<byte> pix = (slice<byte>)null;
            long stride = 0L;
            {
                ptr<image.Paletted> p__prev1 = p;

                ptr<image.Paletted> (p, ok) = dst._<ptr<image.Paletted>>();

                if (ok)
                {
                    palette = make_slice<array<int>>(len(p.Palette));
                    {
                        var i__prev1 = i;

                        foreach (var (__i, __col) in p.Palette)
                        {
                            i = __i;
                            col = __col;
                            var (r, g, b, a) = col.RGBA();
                            palette[i][0L] = int32(r);
                            palette[i][1L] = int32(g);
                            palette[i][2L] = int32(b);
                            palette[i][3L] = int32(a);
                        }

                        i = i__prev1;
                    }

                    pix = p.Pix[p.PixOffset(r.Min.X, r.Min.Y)..];
                    stride = p.Stride;

                } 

                // quantErrorCurr and quantErrorNext are the Floyd-Steinberg quantization
                // errors that have been propagated to the pixels in the current and next
                // rows. The +2 simplifies calculation near the edges.

                p = p__prev1;

            } 

            // quantErrorCurr and quantErrorNext are the Floyd-Steinberg quantization
            // errors that have been propagated to the pixels in the current and next
            // rows. The +2 simplifies calculation near the edges.
            slice<array<int>> quantErrorCurr = default;            slice<array<int>> quantErrorNext = default;

            if (floydSteinberg)
            {
                quantErrorCurr = make_slice<array<int>>(r.Dx() + 2L);
                quantErrorNext = make_slice<array<int>>(r.Dx() + 2L);
            }

            Func<long, long, (uint, uint, uint, uint)> pxRGBA = (x, y) => src.At(x, y).RGBA();
            } 
            // Fast paths for special cases to avoid excessive use of the color.Color
            // interface which escapes to the heap but need to be discovered for
            // each pixel on r. See also https://golang.org/issues/15759.; 
            // Fast paths for special cases to avoid excessive use of the color.Color
            // interface which escapes to the heap but need to be discovered for
            // each pixel on r. See also https://golang.org/issues/15759.
            switch (src.type())
            {
                case ptr<image.RGBA> src0:
                    pxRGBA = (x, y) => src0.RGBAAt(x, y).RGBA();
                    break;
                case ptr<image.NRGBA> src0:
                    pxRGBA = (x, y) => src0.NRGBAAt(x, y).RGBA();
                    break;
                case ptr<image.YCbCr> src0:
                    pxRGBA = (x, y) => src0.YCbCrAt(x, y).RGBA();
                    break; 

                // Loop over each source pixel.
            } 

            // Loop over each source pixel.
            ref color.RGBA64 @out = ref heap(new color.RGBA64(A:0xffff), out ptr<color.RGBA64> _addr_@out);
            for (long y = 0L; y != r.Dy(); y++)
            {
                for (long x = 0L; x != r.Dx(); x++)
                { 
                    // er, eg and eb are the pixel's R,G,B values plus the
                    // optional Floyd-Steinberg error.
                    var (sr, sg, sb, sa) = pxRGBA(sp.X + x, sp.Y + y);
                    var er = int32(sr);
                    var eg = int32(sg);
                    var eb = int32(sb);
                    var ea = int32(sa);
                    if (floydSteinberg)
                    {
                        er = clamp(er + quantErrorCurr[x + 1L][0L] / 16L);
                        eg = clamp(eg + quantErrorCurr[x + 1L][1L] / 16L);
                        eb = clamp(eb + quantErrorCurr[x + 1L][2L] / 16L);
                        ea = clamp(ea + quantErrorCurr[x + 1L][3L] / 16L);
                    }

                    if (palette != null)
                    { 
                        // Find the closest palette color in Euclidean R,G,B,A space:
                        // the one that minimizes sum-squared-difference.
                        // TODO(nigeltao): consider smarter algorithms.
                        long bestIndex = 0L;
                        var bestSum = uint32(1L << (int)(32L) - 1L);
                        {
                            ptr<image.Paletted> p__prev3 = p;

                            foreach (var (__index, __p) in palette)
                            {
                                index = __index;
                                p = __p;
                                var sum = sqDiff(er, p[0L]) + sqDiff(eg, p[1L]) + sqDiff(eb, p[2L]) + sqDiff(ea, p[3L]);
                                if (sum < bestSum)
                                {
                                    bestIndex = index;
                                    bestSum = sum;
                                    if (sum == 0L)
                                    {
                                        break;
                                    }

                                }

                            }
                    else

                            p = p__prev3;
                        }

                        pix[y * stride + x] = byte(bestIndex);

                        if (!floydSteinberg)
                        {
                            continue;
                        }

                        er -= palette[bestIndex][0L];
                        eg -= palette[bestIndex][1L];
                        eb -= palette[bestIndex][2L];
                        ea -= palette[bestIndex][3L];


                    }                    {
                        @out.R = uint16(er);
                        @out.G = uint16(eg);
                        @out.B = uint16(eb);
                        @out.A = uint16(ea); 
                        // The third argument is &out instead of out (and out is
                        // declared outside of the inner loop) to avoid the implicit
                        // conversion to color.Color here allocating memory in the
                        // inner loop if sizeof(color.RGBA64) > sizeof(uintptr).
                        dst.Set(r.Min.X + x, r.Min.Y + y, _addr_out);

                        if (!floydSteinberg)
                        {
                            continue;
                        }

                        sr, sg, sb, sa = dst.At(r.Min.X + x, r.Min.Y + y).RGBA();
                        er -= int32(sr);
                        eg -= int32(sg);
                        eb -= int32(sb);
                        ea -= int32(sa);

                    } 

                    // Propagate the Floyd-Steinberg quantization error.
                    quantErrorNext[x + 0L][0L] += er * 3L;
                    quantErrorNext[x + 0L][1L] += eg * 3L;
                    quantErrorNext[x + 0L][2L] += eb * 3L;
                    quantErrorNext[x + 0L][3L] += ea * 3L;
                    quantErrorNext[x + 1L][0L] += er * 5L;
                    quantErrorNext[x + 1L][1L] += eg * 5L;
                    quantErrorNext[x + 1L][2L] += eb * 5L;
                    quantErrorNext[x + 1L][3L] += ea * 5L;
                    quantErrorNext[x + 2L][0L] += er * 1L;
                    quantErrorNext[x + 2L][1L] += eg * 1L;
                    quantErrorNext[x + 2L][2L] += eb * 1L;
                    quantErrorNext[x + 2L][3L] += ea * 1L;
                    quantErrorCurr[x + 2L][0L] += er * 7L;
                    quantErrorCurr[x + 2L][1L] += eg * 7L;
                    quantErrorCurr[x + 2L][2L] += eb * 7L;
                    quantErrorCurr[x + 2L][3L] += ea * 7L;

                } 

                // Recycle the quantization error buffers.
 

                // Recycle the quantization error buffers.
                if (floydSteinberg)
                {
                    quantErrorCurr = quantErrorNext;
                    quantErrorNext = quantErrorCurr;
                    {
                        var i__prev2 = i;

                        foreach (var (__i) in quantErrorNext)
                        {
                            i = __i;
                            quantErrorNext[i] = new array<int>(new int[] {  });
                        }

                        i = i__prev2;
                    }
                }

            }


        }
    }
}}
