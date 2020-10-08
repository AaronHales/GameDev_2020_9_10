namespace Guess_Number
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
            this.guess_bttn = new System.Windows.Forms.Button();
            this.dir_lbl = new System.Windows.Forms.Label();
            this.enter_num = new System.Windows.Forms.NumericUpDown();
            this.number_between = new System.Windows.Forms.Label();
            this.win_lost_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enter_num)).BeginInit();
            this.SuspendLayout();
            // 
            // guess_bttn
            // 
            this.guess_bttn.AutoSize = true;
            this.guess_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess_bttn.Location = new System.Drawing.Point(302, 343);
            this.guess_bttn.Name = "guess_bttn";
            this.guess_bttn.Size = new System.Drawing.Size(203, 76);
            this.guess_bttn.TabIndex = 0;
            this.guess_bttn.Text = "Guess";
            this.guess_bttn.UseVisualStyleBackColor = true;
            this.guess_bttn.Click += new System.EventHandler(this.guess_bttn_Click);
            // 
            // dir_lbl
            // 
            this.dir_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dir_lbl.Location = new System.Drawing.Point(12, 150);
            this.dir_lbl.Name = "dir_lbl";
            this.dir_lbl.Size = new System.Drawing.Size(776, 20);
            this.dir_lbl.TabIndex = 1;
            this.dir_lbl.Text = "Guess number here";
            this.dir_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enter_num
            // 
            this.enter_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_num.Location = new System.Drawing.Point(376, 173);
            this.enter_num.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.enter_num.Name = "enter_num";
            this.enter_num.Size = new System.Drawing.Size(57, 29);
            this.enter_num.TabIndex = 2;
            // 
            // number_between
            // 
            this.number_between.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_between.Location = new System.Drawing.Point(12, 121);
            this.number_between.Name = "number_between";
            this.number_between.Size = new System.Drawing.Size(776, 29);
            this.number_between.TabIndex = 3;
            this.number_between.Text = "The number is between 1 and 10";
            this.number_between.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // win_lost_lbl
            // 
            this.win_lost_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 99F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win_lost_lbl.ForeColor = System.Drawing.Color.Gold;
            this.win_lost_lbl.Location = new System.Drawing.Point(12, 9);
            this.win_lost_lbl.Name = "win_lost_lbl";
            this.win_lost_lbl.Size = new System.Drawing.Size(776, 432);
            this.win_lost_lbl.TabIndex = 4;
            this.win_lost_lbl.Text = "label1";
            this.win_lost_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.win_lost_lbl);
            this.Controls.Add(this.number_between);
            this.Controls.Add(this.enter_num);
            this.Controls.Add(this.dir_lbl);
            this.Controls.Add(this.guess_bttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enter_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guess_bttn;
        private System.Windows.Forms.Label dir_lbl;
        private System.Windows.Forms.NumericUpDown enter_num;
        private System.Windows.Forms.Label number_between;
        private System.Windows.Forms.Label win_lost_lbl;
    }
}

