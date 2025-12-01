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
        private readonly DALSingleton dal = DALSingleton.ObtenerInstancia();

        public bool Agregar(List<SqlParameter> parametros)
        {
            string query = @"
            INSERT INTO Curso 
            (Nombre, Descripcion, FechaLanzamiento, Activo, Costo, Categoria, DuracionHoras)
            VALUES 
            (@Nombre, @Descripcion, @FechaLanzamiento, @Activo, @Costo, @Categoria, @DuracionHoras)
            ";

            return dal.EjecutarNonQuery(query, parametros);
        }
        public bool Borrar(List<SqlParameter> parametros)
        {
            string query = "DELETE FROM Curso WHERE IdCurso = @IdCurso";
            return dal.EjecutarNonQuery(query, parametros);
        }

        public bool Modificar(List<SqlParameter> parametros)
        {
            string query = @"
            UPDATE Curso SET
                Nombre = @Nombre,
                Descripcion = @Descripcion,
                FechaLanzamiento = @FechaLanzamiento,
                Activo = @Activo,
                Costo = @Costo,
                Categoria = @Categoria,
                DuracionHoras = @DuracionHoras
            WHERE IdCurso = @IdCurso
            ";
            return dal.EjecutarNonQuery(query, parametros);
        }
        public DataTable ObtenerTodos()
        {
            string query = "SELECT * FROM Curso";
            return dal.EjecutarQuery(query);
        }
        public DataTable BuscarPorId(int id)
        {
            string query = "SELECT * FROM Curso WHERE IdCurso = @IdCurso";
            var parametros = new List<SqlParameter>
            {
                new SqlParameter("@IdCurso", id)
            };
            return dal.EjecutarQuery(query, parametros);
        }
    }

}
