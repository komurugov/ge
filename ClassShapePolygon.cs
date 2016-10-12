using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace geApp
{
    class ClassShapePolygon : ClassShape
    {
        public override void Draw(Graphics g, int width, int height)
        {
            g.DrawRectangle(System.Drawing.Pens.Red, _boundRectangle(width, height));
        }
    }
}
