﻿namespace Fitness_Tracker
{
    partial class Health_Details
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(140, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 46);
            label1.TabIndex = 0;
            label1.Text = "HEALTH DETAILS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(226, 35);
            label2.TabIndex = 1;
            label2.Text = "Enter Your Details...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(24, 135);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 2;
            label3.Text = "Height : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(20, 188);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 3;
            label4.Text = "Weight : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(115, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 27);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.5F);
            label5.Location = new Point(274, 146);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 6;
            label5.Text = "cm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.5F);
            label6.Location = new Point(274, 195);
            label6.Name = "label6";
            label6.Size = new Size(26, 20);
            label6.TabIndex = 7;
            label6.Text = "kg";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(24, 243);
            label7.Name = "label7";
            label7.Size = new Size(60, 28);
            label7.TabIndex = 8;
            label7.Text = "BMI : ";
            label7.Click += label7_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 27);
            textBox3.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 20F);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(115, 331);
            button1.Name = "button1";
            button1.Size = new Size(198, 57);
            button1.TabIndex = 10;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            // 
            // Health_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.simple_background_backgrounds_passion_simple_1_5c9b95bd34713;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(532, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Health_Details";
            Text = "Health_Details";
            Load += Health_Details_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private Button button1;
    }
}