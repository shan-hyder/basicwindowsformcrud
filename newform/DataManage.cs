using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace newform
{
    public partial class Data_Manage : Form
    {
        string connection = "server=MSI\\SQLEXPRESS;database=windowscrud;Integrated Security = true;";
        public Data_Manage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("RetreiveAllData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds=new DataSet();
                da.Fill(ds);
                AllData.DataSource = ds.Tables[0];
                AllData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                AllData.ReadOnly = true;
            }
            AllData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllData.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(AllData.SelectedRows.Count>0)
            {
                
              
                DataGridViewRow selectedrow = AllData.SelectedRows[0];
                int id = Convert.ToInt32(selectedrow.Cells["id"].Value);
                
                using (SqlConnection con = new SqlConnection(connection))
                {
                    SqlCommand cmd = new SqlCommand("DeleteById", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int count=cmd.ExecuteNonQuery();
                    if(count==1)
                    {
                        label1.Text = "Deleted Successfully";
                        label1.Visible = true;
                        gridrefresh();
                    }
                    else
                    {
                        label1.Text = "Deletion Failed/No Data present to delete";
                        label1.Visible = true;
                    }
                }

            }
        }
        public void gridrefresh()
        {
            
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("RetreiveAllData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                AllData.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con=new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("UpdateById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@age", textBox3.Text);
                cmd.Parameters.AddWithValue("@address", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(label7.Text));
                con.Open();
                int count=cmd.ExecuteNonQuery();
                if(count==1)
                {
                    label1.Text = "Updated successfully";
                    label1.Visible = true;
                    gridrefresh();
                }
                else
                {
                    label1.Text = "Updated Failed";
                    label1.Visible = true;
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {

                DataGridViewRow row = AllData.Rows[e.RowIndex];
                textBox1.Text = row.Cells["name"].Value.ToString();
                textBox3.Text = row.Cells["age"].Value.ToString();
                richTextBox1.Text = row.Cells["address"].Value.ToString();
                label7.Text = row.Cells["id"].Value.ToString();
                label7.Visible = true;
            }
        }
    }
}
