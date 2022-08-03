using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopping
{

    public partial class CustomerFun : Form
    {
        String iName, iName2;
        int count = 0;
        List<string> item = new List<string>();
        ShopService.WebService1SoapClient admin_ser = new ShopService.WebService1SoapClient();

        int id;
        string email;
        string payment;
        public CustomerFun(string email, int id)
        {
            this.email = email;
            this.id = id;
            
            InitializeComponent();
            x.Text = "";
            textBox5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (iName == null ||x.Text.ToString().Equals(""))
            {
                MessageBox.Show("You Dont Select Any Item or enter quantity");
               
            }
            else
            {
                try
                {
                    admin_ser.Insert_Into_Cart(id, iName, int.Parse(x.Text));
                 }
                catch (Exception t )
                {
                    MessageBox.Show("Item Already Selected");
                }
                
            
            }

            x.Text = "";
            dataGridView2.ClearSelection();

        }

            void ref_fun ()
        {
            
            item = admin_ser.view_cart(id);
            dataGridView1.Columns.Add("Item_Name", "Item_Name");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            for (int i = 0; i < item.Count; i += 2)
            {

                dataGridView1.Rows.Add(item.ElementAt(i).ToString(), item.ElementAt(i + 1));

            }

            textBox3.Text = admin_ser.total_price(id.ToString()).ToString();

            dataGridView1.ClearSelection();



        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(count == 0 )
            
            ref_fun();
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                ref_fun();
            }
            count++;
        }
        private void CustomerFun_Load(object sender, EventArgs e)
        {
            var x = admin_ser.show_items();


            dataGridView2.Columns.Add("Name", "Name");
            dataGridView2.Columns.Add("description", "description");
            dataGridView2.Columns.Add("price", "price");
            dataGridView2.Columns.Add("category", "category");

            for (int i = 0; i < x.Length; i +=1)
            {

                dataGridView2.Rows.Add(x[i][0], x[i][1], x[i][2], x[i][3]);

            }
            dataGridView2.ClearSelection();
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > -1)
            {
                iName = dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.TextLength != 0)
                admin_ser.Update_Item_quantity(id.ToString(), int.Parse(textBox5.Text), iName2);
            else
                MessageBox.Show("Please Enter a Quantity");
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            ref_fun();
            textBox5.Text = null;
        }
        void fun ()
        {

            for (int i = 0; i < item.Count; i ++)
            {

                admin_ser.Delete_Item_from_cart(item.ElementAt(i).ToString(), id);

            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            ref_fun();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (admin_ser.Delete_Item_from_cart(iName2, id) && iName2 != null)
                MessageBox.Show("Deleted", "OnlineShopping");
            else
                MessageBox.Show("ERROR", "Maybe You Dont Select Item");

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            ref_fun();


        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                admin_ser.Insert_Cart("Viza", email);
                radioButton2.Checked = false;
                Form1 f = new Form1();
                f.Show();
                fun();
            }
            else if (radioButton2.Checked)
            {
                admin_ser.Insert_Cart("Cache", email);
                MessageBox.Show("Done");
                radioButton2.Checked = false;
                fun();
            }
            else
            { MessageBox.Show("Please Select a Pay Method"); }


        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                iName2 = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            }

        }
    }
}
