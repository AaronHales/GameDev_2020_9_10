﻿namespace chapter_2_example
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(329, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 152);
            this.button1.TabIndex = 0;
            this.button1.Text = "im the best";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.No;
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(636, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 152);
            this.button2.TabIndex = 1;
            this.button2.Text = "click me";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.No;
            this.button3.ForeColor = System.Drawing.Color.Fuchsia;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(152, 152);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hello";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(455, 284);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Accept Score";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Location = new System.Drawing.Point(65, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "+1 point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Location = new System.Drawing.Point(380, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "+5 points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Location = new System.Drawing.Point(685, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "+7 points";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(349, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Location = new System.Drawing.Point(-88, -130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1406, 887);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

