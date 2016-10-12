using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace geApp
{
    class ClassGE
    {
        List<ClassShape> _shapes = new List<ClassShape>();
        public void AddShape(Type t)
        {
            if (t == typeof(ClassShapeEllipse))
                _shapes.Add(new ClassShapeEllipse());
            else if (t == typeof(ClassShapePolygon))
                _shapes.Add(new ClassShapePolygon());
        }
    }
}
