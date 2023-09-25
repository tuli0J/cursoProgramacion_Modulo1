using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        public string Codigo { get; set; }
        public DateTime FechaApertura { get; set; }
        public decimal Saldo { get; set; }
        public Cliente ClienteCuenta { get; set; }
        public string Estado { get; set; }

        public Cuenta()
        {
        }

        public Cuenta(string codigo, DateTime fechaApertura, decimal saldo, Cliente clienteCuenta, string estado)
        {
            Codigo = codigo;
            FechaApertura = fechaApertura;
            Saldo = saldo;
            ClienteCuenta = clienteCuenta;
            Estado = estado;
        }

        public void Depositar (decimal monto)
        {
            Saldo = Saldo + monto;
        }

        public bool Retirar(decimal monto)
        {
            bool puedeRetirar = false;

            if (Saldo == 0 || Saldo < monto)
            {
                puedeRetirar = false;
            }
            else
            {
                puedeRetirar = true;
                Saldo = Saldo - monto;
            }
            return puedeRetirar;
        }
    }
}
