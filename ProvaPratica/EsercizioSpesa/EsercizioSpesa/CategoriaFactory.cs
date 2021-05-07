using EsercizioSpesa.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSpesa
{
    public class CategoriaFactory
    {
        public static ICategoria FactoryCategoria(string param)
        {
            ICategoria categoria = null;

            if (param.Equals("Viaggio"))
            {
                categoria = new Viaggio();
            }
            else if (param.Equals("Alloggio"))
            {
                categoria = new Alloggio();
            }
            else if (param.Equals("Vitto"))
            {
                categoria = new Vitto();
            }
            else if (param.Equals("Altro"))
            {
                categoria = new Altro();
            }
            else
            {
                return categoria;
            }

            return categoria;
        }

    }
}
