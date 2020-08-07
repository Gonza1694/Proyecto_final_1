using System;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Final_Lab_I
{
    public partial class FormProductos : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}