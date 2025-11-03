using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy {
    internal class Cliente {
        public static void ConversionDolar() {

            Console.WriteLine(Proxy.TipoCambio());
        }
    }
}
