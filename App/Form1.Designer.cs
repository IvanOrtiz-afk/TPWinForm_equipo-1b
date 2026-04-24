namespace App
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBuscar = new TextBox();
            menuStrip1 = new MenuStrip();
            holaToolStripMenuItem = new ToolStripMenuItem();
            cboMarcaFiltro = new ToolStripComboBox();
            filtrarPorCategoriaToolStripMenuItem = new ToolStripMenuItem();
            cboCategoriaFiltro = new ToolStripComboBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleName = "dgvArticulos";
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(742, 310);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dgvArticulos_SelectionChanged;
            // 
            // button1
            // 
            button1.AccessibleName = "btnCargar";
            button1.Location = new Point(12, 390);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCargar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleName = "pbxArticulo";
            pictureBox1.Location = new Point(785, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.AccessibleName = "btnAgregar";
            btnAgregar.Location = new Point(93, 390);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.AccessibleName = "btnModificar";
            btnModificar.Location = new Point(174, 390);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AccessibleName = "btnEliminar";
            btnEliminar.Location = new Point(255, 390);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.AccessibleName = "btnAnterior";
            btnAnterior.Location = new Point(785, 358);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 6;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.AccessibleName = "btnSiguiente";
            btnSiguiente.Location = new Point(972, 358);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 7;
            btnSiguiente.Text = "Siguiente >";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 8;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(835, 38);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 9;
            label2.Text = "Previsualización";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(214, 40);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 10;
            label3.Text = "Búsqueda";
            // 
            // txtBuscar
            // 
            txtBuscar.AccessibleName = "txtBuscar";
            txtBuscar.Location = new Point(305, 40);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(117, 23);
            txtBuscar.TabIndex = 11;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { holaToolStripMenuItem, filtrarPorCategoriaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1066, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // holaToolStripMenuItem
            // 
            holaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cboMarcaFiltro });
            holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            holaToolStripMenuItem.Size = new Size(106, 20);
            holaToolStripMenuItem.Text = "Filtrar por Marca";
            holaToolStripMenuItem.Click += holaToolStripMenuItem_Click;
            // 
            // cboMarcaFiltro
            // 
            cboMarcaFiltro.AccessibleName = "cboMarcaFiltro";
            cboMarcaFiltro.Name = "cboMarcaFiltro";
            cboMarcaFiltro.Size = new Size(121, 23);
            cboMarcaFiltro.Click += Form1_Load;
            // 
            // filtrarPorCategoriaToolStripMenuItem
            // 
            filtrarPorCategoriaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cboCategoriaFiltro });
            filtrarPorCategoriaToolStripMenuItem.Name = "filtrarPorCategoriaToolStripMenuItem";
            filtrarPorCategoriaToolStripMenuItem.Size = new Size(124, 20);
            filtrarPorCategoriaToolStripMenuItem.Text = "Filtrar por Categoria";
            // 
            // cboCategoriaFiltro
            // 
            cboCategoriaFiltro.AccessibleName = "cboCategoriaFiltro";
            cboCategoriaFiltro.Name = "cboCategoriaFiltro";
            cboCategoriaFiltro.Size = new Size(121, 23);
            cboCategoriaFiltro.Click += Form1_Load;
            // 
            // btnBuscar
            // 
            btnBuscar.AccessibleName = "btnBuscar";
            btnBuscar.Location = new Point(428, 40);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AccessibleName = "btnLimpiar";
            btnLimpiar.Location = new Point(509, 40);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar Filtros";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 422);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += btnCargar_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBuscar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem holaToolStripMenuItem;
        private ToolStripMenuItem filtrarPorCategoriaToolStripMenuItem;
        private Button btnBuscar;
        private Button btnLimpiar;
        private ToolStripComboBox cboMarcaFiltro;
        private ToolStripComboBox cboCategoriaFiltro;
    }
}
