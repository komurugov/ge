using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace geApp
{
    class ClassShapeEllipse : ClassShape
    {
        public override void Draw(Graphics g)
        {
            Rectangle rectangle = new System.Drawing.Rectangle(0, 0, 150, 150);
            g.DrawEllipse(System.Drawing.Pens.Red, rectangle);
        }
    }
}
