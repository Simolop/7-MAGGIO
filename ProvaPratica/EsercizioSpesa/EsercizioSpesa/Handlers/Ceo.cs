using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSpesa.Handlers
{
    class Ceo : AbstractHandler
    {
        public override string Handle(double request)
        {
            if (request > 1000 && request < 2500)
            {
                return "Livello di approvazione spesa: CEO (spesa sopra i 1000 euro)";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
