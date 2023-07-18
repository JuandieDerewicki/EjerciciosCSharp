using EmpresaSueldos;

Empresa empresa = new Empresa();

Empleados empleado1 = new Empleados("Juan Diego", "Derewicki", new DateTime(2002, 10, 1), 3, true);
Empleados empleado2 = new Empleados("Maximiliano", "Ruiz Diaz", new DateTime(2002, 1, 24), 10, false);
Empleados empleado3 = new Empleados("Matias", "Guagni", new DateTime(1990, 8, 12), 1, false);
Empleados empleado4 = new Empleados("Joaquin", "Escalada", new DateTime(1997, 6, 5), 7, true);
Empleados empleado5 = new Empleados("Ivan", "Sevilla", new DateTime(2004, 12, 30), 2, true);
Empleados empleado6 = new Empleados("Franco", "Rojas", new DateTime(2000, 4, 6), 5, false);

empresa.agregarEmpleados(empleado1);
empresa.agregarEmpleados(empleado2);
empresa.agregarEmpleados(empleado3);
empresa.agregarEmpleados(empleado4);
empresa.agregarEmpleados(empleado5);
empresa.agregarEmpleados(empleado6);

Hijos h1 = new Hijos("Felipe", "Sevilla", new DateTime(2015, 10, 28), true);
Hijos h2 = new Hijos("Omar", "Escalada", new DateTime(2016, 3, 13), true);
Hijos h3 = new Hijos("Enrique", "Escalada", new DateTime(2014, 1, 10), true);
Hijos h4 = new Hijos("Lionel", "Derewicki", new DateTime(2018, 5, 29), true);
Hijos h5 = new Hijos("Benjamin", "Derewicki", new DateTime(2019, 5, 5), true);
Hijos h6 = new Hijos("Sofia", "Derewicki", new DateTime(2020, 11, 19), true);

empleado1.tieneHijos(h4);
empleado1.tieneHijos(h5);
empleado1.tieneHijos(h6);
empleado4.tieneHijos(h2);
empleado4.tieneHijos(h3);
empleado5.tieneHijos(h1);

empleado1.CalcularSueldoPorAsignacion(); // Hacer metodo y cambiar en el metodo 
empleado4.CalcularSueldoPorAsignacion();
empleado5.CalcularSueldoPorAsignacion();

empleado1.imprimirHijos(empleado1);
empleado4.imprimirHijos(empleado4); 
empleado5.imprimirHijos(empleado5);

empresa.mostrarEmpleados();

double totalSueldos = empresa.CalcularTotalSueldos();
Console.WriteLine("El total de sueldos es: " + totalSueldos);