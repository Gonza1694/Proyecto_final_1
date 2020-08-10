using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Final_Lab_I.Clases
{
    internal class Factura
    {
        public List<DetalleFactura> Items { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Descuento { get; set; }
        public decimal Subtotal => Items.Sum(x => x.Subtotal);
        public decimal Total => Subtotal * (100 - Descuento) / 100;

        public Factura()
        {
            Items = new List<DetalleFactura>();
        }
    }
}