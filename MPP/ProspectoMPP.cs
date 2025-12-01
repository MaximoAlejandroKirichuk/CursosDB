using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MPP
{
    public class ProspectoMPP : IABM<Prospecto>
    {
        ProspectoDAL prospectoDAL = new ProspectoDAL();

        public bool Agregar(Prospecto obj)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Nombre", obj.Nombre),
                new SqlParameter("@Edad", obj.Edad),
                new SqlParameter("@Email", obj.Email),
                new SqlParameter("@Telefono", obj.Telefono),
                new SqlParameter("@Interes", obj.Interes),
                new SqlParameter("@FechaRegistro", obj.FechaRegistro),
                new SqlParameter("@Contactado", obj.Contactado),
                new SqlParameter("@Observaciones", obj.Observaciones),
                new SqlParameter("@IdCurso", obj.IdCurso)
            };

            return prospectoDAL.Agregar(parameters);
        }

      
        public bool Borrar(int id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@IdProspecto", id)
            };

            return prospectoDAL.Borrar(parameters);
        }

        public bool Modificar(Prospecto obj)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@IdProspecto", obj.IdProspecto),
                new SqlParameter("@Nombre", obj.Nombre),
                new SqlParameter("@Edad", obj.Edad),
                new SqlParameter("@Email", obj.Email),
                new SqlParameter("@Telefono", obj.Telefono),
                new SqlParameter("@Interes", obj.Interes),
                new SqlParameter("@FechaRegistro", obj.FechaRegistro),
                new SqlParameter("@Contactado", obj.Contactado),
                new SqlParameter("@Observaciones", obj.Observaciones),
                new SqlParameter("@IdCurso", obj.IdCurso)
            };

            return prospectoDAL.Modificar(parameters);
        }

        public List<Prospecto> ListarPorCurso(int idCurso)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@IdCurso", idCurso)
            };

            DataTable tabla = prospectoDAL.TraerProspectos(parameters);

            List<Prospecto> lista = new List<Prospecto>();

            foreach (DataRow dr in tabla.Rows)
            {
                lista.Add(new Prospecto
                {
                    IdProspecto = Convert.ToInt32(dr["IdProspecto"]),
                    Nombre = dr["Nombre"].ToString(),
                    Edad = Convert.ToInt32(dr["Edad"]),
                    Email = dr["Email"].ToString(),
                    Telefono = dr["Telefono"].ToString(),
                    Interes = dr["Interes"].ToString(),
                    FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                    Contactado = Convert.ToBoolean(dr["Contactado"]),
                    Observaciones = dr["Observaciones"].ToString(),
                    IdCurso = Convert.ToInt32(dr["IdCurso"])
                });
            }

            return lista;
        }
    }
}
