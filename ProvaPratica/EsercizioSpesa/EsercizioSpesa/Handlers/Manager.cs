using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSpesa.Handlers
{
    class Manager : AbstractHandler
    {
        public override string Handle(double request)
        {
            if (request <= 400)
            {
                return "Livello di approvazione spesa: Manager (spesa fino a 400 euro)";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
