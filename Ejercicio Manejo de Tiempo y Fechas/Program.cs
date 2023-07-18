using ManejoTiempoYFechas;

Class1 c1 = new Class1();

bool fechaValida = false; 
bool fechaValida2 = false;
bool fechaValida3 = false;
int opcion;
int diasSumados;
bool opcionCond = false;
DateTime fecha1 = new DateTime();
DateTime fecha2 = new DateTime();



Console.WriteLine("Indique que desea hacer:\n1-Obtener dias entre dos fechas\n2-Obtener dias laborales entre dos fechas\n3-Sumar dias laborales");
opcion = int.Parse(Console.ReadLine());
while (opcionCond == false)
{
    if (opcion == 1)
    {
        Console.WriteLine("---Ingrese dos fechas para obtener los dias entre ellos---");

        while (fechaValida == false)
        {
            Console.WriteLine("Ingresa la primer fecha en el formato dd/MM/yyyy:");
            if (DateTime.TryParse(Console.ReadLine(), out fecha1))
            {
                fechaValida = true;
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida. Por favor intente nuevamente.\n");
            }
        }

        while (fechaValida2 == false)
        {
            Console.WriteLine("Ingresa la segunda fecha en el formato dd/MM/yyyy:");
            if (DateTime.TryParse(Console.ReadLine(), out fecha2))
            {
                fechaValida2 = true;
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida. Por favor intente nuevamente.\n");
            }
        }
        c1.ObtenerDiasCalendario(fecha1, fecha2);
        opcionCond = true;
    }
    else if (opcion == 2)
    {
        Console.WriteLine("---Ingrese dos fechas para obtener los dias entre ellos---");

        while (fechaValida == false)
        {
            Console.WriteLine("Ingresa la primer fecha en el formato dd/MM/yyyy:");
            if (DateTime.TryParse(Console.ReadLine(), out fecha1))
            {
                fechaValida = true;
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida. Por favor intente nuevamente.\n");
            }
        }

        while (fechaValida2 == false)
        {
            Console.WriteLine("Ingresa la segunda fecha en el formato dd/MM/yyyy:");
            if (DateTime.TryParse(Console.ReadLine(), out fecha2))
            {
                fechaValida2 = true;
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida. Por favor intente nuevamente.\n");
            }
        }
        c1.ObtenerDiasLaborales(fecha1, fecha2);
        opcionCond = true;
    }
    else if (opcion == 3)
    {
        while (fechaValida3 == false)
        {
            Console.WriteLine("Ingresa la primer fecha en el formato dd/MM/yyyy:");
            if (DateTime.TryParse(Console.ReadLine(), out fecha1))
            {
                fechaValida3 = true;
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida. Por favor intente nuevamente.\n");
            }
        }
        Console.WriteLine("Indique cuantos dias le desea sumar");
        diasSumados = int.Parse(Console.ReadLine());

        c1.SumarDiasLaborales(fecha1, diasSumados);
        opcionCond = true;    
    }
    else
    {
        Console.WriteLine("ERROR. Ingrese una opcion valida:");
        opcion = int.Parse(Console.ReadLine());
    }
}



/*
DateTime fecha1 = new DateTime(2023, 04, 23);
DateTime fecha2 = new DateTime(2023, 04, 20);

c1.ObtenerDiasCalendario(fecha1, fecha2);
*/

/*
 Console.WriteLine("Por favor ingrese una fecha en el formato dd/MM/yyyy:");
DateTime fecha;
if (DateTime.TryParse(Console.ReadLine(), out fecha))
{
    Console.WriteLine("La fecha ingresada es: " + fecha.ToShortDateString());
}
else
{
    Console.WriteLine("La fecha ingresada no es válida.");
}
 */
