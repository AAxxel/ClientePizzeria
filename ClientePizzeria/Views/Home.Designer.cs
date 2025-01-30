namespace ClientePizzeria
{
    partial class Home
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
            title = new Label();
            usuariosOptions = new Button();
            clientesOptions = new Button();
            pedidosOptions = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 30F);
            title.Location = new Point(320, 9);
            title.Name = "title";
            title.Size = new Size(129, 54);
            title.TabIndex = 0;
            title.Text = "Home";
            // 
            // usuariosOptions
            // 
            usuariosOptions.BackColor = Color.FromArgb(255, 128, 128);
            usuariosOptions.Font = new Font("Segoe UI", 13F);
            usuariosOptions.Location = new Point(271, 92);
            usuariosOptions.Name = "usuariosOptions";
            usuariosOptions.Size = new Size(232, 85);
            usuariosOptions.TabIndex = 1;
            usuariosOptions.Text = "Administrar Usuarios";
            usuariosOptions.UseVisualStyleBackColor = false;
            usuariosOptions.Click += usuariosOptions_Click;
            // 
            // clientesOptions
            // 
            clientesOptions.BackColor = Color.FromArgb(255, 192, 192);
            clientesOptions.Font = new Font("Segoe UI", 13F);
            clientesOptions.Location = new Point(271, 195);
            clientesOptions.Name = "clientesOptions";
            clientesOptions.Size = new Size(232, 85);
            clientesOptions.TabIndex = 2;
            clientesOptions.Text = "Administrar Clientes";
            clientesOptions.UseVisualStyleBackColor = false;
            clientesOptions.Click += clientesOptions_Click;
            // 
            // pedidosOptions
            // 
            pedidosOptions.BackColor = Color.FromArgb(192, 255, 192);
            pedidosOptions.Font = new Font("Segoe UI", 13F);
            pedidosOptions.Location = new Point(271, 300);
            pedidosOptions.Name = "pedidosOptions";
            pedidosOptions.Size = new Size(232, 85);
            pedidosOptions.TabIndex = 3;
            pedidosOptions.Text = "Administrar Productos";
            pedidosOptions.UseVisualStyleBackColor = false;
            pedidosOptions.Click += pedidosOptions_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 415);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(pedidosOptions);
            Controls.Add(clientesOptions);
            Controls.Add(usuariosOptions);
            Controls.Add(title);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button usuariosOptions;
        private Button clientesOptions;
        private Button pedidosOptions;
        private Button button3;
    }
}