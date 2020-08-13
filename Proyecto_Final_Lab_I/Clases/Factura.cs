using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Final_Lab_I.Clases
{
    internal class Factura
    {
        public List<DetalleFactura> Items { get; set; }
        public int Numero { get; set; }
        public string NumeroStr => Numero.ToString("020-10000");
        public DateTime Fecha { get; set; }
        public decimal Descuento { get; set; }
        public decimal Subtotal => Items.Sum(x => x.Subtotal);
        public decimal Total => Subtotal * (100 - Descuento) / 100;
        public string TotalStr => Total.ToString("C");

        public string FechaStr => Fecha.ToShortDateString();
        public string HoraStr => Fecha.ToShortTimeString();

        public Factura()
        {
            Items = new List<DetalleFactura>();
        }
    }
}