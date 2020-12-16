namespace ChattFönster
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.CurrentName = new System.Windows.Forms.Label();
            this.NameStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(47, 49);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(153, 46);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click_1);
            // 
            // CurrentName
            // 
            this.CurrentName.AutoSize = true;
            this.CurrentName.Location = new System.Drawing.Point(12, 9);
            this.CurrentName.Name = "CurrentName";
            this.CurrentName.Size = new System.Drawing.Size(0, 13);
            this.CurrentName.TabIndex = 2;
            this.CurrentName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // NameStatus
            // 
            this.NameStatus.AutoSize = true;
            this.NameStatus.Location = new System.Drawing.Point(44, 90);
            this.NameStatus.Name = "NameStatus";
            this.NameStatus.Size = new System.Drawing.Size(125, 13);
            this.NameStatus.TabIndex = 3;
            this.NameStatus.Text = "Please write a username!";
            // 
            // login
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(322, 496);
            this.Controls.Add(this.NameStatus);
            this.Controls.Add(this.CurrentName);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.NameBox);
            this.Name = "login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label CurrentName;
        private System.Windows.Forms.Label NameStatus;
    }
}