using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculos;

namespace Presentacion
{
    public partial class PaginaTres : Form
    {
        public double suma;
        public PaginaTres()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalculoPublicaciones(); 
            CalculoDoctorado();
            CalculoResena();
            calculoTraduAr();
            TesisIndi();

            calculosExtra ce = calculosExtra.ObtenerInstancia();
            double y = ce.totalPuntos(suma);

            double vpunto = double.Parse(txtValorPunto.Text);
            double salario = double.Parse(txtSalarioBase.Text);
            double sueldo = (y*vpunto) + salario;

            MessageBox.Show("Sueldo total es: "+sueldo);

        }

        public void calculos()
        {
            calculosExtra ce = calculosExtra.ObtenerInstancia();
            double x = ce.totalPuntos(suma);
            MessageBox.Show("Llevamos: " + x);
        }

       
        public void CalculoPonencia()
        {
            double puntos = 0;
            int puntos2 = 0;
            string ponencia = cboPonencias.Text;
            int cantidad = int.Parse(txtCantidadPonencias.Text);
            string impacto = cboImpactoPonencias.Text;

            if (impacto == "Regional" && cantidad != 0 && ponencia == "SI")
            {
                puntos += (cantidad * 24);
            }
            else if (impacto == "Nacional" && cantidad != 0 && ponencia == "SI")
            {
                puntos += (cantidad * 48);
            }
            else if (impacto == "Internacional" && cantidad != 0 && ponencia == "SI")
            {
                puntos += (cantidad * 84);
            }

            puntos2 = (int)Math.Ceiling(puntos);

            calcularTotalPuntos(puntos2);
        }
        public void CalculoPublicaciones()
        {
            double puntos = 0;
            int puntos2 = 0;
            string publi = cboPublicaciones.Text;
            int cantidad = int.Parse(txtCantidadPublicaciones.Text);

            if (publi == "SI" && cantidad != 0)
            {
                puntos += (cantidad * 60);
            }
            puntos2 = (int)Math.Ceiling(puntos);

            calcularTotalPuntos(puntos2);
        }
        public void CalculoDoctorado()
        {
            double puntos = 0;
            int puntos2 = 0;
            string doc = cboEstudiosPosDoctorales.Text;
            int cantidad = int.Parse(txtEstudiosPostDoctorales.Text);

            if (doc == "SI" && cantidad != 0)
            {
                puntos += (cantidad * 120);
            }
            puntos2 = (int)Math.Ceiling(puntos);

            calcularTotalPuntos(puntos2);
        }
        public void CalculoResena()
        {
            double puntos = 0;
            int puntos2 = 0;
            string r = cboCriticasValidas.Text;
            int cantidad = int.Parse(txtCriticasValidas.Text);

            if (r == "SI" && cantidad != 0)
            {
                puntos += (cantidad * 12);
            }
            puntos2 = (int)Math.Ceiling(puntos);

            calcularTotalPuntos(puntos2);
        }
        public void calculoTraduAr()
        {
            double puntos = 0;
            int puntos2 = 0;
            string TA = cboTradArticulos.Text;
            int cantidad = int.Parse(txtTradArtiReconocidos.Text);

            if (TA == "SI" && cantidad != 0)
            {
                puntos += (cantidad * 36);
            }
            puntos2 = (int)Math.Ceiling(puntos);

            calcularTotalPuntos(puntos2);
        }
        public void TesisIndi()
        {
            double puntos = 0;
            int puntos2 = 0;
            string TR = cboTesisIndividuales.Text;
            string tipoT = cboTipoTesis.Text;
            int cantidad = int.Parse(txtTesisIndividuales.Text);

            if (TR == "SI" && cantidad != 0 && (tipoT == "Ph. D"  || tipoT == "Doctorado"))
            {
                puntos += (cantidad * 72);
            }else if (TR == "SI" && cantidad != 0 && tipoT == "Maestría")
            {
                puntos += (cantidad * 36);
            }
            else if(TR == "Seleccionar..." || TR == "NO")
            {
                cboTipoTesis.Enabled = false;
                txtTesisIndividuales.Enabled = false;
                
            }
            puntos2 = (int)Math.Ceiling(puntos);

            calcularTotalPuntos(puntos2);
        }

        public double calcularTotalPuntos(double pts)
        {
            suma += pts;
            return suma;
        }

        private void btnAgregarPonencia_Click(object sender, EventArgs e)
        {
            CalculoPonencia();
        }
    }
}
