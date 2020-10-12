namespace Jeepers__Beepers_
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
            this.num_beep_lbl = new System.Windows.Forms.Label();
            this.beeps_txt = new System.Windows.Forms.TextBox();
            this.for_bttn = new System.Windows.Forms.Button();
            this.while_bttn = new System.Windows.Forms.Button();
            this.do_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num_beep_lbl
            // 
            this.num_beep_lbl.AutoSize = true;
            this.num_beep_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_beep_lbl.Location = new System.Drawing.Point(18, 38);
            this.num_beep_lbl.Name = "num_beep_lbl";
            this.num_beep_lbl.Size = new System.Drawing.Size(137, 20);
            this.num_beep_lbl.TabIndex = 0;
            this.num_beep_lbl.Text = "Number of Beeps:";
            // 
            // beeps_txt
            // 
            this.beeps_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beeps_txt.Location = new System.Drawing.Point(161, 36);
            this.beeps_txt.MaxLength = 32678;
            this.beeps_txt.Name = "beeps_txt";
            this.beeps_txt.Size = new System.Drawing.Size(45, 24);
            this.beeps_txt.TabIndex = 1;
            // 
            // for_bttn
            // 
            this.for_bttn.AutoSize = true;
            this.for_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.for_bttn.Location = new System.Drawing.Point(47, 66);
            this.for_bttn.Name = "for_bttn";
            this.for_bttn.Size = new System.Drawing.Size(140, 28);
            this.for_bttn.TabIndex = 2;
            this.for_bttn.Text = "For Loop Button";
            this.for_bttn.UseVisualStyleBackColor = true;
            this.for_bttn.Click += new System.EventHandler(this.for_bttn_Click);
            // 
            // while_bttn
            // 
            this.while_bttn.AutoSize = true;
            this.while_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.while_bttn.Location = new System.Drawing.Point(47, 100);
            this.while_bttn.Name = "while_bttn";
            this.while_bttn.Size = new System.Drawing.Size(140, 28);
            this.while_bttn.TabIndex = 3;
            this.while_bttn.Text = "While Loop Button";
            this.while_bttn.UseVisualStyleBackColor = true;
            this.while_bttn.Click += new System.EventHandler(this.while_bttn_Click);
            // 
            // do_bttn
            // 
            this.do_bttn.AutoSize = true;
            this.do_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.do_bttn.Location = new System.Drawing.Point(47, 134);
            this.do_bttn.Name = "do_bttn";
            this.do_bttn.Size = new System.Drawing.Size(140, 28);
            this.do_bttn.TabIndex = 4;
            this.do_bttn.Text = "Do Loop Button";
            this.do_bttn.UseVisualStyleBackColor = true;
            this.do_bttn.Click += new System.EventHandler(this.do_bttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 225);
            this.Controls.Add(this.do_bttn);
            this.Controls.Add(this.while_bttn);
            this.Controls.Add(this.for_bttn);
            this.Controls.Add(this.beeps_txt);
            this.Controls.Add(this.num_beep_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num_beep_lbl;
        private System.Windows.Forms.TextBox beeps_txt;
        private System.Windows.Forms.Button for_bttn;
        private System.Windows.Forms.Button while_bttn;
        private System.Windows.Forms.Button do_bttn;
    }
}

