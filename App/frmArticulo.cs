using App.Dominio;
using App.Negocio;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class frmArticulo : Form
    {
        private Articulo articulo = null;

        
        public frmArticulo()
        {
            InitializeComponent();
        }

        
        public frmArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmArticulo_marca(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            // cargar combos
            cboMarca.DataSource = marcaNegocio.listar();
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.ValueMember = "Id";
        }

        private void frmArticulo_categoria(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cboCategoria.DataSource = categoriaNegocio.listar();
            cboCategoria.DisplayMember = "Descripcion";
            cboCategoria.ValueMember = "Id";
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
           

            // si es modificacion
            if (articulo != null)
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtPrecio.Text = articulo.Precio.ToString();

                cboMarca.SelectedValue = articulo.Marca.Id;
                cboCategoria.SelectedValue = articulo.Categoria.Id;

                // cargar imagen si existe
                if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
                {
                    txtImagenUrl.Text = articulo.Imagenes[0].ImagenUrl;
                    cargarImagen(txtImagenUrl.Text);
                }
            }
        }

        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (articulo == null)
                articulo = new Articulo();

            articulo.Codigo = txtCodigo.Text;
            articulo.Nombre = txtNombre.Text;
            articulo.Descripcion = txtDescripcion.Text;
            articulo.Marca = (Marca)cboMarca.SelectedItem;
            articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
            articulo.Precio = decimal.Parse(txtPrecio.Text);

            if (articulo.Id != 0)
            {
                negocio.modificar(articulo);

                // guardar imagen
                if (!string.IsNullOrEmpty(txtImagenUrl.Text))
                {
                    negocio.agregarImagen(articulo.Id, txtImagenUrl.Text);
                }

                MessageBox.Show("Modificado");
            }
            
            else
            {
                int idNuevo = negocio.agregar(articulo);

                // guardar imagen
                if (!string.IsNullOrEmpty(txtImagenUrl.Text))
                {
                    negocio.agregarImagen(idNuevo, txtImagenUrl.Text);
                }

                MessageBox.Show("Agregado");
            }

            Close();
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtImagenUrl.Text))
                cargarImagen(txtImagenUrl.Text);
        }


        private void cargarImagen(string url)
        {
            try
            {
                System.Net.ServicePointManager.SecurityProtocol =
                    System.Net.SecurityProtocolType.Tls12;

                using (var cliente = new System.Net.WebClient())
                {
                    byte[] datos = cliente.DownloadData(url);

                    using (var ms = new System.IO.MemoryStream(datos))
                    {
                        pbxPreview.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                // imagen fallback
                pbxPreview.ImageLocation = "https://via.placeholder.com/300?text=Error";
            }
        }
    }
}