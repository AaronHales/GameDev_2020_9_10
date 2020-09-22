namespace windowsGUI
{
    partial class Start_Page
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
            this.creater_name = new System.Windows.Forms.Label();
            this.created_by = new System.Windows.Forms.Label();
            this.user_name_txt = new System.Windows.Forms.TextBox();
            this.user_name_lbl = new System.Windows.Forms.Label();
            this.user_age_spn = new System.Windows.Forms.NumericUpDown();
            this.user_age = new System.Windows.Forms.Label();
            this.submit_bttn = new System.Windows.Forms.Button();
            this.user_birthday_cal = new System.Windows.Forms.DateTimePicker();
            this.user_birthday = new System.Windows.Forms.Label();
            this.user_gender_m = new System.Windows.Forms.RadioButton();
            this.user_gender_f = new System.Windows.Forms.RadioButton();
            this.user_gender = new System.Windows.Forms.Label();
            this.user_family_lstbx = new System.Windows.Forms.ListBox();
            this.example_cmbx = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.user_age_spn)).BeginInit();
            this.SuspendLayout();
            // 
            // creater_name
            // 
            this.creater_name.AutoSize = true;
            this.creater_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creater_name.Location = new System.Drawing.Point(688, 425);
            this.creater_name.Name = "creater_name";
            this.creater_name.Size = new System.Drawing.Size(100, 16);
            this.creater_name.TabIndex = 0;
            this.creater_name.Text = "Aaron M. Hales";
            // 
            // created_by
            // 
            this.created_by.AutoSize = true;
            this.created_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.created_by.Location = new System.Drawing.Point(606, 425);
            this.created_by.Name = "created_by";
            this.created_by.Size = new System.Drawing.Size(78, 16);
            this.created_by.TabIndex = 1;
            this.created_by.Text = "Created By:";
            // 
            // user_name_txt
            // 
            this.user_name_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user_name_txt.Location = new System.Drawing.Point(116, 6);
            this.user_name_txt.Name = "user_name_txt";
            this.user_name_txt.Size = new System.Drawing.Size(278, 20);
            this.user_name_txt.TabIndex = 2;
            this.user_name_txt.Text = "Enter Name";
            this.user_name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // user_name_lbl
            // 
            this.user_name_lbl.AutoSize = true;
            this.user_name_lbl.Location = new System.Drawing.Point(7, 9);
            this.user_name_lbl.Name = "user_name_lbl";
            this.user_name_lbl.Size = new System.Drawing.Size(103, 13);
            this.user_name_lbl.TabIndex = 3;
            this.user_name_lbl.Text = "Enter your full name:";
            // 
            // user_age_spn
            // 
            this.user_age_spn.Location = new System.Drawing.Point(116, 42);
            this.user_age_spn.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.user_age_spn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.user_age_spn.Name = "user_age_spn";
            this.user_age_spn.Size = new System.Drawing.Size(66, 20);
            this.user_age_spn.TabIndex = 4;
            this.user_age_spn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user_age_spn.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.user_age_spn.ValueChanged += new System.EventHandler(this.urser_age_spn_ValueChanged);
            // 
            // user_age
            // 
            this.user_age.AutoSize = true;
            this.user_age.Location = new System.Drawing.Point(31, 44);
            this.user_age.Name = "user_age";
            this.user_age.Size = new System.Drawing.Size(79, 13);
            this.user_age.TabIndex = 5;
            this.user_age.Text = "Enter your age:";
            // 
            // submit_bttn
            // 
            this.submit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submit_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_bttn.Location = new System.Drawing.Point(280, 415);
            this.submit_bttn.Name = "submit_bttn";
            this.submit_bttn.Size = new System.Drawing.Size(198, 23);
            this.submit_bttn.TabIndex = 6;
            this.submit_bttn.Text = "Submit";
            this.submit_bttn.UseVisualStyleBackColor = true;
            this.submit_bttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_birthday_cal
            // 
            this.user_birthday_cal.Location = new System.Drawing.Point(116, 80);
            this.user_birthday_cal.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.user_birthday_cal.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.user_birthday_cal.Name = "user_birthday_cal";
            this.user_birthday_cal.Size = new System.Drawing.Size(200, 20);
            this.user_birthday_cal.TabIndex = 7;
            this.user_birthday_cal.Value = new System.DateTime(2020, 9, 22, 13, 16, 30, 0);
            // 
            // user_birthday
            // 
            this.user_birthday.AutoSize = true;
            this.user_birthday.Location = new System.Drawing.Point(12, 83);
            this.user_birthday.Name = "user_birthday";
            this.user_birthday.Size = new System.Drawing.Size(98, 13);
            this.user_birthday.TabIndex = 8;
            this.user_birthday.Text = "Enter your birthday:";
            // 
            // user_gender_m
            // 
            this.user_gender_m.AutoSize = true;
            this.user_gender_m.Location = new System.Drawing.Point(489, 25);
            this.user_gender_m.Name = "user_gender_m";
            this.user_gender_m.Size = new System.Drawing.Size(48, 17);
            this.user_gender_m.TabIndex = 9;
            this.user_gender_m.TabStop = true;
            this.user_gender_m.Text = "Male";
            this.user_gender_m.UseVisualStyleBackColor = true;
            // 
            // user_gender_f
            // 
            this.user_gender_f.AutoSize = true;
            this.user_gender_f.Location = new System.Drawing.Point(489, 42);
            this.user_gender_f.Name = "user_gender_f";
            this.user_gender_f.Size = new System.Drawing.Size(59, 17);
            this.user_gender_f.TabIndex = 10;
            this.user_gender_f.TabStop = true;
            this.user_gender_f.Text = "Female";
            this.user_gender_f.UseVisualStyleBackColor = true;
            // 
            // user_gender
            // 
            this.user_gender.AutoSize = true;
            this.user_gender.Location = new System.Drawing.Point(486, 9);
            this.user_gender.Name = "user_gender";
            this.user_gender.Size = new System.Drawing.Size(102, 13);
            this.user_gender.TabIndex = 11;
            this.user_gender.Text = "Choose you gender:";
            // 
            // user_family_lstbx
            // 
            this.user_family_lstbx.FormattingEnabled = true;
            this.user_family_lstbx.Items.AddRange(new object[] {
            "Brother 1",
            "Brother 2",
            "Brother 3",
            "Brother 4",
            "Brother 5"});
            this.user_family_lstbx.Location = new System.Drawing.Point(116, 120);
            this.user_family_lstbx.Name = "user_family_lstbx";
            this.user_family_lstbx.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.user_family_lstbx.Size = new System.Drawing.Size(120, 95);
            this.user_family_lstbx.TabIndex = 12;
            // 
            // example_cmbx
            // 
            this.example_cmbx.FormattingEnabled = true;
            this.example_cmbx.Items.AddRange(new object[] {
            "Test 1",
            "Test 2",
            "Test 3",
            "Test 4",
            "Test 5",
            "Test 6",
            "Test 7",
            "Test 8",
            "Test 9",
            "Test 10",
            "Test 11"});
            this.example_cmbx.Location = new System.Drawing.Point(273, 120);
            this.example_cmbx.Name = "example_cmbx";
            this.example_cmbx.Size = new System.Drawing.Size(121, 21);
            this.example_cmbx.TabIndex = 13;
            this.example_cmbx.Text = "Pick one";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(273, 189);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(273, 212);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(273, 235);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(273, 258);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Start_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.example_cmbx);
            this.Controls.Add(this.user_family_lstbx);
            this.Controls.Add(this.user_gender);
            this.Controls.Add(this.user_gender_f);
            this.Controls.Add(this.user_gender_m);
            this.Controls.Add(this.user_birthday);
            this.Controls.Add(this.user_birthday_cal);
            this.Controls.Add(this.submit_bttn);
            this.Controls.Add(this.user_age);
            this.Controls.Add(this.user_age_spn);
            this.Controls.Add(this.user_name_lbl);
            this.Controls.Add(this.user_name_txt);
            this.Controls.Add(this.created_by);
            this.Controls.Add(this.creater_name);
            this.Name = "Start_Page";
            this.Text = "Start Page";
            this.Load += new System.EventHandler(this.Start_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_age_spn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creater_name;
        private System.Windows.Forms.Label created_by;
        private System.Windows.Forms.TextBox user_name_txt;
        private System.Windows.Forms.Label user_name_lbl;
        private System.Windows.Forms.NumericUpDown user_age_spn;
        private System.Windows.Forms.Label user_age;
        private System.Windows.Forms.Button submit_bttn;
        private System.Windows.Forms.DateTimePicker user_birthday_cal;
        private System.Windows.Forms.Label user_birthday;
        private System.Windows.Forms.RadioButton user_gender_m;
        private System.Windows.Forms.RadioButton user_gender_f;
        private System.Windows.Forms.Label user_gender;
        private System.Windows.Forms.ListBox user_family_lstbx;
        private System.Windows.Forms.ComboBox example_cmbx;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

