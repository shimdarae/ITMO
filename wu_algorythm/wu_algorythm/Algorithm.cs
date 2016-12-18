using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace wu_algorythm
{
    static class Algorithm
    {
        
        public static void DrawWuLine(Graphics g, Color clr, int x0, int y0, int x1, int y1)
        {
            //Вычисление изменения координат
            int dx = (x1 > x0) ? (x1 - x0) : (x0 - x1);
            int dy = (y1 > y0) ? (y1 - y0) : (y0 - y1);
            
            if (dx == 0 || dy == 0)
            {
                g.DrawLine(new Pen(clr), x0, y0, x1, y1);
                return;
            }

            //Для Х-линии (коэффициент наклона < 1)
            if (dy < dx)
            {
                
                if (x1 < x0)
                {
                    x1 += x0; x0 = x1 - x0; x1 -= x0;
                    y1 += y0; y0 = y1 - y0; y1 -= y0;
                }
                
                float grad = (float)dy / dx;
                float intery = y0 + grad;
                PutPixel(g, clr, x0, y0, 255);

                for (int x = x0 + 1; x < x1; x++)
                {
                    PutPixel(g, clr, x, IPart(intery), (int)(255 - FPart(intery) * 255));
                    PutPixel(g, clr, x, IPart(intery) + 1, (int)(FPart(intery) * 255));
                    intery += grad;
                }
                PutPixel(g, clr, x1, y1, 255);
            }
            //Для Y-линии (коэффициент наклона > 1)
            else
            {
                if (y1 < y0)
                {
                    x1 += x0; x0 = x1 - x0; x1 -= x0;
                    y1 += y0; y0 = y1 - y0; y1 -= y0;
                }
                float grad = (float)dx / dy;
                float interx = x0 + grad;
                PutPixel(g, clr, x0, y0, 255);

                for (int y = y0 + 1; y < y1; y++)
                {
                    PutPixel(g, clr, IPart(interx), y, 255 - (int)(FPart(interx) * 255));
                    PutPixel(g, clr, IPart(interx) + 1, y, (int)(FPart(interx) * 255));
                    interx += grad;
                }
                PutPixel(g, clr, x1, y1, 255);
            }
        }

            private static void PutPixel(Graphics g, Color col, int x, int y, int alpha)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(alpha, col)), x, y, 1, 1);
        }
        private static int IPart(float x)
        {
            return (int)x;
        }
        private static float FPart(float x)
        {
            while (x >= 0)
                x--;
            x++;
            return x;
        }
    }


    }
