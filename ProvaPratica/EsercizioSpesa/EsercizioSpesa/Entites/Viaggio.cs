using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSpesa.Entites
{
    public class Viaggio : ICategoria
    {
        public string TipoCategoria()
        {
            return "Categoria di tipo Viaggio: 100% dell'importo + 50€ fisse";
        }
    }
}
