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

        void _imageRefresh()
        {
            panelImage.Invalidate();
        }

        void _addShape(Type t)
        {
            _model.AddShape(t);
            _imageRefresh();
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
//            _model.Draw(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panelImage_Paint(object sender, PaintEventArgs e)
        {
            _model.Draw(e.Graphics, (sender as Panel).Width, (sender as Panel).Height);
        }

        private void panelImage_Resize(object sender, EventArgs e)
        {
            _imageRefresh();
        }

        private void toolStripButtonIncrease_Click(object sender, EventArgs e)
        {
            _model.Increase();
            _imageRefresh();
        }

        private void toolStripButtonDecrease_Click(object sender, EventArgs e)
        {
            _model.Decrease();
            _imageRefresh();
        }

        private void toolStripButtonMoveLeft_Click(object sender, EventArgs e)
        {
            _model.Move(180, 0.1);
            _imageRefresh();
        }

        private void toolStripButtonMoveRight_Click(object sender, EventArgs e)
        {
            _model.Move(0, 0.1);
            _imageRefresh();
        }

        private void toolStripButtonMoveUp_Click(object sender, EventArgs e)
        {
            _model.Move(270, 0.1);
            _imageRefresh();
        }

        private void toolStripButtonMoveDown_Click(object sender, EventArgs e)
        {
            _model.Move(90, 0.1);
            _imageRefresh();
        }
    }
}
