﻿namespace WinFormsApp1
{
    partial class enrollTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enrollTeacher));
            panel1 = new Panel();
            panelLeft = new FlowLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            label1 = new Label();
            SectioncomboBox = new ComboBox();
            CoursecomboBox = new ComboBox();
            label6 = new Label();
            Password = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            Email = new TextBox();
            Name = new TextBox();
            showFiles = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(-1, -27);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 504);
            panel1.TabIndex = 5;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Maroon;
            panelLeft.Location = new Point(1, 208);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 106);
            panelLeft.TabIndex = 3;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(2, 329);
            button4.Name = "button4";
            button4.Size = new Size(175, 106);
            button4.TabIndex = 5;
            button4.Text = "Enroll Student";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(1, 207);
            button3.Name = "button3";
            button3.Size = new Size(175, 106);
            button3.TabIndex = 4;
            button3.Text = "Enroll Instructor";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1, 86);
            button2.Name = "button2";
            button2.Size = new Size(175, 106);
            button2.TabIndex = 3;
            button2.Text = "Profile";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(655, 23);
            button5.Name = "button5";
            button5.Size = new Size(133, 33);
            button5.TabIndex = 58;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 23);
            label1.Name = "label1";
            label1.Size = new Size(325, 47);
            label1.TabIndex = 57;
            label1.Text = "Enroll Instructor ";
            // 
            // SectioncomboBox
            // 
            SectioncomboBox.FormattingEnabled = true;
            SectioncomboBox.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "Y", "Z", "All Sections" });
            SectioncomboBox.Location = new Point(419, 282);
            SectioncomboBox.Name = "SectioncomboBox";
            SectioncomboBox.Size = new Size(206, 28);
            SectioncomboBox.TabIndex = 69;
            // 
            // CoursecomboBox
            // 
            CoursecomboBox.FormattingEnabled = true;
            CoursecomboBox.Location = new Point(419, 333);
            CoursecomboBox.Name = "CoursecomboBox";
            CoursecomboBox.Size = new Size(206, 28);
            CoursecomboBox.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(263, 273);
            label6.Name = "label6";
            label6.Size = new Size(132, 37);
            label6.TabIndex = 67;
            label6.Text = "Section:";
            // 
            // Password
            // 
            Password.Location = new Point(419, 223);
            Password.Name = "Password";
            Password.Size = new Size(206, 27);
            Password.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(229, 219);
            label4.Name = "label4";
            label4.Size = new Size(161, 37);
            label4.TabIndex = 65;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(291, 165);
            label5.Name = "label5";
            label5.Size = new Size(103, 37);
            label5.TabIndex = 64;
            label5.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(263, 321);
            label3.Name = "label3";
            label3.Size = new Size(127, 37);
            label3.TabIndex = 63;
            label3.Text = "Course:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(280, 110);
            label2.Name = "label2";
            label2.Size = new Size(114, 37);
            label2.TabIndex = 62;
            label2.Text = "Name:";
            // 
            // Email
            // 
            Email.Location = new Point(419, 175);
            Email.Name = "Email";
            Email.Size = new Size(206, 27);
            Email.TabIndex = 61;
            // 
            // Name
            // 
            Name.Location = new Point(419, 120);
            Name.Name = "Name";
            Name.Size = new Size(206, 27);
            Name.TabIndex = 60;
            // 
            // showFiles
            // 
            showFiles.BackColor = Color.Black;
            showFiles.FlatAppearance.BorderSize = 0;
            showFiles.FlatStyle = FlatStyle.Flat;
            showFiles.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showFiles.ForeColor = Color.White;
            showFiles.Location = new Point(442, 393);
            showFiles.Name = "showFiles";
            showFiles.Size = new Size(133, 33);
            showFiles.TabIndex = 59;
            showFiles.Text = "SUBMIT ";
            showFiles.UseVisualStyleBackColor = false;
            showFiles.Click += showFiles_Click_1;
            // 
            // enrollTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SectioncomboBox);
            Controls.Add(CoursecomboBox);
            Controls.Add(label6);
            Controls.Add(Password);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Email);
            Controls.Add(Name);
            Controls.Add(showFiles);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(panel1);
//            Name = "enrollTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "enrollTeacher";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel panelLeft;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Label label1;
        private ComboBox SectioncomboBox;
        private ComboBox CoursecomboBox;
        private Label label6;
        private TextBox Password;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox Email;
        private TextBox Name;
        private Button showFiles;
    }
}