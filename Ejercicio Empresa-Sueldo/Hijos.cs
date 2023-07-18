using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaSueldos
{
    internal class Hijos
    {

        public Hijos(string nombre, string apellido, DateTime fechaNacimiento, bool hijoVaColegio = true)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            HijoVaColegio = hijoVaColegio;
            Edad = CalcularEdadHijo();
        }

        public string Nombre { get; set;  }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set;  }
        public bool HijoVaColegio { get; set; }
        public int Edad { get; set; }

        public int CalcularEdadHijo()
        {
            DateTime fechaActual = DateTime.Now; // Fecha actual
            int edadHijo = fechaActual.Year - this.FechaNacimiento.Year; // Calcular la edad en años
            if (this.FechaNacimiento.AddYears(edadHijo) > fechaActual) // Verificar si la fecha de cumpleaños ya pasó en el año actual
            {
                edadHijo--; // Restar 1 a la edad si el cumpleaños no ha pasado
            }
            //Console.WriteLine("La edad de la persona es: " + edad); // Imprimir la edad
            return edadHijo;
        }
        public override string ToString()
        {
            return "\tNombre: " + Nombre + "\t\t- Apellido: " + Apellido + "\t\t- Edad: " + CalcularEdadHijo();
        }
    }
}
