using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Function_Plotter
{
    class Grid
    {
        private uint width;
        private uint height;
        private int scale;

        private Color backgroundColor = Color.FromArgb(255, Color.FromName("White"));
        private Color axesColor = Color.FromArgb(255, Color.FromName("Black"));
        private Color gridColor = Color.FromArgb(255, Color.FromName("Grey"));

        private Bitmap gridBmp;

        public Grid(uint _width, uint _height, int _scale)
        {
            width = _width;
            height = _height;
            scale = _scale;

            gridBmp = new Bitmap((int)width, (int)height); // Must cap resolution on preview... or else you die.

            gridDraw();
        }

        private void gridDraw()
        {
            // DRAW CANVAS
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    gridBmp.SetPixel(x, y, backgroundColor);
                }
            }
            // DRAW GRID
            for (decimal y = 0; y < height; y += scale)
            {
                for (decimal x = 0; x < width; x++)
                {
                    gridBmp.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), gridColor);
                }
            }
            for (decimal x = 0; x < width; x += scale)
            {
                for (decimal y = 0; y < height; y++)
                {
                    gridBmp.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), gridColor);
                }
            }
            // DRAW AXES
            for (int y = 0; y < height; y++)
            {
                gridBmp.SetPixel((int)width / 2, y, axesColor);
                if (y % scale == 0)
                {
                    gridBmp.SetPixel((int)width / 2 + 1, y, axesColor);
                    gridBmp.SetPixel((int)width / 2 - 1, y, axesColor);
                }
            }
            for (int x = 0; x < width; x++)
            {
                gridBmp.SetPixel(x, (int)height / 2, axesColor);
                if (x % scale == 0)
                {
                    gridBmp.SetPixel(x, (int)height / 2 + 1, axesColor);
                    gridBmp.SetPixel(x, (int)height / 2 - 1, axesColor);
                }
            }
        }

        // -------- Properties --------

        public Bitmap GridBmp { get { return gridBmp; } }

        public Color BackgroundColor { get { return backgroundColor; } set { backgroundColor = value; } }
        public Color AxesColor { get { return axesColor; } set { axesColor = value; } }
        public Color GridColor { get { return gridColor; } set { gridColor = value; } }

        public uint Width { get { return width; } }
        public uint Height { get { return height; } }
        public int Scale { get { return scale; } }
    }
}
