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

namespace School_Managment_Sytem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Students values(@id,@name,@age)", con);

            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Boss kam ho gya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Students where id=2121", con);

            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Boss kam ho gya");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
/*            Form2 form = new Form2();*/
            /*signup f = new signup();
            f.Show();
           /* form.Show();
        */
            login form=new login();
            form.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
            form2.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool isvalid()
        {

            if (textBox1.Text.TrimStart() == string.Empty)

            {
                MessageBox.Show("enter valid username", "error");
                return false;
            }

            else if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter valid pasword", "error");
                return false;
            }
            return true;

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Encrypt=True"))
                    string query = "select * from Login where username = @username and pasword = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@password", textBox2.Text.Trim());
            }
        }
    }
}*/