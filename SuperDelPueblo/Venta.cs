namespace SuperDelPueblo;

public class Venta
{
    public int Id { get; set;}
    public DateTime Fecha { get; set; }
    public Vendedor Vendedor { get; set; }
    public Sucursal Sucursal { get; set; }
    public Cliente Cliente { get; set; }
    public decimal SubTotal { get; set; }
    public decimal Iva { get; set; }
    public decimal Total { get; set; }

    public void CalcularTotal() {}

    public decimal RegistrarCobro(decimal pago)
    {
        throw new NotImplementedException();
    }
}
