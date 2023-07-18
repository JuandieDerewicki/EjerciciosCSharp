using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoTiempoYFechas
{
    internal class Class1
    {

        DateTime[] feriados = new DateTime[]
        {
            new DateTime(2023, 1, 1),  // Año Nuevo
            new DateTime(2023, 2, 20), // Carnaval
            new DateTime(2023, 2, 21), // Carnaval
            new DateTime(2023, 3, 24), // Dia de la memoria 
            new DateTime(2023, 4, 6), // Jueves Santo
            new DateTime(2023, 4, 7), // Viernes Santo
            new DateTime(2023, 5, 1),  // Día del Trabajo
            new DateTime(2023, 5, 25),  // 25 de mayo
            new DateTime(2023, 5, 26)  // Feriado puente
        };
        public void ObtenerDiasCalendario(DateTime fecha1, DateTime fecha2)
        {
            // Validar que fecha2 sea mayor que fecha1
            if (fecha2 < fecha1)
            {
                // Intercambiar las fechas
                DateTime temp = fecha1;
                fecha1 = fecha2;
                fecha2 = temp;
            }
            TimeSpan dias = fecha2 - fecha1;
            Console.WriteLine("Los dias entre esas dos fechas son " + dias.Days);
            //return dias.Days;
        }

        public void ObtenerDiasLaborales(DateTime fecha1, DateTime fecha2)
        {
            // Validar que fecha2 sea mayor que fecha1
            if (fecha2 < fecha1)
            {
                // Intercambiar las fechas
                DateTime temp = fecha1;
                fecha1 = fecha2;
                fecha2 = temp;
            }

            /*
            int diasLaborales = 0;
            DateTime fechaActual = fecha1;

            while (fechaActual <= fecha2)
            {
            if (fechaActual.DayOfWeek != DayOfWeek.Saturday && fechaActual.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(fechaActual))
            {
                diasLaborales++;
            }

            fechaActual = fechaActual.AddDays(1);
            }
            */

            int diasLaborales = 0;
            for (DateTime fecha = fecha1; fecha <= fecha2; fecha = fecha.AddDays(1))
            {
                if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(fecha))
                {
                    diasLaborales++;
                }
            }

            Console.WriteLine($"Los días laborales entre las fechas {fecha1.ToShortDateString()} y {fecha2.ToShortDateString()} son: {diasLaborales}");
        }

        public void SumarDiasLaborales(DateTime fecha1, int diasSumados)
        {
            Console.WriteLine("La nueva fecha es " + fecha1.AddDays(diasSumados).ToShortDateString());
        }


    }
}
