namespace Proyecto_Final_Lab_I.Clases
{
    internal class Producto
    {
        public int Codigo { get; set; }
        public string CodigoStr => Codigo.ToString("00000");
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string PrecioUnitarioStr => PrecioUnitario.ToString("C");
        public decimal Stock { get; set; }
        public string StockStr => Stock.ToString("0000");
    }
}