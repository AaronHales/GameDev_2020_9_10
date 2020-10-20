namespace Loops
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
            this.output_lbl = new System.Windows.Forms.Label();
            this.run_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output_lbl
            // 
            this.output_lbl.AutoSize = true;
            this.output_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_lbl.Location = new System.Drawing.Point(292, 134);
            this.output_lbl.Name = "output_lbl";
            this.output_lbl.Size = new System.Drawing.Size(109, 39);
            this.output_lbl.TabIndex = 0;
            this.output_lbl.Text = "label1";
            // 
            // run_bttn
            // 
            this.run_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_bttn.Location = new System.Drawing.Point(252, 241);
            this.run_bttn.Name = "run_bttn";
            this.run_bttn.Size = new System.Drawing.Size(168, 58);
            this.run_bttn.TabIndex = 1;
            this.run_bttn.Text = "Run";
            this.run_bttn.UseVisualStyleBackColor = true;
            this.run_bttn.Click += new System.EventHandler(this.run_bttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.run_bttn);
            this.Controls.Add(this.output_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output_lbl;
        private System.Windows.Forms.Button run_bttn;
    }
}

