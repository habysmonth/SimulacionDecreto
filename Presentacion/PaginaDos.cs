using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PaginaDos : Form
    {
        public double suma;
        public PaginaDos()
        {
            InitializeComponent();
        }

        private void btnSiguienteDos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(suma.ToString());
            //PaginaTres pgt = new PaginaTres();
            //pgt.ShowDialog();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            CapturaDatosArticulo();
            cboTipoArticulo.SelectedIndex = 1;
            txtCantidadArticulo.Text = "0";
            cboRevistaArticulo.SelectedIndex = 1;

        }

        public void ActivaArticulos()
        {
            string opArticulo = cboArticuloEn.Text;

            if (opArticulo == "SI")
            {
                cboTipoArticulo.Enabled = true;
                txtCantidadArticulo.Enabled = true;
                cboRevistaArticulo.Enabled = true;
                btnAgregarArticulo.Enabled = true;
            }
            else if (opArticulo == "NO")
            {
                cboTipoArticulo.Enabled = false;
                txtCantidadArticulo.Enabled = false;
                cboRevistaArticulo.Enabled = false;
                btnAgregarArticulo.Enabled = false;
            }
            else
            {
                cboTipoArticulo.Enabled = false;
                txtCantidadArticulo.Enabled = false;
                cboRevistaArticulo.Enabled = false;
                btnAgregarArticulo.Enabled = false;
            }
        }
        public void CapturaDatosArticulo()
        {
            double puntos = 0;
            string opArticulo = cboArticuloEn.Text;
            string eleccion = cboTipoArticulo.Text;
            int cantidad = int.Parse(txtCantidadArticulo.Text);
            string revista = cboRevistaArticulo.Text;

            if (cantidad != 0 && eleccion == "Normal")
            {
                if (revista == "Semana")
                {
                    puntos += cantidad * 15;
                    calcularTotalPuntos(puntos);
                }
                else
                {
                    puntos += cantidad * 12;
                    calcularTotalPuntos(puntos);
                }
            }
            else if (cantidad != 0 && eleccion == "Corto")
            {
                if (revista == "Semana")
                {
                    puntos += cantidad * (15 * 0.6);
                    calcularTotalPuntos(puntos);
                }
                else
                {
                    puntos += cantidad * (12 * 0.6);
                    calcularTotalPuntos(puntos);
                }
            }
            else
            {
                MessageBox.Show("No puede dejar campos vacíos");
            }
        }
        public void CapturaAudioVisual()
        {
            double puntos = 0;
            string AV = cboAudioVisual.Text;
            string alcance = cboAlcanceAudioVisual.Text;
            int cantidad = int.Parse(txtCantidadAudioVisual.Text);
            string tipo = cboTipoAudioVisual.Text;

            if (cantidad != 0 && alcance == "Nacional" && tipo == "Documental")
            {
                puntos += cantidad * (7 * 0.8);
                calcularTotalPuntos(puntos);
            }
            else if (cantidad != 0 && alcance == "Internacional" && tipo == "Documental")
            {
                puntos += cantidad * (12 * 0.8);
                calcularTotalPuntos(puntos);
            }
            else if (cantidad != 0 && alcance == "Internacional" && tipo == "Normal")
            {
                puntos += cantidad * (12);
                calcularTotalPuntos(puntos);
            }
            else if (cantidad != 0 && alcance == "Nacional" && tipo == "Normal")
            {
                puntos += cantidad * (7);
                calcularTotalPuntos(puntos);
            }
        }
        public double calcularTotalPuntos(double pts)
        {
            suma += pts;
            return suma;
        }

        private void cboArticuloEn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivaArticulos();
        }

        private void btnAgregarAudioVisual_Click(object sender, EventArgs e)
        {
            CapturaAudioVisual();
        }
    }
}
