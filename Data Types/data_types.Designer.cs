namespace Data_Types
{
    partial class data_types
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
            this.numeric_button = new System.Windows.Forms.Button();
            this.bool_button = new System.Windows.Forms.Button();
            this.constant_button = new System.Windows.Forms.Button();
            this.string_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeric_button
            // 
            this.numeric_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_button.Location = new System.Drawing.Point(303, 97);
            this.numeric_button.Name = "numeric_button";
            this.numeric_button.Size = new System.Drawing.Size(156, 54);
            this.numeric_button.TabIndex = 0;
            this.numeric_button.Text = "Numeric Data";
            this.numeric_button.UseVisualStyleBackColor = true;
            this.numeric_button.Click += new System.EventHandler(this.numeric_button_Click);
            // 
            // bool_button
            // 
            this.bool_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bool_button.Location = new System.Drawing.Point(303, 157);
            this.bool_button.Name = "bool_button";
            this.bool_button.Size = new System.Drawing.Size(156, 54);
            this.bool_button.TabIndex = 1;
            this.bool_button.Text = "Bool Data";
            this.bool_button.UseVisualStyleBackColor = true;
            this.bool_button.Click += new System.EventHandler(this.bool_button_Click);
            // 
            // constant_button
            // 
            this.constant_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constant_button.Location = new System.Drawing.Point(303, 217);
            this.constant_button.Name = "constant_button";
            this.constant_button.Size = new System.Drawing.Size(156, 54);
            this.constant_button.TabIndex = 2;
            this.constant_button.Text = "Constant Data";
            this.constant_button.UseVisualStyleBackColor = true;
            this.constant_button.Click += new System.EventHandler(this.constant_button_Click);
            // 
            // string_button
            // 
            this.string_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.string_button.Location = new System.Drawing.Point(303, 277);
            this.string_button.Name = "string_button";
            this.string_button.Size = new System.Drawing.Size(156, 54);
            this.string_button.TabIndex = 3;
            this.string_button.Text = "String Data";
            this.string_button.UseVisualStyleBackColor = true;
            this.string_button.Click += new System.EventHandler(this.string_button_Click);
            // 
            // data_types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.string_button);
            this.Controls.Add(this.constant_button);
            this.Controls.Add(this.bool_button);
            this.Controls.Add(this.numeric_button);
            this.Name = "data_types";
            this.Text = "Experiments with Data Types";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button numeric_button;
        private System.Windows.Forms.Button bool_button;
        private System.Windows.Forms.Button constant_button;
        private System.Windows.Forms.Button string_button;
    }
}

