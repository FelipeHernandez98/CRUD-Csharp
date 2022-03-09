using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PracticaCsharp.Logica;
using System.Windows.Forms;
using System.Data;

namespace PracticaCsharp.Datos
{
    class datoUsuario
    {
        private SqlCommand cmd = new SqlCommand();
        private int idusuario;
        public bool insertar( logicaUsuarios dt)
        {
            try
            {
                Conexion.abrir();
                cmd = new SqlCommand("insertar_usuario",  Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", dt.Usuario);
                cmd.Parameters.AddWithValue("@Contrasena", dt.Contraseña);
                cmd.Parameters.AddWithValue("@Icono", dt.Icono);
                cmd.Parameters.AddWithValue("@Estado", dt.Estado);
                if (cmd.ExecuteNonQuery()!=0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        public bool editar(logicaUsuarios dt)
        {
            try
            {
                Conexion.abrir();
                cmd = new SqlCommand("editar_usuarios", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_usuario", dt.Id_usuario);
                cmd.Parameters.AddWithValue("@Usuario", dt.Usuario);
                cmd.Parameters.AddWithValue("@Contrasena", dt.Contraseña);
                cmd.Parameters.AddWithValue("@Icono", dt.Icono);
                cmd.Parameters.AddWithValue("@Estado", dt.Estado);
                if(cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        public DataTable mostrar_usuarios()
        {
            try
            {
                Conexion.abrir();
                cmd = new SqlCommand("mostrar_usuarios", Conexion.conexion);

                if(cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Conexion.cerrar(); 
            }
        }

        public bool eliminar_usuarios(logicaUsuarios dt)
        {
            try
            {
                Conexion.abrir();
                cmd = new SqlCommand("eliminar_usuarios", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_usuario", dt.Id_usuario);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        public DataTable buscar_usuarios(string parametros)
        {
            try
            {
                Conexion.abrir();
                cmd = new SqlCommand("buscar_usuarios", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscador", parametros);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Conexion.cerrar();
            }
        }

    }
}
