using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaSueldos
{
    internal class Empresa
    {
        private Empleados[] empleadosEmpresa = new Empleados[100];

        private double totalSueldos;

        public void agregarEmpleados(Empleados empleado)
        {
            for (int i = 1; i < empleadosEmpresa.Length; i++)
            {
                if (empleadosEmpresa[i] == null)
                {
                    empleadosEmpresa[i] = empleado;
                    break;
                }
            }
        }

        public void mostrarEmpleados()
        {
            Console.WriteLine("\nEmpleados: \n");
            for (int i = 1; i < empleadosEmpresa.Length;i++)
            {
                if (empleadosEmpresa[i] != null)
                {
                    Console.WriteLine($"{i} - {empleadosEmpresa[i]}");
                }
            }
        }

        public double CalcularTotalSueldos()
        {
            for (int i = 1; i < empleadosEmpresa.Length; i++)
            {
                if (empleadosEmpresa[i] != null)
                {
                    totalSueldos += empleadosEmpresa[i].SueldoBasico;
                }
            }
            return totalSueldos;
        }


    }
}
