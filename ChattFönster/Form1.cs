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
        List<Label> labelList = new List<Label>();

        WebClient wc = new WebClient();

        Messages readMessages;

        string name;
        int sentMessages = 0;

        public class Message
        {
            public string time;
            public string user;
            public string message;
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

            if(textBox1.Text != "" &&
                textBox1.Text != "Write Text Here")
            {
                
                string message = textBox1.Text;

               

                SendMessage(message, name);


                AddMessageBox(message, name);
                
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

        private void ReadMessage()
        {
            string json = wc.DownloadString("http://localhost:3000/all");

            readMessages = JsonConvert.DeserializeObject<Messages>(json);

            AddMessageBox(readMessages.messages[0].message, readMessages.messages[0].user);
        }

        private void SendMessage(string message, string name)
        {
            string sträng = wc.DownloadString("http://localhost:3000/send/" + name + "/" + message);
            sentMessages++;

            string json = wc.DownloadString("http://localhost:3000/all");
            Messages readMessages = JsonConvert.DeserializeObject<Messages>(json);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            name = login.name;
            label1.Text = name;
            label1.AutoSize = true;
            label1.Location = new Point(Form1.ActiveForm.Width - (label1.Width / 2), 30);


            string json = wc.DownloadString("http://localhost:3000/all");
            readMessages = JsonConvert.DeserializeObject<Messages>(json);

            Array.Clear(readMessages.messages, 10, readMessages.messages.Length - 10);

            AddMessageBoxes(readMessages.messages);
            */
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            for (int j = 0; j < labelList.Count; j++)
            {
                labelList[j].Location = new Point(labelList[j].Location.X, labelList[j].Location.Y - ((40 + labelList[labelList.Count - 1].Height) + e.NewValue * 5));
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Enter == e.KeyCode)
            {
                Skicka.PerformClick();
            }
        }

        public void AddMessageBox(string message, string sender)
        {
            Label messageLabel = new Label();
            messageLabel.Text = message;
            messageLabel.Enabled = true;
            messageLabel.AutoSize = true;
            messageLabel.MaximumSize = new Size(200, 0);
            this.Controls.Add(messageLabel);

            for (int i = 0; i < labelList.Count; i++)
            {      
                labelList[i].Location = new Point(labelList[i].Location.X, labelList[i].Location.Y - (40 + labelList[labelList.Count - 1].Height));
            }
           
            if(sender == name)
            {
                messageLabel.Location = new Point(735 - messageLabel.Width, 375);
            }
            else
            {
                messageLabel.Location = new Point(30, 375);
            }
            
            labelList.Add(messageLabel);
            
        }
        public void AddMessageBoxes(Message[] messageArr)
        {
            for (int i = 0; i < messageArr.Length; i++)
            {
                Label messageLabel = new Label();
                messageLabel.Text = messageArr[i].message;
                messageLabel.Enabled = true;
                messageLabel.AutoSize = true;
                messageLabel.MaximumSize = new Size(200, 0);
                this.Controls.Add(messageLabel);

                for (int j = 0; j < labelList.Count; j++)
                {
                    labelList[j].Location = new Point(labelList[j].Location.X, labelList[j].Location.Y - (40 + labelList[labelList.Count - 1].Height));
                }

                if (messageArr[i].user == name)
                {
                    messageLabel.Location = new Point(735 - messageLabel.Width, 375);
                }
                else
                {
                    messageLabel.Location = new Point(30, 375);
                }

                labelList.Add(messageLabel);
            }

            
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            string json = wc.DownloadString("http://localhost:3000/all");
            Messages read = JsonConvert.DeserializeObject<Messages>(json);

            Array.Clear(read.messages, 10 + sentMessages, read.messages.Length);

            if (read != readMessages)
            {
                labelList.Clear();
                AddMessageBoxes(readMessages.messages);
            }
            
        }
        public void Toggler(object sender, EventArgs e)
        {
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
