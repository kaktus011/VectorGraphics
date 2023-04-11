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
            this.ChangeColorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BorderColorBtn = new System.Windows.Forms.Button();
            this.EditShapeBtn = new System.Windows.Forms.Button();
            this.UndoBtn = new System.Windows.Forms.Button();
            this.RedoBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.DoubleBufferedPanel1 = new k_rab.DoubleBufferedPanel();
            this.SuspendLayout();
            // 
            // ElipseBtn
            // 
            this.ElipseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElipseBtn.Location = new System.Drawing.Point(319, 12);
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
            this.TriangleBtn.Location = new System.Drawing.Point(518, 12);
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
            this.SquareBtn.Location = new System.Drawing.Point(717, 12);
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
            this.RectangleBtn.Location = new System.Drawing.Point(916, 12);
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
            // ChangeColorBtn
            // 
            this.ChangeColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeColorBtn.Location = new System.Drawing.Point(203, 894);
            this.ChangeColorBtn.Name = "ChangeColorBtn";
            this.ChangeColorBtn.Size = new System.Drawing.Size(173, 54);
            this.ChangeColorBtn.TabIndex = 9;
            this.ChangeColorBtn.Text = "Shape";
            this.ChangeColorBtn.UseVisualStyleBackColor = true;
            this.ChangeColorBtn.Click += new System.EventHandler(this.ChangeColorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 901);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Edit color of:";
            // 
            // BorderColorBtn
            // 
            this.BorderColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorderColorBtn.Location = new System.Drawing.Point(382, 894);
            this.BorderColorBtn.Name = "BorderColorBtn";
            this.BorderColorBtn.Size = new System.Drawing.Size(188, 54);
            this.BorderColorBtn.TabIndex = 11;
            this.BorderColorBtn.Text = "Shape border";
            this.BorderColorBtn.UseVisualStyleBackColor = true;
            this.BorderColorBtn.Click += new System.EventHandler(this.BorderColorBtn_Click);
            // 
            // EditShapeBtn
            // 
            this.EditShapeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditShapeBtn.Location = new System.Drawing.Point(341, 827);
            this.EditShapeBtn.Name = "EditShapeBtn";
            this.EditShapeBtn.Size = new System.Drawing.Size(282, 63);
            this.EditShapeBtn.TabIndex = 12;
            this.EditShapeBtn.Text = "Edit selected shape";
            this.EditShapeBtn.UseVisualStyleBackColor = true;
            this.EditShapeBtn.Click += new System.EventHandler(this.EditShapeBtn_Click);
            // 
            // UndoBtn
            // 
            this.UndoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndoBtn.Location = new System.Drawing.Point(19, 12);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(111, 67);
            this.UndoBtn.TabIndex = 13;
            this.UndoBtn.Text = "Undo";
            this.UndoBtn.UseVisualStyleBackColor = true;
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // RedoBtn
            // 
            this.RedoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedoBtn.Location = new System.Drawing.Point(136, 12);
            this.RedoBtn.Name = "RedoBtn";
            this.RedoBtn.Size = new System.Drawing.Size(115, 67);
            this.RedoBtn.TabIndex = 14;
            this.RedoBtn.Text = "Redo";
            this.RedoBtn.UseVisualStyleBackColor = true;
            this.RedoBtn.Click += new System.EventHandler(this.RedoBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(717, 879);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(193, 69);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Save to:";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Location = new System.Drawing.Point(916, 879);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(193, 69);
            this.LoadBtn.TabIndex = 16;
            this.LoadBtn.Text = "Load from:";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // DoubleBufferedPanel1
            // 
            this.DoubleBufferedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoubleBufferedPanel1.Location = new System.Drawing.Point(19, 85);
            this.DoubleBufferedPanel1.Name = "DoubleBufferedPanel1";
            this.DoubleBufferedPanel1.Size = new System.Drawing.Size(1291, 734);
            this.DoubleBufferedPanel1.TabIndex = 5;
            this.DoubleBufferedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.DoubleBufferedPanel1_Paint);
            this.DoubleBufferedPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DoubleBufferedPanel1_MouseDown);
            this.DoubleBufferedPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DoubleBufferedPanel1_MouseMove);
            this.DoubleBufferedPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DoubleBufferedPanel1_MouseUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1322, 1012);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.RedoBtn);
            this.Controls.Add(this.UndoBtn);
            this.Controls.Add(this.EditShapeBtn);
            this.Controls.Add(this.BorderColorBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeColorBtn);
            this.Controls.Add(this.DeleteShapeBtn);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.LabelForArea);
            this.Controls.Add(this.DoubleBufferedPanel1);
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
        private DoubleBufferedPanel DoubleBufferedPanel1;
        private System.Windows.Forms.Label LabelForArea;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Button DeleteShapeBtn;
        private System.Windows.Forms.Button ChangeColorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BorderColorBtn;
        private System.Windows.Forms.Button EditShapeBtn;
        private System.Windows.Forms.Button UndoBtn;
        private System.Windows.Forms.Button RedoBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
    }
}

