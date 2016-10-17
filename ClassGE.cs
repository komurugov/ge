using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;

namespace geApp
{
    [DataContract]
    class ClassGE    // модель данных, с которыми работает редактор. По сути - векторное изображение (набор фигур).
    {
        [DataMember]
        List<ClassShape> _shapes = new List<ClassShape>(); // фигуры
        ClassShape _select;                                             // выделенная в данный момент фигура

        public void AddShape(Type t)    // добавляем фигуру с заданным типом и параметрами по умолчанию и выделяем ее
        {
            _select = null;
            if (t == typeof(ClassShapeEllipse))
                _select = new ClassShapeEllipse();
            else if (t == typeof(ClassShapePolygon))
                _select = new ClassShapePolygon();
            if (_select != null)
            {
                _select.PositionX = 0;
                _select.PositionY = 0;
                _select.Size = 0.5;
                _select.Color = Color.Black;
                _shapes.Add(_select);
            }
        }

        public void Draw(Graphics g, int width, int height) // выводим изображение в Graphics указанных размеров (в пикселах)
        {
            foreach (var s in _shapes)
                s.Draw(g, width, height);
        }

        public void Increase()  // меняем размеры выделенной фигуры в 1.25 раза (подобрано чтобы 1.25 * 0.8 = 1.0)
        {
            if (_select != null)
                _select.Size *= 1.25;
        }

        public void Decrease()  // меняем размеры выделенной фигуры в 0.8 раза (подобрано чтобы 1.25 * 0.8 = 1.0)
        {
            if (_select != null)
                _select.Size *= 0.8;
        }

        public void Move(   // смещаем выделенную фигуру
            double angle,   // угол в градусах, задающий направление смещения
            double shift)   // модуль смещения в долях от размеров области вывода
        {
            if (_select != null)
            {
                _select.PositionX += shift * Math.Cos(angle * Math.PI / 180);
                _select.PositionY += shift * Math.Sin(angle * Math.PI / 180);
            }
        }

        public void ChangeColor(    // задаем цвет фигуры
            Color color)
        {
            if (_select != null)
                _select.Color = color;
        }

        public void SaveToFile(string fileName) // сохраняем в файл
        {
            var ds = new DataContractSerializer(typeof(ClassGE), new Type[] { typeof(ClassShapePolygon), typeof(ClassShapeEllipse) });
            using (Stream stream = File.Open(fileName, FileMode.Create))
                ds.WriteObject(stream, this);
        }

        public static ClassGE LoadFromFile(string fileName) // загружаем из файла
        {
            var ds = new DataContractSerializer(typeof(ClassGE), new Type[] { typeof(ClassShapePolygon), typeof(ClassShapeEllipse) });
            using (Stream stream = File.Open(fileName, FileMode.Open))
                return ds.ReadObject(stream) as ClassGE;
        }
    }
}
