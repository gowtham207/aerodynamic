namespace ui2__employeelogin
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
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI", 11F);
            linkLabel2.ForeColor = Color.Lime;
            linkLabel2.LinkColor = Color.Lime;
            linkLabel2.Location = new Point(853, 648);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(189, 30);
            linkLabel2.TabIndex = 21;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(824, 199);
            label4.Name = "label4";
            label4.Size = new Size(251, 41);
            label4.TabIndex = 20;
            label4.Text = "Employee - Login";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.BorderStyle = BorderStyle.FixedSingle;
            linkLabel1.Font = new Font("Segoe UI", 11F);
            linkLabel1.ForeColor = Color.Lime;
            linkLabel1.LinkColor = Color.Lime;
            linkLabel1.Location = new Point(853, 586);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 32);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(0, 0, 64);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(855, 520);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(332, 37);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 0, 64);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(855, 435);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 37);
            textBox1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(679, 517);
            label3.Name = "label3";
            label3.Size = new Size(122, 36);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(679, 432);
            label2.Name = "label2";
            label2.Size = new Size(159, 36);
            label2.TabIndex = 15;
            label2.Text = "Employee ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1898, 1024);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel2;
        private Label label4;
        private LinkLabel linkLabel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
    }
}
