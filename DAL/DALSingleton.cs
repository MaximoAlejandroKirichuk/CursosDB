using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSingleton
    {
        public static DALSingleton Instancia { get; private set; }
        const string stringConnection = "Data Source=.;Initial Catalog=CursosDB;Integrated Security=True;";
        private DALSingleton()
        {
           
        }

        public static DALSingleton ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new DALSingleton();
                
            }
            return Instancia;
        }


        public bool Insertar(List<SqlParameter> parametros,string query)
        {
            using(SqlConnection conn = new SqlConnection(stringConnection))
            {
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    {
                        if (parametros != null)
                            cmd.Parameters.AddRange(parametros.ToArray());

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
        }
        public bool Eliminar(List<SqlParameter> parameters, string query)
        {
            using(SqlConnection conn = new SqlConnection(stringConnection))
            {
                using(SqlCommand cmd = new SqlCommand(query,conn))
                {
                    if(parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable ObtenerTodos(string query)
        {
            DataTable tabla = new DataTable();
            using(SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }
        
    }
}
