using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalPruebas.Clases
{
    public class Ficha
    {
        public Button Button { get; set; }
        public Jugador Jugador { get; set; }
        public int Posicion { get; set; }
        public int Restantes { get; set; }

        public Ficha(Button button, int posicion, int restantes) { 
            this.Button = button;
            this.Posicion = posicion;
            this.Restantes = restantes;
        }
    }
}
