namespace ConverterApp
{
    partial class frm_Main
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
            this.lbl_UofM = new System.Windows.Forms.Label();
            this.txt_UnitOfMeasure = new System.Windows.Forms.TextBox();
            this.btn_CM_to_Inches = new System.Windows.Forms.Button();
            this.btn_M_to_Feet = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Display = new System.Windows.Forms.Label();
            this.lbl_Convert = new System.Windows.Forms.Label();
            this.txt_Convert = new System.Windows.Forms.TextBox();
            this.Btn_Feet_Inches = new System.Windows.Forms.Button();
            this.btn_celsius_fahren = new System.Windows.Forms.Button();
            this.btn_fahrenheit_celsius = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_UofM
            // 
            this.lbl_UofM.AutoSize = true;
            this.lbl_UofM.Location = new System.Drawing.Point(12, 24);
            this.lbl_UofM.Name = "lbl_UofM";
            this.lbl_UofM.Size = new System.Drawing.Size(108, 17);
            this.lbl_UofM.TabIndex = 0;
            this.lbl_UofM.Text = "Unit of Measure";
            // 
            // txt_UnitOfMeasure
            // 
            this.txt_UnitOfMeasure.Location = new System.Drawing.Point(142, 21);
            this.txt_UnitOfMeasure.Name = "txt_UnitOfMeasure";
            this.txt_UnitOfMeasure.Size = new System.Drawing.Size(100, 22);
            this.txt_UnitOfMeasure.TabIndex = 1;
            // 
            // btn_CM_to_Inches
            // 
            this.btn_CM_to_Inches.Location = new System.Drawing.Point(12, 72);
            this.btn_CM_to_Inches.Name = "btn_CM_to_Inches";
            this.btn_CM_to_Inches.Size = new System.Drawing.Size(163, 23);
            this.btn_CM_to_Inches.TabIndex = 2;
            this.btn_CM_to_Inches.Text = "Centimetres to Inches";
            this.btn_CM_to_Inches.UseVisualStyleBackColor = true;
            this.btn_CM_to_Inches.Click += new System.EventHandler(this.btn_CM_to_Inches_Click);
            // 
            // btn_M_to_Feet
            // 
            this.btn_M_to_Feet.Location = new System.Drawing.Point(12, 101);
            this.btn_M_to_Feet.Name = "btn_M_to_Feet";
            this.btn_M_to_Feet.Size = new System.Drawing.Size(163, 23);
            this.btn_M_to_Feet.TabIndex = 3;
            this.btn_M_to_Feet.Text = "Metres to Feet";
            this.btn_M_to_Feet.UseVisualStyleBackColor = true;
            this.btn_M_to_Feet.Click += new System.EventHandler(this.btn_M_to_Feet_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(274, 220);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Display
            // 
            this.lbl_Display.AutoSize = true;
            this.lbl_Display.Location = new System.Drawing.Point(9, 159);
            this.lbl_Display.Name = "lbl_Display";
            this.lbl_Display.Size = new System.Drawing.Size(0, 17);
            this.lbl_Display.TabIndex = 5;
            // 
            // lbl_Convert
            // 
            this.lbl_Convert.AutoSize = true;
            this.lbl_Convert.Location = new System.Drawing.Point(283, 159);
            this.lbl_Convert.Name = "lbl_Convert";
            this.lbl_Convert.Size = new System.Drawing.Size(0, 17);
            this.lbl_Convert.TabIndex = 6;
            // 
            // txt_Convert
            // 
            this.txt_Convert.Location = new System.Drawing.Point(206, 154);
            this.txt_Convert.Name = "txt_Convert";
            this.txt_Convert.Size = new System.Drawing.Size(71, 22);
            this.txt_Convert.TabIndex = 7;
            // 
            // Btn_Feet_Inches
            // 
            this.Btn_Feet_Inches.Location = new System.Drawing.Point(12, 130);
            this.Btn_Feet_Inches.Name = "Btn_Feet_Inches";
            this.Btn_Feet_Inches.Size = new System.Drawing.Size(163, 23);
            this.Btn_Feet_Inches.TabIndex = 8;
            this.Btn_Feet_Inches.Text = "Feet to Centimetres";
            this.Btn_Feet_Inches.UseVisualStyleBackColor = true;
            this.Btn_Feet_Inches.Click += new System.EventHandler(this.Btn_Feet_Inches_Click);
            // 
            // btn_celsius_fahren
            // 
            this.btn_celsius_fahren.Location = new System.Drawing.Point(199, 72);
            this.btn_celsius_fahren.Name = "btn_celsius_fahren";
            this.btn_celsius_fahren.Size = new System.Drawing.Size(163, 23);
            this.btn_celsius_fahren.TabIndex = 9;
            this.btn_celsius_fahren.Text = "Celsius to Fahrenheit";
            this.btn_celsius_fahren.UseVisualStyleBackColor = true;
            this.btn_celsius_fahren.Click += new System.EventHandler(this.btn_celsius_fahren_Click);
            // 
            // btn_fahrenheit_celsius
            // 
            this.btn_fahrenheit_celsius.Location = new System.Drawing.Point(199, 101);
            this.btn_fahrenheit_celsius.Name = "btn_fahrenheit_celsius";
            this.btn_fahrenheit_celsius.Size = new System.Drawing.Size(163, 23);
            this.btn_fahrenheit_celsius.TabIndex = 10;
            this.btn_fahrenheit_celsius.Text = "Fahrenheit to celsius";
            this.btn_fahrenheit_celsius.UseVisualStyleBackColor = true;
            this.btn_fahrenheit_celsius.Click += new System.EventHandler(this.btn_fahrenheit_celsius_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 12;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Distance";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 255);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fahrenheit_celsius);
            this.Controls.Add(this.btn_celsius_fahren);
            this.Controls.Add(this.Btn_Feet_Inches);
            this.Controls.Add(this.txt_Convert);
            this.Controls.Add(this.lbl_Convert);
            this.Controls.Add(this.lbl_Display);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_M_to_Feet);
            this.Controls.Add(this.btn_CM_to_Inches);
            this.Controls.Add(this.txt_UnitOfMeasure);
            this.Controls.Add(this.lbl_UofM);
            this.Name = "frm_Main";
            this.Text = "ATCA Gas Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UofM;
        private System.Windows.Forms.TextBox txt_UnitOfMeasure;
        private System.Windows.Forms.Button btn_CM_to_Inches;
        private System.Windows.Forms.Button btn_M_to_Feet;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Display;
        private System.Windows.Forms.Label lbl_Convert;
        private System.Windows.Forms.TextBox txt_Convert;
        private System.Windows.Forms.Button Btn_Feet_Inches;
        private System.Windows.Forms.Button btn_celsius_fahren;
        private System.Windows.Forms.Button btn_fahrenheit_celsius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

