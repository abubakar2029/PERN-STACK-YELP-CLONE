using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace School_Managment_Sytem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=school;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TLE WHERE password=@password", con);

            cmd.Parameters.AddWithValue("@password", textBox1.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            // Check if there are any rows returned by the query
            if (reader.HasRows)
            {
                MessageBox.Show("Login successful"); 
                signup form=new signup();
                this.Hide();
                form.Show();
                    // Or any other action you want to take upon successful login
            }
            else
            {
                MessageBox.Show("Login failed"); // Or any other action you want to take upon failed login
            }
            con.Close();
/*            MessageBox.Show("OKI");*/
        }
    }
}
