namespace ClientePizzeria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginButton = new Button();
            textBoxUserName = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassWord = new TextBox();
            comboBoxRoles = new ComboBox();
            title = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.Desktop;
            loginButton.FlatStyle = FlatStyle.System;
            loginButton.Location = new Point(298, 326);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(228, 56);
            loginButton.TabIndex = 0;
            loginButton.Text = "Registrame";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(298, 74);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Nombre de Usuario";
            textBoxUserName.Size = new Size(228, 23);
            textBoxUserName.TabIndex = 1;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(298, 123);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "Telefono";
            textBoxTelefono.Size = new Size(228, 23);
            textBoxTelefono.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(298, 179);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email";
            textBoxEmail.Size = new Size(228, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxPassWord
            // 
            textBoxPassWord.Location = new Point(298, 232);
            textBoxPassWord.Name = "textBoxPassWord";
            textBoxPassWord.PlaceholderText = "Password";
            textBoxPassWord.Size = new Size(228, 23);
            textBoxPassWord.TabIndex = 4;
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Items.AddRange(new object[] { "Cajero", "Supervisor", "Gerente" });
            comboBoxRoles.Location = new Point(298, 283);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(228, 23);
            comboBoxRoles.TabIndex = 5;
            comboBoxRoles.Text = "Seleccione su cargo";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 20F);
            title.ForeColor = SystemColors.ButtonHighlight;
            title.Location = new Point(301, 17);
            title.Name = "title";
            title.Size = new Size(211, 37);
            title.TabIndex = 6;
            title.Text = "Registro Pizzeria";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(318, 405);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(184, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Ya estas registrado? Ingresa aqui.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(title);
            Controls.Add(comboBoxRoles);
            Controls.Add(textBoxPassWord);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxUserName);
            Controls.Add(loginButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox textBoxUserName;
        private TextBox textBoxTelefono;
        private TextBox textBoxEmail;
        private TextBox textBoxPassWord;
        private ComboBox comboBoxRoles;
        private Label title;
        private LinkLabel linkLabel1;
    }
}
