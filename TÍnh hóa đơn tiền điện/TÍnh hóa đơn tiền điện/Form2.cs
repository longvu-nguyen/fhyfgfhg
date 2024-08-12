using Microsoft.VisualBasic.Devices;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;

namespace TÍnh_hóa_đơn_tiền_điện
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = tbid.Text;
            string Name = tbname.Text;
            string Phone = tbphone.Text;
            string type = null;
            if (cbtype.SelectedIndex == 0)
            {
                type = "Family";
            }
            else if (cbtype.SelectedIndex == 1)
            {
                type = "Administrative agency";
            }
            else if (cbtype.SelectedIndex == 2)
            {
                type = "Production unit";
            }
            else if (cbtype.SelectedIndex == 3)
            {
                type = " Business service";
            }
            string Number = tbmember.Text;
            string Last = tblast.Text;
            string This = tbthis.Text;
            string Water = tbwater.Text;
            string price = tbprice.Text;

            ListViewItem item = new ListViewItem();
            item.Text = ID;
            item.SubItems.Add(Name);
            item.SubItems.Add(Phone);
            item.SubItems.Add(type);
            item.SubItems.Add(Number);
            item.SubItems.Add(Last);
            item.SubItems.Add(This);
            item.SubItems.Add(Water);
            item.SubItems.Add(price);
            lv1.Items.Add(item);




        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count > 0)

            {
                ListViewItem seleted_Item = lv1.SelectedItems[0];

                string ID = seleted_Item.SubItems[0].Text;
                //kiểm tra lại
                string Name = seleted_Item.SubItems[1].Text;
                string Phone = seleted_Item.SubItems[2].Text;
                string type = seleted_Item.SubItems[3].Text;
                string Number = seleted_Item.SubItems[4].Text;
                string Last = seleted_Item.SubItems[5].Text;
                string This = seleted_Item.SubItems[6].Text;
                string Water = seleted_Item.SubItems[7].Text;
                string Price = seleted_Item.SubItems[8].Text;



                tbid.Text = ID;
                tbname.Text = Name;
                tbphone.Text = Phone;
                if (cbtype.SelectedIndex == 0)
                {
                    type = "Family";
                }
                else if (cbtype.SelectedIndex == 1)
                {
                    type = "Administrative agency";
                }
                else if (cbtype.SelectedIndex == 2)
                {
                    type = "Production unit";
                }
                else if (cbtype.SelectedIndex == 3)
                {
                    type = " Business service";
                }
                tbmember.Text = Number;
                tblast.Text = Last;
                tbthis.Text = This;
                tbwater.Text = Water;
                tbprice.Text = Price;
            }

        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lv1.View = View.Details;
            lv1.GridLines = true;
            lv1.FullRowSelect = true;



            lv1.Columns.Add("ID");
            lv1.Columns.Add("Name");
            lv1.Columns.Add("Phone");
            lv1.Columns.Add("Type of customer");
            lv1.Columns.Add("Number of member");
            lv1.Columns.Add("Last");
            lv1.Columns.Add("This");
            lv1.Columns.Add("Water");
            lv1.Columns.Add("Price");




        }



        private void bt2_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count > 0)
            {
                ListViewItem item = lv1.SelectedItems[0];
                item.SubItems.Clear();

                string ID = tbid.Text;
                string Name = tbname.Text;
                string Phone = tbphone.Text;
                string type = null;
                if (cbtype.SelectedIndex == 0)
                {
                    type = "Family";
                }
                else if (cbtype.SelectedIndex == 1)
                {
                    type = "Administrative agency";
                }
                else if (cbtype.SelectedIndex == 2)
                {
                    type = "Production unit";
                }
                else if (cbtype.SelectedIndex == 3)
                {
                    type = " Business service";
                }
                string Number = tbmember.Text;
                string Last = tblast.Text;
                string This = tbthis.Text;
                string Water = tbwater.Text;
                string price = tbprice.Text;


            //    item.Text = ID;
              //  item.SubItems.Add(Name);
            //    item.SubItems.Add(Phone);
            //    item.SubItems.Add(type);
            //    item.SubItems.Add(Number);
            //    item.SubItems.Add(Last);
            //    item.SubItems.Add(This);


                lv1.Items.Add(item);
           //     var item = lv1.SelectedItems[0];
                tbid.Text = item.SubItems[0].Text;
                tbname.Text = item.SubItems[0].Text;
                tbphone.Text = item.SubItems[0].Text;
                cbtype.SelectedIndex = -1;
                tbthis.Text = item.SubItems[0].Text;
                tblast.Text = item.SubItems[0].Text;
                tbwater.Text = item.SubItems[0].Text;
                tbprice.Text = item.SubItems[0].Text;




                lv1.Items.Remove(lv1.SelectedItems[0]);
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count > 0)
            {
                lv1.Items.Remove(lv1.SelectedItems[0]);
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {

        }

        private void bt5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

