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
    public partial class Admin_form : Form
    {
        ShopService.WebService1SoapClient admin_ser = new ShopService.WebService1SoapClient();
        public Admin_form()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            float price = float.Parse(add_price_item.Text.ToString());
            try
            {
                admin_ser.Add_Item(add_name_item.Text, add_des_item.Text, price, add_category_item.Text);
                MessageBox.Show("Added", "Onlineshopping");
            }
            catch (Exception t)
            {

                MessageBox.Show("Failed", "Onlineshopping");
            }
            add_name_item.Text = "";
            add_des_item.Text = "";
            add_price_item.Text = "";
            add_category_item.Text = "";
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            List<String> item_details = new List<string>();
            item_details = admin_ser.View_Item(view_item_name.Text);
            if (item_details.Count == 0)
                MessageBox.Show("Not Found", "Onlineshopping");
            else
            {
                view_description.Text = item_details.ElementAt(1);
                view_price.Text = item_details.ElementAt(2);
                view_category.Text = item_details.ElementAt(3);
            }


        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (admin_ser.Delete_Item(delete_text.Text))
                MessageBox.Show("Deleted", "Onlineshopping");
            else
                MessageBox.Show("Failed", "Onlineshopping");
            delete_text.Text = "";
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            try
            {
                admin_ser.Update_Item(edit_text.Text, comboBox1.SelectedItem.ToString(), newval.Text);

                MessageBox.Show("Updated", "Onlineshopping");
                edit_text.Text = "";
                newval.Text = "";
                }
            catch (Exception t)
            {
                MessageBox.Show("Failed", "Onlineshopping");
            }

        }
    }
}
