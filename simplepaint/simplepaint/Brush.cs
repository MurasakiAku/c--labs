using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace simplepaint
{
    abstract class Brush
    {
        public static int W, H;
        public static void Sizing(int w, int h)
        {
            W = w;
            H = h;
        }
        public Color BrushColor { get; set; }
        public int Size { get; set; }
        public Brush(Color brushColor, int size)
        {
            BrushColor = brushColor;
            Size = size;
            //if (x0 > 0 & y0 > 0 & x0 < W & y0 < H) { image.SetPixel(x0, y0, cColor); }
        }

      
        public abstract void Draw(Bitmap image, int x, int y);
    }
    class QuadBrush : Brush
    {
        public QuadBrush(Color brushColor, int size): base(brushColor, size)
        { }
        public override void Draw(Bitmap image, int x, int y)
        {

            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    if (x0 > 0 & y0 > 0 & x0 < W & y0 < H) { image.SetPixel(x0, y0, BrushColor); }
                
                }
            }
        }
    }
    class CircleBrush : Brush
    {
        public CircleBrush(Color brushColor, int size) : base(brushColor, size)
        { }
        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {

                    if ((x - x0) *(x - x0) + ((y - y0) * (y - y0)) < (Size * Size))
                    {
                        if (x0 > 0 & y0 > 0 & x0 < W & y0 < H) { image.SetPixel(x0, y0, BrushColor); }
                    }
                }
            }
        }
    }
    class RectangleBrush : Brush
    {
        public RectangleBrush(Color brushColor, int size) : base(brushColor, size)
        { }
        public override void Draw(Bitmap image, int x, int y)
        {
            
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {

                    if ((x + x0) + (x + x0) * ((y - y0) + (y - y0)) < (Size * Size))
                    {
                        if (x0 > 0 & y0 > 0 & x0 < W & y0 < H) { image.SetPixel(x0, y0, BrushColor); }
                    }
                }
            }
        }
    }
    //class LastikBrush : Brush
    //{
    //    public LastikBrush(Color brushColor, int size) : base(brushColor, size)
    //    { }
    //    public override void Draw(Bitmap image, int x, int y)
    //    {

    //        for (int y0 = y - Size; y0 < y + Size; ++y0)
    //        {
    //            for (int x0 = x - Size; x0 < x + Size; ++x0)
    //            {                 
    //                image.SetPixel(x0, y0, BrushColor);
                    
                    
    //            }
    //        }
    //    }
    }
    //class SnowFlakeBrush : Brush
    //{
    //    public SnowFlakeBrush(Color brushColor, int size) : base(brushColor, size)
    //    { }
    //    public override void Draw(Bitmap image, int x, int y)
    //    {
    //        int n = 6;
    //        double R = Size, r = Size * 2;
    //        double alpha = 0;
    //        double a=alpha, da = Math.PI / n, 1;
    //        for (int k=0; k<2*n + 1; k++)
    //        {
    //            for (int y0 = y - Size; y0 < y + Size; ++y0)
    //            {

    //                for (int x0 = x - Size; x0 < x + Size; ++x0)
    //                {
    //                    1 = k % 2 == 0 ? r : R;
    //                    int T = (int)(x0 + 1 * Math.Cos(a));
    //                    int Y = (int)(y0 + 1 * Math.Sin(a));
    //                    a += da;
    //                    image.SetPixel(T, Y, BrushColor);
    //                }
    //            }
    //        }
    //    }
    //}
//}


