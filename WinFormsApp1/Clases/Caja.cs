        public class Caja
    {
        public double Saldo { get; set; }
        //Lista donde se regitraran los movimientos
        private List<Movimientos> movimientos;

        public Caja (double saldo)
        {
            Saldo = saldo;
            movimientos = new List<Movimientos> ();
        }

        //Metodo para modificar saldo durante movimientos

        public void RegistrarMovimientos (Movimientos movimiento)
        {
            //Añadir movimiento a la lista
            movimientos.Add (movimiento);

        if (movimiento.Tipo == TipoMovimiento.Ingreso)
        {
            Saldo += movimiento.Monto;
        }
        else if (movimiento.Tipo == TipoMovimiento.Egreso)
        {
            Saldo -= movimiento.Monto;
        }
        }

        //Obtener la lista de movimientos
        public List<Movimientos> ObtenerMovimientos()
        {
        return movimientos;
        }
    }
