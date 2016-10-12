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
        ClassShape _select;

        public void AddShape(Type t)
        {
            _select = null;
            if (t == typeof(ClassShapeEllipse))
                _select = new ClassShapeEllipse();
            else if (t == typeof(ClassShapePolygon))
                _select = new ClassShapePolygon();
            if (_select != null)
            {
                _select.Size = 0.5;
                _shapes.Add(_select);
            }
        }

        public void Draw(Graphics g, int width, int height)
        {
//            Rectangle rectangle = new System.Drawing.Rectangle(0, 0, 150, 150);
  //          g.DrawEllipse(System.Drawing.Pens.Red, rectangle);
            foreach (var s in _shapes)
                s.Draw(g, width, height);
        }

        public void Increase()
        {
            if (_select != null)
                _select.Size *= 1.25;
        }

        public void Decrease()
        {
            if (_select != null)
                _select.Size *= 0.8;
        }
    }
}
