using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;

namespace geApp
{
    [DataContract]
    class ClassShapePolygon : ClassShape    // многоугольник
                                            // точнее для простоты пока квадрат
    {
        public override void Draw(Graphics g, int width, int height)
        {
            g.DrawRectangle(new Pen(Color, 1), _boundRectangle(width, height));
        }
    }
}
