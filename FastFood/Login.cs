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
namespace FastFood
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            admin obj = new admin();
            obj.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ana-Maria\Desktop\Proiect\FastFood\FastFood\Employees.mdf;Integrated Security=True;Connect Timeout=30");

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (UserTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter the Username and Password");
            }
            else if (UserTb.Text == "Admin" && PasswordTb.Text == "Password")
            {
                admin form = new admin();
                form.Show();
                this.Hide();
            }
            else
            {
                con.Close();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Account where User='"+UserTb.Text+"'and Password='"+PasswordTb.Text+"'",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong User or Password");
                    UserTb.Text = "";
                    PasswordTb.Text = "";
                } 
            }
        }
    }
}
