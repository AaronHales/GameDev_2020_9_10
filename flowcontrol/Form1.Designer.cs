namespace flowcontrol
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
            this.roll_bttn = new System.Windows.Forms.Button();
            this.player_name_lbl = new System.Windows.Forms.Label();
            this.comp_roll_lbl = new System.Windows.Forms.Label();
            this.player_score_lbl = new System.Windows.Forms.Label();
            this.comp_score_lbl = new System.Windows.Forms.Label();
            this.winner_lbl = new System.Windows.Forms.Label();
            this.win_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roll_bttn
            // 
            this.roll_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roll_bttn.Location = new System.Drawing.Point(305, 379);
            this.roll_bttn.Name = "roll_bttn";
            this.roll_bttn.Size = new System.Drawing.Size(186, 57);
            this.roll_bttn.TabIndex = 0;
            this.roll_bttn.Text = "Roll";
            this.roll_bttn.UseVisualStyleBackColor = true;
            this.roll_bttn.Click += new System.EventHandler(this.roll_bttn_Click);
            // 
            // player_name_lbl
            // 
            this.player_name_lbl.AutoSize = true;
            this.player_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_name_lbl.Location = new System.Drawing.Point(12, 56);
            this.player_name_lbl.Name = "player_name_lbl";
            this.player_name_lbl.Size = new System.Drawing.Size(161, 33);
            this.player_name_lbl.TabIndex = 1;
            this.player_name_lbl.Text = "Players roll";
            // 
            // comp_roll_lbl
            // 
            this.comp_roll_lbl.AutoSize = true;
            this.comp_roll_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp_roll_lbl.Location = new System.Drawing.Point(597, 56);
            this.comp_roll_lbl.Name = "comp_roll_lbl";
            this.comp_roll_lbl.Size = new System.Drawing.Size(191, 33);
            this.comp_roll_lbl.TabIndex = 2;
            this.comp_roll_lbl.Text = "Computer roll";
            // 
            // player_score_lbl
            // 
            this.player_score_lbl.AutoSize = true;
            this.player_score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_score_lbl.Location = new System.Drawing.Point(12, 89);
            this.player_score_lbl.Name = "player_score_lbl";
            this.player_score_lbl.Size = new System.Drawing.Size(29, 31);
            this.player_score_lbl.TabIndex = 3;
            this.player_score_lbl.Text = "0";
            // 
            // comp_score_lbl
            // 
            this.comp_score_lbl.AutoSize = true;
            this.comp_score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp_score_lbl.Location = new System.Drawing.Point(759, 89);
            this.comp_score_lbl.Name = "comp_score_lbl";
            this.comp_score_lbl.Size = new System.Drawing.Size(29, 31);
            this.comp_score_lbl.TabIndex = 4;
            this.comp_score_lbl.Text = "0";
            // 
            // winner_lbl
            // 
            this.winner_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winner_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner_lbl.Location = new System.Drawing.Point(12, 305);
            this.winner_lbl.Margin = new System.Windows.Forms.Padding(3);
            this.winner_lbl.Name = "winner_lbl";
            this.winner_lbl.Size = new System.Drawing.Size(776, 55);
            this.winner_lbl.TabIndex = 5;
            this.winner_lbl.Text = "label2";
            this.winner_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winner_lbl.Visible = false;
            // 
            // win_lbl
            // 
            this.win_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win_lbl.Location = new System.Drawing.Point(12, 269);
            this.win_lbl.Name = "win_lbl";
            this.win_lbl.Size = new System.Drawing.Size(776, 33);
            this.win_lbl.TabIndex = 6;
            this.win_lbl.Text = "The Winner is:";
            this.win_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.win_lbl);
            this.Controls.Add(this.winner_lbl);
            this.Controls.Add(this.comp_score_lbl);
            this.Controls.Add(this.player_score_lbl);
            this.Controls.Add(this.comp_roll_lbl);
            this.Controls.Add(this.player_name_lbl);
            this.Controls.Add(this.roll_bttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button roll_bttn;
        private System.Windows.Forms.Label player_name_lbl;
        private System.Windows.Forms.Label comp_roll_lbl;
        private System.Windows.Forms.Label player_score_lbl;
        private System.Windows.Forms.Label comp_score_lbl;
        private System.Windows.Forms.Label winner_lbl;
        private System.Windows.Forms.Label win_lbl;
    }
}

