using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using Negocio; 
namespace Negocio
{
    public class ArticuloNegocio
    {
        //esta funcion la creo para buscar el Id de imagen y relacionarlo con articulo
        public string BuscarUrl(int Id)
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS;database=CATALOGO_P3_DB;integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = $"select ImagenUrl from IMAGENES where IdArticulo ={Id} ";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                string Url = "";
                while (lector.Read())
                {
                    Url = (string)lector["ImagenUrl"];

                }
                conexion.Close();
                return Url;
            }
            catch (Exception ex)

            {
                throw ex;
            }
        }
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS;database=CATALOGO_P3_DB;integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id,Codigo,Nombre,A.Descripcion,IdMarca,IdCategoria,Precio,C.Descripcion Tipo, M.Descripcion Marca, ImagenUrl from ((ARTICULOS A join MARCAS M on A.IdMarca=M.Id)join CATEGORIAS C on C.Id=A.IdCategoria) join IMAGENES I on I.IdArticulo=A.Id ";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
              
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.Tipo = new Categoria();//instancia
                    aux.Tipo.Id = (int)lector["Id"];
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.ImagenUrl = BuscarUrl(aux.Id);
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)

            {
                throw ex;
            }

        }
        public List<Articulo> listarUnico(string Nombre)
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS;database=CATALOGO_P3_DB;integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id,Codigo,Nombre,A.Descripcion,IdMarca,IdCategoria,Precio,C.Descripcion Tipo," +
                    " M.Descripcion Marca, ImagenUrl from ((ARTICULOS A join MARCAS M on A.IdMarca=M.Id)join CATEGORIAS C on C.Id=A.IdCategoria) " +
                    $"join IMAGENES I on I.IdArticulo=A.Id where A.Nombre LIKE '{Nombre}%'";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
               {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.Tipo = new Categoria();//instancia
                    aux.Tipo.Id = (int)lector["Id"];
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.ImagenUrl = BuscarUrl(aux.Id);
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)

            {
                throw ex;
            }

        }
    }
}

        
    

