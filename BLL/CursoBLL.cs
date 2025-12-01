using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLL
{
    public class CursoBLL : IABM<Curso>, ISujeto
    {
        private CursoMPP mPP = new CursoMPP();
        private List<IObservador> observadores = new List<IObservador>();
        public bool Agregar(Curso obj)
        {
            //alguna logica extra
            return mPP.Agregar(obj);

        }

        public bool Borrar(int id)
        {
            //existe?
            return mPP.Borrar(id);
        }

        public bool Modificar(Curso obj)
        {
            return mPP.Modificar(obj);
        }

        public Curso BuscarPorId()
        {
            throw new NotImplementedException();
        }
        public List<Curso> ListarTodos()
        {
            return mPP.ListarTodos();
        }
        //METODOS OBSERVER
        public void AgregarSuscriptor(IObservador obs)
        {
            observadores.Add(obs);
        }

        public void EliminarSucriptor(IObservador obs)
        {
            observadores.Remove(obs);
        }

        public void NotificarTodos()
        {
            foreach (var o in observadores)
            {
                o.Actualizar();
            }
        }
        public void ExportarCurso(Curso curso, string ruta)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Curso));
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                serializer.Serialize(sw, curso);
            }

        }

        public bool ImportarCurso(string ruta)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Curso));

            using (StreamReader sr = new StreamReader(ruta))
            {
                Curso cursoImportado = (Curso)serializer.Deserialize(sr);

                // Lo inserto en la DB
                bool resultado = Agregar(cursoImportado);

                if (resultado)
                    NotificarTodos(); // Solo si salió bien

                return resultado;
            }
        }

    }
}
