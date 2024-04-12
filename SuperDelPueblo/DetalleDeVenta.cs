namespace SuperDelPueblo;

public class DetalleDeVenta
{
    public int Id { get; set;}
    public int VentaId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioDeVenta { get; set; }
    public decimal SubTotal { get; set; }
}
