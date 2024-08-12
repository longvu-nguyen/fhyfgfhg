namespace TÍnh_hóa_đơn_tiền_điện
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
            groupBox1 = new GroupBox();
            txtrepass = new TextBox();
            txtpass = new TextBox();
            txtname = new TextBox();
            login = new Button();
            regiter = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(txtrepass);
            groupBox1.Controls.Add(txtpass);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(login);
            groupBox1.Controls.Add(regiter);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(189, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 268);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtrepass
            // 
            txtrepass.Cursor = Cursors.IBeam;
            txtrepass.Location = new Point(154, 106);
            txtrepass.Name = "txtrepass";
            txtrepass.PasswordChar = '*';
            txtrepass.Size = new Size(184, 27);
            txtrepass.TabIndex = 7;
            // 
            // txtpass
            // 
            txtpass.Cursor = Cursors.IBeam;
            txtpass.Location = new Point(154, 70);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(184, 27);
            txtpass.TabIndex = 6;
            // 
            // txtname
            // 
            txtname.Cursor = Cursors.IBeam;
            txtname.Location = new Point(154, 30);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(184, 27);
            txtname.TabIndex = 5;
            // 
            // login
            // 
            login.BackColor = Color.Lime;
            login.Cursor = Cursors.Hand;
            login.ForeColor = SystemColors.ActiveCaptionText;
            login.Location = new Point(129, 211);
            login.Name = "login";
            login.Size = new Size(208, 29);
            login.TabIndex = 4;
            login.Text = "exit";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // regiter
            // 
            regiter.BackColor = Color.Lime;
            regiter.Cursor = Cursors.Hand;
            regiter.ForeColor = SystemColors.ActiveCaptionText;
            regiter.Location = new Point(129, 155);
            regiter.Name = "regiter";
            regiter.Size = new Size(208, 29);
            regiter.TabIndex = 3;
            regiter.Text = "register now";
            regiter.UseVisualStyleBackColor = false;
            regiter.Click += regiter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 128);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 0;
            label2.Text = "Enter User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lime;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(8, 70);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Enter password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Lime;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(6, 109);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 1;
            label4.Text = "Confirm password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(796, 495);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtrepass;
        private TextBox txtpass;
        private TextBox txtname;
        private Button login;
        private Button regiter;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}