using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace geApp
{
    abstract class ClassShape
    {
        public double Size { get; set; }
        public abstract void Draw(System.Drawing.Graphics g, int width, int height);
        protected Rectangle _boundRectangle(int width, int height)
        {
            return new Rectangle(0, 0, (int)(width * Size), (int)(height * Size));
        }
    }
}
