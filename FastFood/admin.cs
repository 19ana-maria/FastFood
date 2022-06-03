using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FastFood
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            populate();
        }
        
        private void Reset()
        {
            NameTb.Text = "";
            UsernameTb.Text = "";
            PasswordTb.Text = "";
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ana-Maria\Desktop\Proiect\FastFood\FastFood\Employees.mdf;Integrated Security=True;Connect Timeout=30");

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || UsernameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "Insert into Account values ('" + NameTb.Text + "','" + UsernameTb.Text + "', '" + PasswordTb.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee user added");
                    Reset();
                    con.Close();
                    populate();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void populate()
        {
            con.Open();
            string query = "select * from Account";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds =new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void admin_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void UserDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            UsernameTb.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            PasswordTb.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
            if(NameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UserDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Select the employee you want to delete");
            }
            else
            {
                try
                {
                    string query = "Delete from Account where Id ="+key+"";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Username deleted");
                    Reset();
                    con.Close();
                    populate();
                    key = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }
    }
}
