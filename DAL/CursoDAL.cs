using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace DAL
{
    public class CursoDAL 
    {
        private DALSingleton dalSingleton = DALSingleton.ObtenerInstancia();
        public bool Agregar(List<SqlParameter> parametros)
        {
            string query = @"
                    INSERT INTO Curso 
                    (Nombre, Descripcion, FechaLanzamiento, Activo, Costo, Categoria, DuracionHoras)
                    VALUES 
                    (@Nombre, @Descripcion, @FechaLanzamiento, @Activo, @Costo, @Categoria, @DuracionHoras)
                ";
            return DALSingleton.Instancia.Insertar(parametros, query);
        }

        public bool Borrar(List<SqlParameter> parametros)
        {
            string query = @"
                DELETE from Curso * where (IdCurso = @IdCurso)
            ";
            return DALSingleton.Instancia.Eliminar(parametros,query);
        }

        public bool Modificar(List<SqlParameter> parametros)
        {
            throw new NotImplementedException();
        }

        public DataTable ObtenerTodos()
        {
            string query = "SELECT * from Curso";
            return DALSingleton.Instancia.ObtenerTodos(query);
        }
    }
}
