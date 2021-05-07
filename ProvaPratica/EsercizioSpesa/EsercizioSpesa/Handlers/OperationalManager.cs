using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSpesa.Handlers
{
    class OperationalManager : AbstractHandler
    {
        public override string Handle(double request)
        {
            if (request > 400  && request <= 1000)
            {
                return "Livello di approvazione spesa: Operational Manager (spesa da 401 euro a 1000 euro)";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
