using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy {
    internal class Proxy {
        public static double TipoCambio() {
            double cambio = Sunat.TipoCambio();
            Console.WriteLine($"guardado {cambio} en BD");
            return cambio;
        }
    }
}
