namespace Proyecto_Final_Lab_I.Clases
{
    internal class DetalleFactura
    {
        public decimal Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnitario;
        public string PrecioUnitarioStr => PrecioUnitario.ToString("C");
        public string SubtotalStr => Subtotal.ToString("C");
    }
}