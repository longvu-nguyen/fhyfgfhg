using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TÍnh_hóa_đơn_tiền_điện
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void regiter_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;// ktra name 
            string password = txtpass.Text;//
            string confirm = txtrepass.Text;

            // ktra dieu kien gia tri trong txtname khong duoc trong 
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Focus();
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpass.Focus();
            }
            if (string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("please enter confirm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtrepass.Focus();
            }
            else if (password == confirm)
            {
                MessageBox.Show("register succers", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //  From1 from1 = new From1();

                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("register un succers", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpass.Text = ""; txtpass.Focus();
                txtrepass.Text = ""; txtpass.Focus();

                //MessageBox.Show("Register success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
