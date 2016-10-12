namespace geApp
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripAdd = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddPolygon = new System.Windows.Forms.ToolStripButton();
            this.toolStripAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddPolygon,
            this.toolStripButtonAddEllipse});
            this.toolStripAdd.Location = new System.Drawing.Point(0, 0);
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.Size = new System.Drawing.Size(284, 25);
            this.toolStripAdd.TabIndex = 0;
            this.toolStripAdd.Text = "toolStrip1";
            // 
            // toolStripButtonAddEllipse
            // 
            this.toolStripButtonAddEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddEllipse.Image")));
            this.toolStripButtonAddEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddEllipse.Name = "toolStripButtonAddEllipse";
            this.toolStripButtonAddEllipse.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddEllipse.Text = "Add an ellipse";
            this.toolStripButtonAddEllipse.ToolTipText = "Add an ellipse";
            this.toolStripButtonAddEllipse.Click += new System.EventHandler(this.toolStripButtonAddEllipse_Click);
            // 
            // toolStripButtonAddPolygon
            // 
            this.toolStripButtonAddPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddPolygon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddPolygon.Image")));
            this.toolStripButtonAddPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddPolygon.Name = "toolStripButtonAddPolygon";
            this.toolStripButtonAddPolygon.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddPolygon.Text = "Add a polygon";
            this.toolStripButtonAddPolygon.ToolTipText = "Add a polygon";
            this.toolStripButtonAddPolygon.Click += new System.EventHandler(this.toolStripButtonAddPolygon_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.toolStripAdd);
            this.Name = "FormMain";
            this.Text = "Graphic Editor";
            this.toolStripAdd.ResumeLayout(false);
            this.toolStripAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddPolygon;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddEllipse;
    }
}

