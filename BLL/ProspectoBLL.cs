using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProspectoBLL : IABM<Prospecto>
    {
        ProspectoMPP prospectoMPP = new ProspectoMPP();
        public bool Agregar(Prospecto obj)
        {
            return prospectoMPP.Agregar(obj);
        }

        public bool Borrar(int id)
        {
            return prospectoMPP.Borrar(id);
        }

        public bool Modificar(Prospecto obj)
        {
            return prospectoMPP.Modificar(obj);
        }

        public List<Prospecto> ListarProspectosPorCurso(int idCurso)
        {
            return prospectoMPP.ListarPorCurso(idCurso);
        }

        
    }
}
