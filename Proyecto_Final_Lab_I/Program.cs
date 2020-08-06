using Proyecto_Final_Lab_I.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Final_Lab_I
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        public static List<Productos> Productos = new List<Productos>();
        public static List<Facturas> Facturas = new List<Facturas>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }

        public static void CargaInicialProductos()
        {
            Productos.Add(new Productos
            {
                Codigo = 1,
                Descripcion = "Coca Cola ret. 2.5L",
                PrecioUnitario = 120,
                Stock = 50
            });
            Productos.Add(new Productos
            {
                Codigo = 2,
                Descripcion = "Pepsiret. 2L",
                PrecioUnitario = 100,
                Stock = 60
            });
            Productos.Add(new Productos
            {
                Codigo = 3,
                Descripcion = "Yogurt",
                PrecioUnitario = 60,
                Stock = 18
            });
            Productos.Add(new Productos
            {
                Codigo = 4,
                Descripcion = "Queso rallado 45g",
                PrecioUnitario = 100,
                Stock = 40
            });
            Productos.Add(new Productos
            {
                Codigo = 5,
                Descripcion = "Leche en desc. 1L",
                PrecioUnitario = 45,
                Stock = 30
            });
            Productos.Add(new Productos
            {
                Codigo = 6,
                Descripcion = "Leche en polvo Nido",
                PrecioUnitario = 200,
                Stock = 20
            });
        }

    }
}
