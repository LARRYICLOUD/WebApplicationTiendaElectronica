using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationTiendaElectronica.Datos
{
    public class AlmacenData
    {
        public static bool Registrar(Almacen almacen)
        {

            using (SqlConnection cn = new SqlConnection(Conexion.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_registrarAlmacen", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", almacen.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", almacen.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", almacen.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad",almacen.Cantidad);
                cmd.Parameters.AddWithValue("@Precio",almacen.Precio);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }

        }

        public static bool Modificar(Almacen almacen)
        {

            using (SqlConnection cn = new SqlConnection(Conexion.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_modificarAlmacen", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", almacen.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", almacen.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", almacen.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad", almacen.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", almacen.Precio);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }

        }


        public static List<Almacen> Listar()
        {
            List<Almacen> almacen = new List<Almacen>();
            using (SqlConnection cn = new SqlConnection(Conexion.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_listarAlmacen", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())

                        {
                           almacen.Add(new Almacen()
                            {
                                Codigo = Convert.ToInt32(dr["Codigo"]),
                                //Codigo = dr["Codigo"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                               Precio = Convert.ToInt32(dr["Precio"]),
                    

                            });


                        }


                    }
                    return almacen;






                }
                catch (Exception ex)
                {
                    return almacen;
                }
            }
        }

        public static Almacen Obtener(int codigo)
        {
            Almacen almacen = new Almacen();
            using (SqlConnection cn = new SqlConnection(Conexion.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_obtenerAlmacen", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(" @codigo", codigo);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            almacen = new Almacen()
                            {

                                //IdUsuario = Convert.ToInt32(dr["idUsuario"]),
                                Codigo = Convert.ToInt32(dr["Codigo"]),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                Precio = Convert.ToInt32(dr["Cantidad"]),
                   

                            };


                        }






                    }
                    return almacen;


                }
                catch (Exception ex)
                {
                    return almacen;
                }





            }


        }
        public static bool Eliminar(int codigo)
        {

            using (SqlConnection cn = new SqlConnection(Conexion.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_eliminarAlmacen", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(" @codigo", codigo);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;




                }
                catch (Exception ex)
                {
                    return false;
                }



            }






        }
    }
}





