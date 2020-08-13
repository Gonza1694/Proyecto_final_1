using Proyecto_Final_Lab_I.Clases;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Final_Lab_I
{
    public partial class FormVentas : Form
    {
        private Factura _facturaactual;
        private Producto _productos;
        private int _nrofactactual;

        public FormVentas()
        {
            InitializeComponent();
            _facturaactual = new Factura();
            FormatearGrillaDetalle();
            CargarGrillaProductos(string.Empty);
            FormatearGrillaProductos();
            NumeradorFactura();
            CabeceraFactura();
            TotalFactura();
        }

        private void TotalFactura()
        {
            lbl_total.Text = $"TOTAL {_facturaactual.Items.Sum(x => x.Subtotal).ToString("C")}";
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

            txt_cantidad.Text = "1";
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

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                AgregarProducto();
            }
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
            lbl_fecha.Text = DateTime.Now.ToShortDateString();
        }

        //CAMBIAR TEXTBOX PARA CARGAR PRODUCTO DESDE LA LISTA
        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_codigo.Text))
            {
                txt_codigo.Focus();
                return;
            }

            int salida = 0;

            if (!int.TryParse(txt_codigo.Text, out salida))
            {
                return;
            }

            // Código del producto
            _productos = ObtenerProducto(salida);

            if (_productos == null)
            {
                return;
            }

            txt_descripcion.Text = _productos.Descripcion;
            txt_precio.Text = _productos.PrecioUnitarioStr;
            txt_descripcion.ReadOnly = true;
            txt_precio.ReadOnly = true;
            txt_cantidad.Text = "1";
        }

        //PRESIONAR ENTER PARA CARGAR PRODUCTO DESDE LA LISTA
        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                if (txt_codigo.Text == "")
                {
                    MessageBox.Show("Ingrese el código de un producto");
                    txt_buscar.Focus();
                    dgv_busquedaProd.Visible = true;
                    return;
                }
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
                txt_cantidad.Text = "1";

                AgregarProducto();
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

        private void txt_cantidad_Enter(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        //FACTURAR
        private void btn_facturar_Click(object sender, EventArgs e)
        {
            if (lbl_total.Text == "TOTAL $ 0,00")
            {
                MessageBox.Show("Factura vacía", caption: "Atencion!");
                return;
            }

            //Modificar stock
            foreach (var item in _facturaactual.Items)
            {
                var producto = Program.Productos.FirstOrDefault(x => item.Codigo == x.Codigo);
                producto.Stock -= item.Cantidad;
            }
            _facturaactual.Fecha = DateTime.Now;

            Program.Facturas.Add(_facturaactual);
            NumeradorFactura();
            ReinciarPanel();
            _facturaactual = new Factura();
            LimpiarDetalleFactura();
            CabeceraFactura();
        }

        private void CabeceraFactura()
        {
            _facturaactual.Numero = _nrofactactual;
            lbl_numFacStr.Text = _nrofactactual.ToString("020-10000");
        }

        private void LimpiarDetalleFactura()
        {
            dgv_detalleFactura.DataSource = _facturaactual.Items;
            lbl_total.Text = "TOTAL $ 0,00";
            FormatearGrillaDetalle();
        }

        #endregion EVENTOS

        #region METODOS

        private void AgregarProducto()
        {
            var itemSeleccionado = _facturaactual.Items.FirstOrDefault(x => x.Codigo.Equals(_productos.Codigo));
            if (txt_codigo.Text == "Código del producto" || txt_codigo.Text == "" || txt_descripcion.Text == "Descripción")
            {
                MessageBox.Show("Ingresa el código del producto");
                txt_codigo.Focus();
                return;
            }

            //Cuando no se coloca cantidad, por defecto es = 1
            if (string.IsNullOrEmpty(txt_cantidad.Text) || txt_cantidad.Text == "Cantidad")
            {
                txt_cantidad.Text = "1";
            }

            // Controlar el stock
            var productoStock = Program.Productos.FirstOrDefault(x => x.Codigo.ToString().Equals(txt_codigo.Text));
            decimal.TryParse(txt_cantidad.Text, out decimal cantidadItem);
            cantidadItem = itemSeleccionado == null ? cantidadItem : cantidadItem + itemSeleccionado.Cantidad;

            if (cantidadItem > productoStock.Stock)
            {
                MessageBox.Show("No hay suficiente stock");
                txt_cantidad.Focus();
                return;
            }

            //Agregar item al detalle si no existe en el mismo
            else if (itemSeleccionado == null)
            {
                _facturaactual.Items.Add(new DetalleFactura
                {
                    Codigo = _productos.Codigo,
                    Descripcion = _productos.Descripcion,
                    PrecioUnitario = _productos.PrecioUnitario,
                    Cantidad = int.Parse(txt_cantidad.Text)
                });
            }
            //Caso contrario sumarle la cantidad al producto agregado existente
            else
            {
                itemSeleccionado.Cantidad += int.Parse(txt_cantidad.Text);
            }

            FormatearGrillaDetalle();
            ReinciarPanel();
            TotalFactura();
            txt_codigo.Clear();
            txt_codigo.Focus();
        }

        private Producto ObtenerProducto(int valor)
        {
            var producto = Program.Productos.FirstOrDefault(x => x.Codigo.Equals(valor));
            return producto;
        }

        private void NumeradorFactura()
        {
            _nrofactactual = Program.Facturas.Any() ? Program.Facturas.Max(x => x.Numero) + 1 : 0;
        }

        private void ReinciarPanel()
        {
            txt_codigo.Text = "Código del producto";
            txt_descripcion.Text = "Descripción";
            txt_cantidad.Text = "Cantidad";
            txt_precio.Text = 0.ToString("C");
        }

        private void ObtenerDetalle()
        {
            //Carga el detalle de la factura
            dgv_detalleFactura.DataSource = _facturaactual.Items.ToList();
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

        //Dar formato a la grilla
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

        #endregion METODOS        
    }
}