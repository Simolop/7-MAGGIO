using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSpesa.Handlers
{
    public interface IHandler
    {
        //per settare il successivo
        IHandler SetNext(IHandler handler);

        string Handle(double request);
    }
}
