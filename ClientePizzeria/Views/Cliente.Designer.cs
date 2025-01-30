namespace ClientePizzeria.Views
{
    partial class Cliente
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
            buttonEditar = new Button();
            inputEmail = new TextBox();
            inputTelefono = new TextBox();
            inputName = new TextBox();
            panel = new DataGridView();
            IdCliente = new DataGridViewTextBoxColumn();
            nombreCliente = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)panel).BeginInit();
            SuspendLayout();
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(672, 52);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 11;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(304, 53);
            inputEmail.Name = "inputEmail";
            inputEmail.PlaceholderText = "Email";
            inputEmail.Size = new Size(119, 23);
            inputEmail.TabIndex = 10;
            // 
            // inputTelefono
            // 
            inputTelefono.Location = new Point(179, 53);
            inputTelefono.Name = "inputTelefono";
            inputTelefono.PlaceholderText = "Telefono";
            inputTelefono.Size = new Size(119, 23);
            inputTelefono.TabIndex = 9;
            // 
            // inputName
            // 
            inputName.Location = new Point(54, 53);
            inputName.Name = "inputName";
            inputName.PlaceholderText = "Nombre Cliente";
            inputName.Size = new Size(119, 23);
            inputName.TabIndex = 8;
            // 
            // panel
            // 
            panel.BackgroundColor = SystemColors.ActiveCaption;
            panel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panel.Columns.AddRange(new DataGridViewColumn[] { IdCliente, nombreCliente, telefono, email });
            panel.Location = new Point(54, 94);
            panel.Name = "panel";
            panel.Size = new Size(693, 293);
            panel.TabIndex = 6;
            panel.CellClick += panel_CellClick;
            panel.CellContentClick += panel_CellContentClick;
            // 
            // IdCliente
            // 
            IdCliente.HeaderText = "id";
            IdCliente.Name = "IdCliente";
            // 
            // nombreCliente
            // 
            nombreCliente.HeaderText = "Nombre";
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Width = 250;
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
            email.Width = 200;
            // 
            // button1
            // 
            button1.Location = new Point(566, 53);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(672, 404);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Atras";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonEditar);
            Controls.Add(inputEmail);
            Controls.Add(inputTelefono);
            Controls.Add(inputName);
            Controls.Add(panel);
            Name = "Cliente";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)panel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEditar;
        private TextBox inputEmail;
        private TextBox inputTelefono;
        private TextBox inputName;
        private DataGridView panel;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn nombreCliente;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn email;
        private Button button1;
        private Button button2;
    }
}