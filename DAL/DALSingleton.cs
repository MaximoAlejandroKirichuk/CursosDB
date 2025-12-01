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
        const string stringConnection = "Data Source=MK;Initial Catalog=CursosDB;Integrated Security=True;";
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


        // Método único para Insertar / Modificar / Eliminar
        public bool EjecutarNonQuery(string query, List<SqlParameter> parametros = null, bool esStoredProcedure = false)
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (esStoredProcedure)
                    cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                    cmd.Parameters.AddRange(parametros.ToArray());

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Método único para SELECT
        public DataTable EjecutarQuery(string query, List<SqlParameter> parametros = null, bool esStoredProcedure = false)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new SqlConnection(stringConnection))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (esStoredProcedure)
                    cmd.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                    cmd.Parameters.AddRange(parametros.ToArray());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

    }

}

