public class Caja
{
    private List<Movimientos> movimientos;
    public double Saldo { get; set; }

    public Caja(double saldo)
    {
        movimientos = new List<Movimientos>();
        Saldo = 0.0;
    }

    public void RegistrarMovimiento(Movimientos movimiento)
    {
        movimientos.Add(movimiento);
        Saldo = movimiento.ActualizarSaldo(Saldo);
    }

    public IEnumerable<Movimientos> ObtenerMovimientos()
    {
        return movimientos;
    }

    public void RevertirMovimiento(Movimientos movimiento)
    {
        // Lógica para revertir el movimiento, por ejemplo:
        if (movimiento.Tipo == TipoMovimiento.Ingreso)
        {
            Saldo -= movimiento.Monto;
        }
        else if (movimiento.Tipo == TipoMovimiento.Egreso)
        {
            Saldo += movimiento.Monto;
        }

        // Eliminar el movimiento de la lista de movimientos (si corresponde)
        movimientos.Remove(movimiento);
    }

}
