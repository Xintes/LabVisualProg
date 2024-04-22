using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageEditor
{
    internal class ImageProcces
    {
        static byte[] BmpToArray(Bitmap source)
        {
            var result = new byte[source.Width * source.Height * 3];
            for (var i = 0; i < source.Width; i++)  {
                for (var j = 0; j < source.Height; j++) 
                {
                    Color pixel = source.GetPixel(i, j);
                    result[3 *(j * source.Width + i) + 0] = pixel.R;
                    result[3 * (j * source.Width + i) + 1] = pixel.G;
                    result[3 * (j * source.Width + i) + 2] = pixel.B;
                }
            }
            return result;
        }

        static Bitmap ArrayToBmp(byte[] source, int width, int height) 
        {
            var result = new Bitmap(width, height);
            for (int i = 0; i < width; i++)  {
                for (int j = 0;j < height; j++)
                {
                    int position = 3 *(j * width + i);
                    result.SetPixel(i, j, Color.FromArgb(source[position + 0], source[position + 1], source[position + 2]));
                }
            }
            return result;
        }
        static int RgbRange(int value)
        {
            if (value < 0) { value = 0; }   
            else if (value > 255) { value = 255; }
            return value;
        }
        public static Bitmap FilterImage(Bitmap source)
        {
            byte[] src = BmpToArray(source);
            byte[] res = new byte[src.Length];

            int[,] matrix = new int[3, 3] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };

            for (int i = 0;i < source.Width;i++) 
            { 
                for (int j = 0; j < source.Height; j++) 
                {
                    var r = 0;
                    var g = 0;
                    var b = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        for (int m = 0; m < 3; m++)
                        {
                            if (((j - 1 + m) < 0) || ((j - 1 + m) == source.Height)
                                || ((i - 1 + k) < 0) || ((i - 1 + k) == source.Width))
                            {
                                continue;
                            }

                            int position = 3 *(source.Width * (j-1 + m) + (i - 1 +k));
                            int matrixValue = matrix[k, m];


                        }
                    }
                }
            }

        }

    }
}
