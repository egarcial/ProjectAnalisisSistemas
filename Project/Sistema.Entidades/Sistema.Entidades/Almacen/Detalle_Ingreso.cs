namespace Sistema.Entidades.Ventas
{
    public class Detalle_Ingreso
    {
        public int idDetalle { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public int ingreso { get; set; }
        public int idArticulo { get; set; }
        public int idIngreso { get; set; }
    }
}
