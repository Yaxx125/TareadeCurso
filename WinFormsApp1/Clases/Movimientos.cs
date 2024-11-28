public enum TipoMovimiento
{
    Ingreso,
    Egreso
}

public abstract class Movimientos
{
    public TipoMovimiento Tipo { get; set; }
    public double Monto { get; set; }
    public string Concepto { get; set; }
    public string Fecha { get; set; }

    public Movimientos(double monto, string concepto, string fecha)
    {
        Monto = monto;
        Concepto = concepto;
        Fecha = fecha;
    }

    public abstract double ActualizarSaldo(double saldo);
}

public class Ingreso : Movimientos
{
    public Ingreso(double monto, string concepto, string fecha)
        : base(monto, concepto, fecha)
    {
        Tipo = TipoMovimiento.Ingreso;
    }

    public override double ActualizarSaldo(double saldo)
    {
        return saldo += Monto;
    }
}

public class Egreso : Movimientos
{
    public Egreso(double monto, string concepto, string fecha)
        : base(monto, concepto, fecha)
    {
        Tipo = TipoMovimiento.Egreso;
    }

    public override double ActualizarSaldo(double saldo)
    {
        return saldo -= Monto;
    }
}
