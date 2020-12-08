namespace to_do_list
{
    partial class to_do_list
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
            this.item_txt_box = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.to_do_list_box = new System.Windows.Forms.ListBox();
            this.add_front_bttn = new System.Windows.Forms.Button();
            this.add_back_bttn = new System.Windows.Forms.Button();
            this.remove_bttn = new System.Windows.Forms.Button();
            this.clear_bbtn = new System.Windows.Forms.Button();
            this.add_after_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // item_txt_box
            // 
            this.item_txt_box.Location = new System.Drawing.Point(40, 31);
            this.item_txt_box.Name = "item_txt_box";
            this.item_txt_box.Size = new System.Drawing.Size(200, 20);
            this.item_txt_box.TabIndex = 0;
            this.item_txt_box.Text = "Test";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(40, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(144, 15);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Please enter a to-do item";
            // 
            // to_do_list_box
            // 
            this.to_do_list_box.FormattingEnabled = true;
            this.to_do_list_box.Items.AddRange(new object[] {
            "test 1",
            "test 2",
            "test 3"});
            this.to_do_list_box.Location = new System.Drawing.Point(40, 67);
            this.to_do_list_box.Name = "to_do_list_box";
            this.to_do_list_box.Size = new System.Drawing.Size(120, 134);
            this.to_do_list_box.TabIndex = 2;
            // 
            // add_front_bttn
            // 
            this.add_front_bttn.Location = new System.Drawing.Point(166, 67);
            this.add_front_bttn.Name = "add_front_bttn";
            this.add_front_bttn.Size = new System.Drawing.Size(75, 23);
            this.add_front_bttn.TabIndex = 3;
            this.add_front_bttn.Text = "Add Front";
            this.add_front_bttn.UseVisualStyleBackColor = true;
            this.add_front_bttn.Click += new System.EventHandler(this.add_front_bttn_Click);
            // 
            // add_back_bttn
            // 
            this.add_back_bttn.Location = new System.Drawing.Point(166, 96);
            this.add_back_bttn.Name = "add_back_bttn";
            this.add_back_bttn.Size = new System.Drawing.Size(75, 23);
            this.add_back_bttn.TabIndex = 4;
            this.add_back_bttn.Text = "Add Back";
            this.add_back_bttn.UseVisualStyleBackColor = true;
            this.add_back_bttn.Click += new System.EventHandler(this.add_front_bttn_Click);
            // 
            // remove_bttn
            // 
            this.remove_bttn.Location = new System.Drawing.Point(166, 154);
            this.remove_bttn.Name = "remove_bttn";
            this.remove_bttn.Size = new System.Drawing.Size(75, 23);
            this.remove_bttn.TabIndex = 5;
            this.remove_bttn.Text = "Remove";
            this.remove_bttn.UseVisualStyleBackColor = true;
            this.remove_bttn.Click += new System.EventHandler(this.add_front_bttn_Click);
            // 
            // clear_bbtn
            // 
            this.clear_bbtn.Location = new System.Drawing.Point(166, 183);
            this.clear_bbtn.Name = "clear_bbtn";
            this.clear_bbtn.Size = new System.Drawing.Size(75, 23);
            this.clear_bbtn.TabIndex = 6;
            this.clear_bbtn.Text = "Clear";
            this.clear_bbtn.UseVisualStyleBackColor = true;
            this.clear_bbtn.Click += new System.EventHandler(this.add_front_bttn_Click);
            // 
            // add_after_bttn
            // 
            this.add_after_bttn.Location = new System.Drawing.Point(166, 125);
            this.add_after_bttn.Name = "add_after_bttn";
            this.add_after_bttn.Size = new System.Drawing.Size(75, 23);
            this.add_after_bttn.TabIndex = 7;
            this.add_after_bttn.Text = "Add After";
            this.add_after_bttn.UseVisualStyleBackColor = true;
            this.add_after_bttn.Click += new System.EventHandler(this.add_front_bttn_Click);
            // 
            // to_do_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 236);
            this.Controls.Add(this.add_after_bttn);
            this.Controls.Add(this.clear_bbtn);
            this.Controls.Add(this.remove_bttn);
            this.Controls.Add(this.add_back_bttn);
            this.Controls.Add(this.add_front_bttn);
            this.Controls.Add(this.to_do_list_box);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.item_txt_box);
            this.Name = "to_do_list";
            this.Text = "My To-Do List";
            this.Load += new System.EventHandler(this.to_do_list_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox item_txt_box;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListBox to_do_list_box;
        private System.Windows.Forms.Button add_front_bttn;
        private System.Windows.Forms.Button add_back_bttn;
        private System.Windows.Forms.Button remove_bttn;
        private System.Windows.Forms.Button clear_bbtn;
        private System.Windows.Forms.Button add_after_bttn;
    }
}

