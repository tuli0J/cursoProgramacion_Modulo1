using Entidades;

namespace Entidades
{
    public class Movimiento
    {
        public Cuenta CuentaMovimiento { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public TipoMovimiento Tipo { get; set; }

        public Movimiento()
        {
        }

        public Movimiento(Cuenta cuentaMovimiento, DateTime fecha, decimal monto, TipoMovimiento tipo)
        {
            CuentaMovimiento = cuentaMovimiento;
            Fecha = fecha;
            Monto = monto;
            Tipo = tipo;
        }
    }
}
