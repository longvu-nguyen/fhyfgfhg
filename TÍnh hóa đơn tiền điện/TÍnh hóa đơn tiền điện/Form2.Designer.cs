namespace TÍnh_hóa_đơn_tiền_điện
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            bt4 = new Button();
            label11 = new Label();
            label10 = new Label();
            tbprice = new TextBox();
            tbwater = new TextBox();
            label9 = new Label();
            label8 = new Label();
            tbthis = new TextBox();
            tblast = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tbmember = new TextBox();
            label5 = new Label();
            bt5 = new Button();
            bt3 = new Button();
            bt2 = new Button();
            bt1 = new Button();
            tbphone = new TextBox();
            tbname = new TextBox();
            tbid = new TextBox();
            cbtype = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lv1 = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label12 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt4);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(tbprice);
            groupBox1.Controls.Add(tbwater);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbthis);
            groupBox1.Controls.Add(tblast);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbmember);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(bt5);
            groupBox1.Controls.Add(bt3);
            groupBox1.Controls.Add(bt2);
            groupBox1.Controls.Add(bt1);
            groupBox1.Controls.Add(tbphone);
            groupBox1.Controls.Add(tbname);
            groupBox1.Controls.Add(tbid);
            groupBox1.Controls.Add(cbtype);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-81, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1182, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // bt4
            // 
            bt4.Location = new Point(578, 178);
            bt4.Name = "bt4";
            bt4.Size = new Size(94, 29);
            bt4.TabIndex = 24;
            bt4.Text = "Reset";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += bt4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(964, 141);
            label11.Name = "label11";
            label11.Size = new Size(40, 20);
            label11.TabIndex = 23;
            label11.Text = "VND";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(964, 56);
            label10.Name = "label10";
            label10.Size = new Size(30, 20);
            label10.TabIndex = 22;
            label10.Text = "M3";
            // 
            // tbprice
            // 
            tbprice.Location = new Point(834, 138);
            tbprice.Name = "tbprice";
            tbprice.Size = new Size(125, 27);
            tbprice.TabIndex = 21;
            // 
            // tbwater
            // 
            tbwater.Location = new Point(834, 53);
            tbwater.Name = "tbwater";
            tbwater.Size = new Size(125, 27);
            tbwater.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(822, 108);
            label9.Name = "label9";
            label9.Size = new Size(146, 20);
            label9.TabIndex = 19;
            label9.Text = "Total price (with Tax)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(822, 23);
            label8.Name = "label8";
            label8.Size = new Size(148, 20);
            label8.TabIndex = 18;
            label8.Text = "Amout of water used";
            // 
            // tbthis
            // 
            tbthis.Location = new Point(602, 138);
            tbthis.Name = "tbthis";
            tbthis.Size = new Size(82, 27);
            tbthis.TabIndex = 17;
            // 
            // tblast
            // 
            tblast.Location = new Point(450, 138);
            tblast.Name = "tblast";
            tblast.Size = new Size(82, 27);
            tblast.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(602, 108);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 15;
            label7.Text = "This month";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(450, 108);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 14;
            label6.Text = "Last month";
            // 
            // tbmember
            // 
            tbmember.Location = new Point(592, 68);
            tbmember.Name = "tbmember";
            tbmember.Size = new Size(151, 27);
            tbmember.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 68);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 12;
            label5.Text = "Number of member";
            label5.Click += label5_Click;
            // 
            // bt5
            // 
            bt5.Location = new Point(964, 178);
            bt5.Name = "bt5";
            bt5.Size = new Size(94, 29);
            bt5.TabIndex = 11;
            bt5.Text = "Print bill";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += bt5_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(450, 178);
            bt3.Name = "bt3";
            bt3.Size = new Size(94, 29);
            bt3.TabIndex = 10;
            bt3.Text = "Delete";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(335, 178);
            bt2.Name = "bt2";
            bt2.Size = new Size(94, 29);
            bt2.TabIndex = 9;
            bt2.Text = "Edit";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(206, 178);
            bt1.Name = "bt1";
            bt1.Size = new Size(94, 29);
            bt1.TabIndex = 8;
            bt1.Text = "Add";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += button1_Click;
            // 
            // tbphone
            // 
            tbphone.Location = new Point(216, 86);
            tbphone.Name = "tbphone";
            tbphone.Size = new Size(160, 27);
            tbphone.TabIndex = 7;
            // 
            // tbname
            // 
            tbname.Location = new Point(217, 49);
            tbname.Name = "tbname";
            tbname.Size = new Size(159, 27);
            tbname.TabIndex = 6;
            // 
            // tbid
            // 
            tbid.Location = new Point(217, 17);
            tbid.Name = "tbid";
            tbid.Size = new Size(159, 27);
            tbid.TabIndex = 5;
            // 
            // cbtype
            // 
            cbtype.FormattingEnabled = true;
            cbtype.Items.AddRange(new object[] { "Family", "Administrative agency", "Production unit", "Business service" });
            cbtype.Location = new Point(592, 21);
            cbtype.Name = "cbtype";
            cbtype.Size = new Size(151, 28);
            cbtype.TabIndex = 4;
            cbtype.SelectedIndexChanged += cbtype_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 24);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 3;
            label4.Text = "Type of customer";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 93);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 56);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 20);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // lv1
            // 
            lv1.Dock = DockStyle.Bottom;
            lv1.GridLines = true;
            lv1.Location = new Point(0, 277);
            lv1.Name = "lv1";
            lv1.Size = new Size(1108, 400);
            lv1.TabIndex = 1;
            lv1.UseCompatibleStateImageBehavior = false;
            lv1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(497, 4);
            label12.Name = "label12";
            label12.Size = new Size(157, 41);
            label12.TabIndex = 2;
            label12.Text = "Water Bill";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 677);
            Controls.Add(label12);
            Controls.Add(lv1);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lv1;
        private Button bt1;
        private TextBox tbphone;
        private TextBox tbname;
        private TextBox tbid;
        private ComboBox cbtype;
        private ContextMenuStrip contextMenuStrip1;
        private Button bt3;
        private Button bt2;
        private Button bt5;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox tbmember;
        private Button bt4;
        private Label label11;
        private Label label10;
        private TextBox tbprice;
        private TextBox tbwater;
        private Label label9;
        private Label label8;
        private TextBox tbthis;
        private TextBox tblast;
        private Label label12;
    }
}
