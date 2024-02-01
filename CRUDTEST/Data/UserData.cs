using CRUDTEST.Models;
using System.Data.SqlClient;
using System.Data;
namespace CRUDTEST.Data
{
    public class UserData
    {
        public List<UsuarioModel> Listar()
        {
            var oLista = new List<UsuarioModel>();
            var con = new Conexion();
            using (var conexion = new SqlConnection(con.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar_usuarios", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using(var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new UsuarioModel()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            userName = dr["userName"].ToString(),
                            clave = dr["clave"].ToString()
                        });
                    }
                }
            }
            return oLista;
        }
    }
}
