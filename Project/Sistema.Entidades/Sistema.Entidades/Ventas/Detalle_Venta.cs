namespace Sistema.Entidades.Ventas
{
    public class Detalle_Venta
    {
        public int idDetalle { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double descuento { get; set; }
        public int idArticulo { get; set; }
        public int idVenta { get; set; }
    }
}
