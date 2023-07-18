using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaCuentasBancarias
{
    internal class CajaAhorro : CuentaBancaria 
    {
        private double saldoCA;
        public CajaAhorro(string titularCuenta, int numeroCuenta, double saldoCA) : base(titularCuenta, numeroCuenta)
        {
            this.SaldoCA = saldoCA;       
        }

        public double SaldoCA { get => saldoCA; set => saldoCA = value; }

        public override void depositarDinero(double dineroDepositado)
        {
            SaldoCA += dineroDepositado;
            Console.WriteLine($"Has depositado {dineroDepositado} pesos. Tu saldo actual es ${SaldoCA} pesos");
        }

        public override void extraerDinero(double dineroExtraido)
        {
            if (dineroExtraido < SaldoCA)
            {
                SaldoCA -= dineroExtraido;
                Console.WriteLine($"Tu saldo actual es ${SaldoCA} pesos");
            }
            else
            {
                Console.WriteLine("No posee suficente dinero");
            }
        }

        public override string ToString()
        {
            return "Caja de Ahorro --- " + "Titular de la cuenta: " + TitularCuenta + " - Numero de cuenta: " + NumeroCuenta + " - Saldo: " + SaldoCA;
        }
    }
}
