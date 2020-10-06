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
            this.high_low_lbl = new System.Windows.Forms.Label();
            this.win_lose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enter_num)).BeginInit();
            this.SuspendLayout();
            // 
            // guess_bttn
            // 
            this.guess_bttn.AutoSize = true;
            this.guess_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess_bttn.Location = new System.Drawing.Point(361, 403);
            this.guess_bttn.Name = "guess_bttn";
            this.guess_bttn.Size = new System.Drawing.Size(84, 35);
            this.guess_bttn.TabIndex = 0;
            this.guess_bttn.Text = "Guess";
            this.guess_bttn.UseVisualStyleBackColor = true;
            this.guess_bttn.Click += new System.EventHandler(this.guess_bttn_Click);
            // 
            // dir_lbl
            // 
            this.dir_lbl.AutoSize = true;
            this.dir_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dir_lbl.Location = new System.Drawing.Point(326, 30);
            this.dir_lbl.Name = "dir_lbl";
            this.dir_lbl.Size = new System.Drawing.Size(150, 20);
            this.dir_lbl.TabIndex = 1;
            this.dir_lbl.Text = "Guess number here";
            // 
            // enter_num
            // 
            this.enter_num.Location = new System.Drawing.Point(361, 53);
            this.enter_num.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.enter_num.Name = "enter_num";
            this.enter_num.Size = new System.Drawing.Size(57, 20);
            this.enter_num.TabIndex = 2;
            // 
            // number_between
            // 
            this.number_between.AutoSize = true;
            this.number_between.Location = new System.Drawing.Point(321, 17);
            this.number_between.Name = "number_between";
            this.number_between.Size = new System.Drawing.Size(163, 13);
            this.number_between.TabIndex = 3;
            this.number_between.Text = "The number is between 1 and 10";
            // 
            // high_low_lbl
            // 
            this.high_low_lbl.AutoSize = true;
            this.high_low_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high_low_lbl.Location = new System.Drawing.Point(356, 208);
            this.high_low_lbl.Name = "high_low_lbl";
            this.high_low_lbl.Size = new System.Drawing.Size(79, 29);
            this.high_low_lbl.TabIndex = 4;
            this.high_low_lbl.Text = "label1";
            this.high_low_lbl.Visible = false;
            // 
            // win_lose
            // 
            this.win_lose.AutoSize = true;
            this.win_lose.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win_lose.Location = new System.Drawing.Point(295, 237);
            this.win_lose.Name = "win_lose";
            this.win_lose.Size = new System.Drawing.Size(204, 73);
            this.win_lose.TabIndex = 5;
            this.win_lose.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.win_lose);
            this.Controls.Add(this.high_low_lbl);
            this.Controls.Add(this.number_between);
            this.Controls.Add(this.enter_num);
            this.Controls.Add(this.dir_lbl);
            this.Controls.Add(this.guess_bttn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.enter_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guess_bttn;
        private System.Windows.Forms.Label dir_lbl;
        private System.Windows.Forms.NumericUpDown enter_num;
        private System.Windows.Forms.Label number_between;
        private System.Windows.Forms.Label high_low_lbl;
        private System.Windows.Forms.Label win_lose;
    }
}

