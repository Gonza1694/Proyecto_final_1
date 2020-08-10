using System;
using System.Windows.Forms;

namespace Proyecto_Final_Lab_I.Formularios
{
    public partial class FormBase : Form
    {
        private string _placeholder;

        public FormBase()
        {
            InitializeComponent();
        }

        protected void Placeholder(object control, string placeholder)
        {
            if (control is TextBox)
            {
                _placeholder = placeholder;
                ((TextBox)control).MouseDown += Control_MouseDown;
                ((TextBox)control).Leave += Control_Leave;
            }
        }

        protected void Control_Leave(object sender, EventArgs e)
        {
            switch (sender)
            {
                case TextBox caja:
                    if (caja.Text == "")
                    {
                        caja.Text = _placeholder;
                    }
                    break;

                default:
                    break;
            }
        }

        protected void Control_MouseDown(object sender, EventArgs e)
        {
            switch (sender)
            {
                case TextBox caja:
                    if (caja.Text == _placeholder)
                    {
                        caja.Clear();
                    }
                    break;

                default:
                    break;
            }
        }
    }
}