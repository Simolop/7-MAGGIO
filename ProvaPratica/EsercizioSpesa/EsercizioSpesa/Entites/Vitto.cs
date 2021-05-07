using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSpesa.Entites
{
    public class Vitto : ICategoria
    {
        public string TipoCategoria()
        {
            return "Categoria di tipo Vitto: 70% dell'importo";
        }
    }
}
