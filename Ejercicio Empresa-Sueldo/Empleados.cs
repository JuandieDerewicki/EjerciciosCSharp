using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaSueldos
{
    internal class Empleados
    {

        private double sueldoBasico = 120000;
        private Hijos[] listaHijos = new Hijos[100];
        private int contHijos = 0;
        private int contHijosMenores = 0;

        public Empleados(string nombre, string apellido, DateTime fechaNacimiento, int añosAntiguedad, bool hijos = true)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            AñosAntiguedad = añosAntiguedad;
            Hijos = hijos;
            SueldoBasico = sueldoBasico;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set;  }
        public DateTime FechaNacimiento { get; set; }
        public int AñosAntiguedad { get; set;  }
        public double SueldoBasico { get; set; }
        public bool Hijos { get; set;  }

        public int CalcularEdadEmpleado()
        {
            DateTime fechaActual = DateTime.Now; 
            int edadEmpleado = fechaActual.Year - this.FechaNacimiento.Year; 
            if (this.FechaNacimiento.AddYears(edadEmpleado) > fechaActual) 
            {
                edadEmpleado--; 
            }
            return edadEmpleado;
        }

        public void tieneHijos(Hijos hijosHijas)
        {
            this.Hijos = true;

            for (int i = 1; i < listaHijos.Length; i++)
            {
                if (listaHijos[i] == null)
                {
                    listaHijos[i] = hijosHijas;
                    contHijos++;
                    if (hijosHijas.Edad < 21 && hijosHijas.HijoVaColegio == true)
                    {
                        contHijosMenores++;
                    }
                    break;
                }
            }
        }

        public void imprimirHijos(Empleados empleado)
        {
            Console.WriteLine($"\nHijos de {empleado.Nombre} {empleado.Apellido}");
            Console.WriteLine($"Tiene {contHijos} hijos y cobra asignación por {contHijosMenores} hijos menores ");
            for (int i = 1; i < listaHijos.Length; i++)
            {
                if (listaHijos[i] != null)
                {
                    Console.WriteLine($"{i} - {listaHijos[i]}");
                }
            }
        }

        public void CalcularSueldoPorAsignacion()
        {
            if (contHijosMenores > 0)
            {
                sueldoBasico += sueldoBasico * contHijosMenores * 10 / 100;
            }
        }

        public override string ToString()
        {
            return "\tNombre: " + Nombre + "\t\t- Apellido: " + Apellido + "\t\t- Edad: " + CalcularEdadEmpleado() + "\t\t- Años de antiguedad: " + AñosAntiguedad + "\t\t- Sueldo: " + sueldoBasico +"\n";
        }
    }
}
