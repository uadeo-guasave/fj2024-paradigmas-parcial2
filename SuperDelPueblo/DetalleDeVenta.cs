namespace SuperDelPueblo;

public class DetalleDeVenta
{
    public int Id { get; set;}
    public Venta Venta { get; set; }
    public Producto Producto { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioDeVenta { get; set; }
    public decimal SubTotal { get; set; }
}
