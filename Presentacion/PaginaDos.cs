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
            ValoresDefault();
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
        public void ValoresDefault()
        {
            int v = 0;
            cboArticuloEn.SelectedIndex = 0;
            cboTipoArticulo.SelectedIndex = 0;
            txtCantidadArticulo.Text = v.ToString();
            cboRevistaArticulo.SelectedIndex = 0;
            cboAudioVisual.SelectedIndex = 0;
            cboAlcanceAudioVisual.SelectedIndex = 0;
            txtCantidadAudioVisual.Text = v.ToString();
            cboTipoAudioVisual.SelectedIndex = 0;
            cboPatentes.SelectedIndex = 0;
            txtPatentes.Text = v.ToString();
            cboTraduLibros.SelectedIndex = 0;
            txtTraduLibros.Text = v.ToString();
            cboObrasArtes.SelectedIndex = 0;
            txtCantidadAutoresArte.Text = v.ToString();
            txtCantidadObrasArte.Text = v.ToString();
            cboImpactoObra.SelectedIndex = 0;
            cboObraArteOriginal.SelectedIndex = 0;
            txtObraArteOriginal.Text = v.ToString();
            txtCantidadArteOriginal.Text = v.ToString();
            cboImpactoObraArteOriginal.SelectedIndex = 0;
            cboPresentacionAudi.SelectedIndex = 0;
            txtCantidadAutoresPresentaciones.Text = v.ToString();
            txtCantidadPresentaciones.Text = v.ToString() ;
            cboImpactoPresentaciones.SelectedIndex = 0;
            cboProcesosTecnologicos.SelectedIndex = 0;
            txtCantidadAutoresProceso.Text = v.ToString();
            txtCantidadProcesos.Text = v.ToString() ;
            cboTipoProcesos.SelectedIndex = 0;
            cboSoftware.SelectedIndex = 0;
            txtCantidadAutoresSoftware.Text = v.ToString();
            txtCantidadSoftware.Text = v.ToString();
            cboPremiosInter.SelectedIndex = 0;
            txtCantidadPremios.Text = v.ToString();

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
        public void CapturaPatentes()
        {
            double puntos = 0;
            string patentes = cboPatentes.Text;
            int cantidadPatentes = int.Parse(txtPatentes.Text);

            if (patentes == "SI" && cantidadPatentes != 0)
            {
                puntos += (cantidadPatentes * 25);
                calcularTotalPuntos(puntos);
            }
        }
        public void CapturaTraducciones()
        {
            double puntos = 0;
            string Tradu = cboTraduLibros.Text;
            int cantidad = int.Parse(txtTraduLibros.Text);

            if (Tradu == "SI" && cantidad != 0)
            {
                puntos += (cantidad * 15);
                calcularTotalPuntos(puntos);
            }

        }
        public void CapturaObrasApoyo()
        {
            int puntos2 = 0;
            double puntos = 0;
            string obrasApoyo = cboObrasArtes.Text;
            int autores = int.Parse(txtCantidadAutoresArte.Text);
            int CObras = int.Parse(txtCantidadObrasArte.Text);
            string impacto = cboImpactoObra.Text;

            if (obrasApoyo == "SI" && CObras != 0)
            {
                if (autores <= 3 && autores > 0)
                {
                    if (impacto == "Nacional")
                    {
                        puntos += (CObras * 14);
                    }
                    else
                    {
                        puntos += (CObras * 20);
                    }

                }
                else if (autores >= 4 && autores < 6)
                {
                    if (impacto == "Nacional")
                    {
                        puntos += (CObras * 7);
                    }
                    else
                    {
                        puntos += (CObras * 10);
                    }

                }
                else
                {
                    if (impacto == "Nacional")
                    {
                        double x = autores / 2;
                        int y = (int)Math.Ceiling(x);

                        puntos += (14 / y);
                        puntos2 = (int)Math.Ceiling(puntos);

                    }
                    else
                    {
                        double x = autores / 2;
                        int y = (int)Math.Ceiling(x);

                        puntos += (20 / y);
                        puntos2 = (int)Math.Ceiling(puntos);


                    }

                }
            }
            puntos2 = (int)Math.Ceiling(puntos);

            calcularTotalPuntos(puntos2);
        }
        public void CapturaObraOriginal()
        {
            int puntos2 = 0;
            double puntos = 0;
            string obrasApoyo = cboObraArteOriginal.Text;
            int autores = int.Parse(txtObraArteOriginal.Text);
            int CObras = int.Parse(txtCantidadArteOriginal.Text);
            string impacto = cboImpactoObraArteOriginal.Text;

            if (obrasApoyo == "SI" && CObras != 0)
            {
                if (autores <= 3 && autores > 0)
                {
                    if (impacto == "Nacional")
                    {
                        puntos += (CObras * 8);
                    }
                    else
                    {
                        puntos += (CObras * 12);
                    }

                }
                else if (autores >= 4 && autores < 6)
                {
                    if (impacto == "Nacional")
                    {
                        puntos += (CObras * 4);
                    }
                    else
                    {
                        puntos += (CObras * 6);
                    }

                }
                else
                {
                    if (impacto == "Nacional")
                    {
                        double x = autores / 2;
                        int y = (int)Math.Ceiling(x);

                        puntos += (8 / y);
                        puntos2 = (int)Math.Ceiling(puntos);

                    }
                    else
                    {
                        double x = autores / 2;
                        int y = (int)Math.Ceiling(x);

                        puntos += (12 / y);
                        puntos2 = (int)Math.Ceiling(puntos);


                    }

                }
            }
            puntos2 = (int)Math.Ceiling(puntos);

            calcularTotalPuntos(puntos2);
        }
        public void CapturaPresentaciones()
        {
            int puntos2 = 0;
            double puntos = 0;
            string obrasApoyo = cboPresentacionAudi.Text;
            int autores = int.Parse(txtCantidadAutoresPresentaciones.Text);
            int CObras = int.Parse(txtCantidadPresentaciones.Text);
            string impacto = cboImpactoPresentaciones.Text;

            if (obrasApoyo == "SI" && CObras != 0)
            {
                if (autores <= 3 && autores > 0)
                {
                    if (impacto == "Nacional")
                    {
                        puntos += (CObras * 8);
                    }
                    else
                    {
                        puntos += (CObras * 14);
                    }

                }
                else if (autores >= 4 && autores < 6)
                {
                    if (impacto == "Nacional")
                    {
                        puntos += (CObras * 4);
                    }
                    else
                    {
                        puntos += (CObras * 7);
                    }

                }
                else
                {
                    if (impacto == "Nacional")
                    {
                        double x = autores / 2;
                        int y = (int)Math.Ceiling(x);

                        puntos += (8 / y);
                        puntos2 = (int)Math.Ceiling(puntos);

                    }
                    else
                    {
                        double x = autores / 2;
                        int y = (int)Math.Ceiling(x);

                        puntos += (14 / y);
                        puntos2 = (int)Math.Ceiling(puntos);


                    }

                }
            }
            puntos2 = (int)Math.Ceiling(puntos);

            calcularTotalPuntos(puntos2);
        }
        public void CapturaSistemaTec()
        {
            int puntos2 = 0;
            double puntos = 0;
            string obrasApoyo = cboProcesosTecnologicos.Text;
            int autores = int.Parse(txtCantidadAutoresProceso.Text);
            int CObras = int.Parse(txtCantidadProcesos.Text);
            string impacto = cboTipoProcesos.Text;

            if (obrasApoyo == "SI" && CObras != 0)
            {
                if (autores <= 3 && autores > 0)
                {
                    if (impacto == "Adaptación")
                    {
                        puntos += (CObras * 8);
                    }
                    else
                    {
                        puntos += (CObras * 15);
                    }

                }
                else if (autores >= 4 && autores < 6)
                {
                    if (impacto == "Adaptación")
                    {
                        puntos += (CObras * 4);
                    }
                    else
                    {
                        puntos += (CObras * 7.5);
                    }

                }
                else
                {
                    if (impacto == "Adaptación")
                    {
                        double x = autores / 2;
                        int y = (int)Math.Ceiling(x);

                        puntos += (8 / y);
                        puntos2 = (int)Math.Ceiling(puntos);

                    }
                    else
                    {
                        double x = autores / 2;
                        int y = (int)Math.Ceiling(x);

                        puntos += (15 / y);
                        puntos2 = (int)Math.Ceiling(puntos);


                    }

                }
            }
            puntos2 = (int)Math.Ceiling(puntos);

            calcularTotalPuntos(puntos2);
        }
        public void CapturaSoftware()
        {
            int puntos2 = 0;
            double puntos = 0;
            string obrasApoyo = cboSoftware.Text;
            int autores = int.Parse(txtCantidadAutoresSoftware.Text);
            int CObras = int.Parse(txtCantidadSoftware.Text);

            if (obrasApoyo == "SI" && CObras != 0)
            {
                if (autores <= 3 && autores > 0)
                {
                    puntos += 15;

                }
                else if (autores >= 4 && autores > 6)
                {

                    puntos += 7.5;
                }
                else
                {
                    double x = autores / 2;
                    int y = (int)Math.Ceiling(x);

                    puntos += (15 / y);
                    puntos2 = (int)Math.Ceiling(puntos);

                }
            }
            puntos2 = (int)Math.Ceiling(puntos);

            calcularTotalPuntos(puntos2);
        }
        public void CapturaPremios()
        {
            double puntos = 0;
            string premios = cboPremiosInter.Text; 
            int cantidadPremios = int.Parse(txtCantidadPremios.Text);

            if (premios == "SI" && cantidadPremios != 0)
            {
                puntos += (cantidadPremios * 15);
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

        private void btnAgregarPatente_Click(object sender, EventArgs e)
        {
            CapturaPatentes();
        }

        private void btnAgregarTradiconLibros_Click(object sender, EventArgs e)
        {
            CapturaTraducciones();
        }

        private void btnAgregarObraApoyo_Click(object sender, EventArgs e)
        {
            CapturaObrasApoyo();
        }

        private void btnAgregarObraOriginal_Click(object sender, EventArgs e)
        {
            CapturaObraOriginal();
        }

        private void btnAgregarPresentacion_Click(object sender, EventArgs e)
        {
            CapturaPresentaciones();
        }

        private void btnAgregarSistemaTecnologico_Click(object sender, EventArgs e)
        {
            CapturaSistemaTec();
        }

        private void btnAgregarSoftware_Click(object sender, EventArgs e)
        {
            CapturaSoftware();
        }

        private void btnAgregarPremio_Click(object sender, EventArgs e)
        {
            CapturaPremios();
        }
    }
}
