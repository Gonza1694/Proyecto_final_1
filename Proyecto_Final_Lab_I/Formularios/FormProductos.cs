using Proyecto_Final_Lab_I.Clases;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Final_Lab_I
{
    public partial class FormProductos : Form
    {
        private Productos Productos;

        public FormProductos()
        {
            InitializeComponent();
            CargarGrillaProductos();
            FormatearGrillaProductos();
        }

        private void CargarGrillaProductos()
        {
            dgv_busquedaProd.DataSource = Program.Productos
                .OrderBy(x => x.Codigo)
                 .ToList();

        }
        private void FormatearGrillaProductos()
        {
            dgv_busquedaProd.Columns["Codigo"].Visible = false;
            dgv_busquedaProd.Columns["CodigoStr"].HeaderText = "Código";

            dgv_busquedaProd.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_busquedaProd.Columns["PrecioUnitario"].Visible = false;
            dgv_busquedaProd.Columns["PrecioUnitarioStr"].HeaderText = "Precio";

            dgv_busquedaProd.Columns["Stock"].Visible = false;
            dgv_busquedaProd.Columns["StockStr"].HeaderText = "Stock";
        }

		#region EVENTOS
		

		private void btn_agregar_Click(object sender, EventArgs e)
		{
            AgregarProducto();

		}
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // PLACEHOLDER
        private void txt_codigo_MouseDown(object sender, MouseEventArgs e)
        {
            if (txt_codigo.Text == "Código del producto")
            {
                txt_codigo.Clear();
            }
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
            {
                txt_codigo.Text = "Código del producto";
            }
        }

        private void txt_stock_MouseDown(object sender, MouseEventArgs e)
        {
            if (txt_stock.Text == "Stock")
            {
                txt_stock.Clear();
            }
        }

        private void txt_stock_Leave(object sender, EventArgs e)
        {
            if (txt_stock.Text == "")
            {
                txt_stock.Text = "Stock";
            }
        }
        private void txt_descripcion_MouseDown(object sender, MouseEventArgs e)
        {
            if (txt_descripcion.Text == "Descripción")
            {
                txt_descripcion.Clear();
            }
        }

        private void txt_descripcion_Leave(object sender, EventArgs e)
        {
            if (txt_descripcion.Text == "")
            {
                txt_descripcion.Text = "Descripción";
            }
        }
        private void txt_precio_MouseDown(object sender, MouseEventArgs e)
        {
            if (txt_precio.Text == 0.ToString("C"))
            {
                txt_precio.Clear();
            }
        }

        private void txt_precio_Leave(object sender, EventArgs e)
        {
            if (txt_precio.Text == "")
            {
                txt_precio.Text = 0.ToString("C");
            }
        }
        //FIN PLACEHOLDER

        #endregion EVENTOS

        #region METODOS  
        private void AgregarProducto()
        {
            Productos Productos = new Productos()
            {
                Codigo = int.Parse(txt_codigo.Text),
                Descripcion = txt_descripcion.Text,
                PrecioUnitario = int.Parse(txt_precio.Text),
                Stock = int.Parse(txt_stock.Text)
            };
            Program.Productos.Add(Productos);
            ReinciarPanel();
            CargarGrillaProductos();
        }

        private void ReinciarPanel()
        {
            txt_codigo.Text = "Código del producto";
            txt_descripcion.Text = "Descripción";
            txt_stock.Text = "Stock";
            txt_precio.Text = 0.ToString("C");
            Productos = new Productos();
        }
        #endregion METODOS



    }
}