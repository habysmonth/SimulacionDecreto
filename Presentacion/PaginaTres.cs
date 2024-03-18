using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Calculos;

namespace Presentacion
{
    public partial class PaginaTres : Form
    {
        public double suma;
        private Chart chart;

        public PaginaTres()
        {
            InitializeComponent();
            // Inicializar el control Chart
            InicializarChart();
        }

        private void InicializarChart()
        {
            // Crear el gráfico de línea
            chart = new Chart();
            chart.Size = new System.Drawing.Size(800, 600);
            chart.Dock = DockStyle.Fill;
            chart.ChartAreas.Add(new ChartArea("Area"));
            chart.Series.Add(new Series("Salario"));
            chart.Series["Salario"].ChartType = SeriesChartType.Line;
            Controls.Add(chart);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Calcula el salario total
            CalculoPublicaciones();
            CalculoDoctorado();
            CalculoResena();
            calculoTraduAr();
            TesisIndi();

            calculosExtra ce = calculosExtra.ObtenerInstancia();
            double y = ce.totalPuntos(suma);

            double vpunto = double.Parse(txtValorPunto.Text);
            double salario = double.Parse(txtSalarioBase.Text);
            double sueldo = (y * vpunto) + salario;

            MessageBox.Show("Sueldo total es: " + sueldo);

            // Actualizar el gráfico con el salario calculado
            //ActualizarGrafico(sueldo);
        }

        private void ActualizarGrafico(double sueldo)
        {
            // Limpiar los puntos existentes en el gráfico
            chart.Series["Salario"].Points.Clear();

            // Agregar el nuevo punto al gráfico con el salario calculado
            chart.Series["Salario"].Points.AddXY(DateTime.Now.Year, sueldo);
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

            if (TR == "SI" && cantidad != 0 && (tipoT == "Ph. D" || tipoT == "Doctorado"))
            {
                puntos += (cantidad * 72);
            }
            else if (TR == "SI" && cantidad != 0 && tipoT == "Maestría")
            {
                puntos += (cantidad * 36);
            }
            else if (TR == "Seleccionar..." || TR == "NO")
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
