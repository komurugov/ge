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
            this.panelImage = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonIncrease = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDecrease = new System.Windows.Forms.ToolStripButton();
            this.toolStripAdd.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            // panelImage
            // 
            this.panelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImage.Location = new System.Drawing.Point(12, 53);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(260, 197);
            this.panelImage.TabIndex = 3;
            this.panelImage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelImage_Paint);
            this.panelImage.Resize += new System.EventHandler(this.panelImage_Resize);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonIncrease,
            this.toolStripButtonDecrease});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonIncrease
            // 
            this.toolStripButtonIncrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIncrease.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIncrease.Image")));
            this.toolStripButtonIncrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIncrease.Name = "toolStripButtonIncrease";
            this.toolStripButtonIncrease.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonIncrease.Text = "toolStripButtonIncrease";
            this.toolStripButtonIncrease.ToolTipText = "Increase";
            this.toolStripButtonIncrease.Click += new System.EventHandler(this.toolStripButtonIncrease_Click);
            // 
            // toolStripButtonDecrease
            // 
            this.toolStripButtonDecrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDecrease.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDecrease.Image")));
            this.toolStripButtonDecrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDecrease.Name = "toolStripButtonDecrease";
            this.toolStripButtonDecrease.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDecrease.Text = "Decrease";
            this.toolStripButtonDecrease.Click += new System.EventHandler(this.toolStripButtonDecrease_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.toolStripAdd);
            this.Name = "FormMain";
            this.Text = "Graphic Editor";
            this.toolStripAdd.ResumeLayout(false);
            this.toolStripAdd.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddPolygon;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddEllipse;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonIncrease;
        private System.Windows.Forms.ToolStripButton toolStripButtonDecrease;
    }
}

