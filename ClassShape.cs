using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;

namespace geApp
{
    [DataContract] abstract class ClassShape
    {
        [DataMember]
        public double Size { get; set; }
        [DataMember]
        public double PositionX { get; set; }
        [DataMember]
        public double PositionY { get; set; }
        [DataMember]
        public Color Color { get; set; }
        
        public abstract void Draw(System.Drawing.Graphics g, int width, int height);
        protected Rectangle _boundRectangle(int width, int height)
        {
            return new Rectangle((int)(width * PositionX), (int)(height * PositionY), (int)(width * Size), (int)(height * Size));
        }
    }
}
