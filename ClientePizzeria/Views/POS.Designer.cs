namespace ClientePizzeria.Views
{
    partial class POS
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
            index = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            comboBoxCliente = new ComboBox();
            comboBoxDireccion = new ComboBox();
            comboBoxProducto = new ComboBox();
            inputCantidad = new TextBox();
            labelNumero = new Label();
            labelTotal = new Label();
            buttonAdd = new Button();
            buttonSalir = new Button();
            buttonCobrar = new Button();
            ((System.ComponentModel.ISupportInitialize)panel).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panel.Columns.AddRange(new DataGridViewColumn[] { index, producto, precio, cantidad, subTotal });
            panel.Location = new Point(51, 84);
            panel.Name = "panel";
            panel.Size = new Size(702, 301);
            panel.TabIndex = 0;
            // 
            // index
            // 
            index.HeaderText = "No.";
            index.Name = "index";
            index.Width = 60;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.Name = "producto";
            producto.Width = 300;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            // 
            // subTotal
            // 
            subTotal.HeaderText = "SubTotal Producto";
            subTotal.Name = "subTotal";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(59, 43);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(121, 23);
            comboBoxCliente.TabIndex = 1;
            comboBoxCliente.Text = "Seleccione cliente";
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
            // 
            // comboBoxDireccion
            // 
            comboBoxDireccion.FormattingEnabled = true;
            comboBoxDireccion.Location = new Point(210, 43);
            comboBoxDireccion.Name = "comboBoxDireccion";
            comboBoxDireccion.Size = new Size(136, 23);
            comboBoxDireccion.TabIndex = 2;
            comboBoxDireccion.Text = "Seleccione Direccion";
            // 
            // comboBoxProducto
            // 
            comboBoxProducto.FormattingEnabled = true;
            comboBoxProducto.Location = new Point(377, 43);
            comboBoxProducto.Name = "comboBoxProducto";
            comboBoxProducto.Size = new Size(136, 23);
            comboBoxProducto.TabIndex = 3;
            comboBoxProducto.Text = "Seleccione Producto";
            // 
            // inputCantidad
            // 
            inputCantidad.Location = new Point(539, 43);
            inputCantidad.Name = "inputCantidad";
            inputCantidad.PlaceholderText = "Cantidad";
            inputCantidad.Size = new Size(100, 23);
            inputCantidad.TabIndex = 4;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Segoe UI", 20F);
            labelNumero.Location = new Point(645, 404);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(32, 37);
            labelNumero.TabIndex = 5;
            labelNumero.Text = "0";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 20F);
            labelTotal.Location = new Point(559, 404);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(80, 37);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "Total:";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(678, 43);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Agregar";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(51, 412);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(75, 23);
            buttonSalir.TabIndex = 8;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonCobrar
            // 
            buttonCobrar.Location = new Point(167, 412);
            buttonCobrar.Name = "buttonCobrar";
            buttonCobrar.Size = new Size(75, 23);
            buttonCobrar.TabIndex = 9;
            buttonCobrar.Text = "Cobrar";
            buttonCobrar.UseVisualStyleBackColor = true;
            buttonCobrar.Click += buttonCobrar_Click;
            // 
            // POS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCobrar);
            Controls.Add(buttonSalir);
            Controls.Add(buttonAdd);
            Controls.Add(labelTotal);
            Controls.Add(labelNumero);
            Controls.Add(inputCantidad);
            Controls.Add(comboBoxProducto);
            Controls.Add(comboBoxDireccion);
            Controls.Add(comboBoxCliente);
            Controls.Add(panel);
            Name = "POS";
            Text = "POS";
            ((System.ComponentModel.ISupportInitialize)panel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView panel;
        private DataGridViewTextBoxColumn index;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subTotal;
        private ComboBox comboBoxCliente;
        private ComboBox comboBoxDireccion;
        private ComboBox comboBoxProducto;
        private TextBox inputCantidad;
        private Label labelNumero;
        private Label labelTotal;
        private Button buttonAdd;
        private Button buttonSalir;
        private Button buttonCobrar;
    }
}