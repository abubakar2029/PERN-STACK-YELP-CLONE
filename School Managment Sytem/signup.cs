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

namespace School_Managment_Sytem
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=school;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into TLE values(@id,@name,@password)", con);

            cmd.Parameters.AddWithValue("@id", 02);
            cmd.Parameters.AddWithValue("@name", NAME.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("sUCCESSFULLY SUBMITTED");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_Load(object sender, EventArgs e)
        {

        }
    }
}
