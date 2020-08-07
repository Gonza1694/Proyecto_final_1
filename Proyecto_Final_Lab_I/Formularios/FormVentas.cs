using Proyecto_Final_Lab_I.Clases;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Final_Lab_I
{
    public partial class FormVentas : Form
    {
        private Facturas _facturas;
        private Productos _productos;

        public FormVentas()
        {
            InitializeComponent();
            _facturas = new Facturas();
            ObtenerDetalle();
            CargarGrillaProductos(string.Empty);
            FormatearGrillaProductos();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private Productos ObtenerProducto(int valor)
        {
            return Program.Productos.FirstOrDefault(x => x.Codigo.Equals(valor));
        }

        private void AgregarProducto()
        {
            //var item = _facturas.Items.FirstOrDefault(x => x.Equals(_productos.Codigo));

            //if (item == null)
            //{
            //    DetalleFactura detalle = new DetalleFactura
            //    {
            //        Codigo = _productos.Codigo,
            //        Descripcion = _productos.Descripcion,
            //        PrecioUnitario = _productos.PrecioUnitario,
            //        Cantidad = int.Parse(txt_cantidad.Text)
            //    };
            //    _facturas.Items.Add(detalle);
            //}
            //else
            //{
            //    item.Cantidad += int.Parse(txt_cantidad.Text);
            //}

            //ObtenerDetalle();
            ReinciarPanel();
        }

        private void ObtenerDetalle()
        {
            dgv_detalleFactura.DataSource = _facturas.Items.ToList();
            //dgv_detalleFactura.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Ocultar Columnas
            dgv_detalleFactura.Columns["Subtotal"].Visible = false;
            dgv_detalleFactura.Columns["PrecioUnitario"].Visible = false;
            //Modificar Cabeceras de Columnas
            dgv_detalleFactura.Columns["SubtotalStr"].HeaderText = "Subtotal";
            dgv_detalleFactura.Columns["PrecioUnitarioStr"].HeaderText = "Precio";
        }

        private void CargarGrillaProductos(string busqueda)
        {
            dgv_busquedaProd.DataSource = Program.Productos.Where(x => x.Codigo.ToString().Contains(busqueda)
            || x.Descripcion.Contains(busqueda)
            || x.Descripcion.ToLower().Contains(busqueda)
            || x.Descripcion.ToUpper().Contains(busqueda))
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

        private void pb_buscar_Click(object sender, EventArgs e)
        {
            CargarGrillaProductos(txt_buscar.Text);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            CargarGrillaProductos(txt_buscar.Text);
        }

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

        private void txt_cantidad_MouseDown(object sender, MouseEventArgs e)
        {
            if (txt_cantidad.Text == "Cantidad")
            {
                txt_cantidad.Clear();
            }
        }

        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "")
            {
                txt_cantidad.Text = "Cantidad";
            }
        }

        private void ReinciarPanel()
        {
            txt_codigo.Text = "Código del producto";
            txt_descripcion.Text = "Descripción";
            txt_cantidad.Text = "Cantidad";
            txt_precio.Text = 0.ToString("C");
        }

        private void txt_buscar_MouseDown(object sender, MouseEventArgs e)
        {
            dgv_busquedaProd.Visible = true;

            if (txt_buscar.Text == "Buscar")
            {
                txt_buscar.Text = "";
            }
        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            dgv_busquedaProd.Visible = false;

            dgv_busquedaProd.Visible = true;
            if (txt_buscar.Text == "")
            {
                txt_buscar.Text = "Buscar";
            }
        }
    }
}