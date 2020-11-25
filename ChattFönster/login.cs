using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattFönster
{
    public partial class login : Form
    {
        public static String name = "Loser";
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentName.Visible = true;

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {

           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click_1(object sender, EventArgs e)
        {
            name = NameBox.Text;
            name = name.Trim();
            if (name.Length <= 20 && name.Length >= 4)
            {
                NameStatus.Text = name;
                NameBox.Visible = false;
                DoneButton.Visible = false;
                Form1 F = new Form1();
                F.Show();
                this.Hide();
            }
            else
            {
                NameStatus.Text = "Please put your name between 4 and 20 characters";
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
