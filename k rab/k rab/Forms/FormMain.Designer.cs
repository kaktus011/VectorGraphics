namespace k_rab
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ElipseBtn = new System.Windows.Forms.Button();
            this.TriangleBtn = new System.Windows.Forms.Button();
            this.SquareBtn = new System.Windows.Forms.Button();
            this.RectangleBtn = new System.Windows.Forms.Button();
            this.LabelForArea = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.DeleteShapeBtn = new System.Windows.Forms.Button();
            this.doubleBufferedPanel1 = new k_rab.DoubleBufferedPanel();
            this.SuspendLayout();
            // 
            // ElipseBtn
            // 
            this.ElipseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElipseBtn.Location = new System.Drawing.Point(160, 12);
            this.ElipseBtn.Name = "ElipseBtn";
            this.ElipseBtn.Size = new System.Drawing.Size(193, 67);
            this.ElipseBtn.TabIndex = 0;
            this.ElipseBtn.Text = "Elipse";
            this.ElipseBtn.UseVisualStyleBackColor = true;
            this.ElipseBtn.Click += new System.EventHandler(this.ElipseBtn_Click);
            // 
            // TriangleBtn
            // 
            this.TriangleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriangleBtn.Location = new System.Drawing.Point(423, 12);
            this.TriangleBtn.Name = "TriangleBtn";
            this.TriangleBtn.Size = new System.Drawing.Size(193, 67);
            this.TriangleBtn.TabIndex = 1;
            this.TriangleBtn.Text = "Triangle";
            this.TriangleBtn.UseVisualStyleBackColor = true;
            this.TriangleBtn.Click += new System.EventHandler(this.TriangleBtn_Click);
            // 
            // SquareBtn
            // 
            this.SquareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareBtn.Location = new System.Drawing.Point(679, 12);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(193, 67);
            this.SquareBtn.TabIndex = 2;
            this.SquareBtn.Text = "Square";
            this.SquareBtn.UseVisualStyleBackColor = true;
            this.SquareBtn.Click += new System.EventHandler(this.SquareBtn_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectangleBtn.Location = new System.Drawing.Point(929, 12);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(193, 67);
            this.RectangleBtn.TabIndex = 3;
            this.RectangleBtn.Text = "Rectangle";
            this.RectangleBtn.UseVisualStyleBackColor = true;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // LabelForArea
            // 
            this.LabelForArea.AutoSize = true;
            this.LabelForArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelForArea.Location = new System.Drawing.Point(688, 827);
            this.LabelForArea.Name = "LabelForArea";
            this.LabelForArea.Size = new System.Drawing.Size(352, 37);
            this.LabelForArea.TabIndex = 6;
            this.LabelForArea.Text = "Area of selected shape:";
            this.LabelForArea.Click += new System.EventHandler(this.LabelForArea_Click);
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaLabel.Location = new System.Drawing.Point(1040, 827);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(0, 37);
            this.AreaLabel.TabIndex = 7;
            // 
            // DeleteShapeBtn
            // 
            this.DeleteShapeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteShapeBtn.Location = new System.Drawing.Point(12, 825);
            this.DeleteShapeBtn.Name = "DeleteShapeBtn";
            this.DeleteShapeBtn.Size = new System.Drawing.Size(323, 63);
            this.DeleteShapeBtn.TabIndex = 8;
            this.DeleteShapeBtn.Text = "Delete selected shape";
            this.DeleteShapeBtn.UseVisualStyleBackColor = true;
            this.DeleteShapeBtn.Click += new System.EventHandler(this.DeleteShapeBtn_Click);
            // 
            // doubleBufferedPanel1
            // 
            this.doubleBufferedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(56, 85);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(1252, 734);
            this.doubleBufferedPanel1.TabIndex = 5;
            this.doubleBufferedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.doubleBufferedPanel1_Paint);
            this.doubleBufferedPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.doubleBufferedPanel1_MouseDown);
            this.doubleBufferedPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.doubleBufferedPanel1_MouseMove);
            this.doubleBufferedPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.doubleBufferedPanel1_MouseUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1368, 914);
            this.Controls.Add(this.DeleteShapeBtn);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.LabelForArea);
            this.Controls.Add(this.doubleBufferedPanel1);
            this.Controls.Add(this.RectangleBtn);
            this.Controls.Add(this.SquareBtn);
            this.Controls.Add(this.TriangleBtn);
            this.Controls.Add(this.ElipseBtn);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ElipseBtn;
        private System.Windows.Forms.Button TriangleBtn;
        private System.Windows.Forms.Button SquareBtn;
        private System.Windows.Forms.Button RectangleBtn;
        private DoubleBufferedPanel doubleBufferedPanel1;
        private System.Windows.Forms.Label LabelForArea;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Button DeleteShapeBtn;
    }
}

