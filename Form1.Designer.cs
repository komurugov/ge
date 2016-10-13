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
            this.toolStripButtonAddPolygon = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddEllipse = new System.Windows.Forms.ToolStripButton();
            this.panelImage = new System.Windows.Forms.Panel();
            this.toolStripOnSelect = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonIncrease = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDecrease = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMoveLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRed = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGreen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripCommon = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveToFiile = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripAdd.SuspendLayout();
            this.toolStripOnSelect.SuspendLayout();
            this.toolStripCommon.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddPolygon,
            this.toolStripButtonAddEllipse});
            this.toolStripAdd.Location = new System.Drawing.Point(0, 0);
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.Size = new System.Drawing.Size(517, 25);
            this.toolStripAdd.TabIndex = 0;
            this.toolStripAdd.Text = "toolStrip1";
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
            // panelImage
            // 
            this.panelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImage.Location = new System.Drawing.Point(12, 78);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(493, 335);
            this.panelImage.TabIndex = 3;
            this.panelImage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelImage_Paint);
            this.panelImage.Resize += new System.EventHandler(this.panelImage_Resize);
            // 
            // toolStripOnSelect
            // 
            this.toolStripOnSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonIncrease,
            this.toolStripButtonDecrease,
            this.toolStripSeparator1,
            this.toolStripButtonMoveLeft,
            this.toolStripButtonMoveRight,
            this.toolStripButtonMoveUp,
            this.toolStripButtonMoveDown,
            this.toolStripSeparator2,
            this.toolStripButtonBlack,
            this.toolStripButtonRed,
            this.toolStripButtonGreen,
            this.toolStripButtonBlue});
            this.toolStripOnSelect.Location = new System.Drawing.Point(0, 25);
            this.toolStripOnSelect.Name = "toolStripOnSelect";
            this.toolStripOnSelect.Size = new System.Drawing.Size(517, 25);
            this.toolStripOnSelect.TabIndex = 4;
            this.toolStripOnSelect.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonMoveLeft
            // 
            this.toolStripButtonMoveLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveLeft.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveLeft.Image")));
            this.toolStripButtonMoveLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveLeft.Name = "toolStripButtonMoveLeft";
            this.toolStripButtonMoveLeft.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveLeft.Text = "Move left";
            this.toolStripButtonMoveLeft.Click += new System.EventHandler(this.toolStripButtonMoveLeft_Click);
            // 
            // toolStripButtonMoveRight
            // 
            this.toolStripButtonMoveRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveRight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveRight.Image")));
            this.toolStripButtonMoveRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveRight.Name = "toolStripButtonMoveRight";
            this.toolStripButtonMoveRight.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveRight.Text = "Move right";
            this.toolStripButtonMoveRight.Click += new System.EventHandler(this.toolStripButtonMoveRight_Click);
            // 
            // toolStripButtonMoveUp
            // 
            this.toolStripButtonMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveUp.Image")));
            this.toolStripButtonMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveUp.Name = "toolStripButtonMoveUp";
            this.toolStripButtonMoveUp.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveUp.Text = "Move up";
            this.toolStripButtonMoveUp.Click += new System.EventHandler(this.toolStripButtonMoveUp_Click);
            // 
            // toolStripButtonMoveDown
            // 
            this.toolStripButtonMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveDown.Image")));
            this.toolStripButtonMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveDown.Name = "toolStripButtonMoveDown";
            this.toolStripButtonMoveDown.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveDown.Text = "Move down";
            this.toolStripButtonMoveDown.Click += new System.EventHandler(this.toolStripButtonMoveDown_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonBlack
            // 
            this.toolStripButtonBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBlack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBlack.Image")));
            this.toolStripButtonBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBlack.Name = "toolStripButtonBlack";
            this.toolStripButtonBlack.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBlack.Text = "Black";
            this.toolStripButtonBlack.Click += new System.EventHandler(this.toolStripButtonBlack_Click);
            // 
            // toolStripButtonRed
            // 
            this.toolStripButtonRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRed.Image")));
            this.toolStripButtonRed.ImageTransparentColor = System.Drawing.Color.MediumAquamarine;
            this.toolStripButtonRed.Name = "toolStripButtonRed";
            this.toolStripButtonRed.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRed.Text = "Red";
            this.toolStripButtonRed.Click += new System.EventHandler(this.toolStripButtonRed_Click);
            // 
            // toolStripButtonGreen
            // 
            this.toolStripButtonGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGreen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGreen.Image")));
            this.toolStripButtonGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGreen.Name = "toolStripButtonGreen";
            this.toolStripButtonGreen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGreen.Text = "Green";
            this.toolStripButtonGreen.Click += new System.EventHandler(this.toolStripButtonGreen_Click);
            // 
            // toolStripButtonBlue
            // 
            this.toolStripButtonBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBlue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBlue.Image")));
            this.toolStripButtonBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBlue.Name = "toolStripButtonBlue";
            this.toolStripButtonBlue.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBlue.Text = "Blue";
            this.toolStripButtonBlue.Click += new System.EventHandler(this.toolStripButtonBlue_Click);
            // 
            // toolStripCommon
            // 
            this.toolStripCommon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenFile,
            this.toolStripButtonSaveToFiile});
            this.toolStripCommon.Location = new System.Drawing.Point(0, 50);
            this.toolStripCommon.Name = "toolStripCommon";
            this.toolStripCommon.Size = new System.Drawing.Size(517, 25);
            this.toolStripCommon.TabIndex = 5;
            this.toolStripCommon.Text = "toolStrip2";
            // 
            // toolStripButtonOpenFile
            // 
            this.toolStripButtonOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenFile.Image")));
            this.toolStripButtonOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFile.Name = "toolStripButtonOpenFile";
            this.toolStripButtonOpenFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpenFile.Text = "Open file...";
            this.toolStripButtonOpenFile.Click += new System.EventHandler(this.toolStripButtonOpenFile_Click);
            // 
            // toolStripButtonSaveToFiile
            // 
            this.toolStripButtonSaveToFiile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveToFiile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveToFiile.Image")));
            this.toolStripButtonSaveToFiile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveToFiile.Name = "toolStripButtonSaveToFiile";
            this.toolStripButtonSaveToFiile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveToFiile.Text = "Save to file...";
            this.toolStripButtonSaveToFiile.Click += new System.EventHandler(this.toolStripButtonSaveToFiile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 425);
            this.Controls.Add(this.toolStripCommon);
            this.Controls.Add(this.toolStripOnSelect);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.toolStripAdd);
            this.Name = "FormMain";
            this.Text = "Graphic Editor";
            this.toolStripAdd.ResumeLayout(false);
            this.toolStripAdd.PerformLayout();
            this.toolStripOnSelect.ResumeLayout(false);
            this.toolStripOnSelect.PerformLayout();
            this.toolStripCommon.ResumeLayout(false);
            this.toolStripCommon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddPolygon;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddEllipse;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.ToolStrip toolStripOnSelect;
        private System.Windows.Forms.ToolStripButton toolStripButtonIncrease;
        private System.Windows.Forms.ToolStripButton toolStripButtonDecrease;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveLeft;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveRight;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveUp;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonBlack;
        private System.Windows.Forms.ToolStripButton toolStripButtonRed;
        private System.Windows.Forms.ToolStripButton toolStripButtonGreen;
        private System.Windows.Forms.ToolStripButton toolStripButtonBlue;
        private System.Windows.Forms.ToolStrip toolStripCommon;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveToFiile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

