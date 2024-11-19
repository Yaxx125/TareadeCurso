using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    public abstract class Movimientos
    {
        public string Tipo {  get; set; }
        public double Monto { get; set; }
        public string Concepto { get; set; }
        public DateTime Fecha { get; set; }

        public Movimientos (string tipo, double monto, string concepto, DateTime fecha)
        {
            Tipo = tipo;
            Monto = monto;
            Concepto = concepto;
            Fecha = fecha;
        }
    }

    public class Ingreso : Movimientos 
    {
         public Ingreso (double monto, string concepto, DateTime fecha, string tipo = "Ingreso") : base (tipo, monto, concepto, fecha) {}
    }

    public class Egreso : Movimientos
    {
        public Egreso (double monto, string concepto, DateTime fecha, string tipo = "Egreso"): base (tipo, monto, concepto, fecha) {}
    }

}
