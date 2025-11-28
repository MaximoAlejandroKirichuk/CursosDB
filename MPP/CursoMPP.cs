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
        CursoDAL cursoDAL = new CursoDAL();
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
            throw new NotImplementedException();
        }

        public bool Modificar(Curso obj)
        {
            throw new NotImplementedException();
        }
        public Curso BuscarPorId()
        {
            throw new NotImplementedException();
        }
        public List<Curso> ListarTodos()
        {
            var tabla = cursoDAL.ObtenerTodos();
            List<Curso> cursos = new List<Curso>();
            foreach (DataRow dr in tabla.Rows)
            {
                Curso nuevoCurso = new Curso();
                nuevoCurso.Descripcion = dr["Descripcion"].ToString();
                nuevoCurso.Id = Convert.ToInt32(dr["IdCurso"]);
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
