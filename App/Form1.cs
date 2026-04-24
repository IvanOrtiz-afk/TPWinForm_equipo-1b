using App.Dominio;
using App.Negocio;
using System;
using System.Collections.Generic;
using System.Net;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        private List<Imagen> listaImagenes;
        private int indiceImagen = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dataGridView1.DataSource = listaArticulos;
            //pictureBox1.ImageLocation = "https://i5-mx.walmartimages.com/mg/gm/1p/images/product-images/img_large/00019019862572l.jpg";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            var marcas = marcaNegocio.listar();

            cboMarcaFiltro.Items.Clear();

            foreach (var item in marcas)
            {
                cboMarcaFiltro.Items.Add(item);
            }
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            var categorias = categoriaNegocio.listar();

            cboCategoriaFiltro.Items.Clear();

            foreach (var item in categorias)
            {
                cboCategoriaFiltro.Items.Add(item);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada = listaArticulos;

            // TEXTO
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                listaFiltrada = listaFiltrada.FindAll(x =>
                    x.Nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()) ||
                    x.Codigo.ToUpper().Contains(txtBuscar.Text.ToUpper()) ||
                    x.Descripcion.ToUpper().Contains(txtBuscar.Text.ToUpper())
                );
            }

            // MARCA
            if (cboMarcaFiltro.SelectedIndex != -1)
            {
                Marca marcaSeleccionada = (Marca)cboMarcaFiltro.SelectedItem;
                listaFiltrada = listaFiltrada.FindAll(x => x.Marca.Id == marcaSeleccionada.Id);
            }

            // CATEGORIA
            if (cboCategoriaFiltro.SelectedIndex != -1)
            {
                Categoria categoriaSeleccionada = (Categoria)cboCategoriaFiltro.SelectedItem;
                listaFiltrada = listaFiltrada.FindAll(x => x.Categoria.Id == categoriaSeleccionada.Id);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaFiltrada;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cboMarcaFiltro.SelectedIndex = -1;
            cboCategoriaFiltro.SelectedIndex = -1;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaArticulos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que querés eliminar el artículo?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.Yes)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.eliminar(seleccionado.Id);

                listaArticulos = negocio.listar();
                dataGridView1.DataSource = listaArticulos;


            }
        }

        private void cargarImagen(string url)
        {
            try
            {
                pictureBox1.ImageLocation = null;
                pictureBox1.ImageLocation = url;
            }
            catch
            {
                pictureBox1.ImageLocation = "https://via.placeholder.com/300?text=Error";
            }
        }


        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;

                ArticuloNegocio negocio = new ArticuloNegocio();
                listaImagenes = negocio.listarImagenes(seleccionado.Id);

                indiceImagen = 0;

                if (listaImagenes != null && listaImagenes.Count > 0)
                {
                    cargarImagen(listaImagenes[indiceImagen].ImagenUrl);
                }
                else
                {
                    pictureBox1.ImageLocation = "https://via.placeholder.com/300?text=Sin+Imagen";
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (listaImagenes == null || listaImagenes.Count == 0)
                return;

            indiceImagen++;

            if (indiceImagen >= listaImagenes.Count)
                indiceImagen = 0;

            cargarImagen(listaImagenes[indiceImagen].ImagenUrl);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (listaImagenes == null || listaImagenes.Count == 0)
                return;

            indiceImagen--;

            if (indiceImagen < 0)
                indiceImagen = listaImagenes.Count - 1;

            cargarImagen(listaImagenes[indiceImagen].ImagenUrl);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArticulo alta = new frmArticulo();
            alta.ShowDialog();


            btnCargar_Click(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            frmArticulo modificar = new frmArticulo(seleccionado);
            modificar.ShowDialog();

            // refrescar lista
            btnCargar_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
