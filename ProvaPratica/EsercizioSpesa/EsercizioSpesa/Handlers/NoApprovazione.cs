using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSpesa.Handlers
{
    public class NoApprovazione : AbstractHandler
    {
        public override string Handle(double request)
        {
            if (request > 2500)
            {
                return "La tua spesa non è stata approvata perchè supera i 2500 euro";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
