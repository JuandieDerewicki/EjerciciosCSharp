using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioApuestasCompleto
{
    internal class Dados
    {
        public double AdivinarNroDado()
        {
            Random numeroDado = new Random();
            return numeroDado.Next(2, 12);
        }
    }
}
