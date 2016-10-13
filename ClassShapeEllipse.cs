using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;

namespace geApp
{
    [DataContract]
    class ClassShapeEllipse : ClassShape
    {
        public override void Draw(Graphics g, int width, int height)
        {
            g.DrawEllipse(new Pen(Color, 1), _boundRectangle(width, height));
        }
    }
}
