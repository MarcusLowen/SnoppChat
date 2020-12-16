namespace ChattFönster
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Skicka = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.EmojiButton = new System.Windows.Forms.Button();
            this.EggplantButton = new System.Windows.Forms.PictureBox();
            this.MonkeeButton = new System.Windows.Forms.PictureBox();
            this.HappyButton = new System.Windows.Forms.PictureBox();
            this.CoolButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EggplantButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonkeeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HappyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoolButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Skicka
            // 
            this.Skicka.AutoSize = true;
            this.Skicka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Skicka.Location = new System.Drawing.Point(701, 419);
            this.Skicka.Name = "Skicka";
            this.Skicka.Size = new System.Drawing.Size(75, 23);
            this.Skicka.TabIndex = 1;
            this.Skicka.Text = "Send";
            this.Skicka.UseVisualStyleBackColor = true;
            this.Skicka.Click += new System.EventHandler(this.Skicka_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(0, 477);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(802, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Write Text Here";
            this.textBox1.Click += new System.EventHandler(this.TextBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(776, 0);
            this.vScrollBar1.Minimum = 1;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 477);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Value = 100;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "SnoppMeister";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 320);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "därfrör ffsj";
            // 
            // EmojiButton
            // 
            this.EmojiButton.Location = new System.Drawing.Point(566, 361);
            this.EmojiButton.Name = "EmojiButton";
            this.EmojiButton.Size = new System.Drawing.Size(52, 19);
            this.EmojiButton.TabIndex = 6;
            this.EmojiButton.Text = "Emojis";
            this.EmojiButton.UseVisualStyleBackColor = true;
            this.EmojiButton.Click += new System.EventHandler(this.EmojiButton_Click);
            // 
            // EggplantButton
            // 
            this.EggplantButton.BackColor = System.Drawing.SystemColors.Control;
            this.EggplantButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EggplantButton.BackgroundImage")));
            this.EggplantButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("EggplantButton.ErrorImage")));
            this.EggplantButton.Image = ((System.Drawing.Image)(resources.GetObject("EggplantButton.Image")));
            this.EggplantButton.Location = new System.Drawing.Point(482, 239);
            this.EggplantButton.Name = "EggplantButton";
            this.EggplantButton.Size = new System.Drawing.Size(136, 94);
            this.EggplantButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EggplantButton.TabIndex = 7;
            this.EggplantButton.TabStop = false;
            this.EggplantButton.Visible = false;
            // 
            // MonkeeButton
            // 
            this.MonkeeButton.Image = ((System.Drawing.Image)(resources.GetObject("MonkeeButton.Image")));
            this.MonkeeButton.Location = new System.Drawing.Point(339, 239);
            this.MonkeeButton.Name = "MonkeeButton";
            this.MonkeeButton.Size = new System.Drawing.Size(125, 94);
            this.MonkeeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MonkeeButton.TabIndex = 8;
            this.MonkeeButton.TabStop = false;
            this.MonkeeButton.Visible = false;
            // 
            // HappyButton
            // 
            this.HappyButton.Image = ((System.Drawing.Image)(resources.GetObject("HappyButton.Image")));
            this.HappyButton.Location = new System.Drawing.Point(222, 239);
            this.HappyButton.Name = "HappyButton";
            this.HappyButton.Size = new System.Drawing.Size(111, 94);
            this.HappyButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HappyButton.TabIndex = 9;
            this.HappyButton.TabStop = false;
            this.HappyButton.Visible = false;
            // 
            // CoolButton
            // 
            this.CoolButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CoolButton.BackgroundImage")));
            this.CoolButton.Image = ((System.Drawing.Image)(resources.GetObject("CoolButton.Image")));
            this.CoolButton.Location = new System.Drawing.Point(104, 239);
            this.CoolButton.Name = "CoolButton";
            this.CoolButton.Size = new System.Drawing.Size(112, 94);
            this.CoolButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoolButton.TabIndex = 10;
            this.CoolButton.TabStop = false;
            this.CoolButton.Visible = false;
            this.CoolButton.Click += new System.EventHandler(this.CoolButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Skicka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EggplantButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonkeeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HappyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoolButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Skicka;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EmojiButton;
        private System.Windows.Forms.PictureBox EggplantButton;
        private System.Windows.Forms.PictureBox MonkeeButton;
        private System.Windows.Forms.PictureBox HappyButton;
        private System.Windows.Forms.PictureBox CoolButton;
    }
}

