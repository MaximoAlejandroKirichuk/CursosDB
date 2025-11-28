using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CursoBLL : IABM<Curso>
    {
        CursoMPP mPP = new CursoMPP();
        public bool Agregar(Curso obj)
        {
            //alguna logica extra
            return mPP.Agregar(obj);

        }

        public bool Borrar(int id)
        {
            //existe?
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
            return mPP.ListarTodos();
        }
    }
}
