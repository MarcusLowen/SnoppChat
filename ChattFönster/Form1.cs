using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace ChattFönster
{
    public partial class Form1 : Form
    {
        bool emojible = false;
        WebClient wc = new WebClient();

        string name;

        public class Message
        {
            public string sender;
            public string messageText;
        }

        public class Messages
        {
            public Message[] messages;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Skicka_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();

            if(textBox1.Text != "")
            {
                //skicka meddelande
                string message = textBox1.Text;

                textBox1.Text = "Write Text Here";
                textBox1.ForeColor = Color.DarkGray;

                //SendMessage(message, name);

                Label messageLabel = new Label();
                messageLabel.Text = message;
                messageLabel.Location = new Point(100, 50);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.ForeColor == Color.DarkGray)
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = "";
            }
        }

        private void ReadMessages()
        {
            string json = wc.DownloadString("http://localhost:3000/");

            Messages readMessages = JsonConvert.DeserializeObject<Messages>(json);

        }

        private void SendMessage(string message, string name)
        {
            wc.UploadString("http://localhost:3000/", name, message);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            name = login.name;
            label1.Text = name;
            
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Enter == e.KeyCode)
            {
                Skicka.PerformClick();
            }
        }

        private void EmojiButton_Click(object sender, EventArgs e)
        {
            

            if (emojible == false)
            {
                EggplantButton.Visible = true;
                HappyButton.Visible = true;
                CoolButton.Visible = true;
                MonkeeButton.Visible = true;
                emojible = true;
            } else if (emojible == true)
            {
                EggplantButton.Visible = false;
                HappyButton.Visible = false;
                CoolButton.Visible = false;
                MonkeeButton.Visible = false;
                emojible = false;
            }
        }

        private void CoolButton_Click(object sender, EventArgs e)
        {

        }
    }
}
