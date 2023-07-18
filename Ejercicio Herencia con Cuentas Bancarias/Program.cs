using EjercicioHerenciaCuentasBancarias;
using System;

CuentaBancaria miCuentaBancaria = new CuentaBancaria("Juan Diego Derewicki", 349223);
CuentaCorriente miCuentaCorriente = new CuentaCorriente(miCuentaBancaria.TitularCuenta, miCuentaBancaria.NumeroCuenta, 5000, -1000);
CajaAhorro miCajaAhorro = new CajaAhorro(miCuentaBancaria.TitularCuenta, miCuentaBancaria.NumeroCuenta, 3000);
Random nrorandom = new Random();

for (int i = 0; i < 100; i++)
{
    Console.WriteLine($"\n------- TRANSACCION {i} --------");
    var numeroOperacion = nrorandom.Next(1, 3);

    if (numeroOperacion == 1)
    {
        Console.WriteLine("\n***Cuenta Corriente***\n");
        var dinerodep = nrorandom.Next(10, 10000);
        var dineroext = nrorandom.Next(10, 10000);

        miCuentaCorriente.depositarDinero(dinerodep);
        miCuentaCorriente.extraerDinero(dineroext);
    }
    if (numeroOperacion == 2)
    {
        Console.WriteLine("\n***Caja de Ahorro***\n");
        var dinerodep = nrorandom.Next(10, 10000);
        var dineroext = nrorandom.Next(10, 10000);

        miCajaAhorro.depositarDinero(dinerodep);
        miCajaAhorro.extraerDinero(dineroext);
    }
}
Console.WriteLine("\n***********************************************************************************************************************");
Console.WriteLine("\t\t\t\t\tSALDO DE CUENTAS:");
Console.WriteLine(miCuentaCorriente.ToString());
Console.WriteLine(miCajaAhorro.ToString());





