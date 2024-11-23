public enum TipoMovimiento
{
    Ingreso,
    Egreso
}

public class Movimientos
{
    public TipoMovimiento Tipo { get; set; }
    public double Monto { get; set; }
    public string Concepto { get; set; }
    public DateTime Fecha { get; set; }



    public Movimientos(TipoMovimiento tipo, double monto, string concepto, DateTime fecha)
    {
        Tipo = tipo;
        Monto = monto;
        Concepto = concepto;
        Fecha = fecha;
    }

}

