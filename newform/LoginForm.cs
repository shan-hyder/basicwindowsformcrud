using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace newform
{
    public partial class LoginForm : Form
    {
        string Connection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string name = TextName.Text;
            int age = Convert.ToInt32(AgeNumeric.Value);
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                SqlCommand cmd = new SqlCommand("LoginCheck", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                connection.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if(count==1)
                {
                    MessageBox.Show("LoginSuccessfull");
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }

        }
    }
}
