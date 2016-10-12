using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace geApp
{
    class ClassShapePolygon : ClassShape
    {
        public override void Draw(Graphics g)
        {
            Rectangle rectangle = new System.Drawing.Rectangle(0, 0, 150, 150);
            g.DrawRectangle(System.Drawing.Pens.Red, rectangle);
        }
    }
}
