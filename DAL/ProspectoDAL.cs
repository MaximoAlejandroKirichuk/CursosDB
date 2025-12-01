using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProspectoDAL
    {
        DALSingleton dal = DALSingleton.ObtenerInstancia();
        public bool Agregar(List<SqlParameter> parametros)
        {
            return dal.EjecutarNonQuery(
                "InsertarProspecto",
                parametros,
                true  // esStoredProcedure
            );
        }

        public DataTable TraerProspectos(List<SqlParameter> parametros)
        {
         

            return dal.EjecutarQuery(
                "TraerProspectosPorCurso",
                parametros,
                true
            );
        }

        public bool Borrar(List<SqlParameter> parametros)
        {
           
            return dal.EjecutarNonQuery(
                "EliminarProspecto",
                parametros,
                true
            );
        }

        public bool Modificar(List<SqlParameter> parametros)
        {
            return dal.EjecutarNonQuery(
                "ActualizarProspecto",
                parametros,
                true
            );
        }
    }
}
