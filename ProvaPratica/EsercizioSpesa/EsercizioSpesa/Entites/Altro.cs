using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSpesa.Entites
{
    public class Altro : ICategoria
    {
        public string TipoCategoria()
        {
            return "Altro tipo di categoria: 10% dell'importo";
        }
    }
}
