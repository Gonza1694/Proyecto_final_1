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
            CargaProductos();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }

        public static void CargaProductos()
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
                Descripcion = "Pepsi ret. 2L",
                PrecioUnitario = 100,
                Stock = 60
            });
            Productos.Add(new Productos
            {
                Codigo = 3,
                Descripcion = "Yogurt",
                PrecioUnitario = 60,
                Stock = 21
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
            Productos.Add(new Productos
            {
                Codigo = 7,
                Descripcion = "Mermelada Ciruela",
                PrecioUnitario = 85,
                Stock = 20
            });
            Productos.Add(new Productos
            {
                Codigo = 8,
                Descripcion = "Mermelada Naranja",
                PrecioUnitario = 90,
                Stock = 20
            });
            Productos.Add(new Productos
            {
                Codigo = 9,
                Descripcion = "Fideos 500g",
                PrecioUnitario = 60,
                Stock = 20
            });
            Productos.Add(new Productos
            {
                Codigo = 10,
                Descripcion = "Arroz 1Kg",
                PrecioUnitario = 70,
                Stock = 20
            });
            Productos.Add(new Productos
            {
                Codigo = 11,
                Descripcion = "Arroz 500gr",
                PrecioUnitario = 40,
                Stock = 20
            }); 
            Productos.Add(new Productos
            {
                Codigo = 12,
                Descripcion = "Mirinda Mza 2L",
                PrecioUnitario = 110,
                Stock = 20
            });
            Productos.Add(new Productos
            {
                Codigo = 13,
                Descripcion = "Serenito",
                PrecioUnitario = 200,
                Stock = 20
            });
            Productos.Add(new Productos
            {
                Codigo = 14,
                Descripcion = "Doritos 160g",
                PrecioUnitario = 155,
                Stock = 20
            });
            Productos.Add(new Productos
            {
                Codigo = 15,
                Descripcion = "Papas Lays 140g",
                PrecioUnitario = 140,
                Stock = 20
            });
            Productos.Add(new Productos
            {
                Codigo = 16,
                Descripcion = "Papas Lays 50g",
                PrecioUnitario = 50,
                Stock = 20
            });
            Productos.Add(new Productos
            {
                Codigo = 17,
                Descripcion = "Salchichas 99",
                PrecioUnitario = 30,
                Stock = 20
            });
            Productos.Add(new Productos
            {
                Codigo = 18,
                Descripcion = "Hamburguesa Paty",
                PrecioUnitario = 80,
                Stock = 20
            });
            Productos.Add(new Productos
            {
                Codigo = 19,
                Descripcion = "Hamburguesa Swift",
                PrecioUnitario = 60,
                Stock = 20
            });
            Productos.Add(new Productos
            {
                Codigo = 20,
                Descripcion = "Fenet",
                PrecioUnitario = 450,
                Stock = 20
            });
        }

    }
}
