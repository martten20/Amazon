using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Services;
namespace SDAProject
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public void register(string u_n, string pass, string name, string add, string area, int mobile)
        {
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("insert into customer (user_name,pass,name,address,area,mobile) values(@x,@y,@z,@w,@e,@f)", conn);
            SqlParameter p1 = new SqlParameter("@x", u_n);
            SqlParameter p2 = new SqlParameter("@y", pass);
            SqlParameter p3 = new SqlParameter("@z", name);
            SqlParameter p4 = new SqlParameter("@w", add);
            SqlParameter p5 = new SqlParameter("@e", area);
            SqlParameter p6 = new SqlParameter("@f", mobile);
            c.Parameters.Add(p1);
            c.Parameters.Add(p2);
            c.Parameters.Add(p3);
            c.Parameters.Add(p4);
            c.Parameters.Add(p5);
            c.Parameters.Add(p6);
            try
            {
                c.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
        }
        [WebMethod]
        public bool login(string username, string pass)
        {
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("select pass from customer where user_name=@x", conn);
            SqlParameter p1 = new SqlParameter("@x", username);
            c.Parameters.Add(p1);
            SqlDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == pass)
                {
                    return true;
                }
            }
            return false;
        }
        [WebMethod]
        public void Insert_Cart(string name)
        {
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("insert into cart (customer_user_name ) values (@z)", conn);
            SqlParameter p3 = new SqlParameter("@z", name);
            c.Parameters.Add(p3);
            try
            {
                c.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
        }
        [WebMethod]
        public void Insert_Into_Cart(int id, string name, int q)
        {
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("insert into cart_line (cart_id,item_name,quantity) values(@x,@y,@z)", conn);
            SqlParameter p1 = new SqlParameter("@x", id);
            SqlParameter p2 = new SqlParameter("@y", name);
            SqlParameter p3 = new SqlParameter("@z", q);
            c.Parameters.Add(p1);
            c.Parameters.Add(p2);
            c.Parameters.Add(p3);
            try
            {
                int x = c.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
        }
        [WebMethod]
        public List<string> view_cart(int id)
        {
            List<string> list = new List<string>();
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("select item_name , quantity from cart_line where cart_id= @x", conn);
            SqlParameter p1 = new SqlParameter("@x", id);
            c.Parameters.Add(p1);
            SqlDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < 2; i++)
                {

                    if (i == 0)
                    {
                        list.Add(reader.GetString(i));

                        continue;
                    }
                    list.Add(reader.GetValue(i).ToString());
                }
            }

            conn.Close();
            return list;
        }
        [WebMethod]
        public bool Delete_Item_from_cart(string name, int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("delete from cart_line where item_name = @x and cart_id=@y", conn);
            SqlParameter p1 = new SqlParameter("@x", name);
            SqlParameter p2 = new SqlParameter("@y", id);
            c.Parameters.Add(p1);
            c.Parameters.Add(p2);

            int x = c.ExecuteNonQuery();
            conn.Close();
            if (x == -1)
            {
                return false;
            }
            return true;
        }
        [WebMethod]
        public int Getquantity(int id, string name)
        {
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("select quantity from cart_line  where cart_id=@x and item_name = @y", conn);
            SqlParameter p1 = new SqlParameter("@x", id);
            SqlParameter p2 = new SqlParameter("@y", name);
            c.Parameters.Add(p1);
            c.Parameters.Add(p2);
            try
            {
                SqlDataReader reader = c.ExecuteReader();
                string x = "";
                while (reader.Read())
                {
                    x = reader.GetValue(0).ToString();

                }
                reader.Close();
                return int.Parse(x);
            }
            catch
            {
                return 0;
            }
        }
        [WebMethod]
        public void Update_Item_quantity(string id, int q, string name)
        {
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("update cart_line set quantity = @x where cart_id=@y and item_name=@z", conn);
            SqlParameter p1 = new SqlParameter("@x", q);
            SqlParameter p2 = new SqlParameter("@y", id);
            SqlParameter p3 = new SqlParameter("@z", name);
            c.Parameters.Add(p1);
            c.Parameters.Add(p2);
            c.Parameters.Add(p3);

            try
            {
                c.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
        }
        [WebMethod]
        public List<List<string>> show_items()
        {
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("select * from item ", conn);
            SqlDataReader r = c.ExecuteReader();
            List<List<string>> x = new List<List<string>>();
            while (r.Read())
            {
                List<string> y = new List<string>();
                for (int i = 0; i < 4; i++)
                {
                    if (i != 2)
                    {
                        y.Add(r.GetString(i));

                        continue;
                    }
                    y.Add(r.GetValue(i).ToString());



                }
                x.Add(y);

            }

            conn.Close();
            return x;
        }
        [WebMethod]
        public int GetCart_ID(string EMAIL)
        {
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("select cart_id from cart where customer_user_name=@x", conn);
            SqlParameter p1 = new SqlParameter("@x", EMAIL);
            c.Parameters.Add(p1);
            SqlDataReader reader = c.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {
                x = int.Parse(reader.GetValue(0).ToString());

            }
            reader.Close();
            return x;
        }
        [WebMethod]
        public string Getpayment(string EMAIL)
        {
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("select pay_method from cart where customer_user_name=@x", conn);
            SqlParameter p1 = new SqlParameter("@x", EMAIL);
            c.Parameters.Add(p1);
            SqlDataReader reader = c.ExecuteReader();
            string x = "";
            while (reader.Read())
            {
                x = reader.GetValue(0).ToString();

            }
            reader.Close();
            return x;
        }
        [WebMethod]
        public List<string> personal_info(string email)
        {
            List<string> list = new List<string>();
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("select address , area , mobile from customer where user_name = @x", conn);
            SqlParameter p1 = new SqlParameter("@x", email);
            c.Parameters.Add(p1);
            SqlDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < 3; i++)
                {

                    if (i == 0 || i == 1)
                    {
                        list.Add(reader.GetString(i));

                        continue;
                    }
                    list.Add(reader.GetValue(i).ToString());
                }
            }

            conn.Close();
            return list;



        }
        [WebMethod]
        public void put_method(int cart, string pay)
        {
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("update cart set pay_method = @z where cart_id = @y", conn);
            SqlParameter p3 = new SqlParameter("@z", pay);
            SqlParameter p4 = new SqlParameter("@y", cart);
            c.Parameters.Add(p3);
            c.Parameters.Add(p4);
            try
            {
                c.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();




        }

        [WebMethod]
        public string getemail_from_cart_id(int id)
        {
            string email = "";
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("select customer_user_name from cart where cart_id = @x", conn);
            SqlParameter p1 = new SqlParameter("@x", id);
            c.Parameters.Add(p1);
            SqlDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                email = reader.GetValue(0).ToString();
            }

            conn.Close();
            return email;



        }

        [WebMethod]
        public void update_personal_info(string email, string address, string area, int mob)
        {
            List<string> list = new List<string>();
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("update customer set address = @y , area = @yy , mobile = @yyy  where user_name = @x", conn);
            SqlParameter p1 = new SqlParameter("@x", email);
            SqlParameter p2y = new SqlParameter("@y", address);
            SqlParameter p3y = new SqlParameter("@yy", area);
            SqlParameter p4y = new SqlParameter("@yyy", mob);

            c.Parameters.Add(p1);
            c.Parameters.Add(p2y);
            c.Parameters.Add(p3y);
            c.Parameters.Add(p4y);

            c.ExecuteNonQuery();
            conn.Close();




        }

        [WebMethod]
        public string Getpimage(string name)
        {
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("select Url_image from item where name=@x", conn);
            SqlParameter p1 = new SqlParameter("@x", name);
            c.Parameters.Add(p1);
            SqlDataReader reader = c.ExecuteReader();
            string x = "";
            while (reader.Read())
            {
                x = reader.GetValue(0).ToString();

            }
            reader.Close();
            return x;
        }

        [WebMethod]
        public float total_price(string id)
        {
            float price = 0;
            SqlConnection conn = new SqlConnection("Data Source=MOHAMEDADNAN\\MSSQLSERVER01;Initial Catalog=onlineshopping;Integrated Security=True");
            conn.Open();
            SqlCommand c = new SqlCommand("select item_name,quantity from cart_line where cart_id = @x", conn);
            SqlParameter p1 = new SqlParameter("@x", id);
            c.Parameters.Add(p1);
            SqlDataReader reader = c.ExecuteReader();
            List<string> names = new List<string>();
            List<string> quantity = new List<string>();
            while (reader.Read())
            {
                names.Add(reader.GetString(0));
                quantity.Add(reader.GetValue(1).ToString());

            }
            reader.Close();
            int j = 0;
            for (int i = 0; i < names.Count; i++)
            {

                SqlCommand com = new SqlCommand("select price from item where name = @y", conn);
                SqlParameter p2 = new SqlParameter("@y", names[i]);
                com.Parameters.Add(p2);
                SqlDataReader r = com.ExecuteReader();

                while (r.Read())
                {

                    price += float.Parse(quantity[j]) * float.Parse(r.GetValue(0).ToString());
                    j = j + 1;
                }

                r.Close();
            }

            conn.Close();
            return price;
        }


    }
}
