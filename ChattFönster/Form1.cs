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
using System.Web;
using System.IO;

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
            public List<Message> messages = new List<Message>();
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
                textBox1.Text = "";
               

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
            message = WebUtility.UrlEncode(message);
            string sträng = wc.DownloadString("http://localhost:3000/send/" + name + "/" + message);
            sentMessages++;

            

            string json = wc.DownloadString("http://localhost:3000/all");
            
            Messages readMessages = JsonConvert.DeserializeObject<Messages>(json);
            json = WebUtility.UrlDecode(json);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            name = login.name;
            label1.Text = name;
            label1.AutoSize = true;
            label1.Location = new Point(Form1.ActiveForm.Width - (label1.Width/2), 30);

            wc.Encoding = System.Text.Encoding.UTF8;
            string json = wc.DownloadString("http://localhost:3000/all");
            
            readMessages = JsonConvert.DeserializeObject<Messages>(json);
            json = WebUtility.UrlDecode(json);

            if (readMessages.messages != null)
            {
                if (readMessages.messages.Count > 10)
                {
                    readMessages.messages.RemoveRange(9, readMessages.messages.Count - 10);                   
                }
                    AddMessageBoxes(readMessages.messages);
            }          
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
            int value;
            //scrolla ner (flytta sms uppåt)
            if(e.NewValue < e.OldValue)
            {
                value = e.NewValue - e.OldValue;
            }
            //scrolla upp (flytta sms nedåt)
            else
            {
                value = e.NewValue - e.OldValue;
            }
            for (int j = 0; j < labelList.Count; j++)
            {
                labelList[j].Location = new Point(labelList[j].Location.X, labelList[j].Location.Y - value * 5);
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
        public void AddMessageBoxes(List<Message> messageList)
        {
            for (int i = 0; i < messageList.Count; i++)
            {
                Label messageLabel = new Label();
                messageLabel.Text = WebUtility.UrlDecode(messageList[i].message);
                messageLabel.Enabled = true;
                messageLabel.AutoSize = true;
                messageLabel.MaximumSize = new Size(200, 0);
                this.Controls.Add(messageLabel);

                for (int j = 0; j < labelList.Count; j++)
                {
                    labelList[j].Location = new Point(labelList[j].Location.X, labelList[j].Location.Y - (40 + labelList[labelList.Count - 1].Height));
                }

                if (messageList[i].user == name)
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

            if (read.messages != null)
            {
                if (read.messages.Count > 10)
                {
                    read.messages.RemoveRange(9, read.messages.Count - 10);
                }


                
                if (read.messages[read.messages.Count-1].time != readMessages.messages[readMessages.messages.Count-1].time)
                {
                    readMessages = read;
                    RemoveMessageBoxes();
                    labelList.Clear();
                    AddMessageBoxes(read.messages);
                }
            }
        }

        private void RemoveMessageBoxes()
        {
            for (int i = 0; i < labelList.Count; i++)
            {
                labelList[i].Dispose();
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
