using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace newform
{
    public partial class Form1 : Form
    {
        string connection = "server=MSI\\SQLEXPRESS;database=windowscrud;Integrated Security=true;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Nametextbox.Text;
            int age = Convert.ToInt32(AgeTextbox.Text);
            string address = AddressRichTextbox.Text;

            string gender = "";
            if(RadMale.Checked)
            {
                gender = RadMale.Text;
            }
            else if(RadFemale.Checked)
            {
                gender = RadFemale.Text;
            }

            //var insertdto = new insertDTO
            //{
            //    name = name,
            //    age = age,
            //    address = address,
            //    gender = gender
            //};

            //using (HttpClient client = new HttpClient())
            //{
            //    string url = "https://localhost:7033/api/WindowsCrud";

            //    HttpResponseMessage response = await client.PostAsJsonAsync(url, insertdto);



            //}

            //create

            using (SqlConnection con = new SqlConnection(connection))
            {
                string query = "insert into Details values(@name,@age,@address,@gender)";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@gender", gender);
                con.Open();
                int count=cmd.ExecuteNonQuery();
                if(count==1)
                {
                    MessageBox.Show("inserted Successfully");
                }
                else
                {
                    MessageBox.Show("insertion failed");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data_Manage f2 = new Data_Manage();
            f2.Show();
            this.Hide();
        }
    }
}
