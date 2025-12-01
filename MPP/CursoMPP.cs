using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class CursoMPP : IABM<Curso>
    {
        private readonly CursoDAL cursoDAL = new CursoDAL();

        public bool Agregar(Curso obj)
        {
            var parametros = new List<SqlParameter>
        {
            new SqlParameter("@Nombre", obj.Nombre),
            new SqlParameter("@Descripcion", (object)obj.Descripcion ?? DBNull.Value),
            new SqlParameter("@FechaLanzamiento", obj.FechaLanzamiento),
            new SqlParameter("@Activo", obj.Activo),
            new SqlParameter("@Costo", obj.Costo),
            new SqlParameter("@Categoria", (object)obj.Categoria ?? DBNull.Value),
            new SqlParameter("@DuracionHoras", (object)obj.DuracionHoras ?? DBNull.Value)
        };

            return cursoDAL.Agregar(parametros);
        }

        public bool Borrar(int id)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter("@IdCurso", id)
            };

            return cursoDAL.Borrar(parametros);
        }

        public bool Modificar(Curso obj)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter("@IdCurso", obj.IdCurso),
                new SqlParameter("@Nombre", obj.Nombre),
                new SqlParameter("@Descripcion", obj.Descripcion),
                new SqlParameter("@FechaLanzamiento", obj.FechaLanzamiento),
                new SqlParameter("@Activo", obj.Activo),
                new SqlParameter("@Costo", obj.Costo),
                new SqlParameter("@Categoria", obj.Categoria),
                new SqlParameter("@DuracionHoras", obj.DuracionHoras)
            };

            return cursoDAL.Modificar(parametros);
        }

        public Curso BuscarPorId(int id)
        {
            DataTable dt = cursoDAL.BuscarPorId(id);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Curso
            {
                IdCurso = Convert.ToInt32(row["IdCurso"]),
                Nombre = row["Nombre"].ToString(),
                Descripcion = row["Descripcion"]?.ToString(),
                FechaLanzamiento = Convert.ToDateTime(row["FechaLanzamiento"]),
                Activo = Convert.ToBoolean(row["Activo"]),
                Costo = Convert.ToDecimal(row["Costo"]),
                Categoria = row["Categoria"]?.ToString(),
                DuracionHoras = Convert.ToInt32(row["DuracionHoras"])
                };

        }

        public List<Curso> ListarTodos()
        {
            var tabla = cursoDAL.ObtenerTodos();
            List<Curso> cursos = new List<Curso>();
            foreach (DataRow dr in tabla.Rows)
            {
                Curso nuevoCurso = new Curso();
                nuevoCurso.Descripcion = dr["Descripcion"].ToString();
                nuevoCurso.IdCurso = Convert.ToInt32(dr["IdCurso"]);
                nuevoCurso.Nombre = dr["Nombre"].ToString();
                nuevoCurso.FechaLanzamiento = Convert.ToDateTime(dr["FechaLanzamiento"]);
                nuevoCurso.Activo = Convert.ToBoolean(dr["Activo"]);
                nuevoCurso.Costo = Convert.ToDecimal(dr["Costo"]);
                nuevoCurso.Categoria = dr["Categoria"].ToString();
                nuevoCurso.DuracionHoras = Convert.ToInt32(dr["DuracionHoras"]);
                cursos.Add(nuevoCurso);
            }
            return cursos;
        }
    }
}
