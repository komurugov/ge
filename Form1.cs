using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace geApp
{
    public partial class FormMain : Form
    {
        ClassGE _model = new ClassGE();
        Graphics _graphics;

        public FormMain()
        {
            InitializeComponent();

            _graphics = CreateGraphics();
        }

        void _addShape(Type t)
        {
            _model.AddShape(t);
            panelImage.Invalidate();
        }

        private void toolStripButtonAddPolygon_Click(object sender, EventArgs e)
        {
            _addShape(typeof(ClassShapePolygon));
        }

        private void toolStripButtonAddEllipse_Click(object sender, EventArgs e)
        {
            _addShape(typeof(ClassShapeEllipse));
        }

        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            _model.Draw(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panelImage_Paint(object sender, PaintEventArgs e)
        {
            _model.Draw(e.Graphics);
        }
    }
}
