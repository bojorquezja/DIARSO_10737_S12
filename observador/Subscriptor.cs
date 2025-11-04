using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observador {
    internal class Subscriptor {
        public string Nombre {  get; set; }

        public Subscriptor(string nombre) {
            Nombre = nombre;
        }

        public void Actualizar() {
            Console.WriteLine($"{Nombre} notificado");
        }
    }
}
