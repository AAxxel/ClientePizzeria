namespace ClientePizzeria
{
    partial class Login
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
            linkLabel1 = new LinkLabel();
            title = new Label();
            textBoxPassWord = new TextBox();
            textBoxUserName = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(286, 380);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(222, 15);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Aun no tienes una cuenta? Ingresa aqui.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 20F);
            title.ForeColor = SystemColors.ButtonHighlight;
            title.Location = new Point(296, 49);
            title.Name = "title";
            title.Size = new Size(181, 37);
            title.TabIndex = 11;
            title.Text = "Login Pizzeria";
            // 
            // textBoxPassWord
            // 
            textBoxPassWord.Location = new Point(286, 210);
            textBoxPassWord.Name = "textBoxPassWord";
            textBoxPassWord.PlaceholderText = "Password";
            textBoxPassWord.Size = new Size(228, 23);
            textBoxPassWord.TabIndex = 10;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(286, 138);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Nombre de Usuario";
            textBoxUserName.Size = new Size(228, 23);
            textBoxUserName.TabIndex = 9;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.Desktop;
            loginButton.FlatStyle = FlatStyle.System;
            loginButton.Location = new Point(286, 283);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(228, 56);
            loginButton.TabIndex = 8;
            loginButton.Text = "Registrame";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(title);
            Controls.Add(textBoxPassWord);
            Controls.Add(textBoxUserName);
            Controls.Add(loginButton);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label title;
        private TextBox textBoxPassWord;
        private TextBox textBoxUserName;
        private Button loginButton;
    }
}