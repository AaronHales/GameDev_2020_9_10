namespace eventform
{
    partial class Main
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
            this.first_name_txt = new System.Windows.Forms.TextBox();
            this.middle_name_txt = new System.Windows.Forms.TextBox();
            this.last_name_txt = new System.Windows.Forms.TextBox();
            this.first_name_lbl = new System.Windows.Forms.Label();
            this.middle_name_lbl = new System.Windows.Forms.Label();
            this.last_name_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(775, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // first_name_txt
            // 
            this.first_name_txt.Location = new System.Drawing.Point(13, 13);
            this.first_name_txt.Name = "first_name_txt";
            this.first_name_txt.Size = new System.Drawing.Size(186, 20);
            this.first_name_txt.TabIndex = 1;
            this.first_name_txt.TextChanged += new System.EventHandler(this.first_name_txt_TextChanged);
            // 
            // middle_name_txt
            // 
            this.middle_name_txt.Location = new System.Drawing.Point(293, 13);
            this.middle_name_txt.Name = "middle_name_txt";
            this.middle_name_txt.Size = new System.Drawing.Size(186, 20);
            this.middle_name_txt.TabIndex = 2;
            this.middle_name_txt.TextChanged += new System.EventHandler(this.middle_name_txt_TextChanged);
            // 
            // last_name_txt
            // 
            this.last_name_txt.Location = new System.Drawing.Point(602, 12);
            this.last_name_txt.Name = "last_name_txt";
            this.last_name_txt.Size = new System.Drawing.Size(186, 20);
            this.last_name_txt.TabIndex = 3;
            this.last_name_txt.TextChanged += new System.EventHandler(this.last_name_txt_TextChanged);
            // 
            // first_name_lbl
            // 
            this.first_name_lbl.AutoSize = true;
            this.first_name_lbl.Location = new System.Drawing.Point(12, 36);
            this.first_name_lbl.Name = "first_name_lbl";
            this.first_name_lbl.Size = new System.Drawing.Size(57, 13);
            this.first_name_lbl.TabIndex = 4;
            this.first_name_lbl.Text = "First Name";
            this.first_name_lbl.Click += new System.EventHandler(this.first_name_lbl_Click);
            // 
            // middle_name_lbl
            // 
            this.middle_name_lbl.AutoSize = true;
            this.middle_name_lbl.Location = new System.Drawing.Point(290, 36);
            this.middle_name_lbl.Name = "middle_name_lbl";
            this.middle_name_lbl.Size = new System.Drawing.Size(69, 13);
            this.middle_name_lbl.TabIndex = 5;
            this.middle_name_lbl.Text = "Middle Name";
            this.middle_name_lbl.Click += new System.EventHandler(this.middle_name_lbl_Click);
            // 
            // last_name_lbl
            // 
            this.last_name_lbl.AutoSize = true;
            this.last_name_lbl.Location = new System.Drawing.Point(599, 35);
            this.last_name_lbl.Name = "last_name_lbl";
            this.last_name_lbl.Size = new System.Drawing.Size(58, 13);
            this.last_name_lbl.TabIndex = 6;
            this.last_name_lbl.Text = "Last Name";
            this.last_name_lbl.Click += new System.EventHandler(this.last_name_lbl_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.last_name_lbl);
            this.Controls.Add(this.middle_name_lbl);
            this.Controls.Add(this.first_name_lbl);
            this.Controls.Add(this.last_name_txt);
            this.Controls.Add(this.middle_name_txt);
            this.Controls.Add(this.first_name_txt);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox first_name_txt;
        private System.Windows.Forms.TextBox middle_name_txt;
        private System.Windows.Forms.TextBox last_name_txt;
        private System.Windows.Forms.Label first_name_lbl;
        private System.Windows.Forms.Label middle_name_lbl;
        private System.Windows.Forms.Label last_name_lbl;
    }
}

