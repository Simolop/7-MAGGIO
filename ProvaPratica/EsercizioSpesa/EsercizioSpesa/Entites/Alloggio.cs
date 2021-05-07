using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSpesa.Entites
{
    public class Alloggio : ICategoria
    {
        public string TipoCategoria()
        {
            return "Categoria di tipo Alloggio: 100% dell'importo";
        }
    }
}
