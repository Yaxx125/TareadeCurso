using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    public class Caja
    {
        public double Saldo { get; set; }

        public Caja (double saldo)
        {
            Saldo = saldo;
        }

        //Metodo para modificar saldo durante movimientos

        public void RegistrarMovimientos (Movimientos movimiento)
        {
            if (movimiento.Tipo == "Ingreso")
            {
                Saldo += movimiento.Monto;
            } else if (movimiento.Tipo == "Egreso")
            {
                Saldo -= movimiento.Monto;
            }
        }

    }
}
