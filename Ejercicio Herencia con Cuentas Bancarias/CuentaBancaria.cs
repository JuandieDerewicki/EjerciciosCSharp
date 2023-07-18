using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaCuentasBancarias
{
    internal class CuentaBancaria
    {
        private double saldo;
        private int numeroCuenta;
        private string titularCuenta;

        public CuentaBancaria(string titularCuenta, int numeroCuenta)
        {
            this.TitularCuenta = titularCuenta;
            this.NumeroCuenta = numeroCuenta;
            Saldo = 0;
        }
        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public string TitularCuenta { get => titularCuenta; set => titularCuenta = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public virtual void depositarDinero(double dineroDepositado)
        {
            Saldo += dineroDepositado;
            Console.WriteLine($"Has depositado {dineroDepositado} dinero. Tu saldo actual es {Saldo}");
        }

        public virtual void extraerDinero(double dineroExtraido)
        {
            if (dineroExtraido < Saldo)
            {
                Saldo -= dineroExtraido;
            }
            else
            {
                Console.WriteLine("No posee suficente dinero");
            }
        }

        public override string ToString()
        {
            return "Titular de la cuenta: " + TitularCuenta + " - Numero de cuenta: " + NumeroCuenta;
        }
    }
}
