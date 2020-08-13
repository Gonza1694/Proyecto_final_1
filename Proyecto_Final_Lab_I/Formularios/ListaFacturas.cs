using System;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Final_Lab_I.Formularios
{
    public partial class ListaFacturas : Form
    {
        public ListaFacturas()
        {
            InitializeComponent();
            CargarGrillaFacturas();
            FormatearGrillaFacturas();
        }

        private void CargarGrillaFacturas()
        {
            dgv_listaFacturas.DataSource = Program.Facturas.OrderBy(x => x.Numero).ToList();

            dgv_listaFacturas.Columns["Numero"].Visible = false;

            dgv_listaFacturas.Columns["NumeroStr"].HeaderText = "N° de Factura";

            dgv_listaFacturas.Columns["Descuento"].Visible = false;

            dgv_listaFacturas.Columns["Total"].Visible = false;

            dgv_listaFacturas.Columns["TotalStr"].HeaderText = "Total";
        }

        private void FormatearGrillaFacturas()
        {
            dgv_listaFacturas.Columns["Subtotal"].Visible = false;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actulizar_Click(object sender, EventArgs e)
        {
            CargarGrillaFacturas();
        }
    }
}