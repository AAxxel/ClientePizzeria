namespace ClientePizzeria
{
    partial class UsuariosList
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
            panel = new DataGridView();
            IdUsuario = new DataGridViewTextBoxColumn();
            idRol = new DataGridViewTextBoxColumn();
            nombreUsuario = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            inputRol = new TextBox();
            inputName = new TextBox();
            inputTelefono = new TextBox();
            inputEmail = new TextBox();
            buttonEditar = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)panel).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackgroundColor = SystemColors.ActiveCaption;
            panel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panel.Columns.AddRange(new DataGridViewColumn[] { IdUsuario, idRol, nombreUsuario, telefono, email });
            panel.Location = new Point(61, 108);
            panel.Name = "panel";
            panel.Size = new Size(693, 293);
            panel.TabIndex = 0;
            panel.CellClick += panel_CellClick_1;
            panel.CellContentClick += panel_CellContentClick;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "id";
            IdUsuario.Name = "IdUsuario";
            // 
            // idRol
            // 
            idRol.HeaderText = "Rol";
            idRol.Name = "idRol";
            // 
            // nombreUsuario
            // 
            nombreUsuario.HeaderText = "Nombre";
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.Width = 250;
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.Name = "email";
            // 
            // inputRol
            // 
            inputRol.Location = new Point(61, 75);
            inputRol.Name = "inputRol";
            inputRol.PlaceholderText = "IdRol";
            inputRol.Size = new Size(119, 23);
            inputRol.TabIndex = 1;
            // 
            // inputName
            // 
            inputName.Location = new Point(186, 75);
            inputName.Name = "inputName";
            inputName.PlaceholderText = "Nombre Usuario";
            inputName.Size = new Size(119, 23);
            inputName.TabIndex = 2;
            // 
            // inputTelefono
            // 
            inputTelefono.Location = new Point(311, 75);
            inputTelefono.Name = "inputTelefono";
            inputTelefono.PlaceholderText = "Telefono";
            inputTelefono.Size = new Size(119, 23);
            inputTelefono.TabIndex = 3;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(436, 75);
            inputEmail.Name = "inputEmail";
            inputEmail.PlaceholderText = "Email";
            inputEmail.Size = new Size(119, 23);
            inputEmail.TabIndex = 4;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(655, 74);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(99, 23);
            buttonEditar.TabIndex = 5;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(679, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Atras";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UsuariosList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(buttonEditar);
            Controls.Add(inputEmail);
            Controls.Add(inputTelefono);
            Controls.Add(inputName);
            Controls.Add(inputRol);
            Controls.Add(panel);
            Name = "UsuariosList";
            Text = "UsuariosList";
            ((System.ComponentModel.ISupportInitialize)panel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView panel;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn idRol;
        private DataGridViewTextBoxColumn nombreUsuario;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn email;
        private TextBox inputRol;
        private TextBox inputName;
        private TextBox inputTelefono;
        private TextBox inputEmail;
        private Button buttonEditar;
        private Button button1;
        private Button button2;
    }
}