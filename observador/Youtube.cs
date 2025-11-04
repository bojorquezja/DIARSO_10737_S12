using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observador {
    internal class Youtube {
        public Subscriptor[] Subscriptores { get; set; } = new Subscriptor[0];


        public void AgregaSub(Subscriptor sub) {
            Subscriptor[] s2 = new Subscriptor[Subscriptores.Length + 1];

            // Copy elements from the original array
            for (int i = 0; i < Subscriptores.Length; i++) {
                s2[i] = Subscriptores[i];
            }
            s2[s2.Length - 1] = sub;
            Subscriptores = s2;
            
        }
        public void Publicar() {
            foreach (var sub in Subscriptores) {
                sub.Actualizar();
            }
        }
    }
}
