using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioModa2
{
    internal class Moda
    {
        public string FuncionModa(int[] matrizDatos)
        {
            int maxNumero = matrizDatos[0];
            int maxVeces = 0;

            for (int i = 0; i < matrizDatos.Length; i++) // Recorro cada numero de la matriz
            {
                int numVeces = 0; // Inicializo en 0 para que se actualice el conteo de cada numero
                for (int j = 0; j < matrizDatos.Length; j++) // Recorro para saber cuantas veces se repite el numero
                {
                    if (matrizDatos[i] == matrizDatos[j])
                    {
                        numVeces++;
                    }
                    if (numVeces > maxVeces)
                    {
                        maxNumero = matrizDatos[i];
                        maxVeces = numVeces;
                    }
                }
            }
            return "La moda en el conjunto de datos es " + maxNumero + " y se repite " + maxVeces + " veces";
        }

        public string FuncionValorMinMax(int[] matrizDatos)
        {
            int numMaximo = matrizDatos[0];
            int numMinimo = matrizDatos[0];
            foreach (int i in matrizDatos)
            {
                if (i > numMaximo)
                {
                    numMaximo = i;
                }
                if (i < numMinimo)
                {
                    numMinimo = i;  
                }
            }
            return "El valor máximo en el conjunto de datos es " + numMaximo + " y el valor mínimo es " + numMinimo;
        }
    }
}
