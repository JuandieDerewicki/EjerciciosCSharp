using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaCuentasBancarias
{
    internal class CuentaCorriente : CuentaBancaria
    {
        private double topeDescubierto;
        private double saldoCC;
        public CuentaCorriente(string titularCuenta, int numeroCuenta, double saldoCC, double topeDescubierto) : base(titularCuenta, numeroCuenta/*, saldo*/)
        {
            this.SaldoCC = saldoCC; 
            this.TopeDescubierto = topeDescubierto;
        }

        public double TopeDescubierto { get => topeDescubierto; set => topeDescubierto = value; }
        public double SaldoCC { get => saldoCC; set => saldoCC = value; }

        public override void depositarDinero(double dineroDepositado)
        {
            SaldoCC += dineroDepositado;
            Console.WriteLine($"Has depositado {dineroDepositado} pesos. Tu saldo actual es ${SaldoCC} pesos");
        }
        public override void extraerDinero(double dineroExtraido)
        {
            double saldoExtraccion = SaldoCC - dineroExtraido;    
            if (saldoExtraccion < topeDescubierto)
            {
                Console.WriteLine($"La operacion no se puede realizar porque pasó su tope descubierto. Su saldo actual es de ${SaldoCC} pesos");
            }
            else
            {
                SaldoCC -= dineroExtraido;
                Console.WriteLine($"Has extraido {dineroExtraido} pesos. Tu saldo actual es de ${SaldoCC} pesos");
            }
        }

        public override string ToString()
        {
            return "Cuenta Corriente --- " + "Titular de la cuenta: " + TitularCuenta + " - Numero de cuenta: " + NumeroCuenta + " - Saldo: " + SaldoCC;
        }
    }
}
