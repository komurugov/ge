using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;

namespace geApp
{
    [DataContract] abstract class ClassShape    // фигура
    {
        [DataMember]
        public double Size { get; set; }    // размер ограничивающего прямоугольника относительно размеров области вывода
                                            // например при Size == 1.0 ограничивающий прямоугольник размером со всю область вывода

        // положение верхнего левого угла ограничивающего прямоугольника относительно размеров области вывода
        // например при PositionX == 0.5 и PositionY == 0.5 этот угол находится в центре области вывода
        [DataMember]
        public double PositionX { get; set; }
        [DataMember]
        public double PositionY { get; set; }

        [DataMember]
        public Color Color { get; set; }    // цвет
        
        public abstract void Draw(System.Drawing.Graphics g, int width, int height);    // вывод в Graphics с указанными размерами области вывода в пикселах

        protected Rectangle _boundRectangle(int width, int height)  // возвращает ограничивающий прямоугольник в пикселах на области вывода указанных размеров в пикселах
        {
            return new Rectangle((int)(width * PositionX), (int)(height * PositionY), (int)(width * Size), (int)(height * Size));
        }
    }

    interface IShapeMetaData
    {
        string GetName();
    }
}
