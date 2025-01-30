namespace ClientePizzeria.Views
{
    partial class Producto
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
            button2 = new Button();
            button1 = new Button();
            buttonEditar = new Button();
            inputCategoria = new TextBox();
            inputImpuesto = new TextBox();
            inputPrecio = new TextBox();
            inputNombre = new TextBox();
            panel = new DataGridView();
            inputProveedor = new TextBox();
            idProducto = new DataGridViewTextBoxColumn();
            nombreProductoCell = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            impuesto = new DataGridViewTextBoxColumn();
            stockCell = new DataGridViewTextBoxColumn();
            idCategoria = new DataGridViewTextBoxColumn();
            idProveedor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)panel).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(655, 398);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Atras";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(66, 400);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(147, 400);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 13;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // inputCategoria
            // 
            inputCategoria.Location = new Point(476, 53);
            inputCategoria.Name = "inputCategoria";
            inputCategoria.PlaceholderText = "idCategoria";
            inputCategoria.Size = new Size(119, 23);
            inputCategoria.TabIndex = 12;
            // 
            // inputImpuesto
            // 
            inputImpuesto.Location = new Point(341, 53);
            inputImpuesto.Name = "inputImpuesto";
            inputImpuesto.PlaceholderText = "Impuesto";
            inputImpuesto.Size = new Size(119, 23);
            inputImpuesto.TabIndex = 11;
            // 
            // inputPrecio
            // 
            inputPrecio.Location = new Point(204, 53);
            inputPrecio.Name = "inputPrecio";
            inputPrecio.PlaceholderText = "precio";
            inputPrecio.Size = new Size(119, 23);
            inputPrecio.TabIndex = 10;
            // 
            // inputNombre
            // 
            inputNombre.Location = new Point(67, 53);
            inputNombre.Name = "inputNombre";
            inputNombre.PlaceholderText = "Nombre Producto";
            inputNombre.Size = new Size(119, 23);
            inputNombre.TabIndex = 9;
            // 
            // panel
            // 
            panel.BackgroundColor = SystemColors.ActiveCaption;
            panel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panel.Columns.AddRange(new DataGridViewColumn[] { idProducto, nombreProductoCell, precio, impuesto, stockCell, idCategoria, idProveedor });
            panel.Location = new Point(35, 88);
            panel.Name = "panel";
            panel.Size = new Size(753, 293);
            panel.TabIndex = 8;
            panel.CellClick += panel_CellClick;
            // 
            // inputProveedor
            // 
            inputProveedor.Location = new Point(611, 53);
            inputProveedor.Name = "inputProveedor";
            inputProveedor.PlaceholderText = "idProveedor";
            inputProveedor.Size = new Size(119, 23);
            inputProveedor.TabIndex = 16;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "Id";
            idProducto.Name = "idProducto";
            // 
            // nombreProductoCell
            // 
            nombreProductoCell.HeaderText = "Nombre Producto";
            nombreProductoCell.Name = "nombreProductoCell";
            nombreProductoCell.Width = 150;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // impuesto
            // 
            impuesto.HeaderText = "Impuesto";
            impuesto.Name = "impuesto";
            impuesto.Width = 70;
            // 
            // stockCell
            // 
            stockCell.HeaderText = "Disponibles";
            stockCell.Name = "stockCell";
            // 
            // idCategoria
            // 
            idCategoria.HeaderText = "idCategoria";
            idCategoria.Name = "idCategoria";
            // 
            // idProveedor
            // 
            idProveedor.HeaderText = "idProveedor";
            idProveedor.Name = "idProveedor";
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputProveedor);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonEditar);
            Controls.Add(inputCategoria);
            Controls.Add(inputImpuesto);
            Controls.Add(inputPrecio);
            Controls.Add(inputNombre);
            Controls.Add(panel);
            Name = "Producto";
            Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)panel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button buttonEditar;
        private TextBox inputCategoria;
        private TextBox inputImpuesto;
        private TextBox inputPrecio;
        private TextBox inputNombre;
        private DataGridView panel;
        private TextBox inputProveedor;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn nombreProductoCell;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn impuesto;
        private DataGridViewTextBoxColumn stockCell;
        private DataGridViewTextBoxColumn idCategoria;
        private DataGridViewTextBoxColumn idProveedor;
    }
}