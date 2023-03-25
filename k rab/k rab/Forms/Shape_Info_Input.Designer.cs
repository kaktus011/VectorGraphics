﻿using System;

namespace k_rab.Forms
{
    partial class Shape_Info_Input
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
            this.xValBox = new System.Windows.Forms.TextBox();
            this.yValBox = new System.Windows.Forms.TextBox();
            this.xValLabel = new System.Windows.Forms.Label();
            this.yValLabel = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.SideLengthBox = new System.Windows.Forms.TextBox();
            this.widthValLabel = new System.Windows.Forms.Label();
            this.heightValLabel = new System.Windows.Forms.Label();
            this.SideLengthLabel = new System.Windows.Forms.Label();
            this.Submit_InfoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xValBox
            // 
            this.xValBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xValBox.Location = new System.Drawing.Point(635, 125);
            this.xValBox.Name = "xValBox";
            this.xValBox.Size = new System.Drawing.Size(202, 53);
            this.xValBox.TabIndex = 0;
            this.xValBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // yValBox
            // 
            this.yValBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yValBox.Location = new System.Drawing.Point(635, 214);
            this.yValBox.Name = "yValBox";
            this.yValBox.Size = new System.Drawing.Size(202, 53);
            this.yValBox.TabIndex = 1;
            // 
            // xValLabel
            // 
            this.xValLabel.AutoSize = true;
            this.xValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xValLabel.Location = new System.Drawing.Point(456, 125);
            this.xValLabel.Name = "xValLabel";
            this.xValLabel.Size = new System.Drawing.Size(152, 46);
            this.xValLabel.TabIndex = 2;
            this.xValLabel.Text = "X value";
            // 
            // yValLabel
            // 
            this.yValLabel.AutoSize = true;
            this.yValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yValLabel.Location = new System.Drawing.Point(457, 221);
            this.yValLabel.Name = "yValLabel";
            this.yValLabel.Size = new System.Drawing.Size(151, 46);
            this.yValLabel.TabIndex = 3;
            this.yValLabel.Text = "Y value";
            // 
            // WidthBox
            // 
            this.WidthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthBox.Location = new System.Drawing.Point(634, 404);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(202, 53);
            this.WidthBox.TabIndex = 4;
            this.WidthBox.TextChanged += new System.EventHandler(this.WidthBox_TextChanged);
            // 
            // HeightBox
            // 
            this.HeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightBox.Location = new System.Drawing.Point(634, 504);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(202, 53);
            this.HeightBox.TabIndex = 5;
            this.HeightBox.TextChanged += new System.EventHandler(this.HeightBox_TextChanged);
            // 
            // SideLengthBox
            // 
            this.SideLengthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideLengthBox.Location = new System.Drawing.Point(634, 314);
            this.SideLengthBox.Name = "SideLengthBox";
            this.SideLengthBox.Size = new System.Drawing.Size(202, 53);
            this.SideLengthBox.TabIndex = 6;
            this.SideLengthBox.TextChanged += new System.EventHandler(this.SideLengthBox_TextChanged);
            // 
            // widthValLabel
            // 
            this.widthValLabel.AutoSize = true;
            this.widthValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthValLabel.Location = new System.Drawing.Point(456, 407);
            this.widthValLabel.Name = "widthValLabel";
            this.widthValLabel.Size = new System.Drawing.Size(122, 46);
            this.widthValLabel.TabIndex = 7;
            this.widthValLabel.Text = "Width";
            this.widthValLabel.Click += new System.EventHandler(this.WidthValLabel_Click);
            // 
            // heightValLabel
            // 
            this.heightValLabel.AutoSize = true;
            this.heightValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightValLabel.Location = new System.Drawing.Point(456, 511);
            this.heightValLabel.Name = "heightValLabel";
            this.heightValLabel.Size = new System.Drawing.Size(135, 46);
            this.heightValLabel.TabIndex = 8;
            this.heightValLabel.Text = "Height";
            this.heightValLabel.Click += new System.EventHandler(this.HeightValLabel_Click);
            // 
            // SideLengthLabel
            // 
            this.SideLengthLabel.AutoSize = true;
            this.SideLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideLengthLabel.Location = new System.Drawing.Point(375, 314);
            this.SideLengthLabel.Name = "SideLengthLabel";
            this.SideLengthLabel.Size = new System.Drawing.Size(232, 46);
            this.SideLengthLabel.TabIndex = 9;
            this.SideLengthLabel.Text = "Side Length";
            this.SideLengthLabel.Click += new System.EventHandler(this.SideLengthLabel_Click);
            // 
            // Submit_InfoBtn
            // 
            this.Submit_InfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_InfoBtn.Location = new System.Drawing.Point(535, 686);
            this.Submit_InfoBtn.Name = "Submit_InfoBtn";
            this.Submit_InfoBtn.Size = new System.Drawing.Size(227, 91);
            this.Submit_InfoBtn.TabIndex = 10;
            this.Submit_InfoBtn.Text = "Submit";
            this.Submit_InfoBtn.UseVisualStyleBackColor = true;
            this.Submit_InfoBtn.Click += new System.EventHandler(this.Submit_InfoBtn_Click);
            // 
            // Shape_Info_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 888);
            this.Controls.Add(this.Submit_InfoBtn);
            this.Controls.Add(this.SideLengthLabel);
            this.Controls.Add(this.heightValLabel);
            this.Controls.Add(this.widthValLabel);
            this.Controls.Add(this.SideLengthBox);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.yValLabel);
            this.Controls.Add(this.xValLabel);
            this.Controls.Add(this.yValBox);
            this.Controls.Add(this.xValBox);
            this.Name = "Shape_Info_Input";
            this.Text = "Shape Info ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox xValBox;
        private System.Windows.Forms.TextBox yValBox;
        private System.Windows.Forms.Label xValLabel;
        private System.Windows.Forms.Label yValLabel;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox SideLengthBox;
        private System.Windows.Forms.Label widthValLabel;
        private System.Windows.Forms.Label heightValLabel;
        private System.Windows.Forms.Label SideLengthLabel;
        private System.Windows.Forms.Button Submit_InfoBtn;
    }
}