using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace geApp
{
    class ClassGE
    {
        List<ClassShape> _shapes = new List<ClassShape>();// { new ClassShapeEllipse() };

        public void AddShape(Type t)
        {
            if (t == typeof(ClassShapeEllipse))
                _shapes.Add(new ClassShapeEllipse());
            else if (t == typeof(ClassShapePolygon))
                _shapes.Add(new ClassShapePolygon());
        }

        public void Draw(Graphics g)
        {
//            Rectangle rectangle = new System.Drawing.Rectangle(0, 0, 150, 150);
  //          g.DrawEllipse(System.Drawing.Pens.Red, rectangle);
            foreach (var s in _shapes)
                s.Draw(g);
        }
    }
}
