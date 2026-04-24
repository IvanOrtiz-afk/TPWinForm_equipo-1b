using App.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca m = new Marca();
                    m.Id = (int)datos.Lector["Id"];
                    m.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(m);
                }

                return lista;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
