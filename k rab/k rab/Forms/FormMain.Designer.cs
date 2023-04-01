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
            this.panel1 = new System.Windows.Forms.Panel();
            this.doubleBufferedPanel1 = new k_rab.DoubleBufferedPanel();
            this.SuspendLayout();
            // 
            // ElipseBtn
            // 
            this.ElipseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElipseBtn.Location = new System.Drawing.Point(158, 12);
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
            this.TriangleBtn.Location = new System.Drawing.Point(421, 12);
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
            this.SquareBtn.Location = new System.Drawing.Point(677, 12);
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
            this.RectangleBtn.Location = new System.Drawing.Point(927, 12);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(193, 67);
            this.RectangleBtn.TabIndex = 3;
            this.RectangleBtn.Text = "Rectangle";
            this.RectangleBtn.UseVisualStyleBackColor = true;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(58, 779);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 740);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // doubleBufferedPanel1
            // 
            this.doubleBufferedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(58, 103);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(1172, 766);
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
            this.ClientSize = new System.Drawing.Size(1314, 910);
            this.Controls.Add(this.doubleBufferedPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RectangleBtn);
            this.Controls.Add(this.SquareBtn);
            this.Controls.Add(this.TriangleBtn);
            this.Controls.Add(this.ElipseBtn);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ElipseBtn;
        private System.Windows.Forms.Button TriangleBtn;
        private System.Windows.Forms.Button SquareBtn;
        private System.Windows.Forms.Button RectangleBtn;
        private System.Windows.Forms.Panel panel1;
        private DoubleBufferedPanel doubleBufferedPanel1;
    }
}

