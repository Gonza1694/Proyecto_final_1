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
            FormatearGrillaDetalle();
            CargarGrillaProductos(string.Empty);
            FormatearGrillaProductos();
            NumeradorFactura();
        }

        #region EVENTOS

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

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                _productos = ObtenerProducto(int.Parse(txt_codigo.Text));
                if (_productos == null)
                {
                    MessageBox.Show("Ingrese un producto existente");
                    txt_buscar.Focus();
                    dgv_busquedaProd.Visible = true;
                    return;
                }
                txt_descripcion.Text = _productos.Descripcion;
                txt_precio.Text = _productos.PrecioUnitarioStr;
                txt_descripcion.ReadOnly = true;
                txt_precio.ReadOnly = true;
            }

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
                {
                    return;
                }
                else
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            Program.Facturas.Add(_facturas);
            _facturas = new Facturas();
            NumeradorFactura();
        }

        #endregion EVENTOS

        #region METODOS

        private void NumeradorFactura()
        {
            _facturas.Numero = Program.Facturas.Any() ? Program.Facturas.Max(x => x.Numero) + 1 : 0;
            txt_numFac.Text += _facturas.Numero.ToString();
        }

        private void ReinciarPanel()
        {
            txt_codigo.Text = "Código del producto";
            txt_descripcion.Text = "Descripción";
            txt_cantidad.Text = "Cantidad";
            txt_precio.Text = 0.ToString("C");
            _facturas = new Facturas();
        }

        private void AgregarProducto()
        {
            var itemSeleccionado = _facturas.Items.FirstOrDefault(x => x.Codigo.Equals(_productos.Codigo));
            if (txt_cantidad.Text == "" || txt_cantidad.Text == "Cantidad" || txt_cantidad == null)
            {
                txt_cantidad.Text = "1";
            }
            if (itemSeleccionado == null)
            {
                _facturas.Items.Add(new DetalleFactura
                {
                    Codigo = _productos.Codigo,
                    Descripcion = _productos.Descripcion,
                    PrecioUnitario = _productos.PrecioUnitario,
                    Cantidad = int.Parse(txt_cantidad.Text)
                });
            }
            else
            {
                itemSeleccionado.Cantidad += int.Parse(txt_cantidad.Text);
            }
            FormatearGrillaDetalle();
            ReinciarPanel();
        }

        private void ObtenerDetalle()
        {
            //Carga el detalle de la factura
            dgv_detalleFactura.DataSource = _facturas.Items.ToList();
        }

        private void FormatearGrillaDetalle()
        {
            ObtenerDetalle();
            dgv_detalleFactura.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //Ocultar Columnas
            dgv_detalleFactura.Columns["Subtotal"].Visible = false;
            dgv_detalleFactura.Columns["PrecioUnitario"].Visible = false;

            //Modificar Cabeceras de Columnas
            dgv_detalleFactura.Columns["SubtotalStr"].HeaderText = "Subtotal";
            dgv_detalleFactura.Columns["PrecioUnitarioStr"].HeaderText = "Precio";
        }

        private void CargarGrillaProductos(string busqueda)
        {
            //Carga la grilla de productos
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
        private Productos ObtenerProducto(int valor)
        {
            var producto = Program.Productos.FirstOrDefault(x => x.Codigo.Equals(valor));
            return producto;
        }
        #endregion METODOS
    }
}