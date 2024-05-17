using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_Sytem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        public Form1 MidParent { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi single!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
/*
            form2.Shown();*/
            this.Hide();
            form1.Show();
        }
    }
}
