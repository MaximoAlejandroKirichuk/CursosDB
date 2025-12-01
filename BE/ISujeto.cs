using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ISujeto
    {
        void AgregarSuscriptor(IObservador obs);
        void EliminarSucriptor(IObservador obs);
        void NotificarTodos();
    }
}
