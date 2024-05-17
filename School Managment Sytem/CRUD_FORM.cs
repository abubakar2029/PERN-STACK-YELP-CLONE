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
using System.Xml.Linq;

namespace School_Managment_Sytem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolDB;Integrated Security=True;Encrypt=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO STUDENTS VALUES (@id,@name,@age)",con);

            // ADD PARAM FOR DATA TO BE ADDED
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@age", System.Data.SqlDbType.Int);

            // INSERTING DATA
            for (int i = 0; i < 10; i++)
            {
                cmd.Parameters["@id"].Value = i + 1;
                cmd.Parameters["@name"].Value = "Student" +" "+ i;
                cmd.Parameters["@age"].Value = 20 + i;
                cmd.ExecuteNonQuery();
            }

            // CLOSE THE CONNECTION
            con.Close();
            Console.WriteLine("10 records inserted successfully.");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolDB;Integrated Security=True;Encrypt=True");
                con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Students where id=@id", con);

                // ADD PARAM DATATYPE
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);

                // GIVE PARAM VALUE
                cmd.Parameters["@id"].Value = int.Parse(DeleteID.Text);
            }

        private void DeleteID_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayRecords(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolDB;Integrated Security=True;Encrypt=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students",con);

            // Executing Command And Reading Results
            SqlDataReader reader = cmd.ExecuteReader();

            // Create a DataTable to hold the data
            DataTable dt = new DataTable();
           

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0); // ASSUME ID is first column
                    string name=reader.GetString(1);
                    int age=reader.GetInt32(2);

                    Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
                }
                // Load data into DataTable
                dt.Load(reader);

                // Bind the DataTable to the DataGridView
                GridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Yaar Data nahi mila");
            }
        
            reader.Close();
            con.Close();
        
        }

        private void Update(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("");
            conn.Open();
            SqlCommand cmd = new SqlCommand("ALTER Students Set name=@name,age=@age where id=@id");

            cmd.Parameters.AddWithValue("@name",Uname.Text);
            cmd.Parameters.AddWithValue("@age",int.Parse(Uage.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            DisplayRecords(sender, e);
        }
    }
}
