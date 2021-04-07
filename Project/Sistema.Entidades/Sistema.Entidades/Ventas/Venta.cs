namespace Sistema.Entidades.Ventas
{
   public class Venta
    {
        public int idVenta { get; set; }
        public string tipoComprobante { get; set; }
        public string serieComprobante { get; set; }
        public string numeroComprobante { get; set; }
        public string fechaHora { get; set; }
        public double impuesto { get; set; }
        public double total { get; set; }
        public string condicion { get; set; }
        public int idUsuario { get; set; }

    }
}
