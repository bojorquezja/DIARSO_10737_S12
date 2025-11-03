using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adaptador {
    internal class Biblioteca {
        public static void RecibeJSON(string mensaje) {
            if (mensaje == "es JSON") {
                Console.WriteLine("OK");
            } else {
                Console.WriteLine("ERROR");
            }
        }
    }
}
