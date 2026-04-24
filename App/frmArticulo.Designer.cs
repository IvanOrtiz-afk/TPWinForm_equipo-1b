namespace App
{
    partial class frmArticulo
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
            txtNombre = new TextBox();
            cboMarca = new ComboBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtCodigo = new TextBox();
            cboCategoria = new ComboBox();
            pbxPreview = new PictureBox();
            txtImagenUrl = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxPreview).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.AccessibleName = "txtNombre";
            txtNombre.Location = new Point(118, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // cboMarca
            // 
            cboMarca.AccessibleName = "cboMarca";
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(12, 148);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(121, 23);
            cboMarca.TabIndex = 1;
            
            cboMarca.Click += frmArticulo_marca;
            // 
            // txtDescripcion
            // 
            txtDescripcion.AccessibleName = "txtDescripcion";
            txtDescripcion.Location = new Point(224, 87);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.AccessibleName = "txtPrecio";
            txtPrecio.Location = new Point(330, 87);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 3;
            // 
            // txtCodigo
            // 
            txtCodigo.AccessibleName = "txtCodigo";
            txtCodigo.Location = new Point(12, 87);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 4;
            // 
            // cboCategoria
            // 
            cboCategoria.AccessibleName = "cboCategoria";
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(139, 148);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(121, 23);
            cboCategoria.TabIndex = 5;
            cboCategoria.Click += frmArticulo_categoria;
            // 
            // pbxPreview
            // 
            pbxPreview.AccessibleName = "pbxPreview";
            pbxPreview.Location = new Point(468, 39);
            pbxPreview.Name = "pbxPreview";
            pbxPreview.Size = new Size(187, 176);
            pbxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPreview.TabIndex = 6;
            pbxPreview.TabStop = false;
            // 
            // txtImagenUrl
            // 
            txtImagenUrl.AccessibleName = "txtImagenUrl";
            txtImagenUrl.Location = new Point(266, 148);
            txtImagenUrl.Name = "txtImagenUrl";
            txtImagenUrl.Size = new Size(100, 23);
            txtImagenUrl.TabIndex = 7;
            txtImagenUrl.TextChanged += txtImagenUrl_Leave;
            // 
            // label1
            // 
            label1.AccessibleName = "lblTitulo";
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 8;
            label1.Text = "Carga de datos";
            // 
            // button1
            // 
            button1.AccessibleName = "btnAceptar";
            button1.Location = new Point(79, 186);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.TabIndex = 9;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAceptar_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "btnCancelar";
            button2.Location = new Point(302, 186);
            button2.Name = "button2";
            button2.Size = new Size(100, 38);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 69);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 11;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 69);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 12;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 69);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 13;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 69);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 14;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 130);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 15;
            label6.Text = "Marca";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 130);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 16;
            label7.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(278, 130);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 17;
            label8.Text = "Imagen URL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(513, 9);
            label9.Name = "label9";
            label9.Size = new Size(100, 21);
            label9.TabIndex = 18;
            label9.Text = "Vista previa";
            // 
            // frmArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 255);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtImagenUrl);
            Controls.Add(pbxPreview);
            Controls.Add(cboCategoria);
            Controls.Add(txtCodigo);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(cboMarca);
            Controls.Add(txtNombre);
            Name = "frmArticulo";
            Text = "frmArticulo";
            Load += frmArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)pbxPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private ComboBox cboMarca;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtCodigo;
        private ComboBox cboCategoria;
        private PictureBox pbxPreview;
        private TextBox txtImagenUrl;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}