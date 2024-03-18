using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class FormGrafica : Form
    {
        private Chart chart;

        public FormGrafica()
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

        public void MostrarGrafica(double sueldo)
        {
            // Limpiar los puntos existentes en el gráfico
            chart.Series["Salario"].Points.Clear();

            // Agregar el nuevo punto al gráfico con el salario calculado
            chart.Series["Salario"].Points.AddXY(DateTime.Now.Year, sueldo);
        }
    }
}
