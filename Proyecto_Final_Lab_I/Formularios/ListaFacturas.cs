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
        }

        private void FormatearGrillaFacturas()
        {
            //throw new NotImplementedException();
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
