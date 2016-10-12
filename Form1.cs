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

        public FormMain()
        {
            InitializeComponent();


        }

        private void toolStripButtonAddPolygon_Click(object sender, EventArgs e)
        {
            _model.AddShape(typeof(ClassShapePolygon));
        }

        private void toolStripButtonAddEllipse_Click(object sender, EventArgs e)
        {
            _model.AddShape(typeof(ClassShapeEllipse));
        }
    }
}
