﻿namespace Admin_portal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            linkLabel2 = new LinkLabel();
            label6 = new Label();
            linkLabel3 = new LinkLabel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.MenuHighlight;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-9, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1911, 85);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(0, 84);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(181, 946);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Berlin Sans FB", 20F);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(414, 44);
            label1.TabIndex = 3;
            label1.Text = "AEROTECH DYNAMICS";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.MenuHighlight;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(1757, 112);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 32);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "LOGOUT";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 237);
            label2.Name = "label2";
            label2.Size = new Size(244, 35);
            label2.TabIndex = 5;
            label2.Text = "Welcome Admin,";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(213, 394);
            label4.Name = "label4";
            label4.Size = new Size(379, 35);
            label4.TabIndex = 7;
            label4.Text = "Choose the role to continue";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(259, 523);
            label5.Name = "label5";
            label5.Size = new Size(431, 35);
            label5.TabIndex = 9;
            label5.Text = "To modify Employee details     -";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.DisabledLinkColor = Color.FromArgb(224, 224, 224);
            linkLabel2.Font = new Font("Georgia", 15F);
            linkLabel2.Location = new Point(717, 523);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(148, 35);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Employee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Georgia", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(260, 655);
            label6.Name = "label6";
            label6.Size = new Size(430, 35);
            label6.TabIndex = 11;
            label6.Text = "To modify Manager details       -";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.DisabledLinkColor = Color.FromArgb(224, 224, 224);
            linkLabel3.Font = new Font("Georgia", 15F);
            linkLabel3.Location = new Point(717, 655);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(133, 35);
            linkLabel3.TabIndex = 12;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Manager";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuHighlight;
            label3.Font = new Font("Georgia", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(22, 112);
            label3.Name = "label3";
            label3.Size = new Size(192, 35);
            label3.TabIndex = 13;
            label3.Text = "Admin Portal";
            label3.Click += label3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel3);
            Controls.Add(label6);
            Controls.Add(linkLabel2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel2;
        private Label label6;
        private LinkLabel linkLabel3;
        private Label label3;
    }
}
