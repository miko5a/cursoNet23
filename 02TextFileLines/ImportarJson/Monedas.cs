using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportarJson
{
    public class Monedas
    {
            public string nombre { get; set; }
            public string codigo { get; set; }
            public double valorEnDolares { get; set; }

        public Monedas(string nombre, string codigo, double valorEnDolares)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.valorEnDolares = valorEnDolares;
        }
    }
}
