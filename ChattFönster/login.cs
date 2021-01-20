using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Web;
using System.Net;

namespace ChattFönster
{
    public partial class login : Form
    {   //Hey, where you from, Loser? Are you from Losertown, because you're a loser!
        public static String name = "Loser";
        private bool createAccount;

        WebClient wc = new WebClient();

        string password;
        public login()
        {
            playHolyMusic();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentName.Visible = true;
            createAccount = false;
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

            password = textBox1.Text;

            if (!createAccount)
            {
     string json = wc.DownloadString("http://localhost:3000/login/" + name + "/" + password);
                
                
                    if(!json.Contains("failed"))
                     {
                    //Opens the "main"-form
                    Form1 F = new Form1();
                    F.Show();
                    this.Hide();
                }
                    


                
                
            }
            else
            {
                if (name.Length <= 20 && name.Length >= 4)
                {
                    CreateAccount(name, password);
                }
                else
                {
                    NameStatus.Text = "Please put your name between 4 and 20 characters";
                }
            }
        }

        private void CreateAccount(string name, string password)
        {
            string sträng = wc.DownloadString("http://localhost:3000/send/add/" + name +"/" + password);
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void playHolyMusic()
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"K:\Teknik\IMT\prog 2 jao\kanskebra\SnoppChat\crack2.wav");
            //simpleSound.Play();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Create a new account")
            {
                button2.Text = "Login instead";
            } else { button2.Text = "Create a new account"; }
        }
    }
}
