using Calculos;


namespace Presentacion
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int suma = 0;
        int puntaje = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            ValoresDefault();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (cboTitulo1.SelectedItem.ToString() == "Seleccionar...")
            {
                MessageBox.Show("Por favor, seleccione un TÍTULO primero");
            }
            else
            {
                calculosExtra ce = calculosExtra.ObtenerInstancia();
                ce.totalPuntos(suma);
                PaginaDos pgd = new PaginaDos();
                pgd.ShowDialog();
            }

        }
        private void cboTitulo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTitulo1.SelectedItem.ToString() == "PREGRADO")
            {
                inhabilitarPosgrado();
                cboCarreraPre.Enabled = true;
                cboMedicina.Enabled = true;

            }
            else if (cboTitulo1.SelectedItem.ToString() == "Seleccionar...")
            {

                inhabilitarPosgrado();
                ValoresDefault();
                cboCarreraPre.Enabled = false;
                cboMedicina.Enabled = false;
            }
            else
            {
                habilitarPosgrado();

            }
        }
        public void inhabilitarPosgrado()
        {
            cboCantidadPos.Enabled = false;
            cboTipoPos.Enabled = false;
            cboCarreraEsp.Enabled = false;
            txtAnoPos.Enabled = false;
            cboCarreraEjercePos.Enabled = false;
            cboMaestríaPos.Enabled = false;
            txtAnoMaestríaPos.Enabled = false;
            txtAnosTotalEspe.Enabled = false;
        }
        public void habilitarPosgrado()
        {
            cboTipoPos.Enabled = true;
            cboCarreraPre.Enabled = false;
            cboMedicina.Enabled = false;
        }
        public void ValoresDefault()
        {
            int v = 0;
            cboTitulo1.SelectedIndex = 0;
            cboTipoPos.SelectedIndex = 0;
            cboCantidadPos.SelectedIndex = 0;
            txtAnoPos.Text = v.ToString();
            cboCarreraEjercePos.SelectedIndex = 0;
            cboMaestríaPos.SelectedIndex = 0;
            txtAnoMaestríaPos.Text = v.ToString();
            txtAnosTotalEspe.Text = v.ToString();
            cboCarreraPre.SelectedIndex = 0;
            cboMedicina.SelectedIndex = 0;
            cboCarreraEsp.SelectedIndex = 0;
            cboEscalafon.SelectedIndex = 0;
            cboReintegroN.SelectedIndex = 0;
            cboColegios.SelectedIndex = 0;
            cboRolColegios.SelectedIndex = 0;
            cboDireccion.SelectedIndex = 0;
            cboRolDireccion.SelectedIndex = 0;
            cboUniversidades.SelectedIndex = 0;
            cboRolUniversidades.SelectedIndex = 0;
            cboDiferente.SelectedIndex = 0;
            cboRolDiferente.SelectedIndex = 0;
            txtAnosColegio.Text = v.ToString();
            txtAnosDireccion.Text = v.ToString();
            txtAnosUniversidad.Text = v.ToString();
            txtAnosDiferentes.Text = v.ToString();
        }

        private void cboTipoPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoPos.SelectedItem.ToString() == "Especilizacion")
            {
                cboCantidadPos.Enabled = true;
                txtAnosTotalEspe.Enabled = true;
            }
            else if (cboTipoPos.SelectedItem.ToString() == "Seleccionar..." &&
                cboTitulo1.SelectedItem.ToString() == "POSGRADO")
            {
                inhabilitarPosgrado();
                cboTipoPos.Enabled = true;
            }
            else if (cboTipoPos.SelectedItem.ToString() == "Maestría")
            {
                cboCantidadPos.Enabled = false;
                txtAnosTotalEspe.Enabled = false;
                cboMaestríaPos.Enabled = false;
                txtAnoMaestríaPos.Enabled = false;
                txtAnoPos.Enabled = false;
                cboCarreraEsp.Enabled = true;
                cboCarreraEjercePos.Enabled = true;
            }
            else if (cboTipoPos.SelectedItem.ToString() == "Doctorado" ||
                cboTipoPos.SelectedItem.ToString() == "Ph.D")
            {
                cboCantidadPos.Enabled = true;
                cboCarreraEsp.Enabled = true;
                txtAnoPos.Enabled = true;
                cboCarreraEjercePos.Enabled = true;
                cboMaestríaPos.Enabled = true;
                txtAnoMaestríaPos.Enabled = true;

            }

        }

        private void cboCantidadPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No necesitas calcular el puntaje aquí; solo cuando se hace clic en el botón
        }

        private void btnPuntaje_Click(object sender, EventArgs e)
        {

            int ptss = calcularPuntaje();
            int total = totalPuntos(ptss);
            MessageBox.Show($"El puntaje calculado es: {total}", "Puntaje Calculado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int calcularPuntaje()
        {
            int ce = 0;
            string titulo = cboTitulo1.Text;
            string medicina = cboMedicina.Text;
            string tipoPosgrado = cboTipoPos.Text;
            string cantidadEspe = cboCantidadPos.Text;
            string carreraEspe = cboCarreraEsp.Text;
            int Anho = int.Parse(txtAnoPos.Text);
            string CarreraEjerce = cboCarreraEjercePos.Text;
            string maestria = cboMaestríaPos.Text;
            int AnoMaestria = int.Parse(txtAnoMaestríaPos.Text);
            int tiempoTEsp = int.Parse(txtAnosTotalEspe.Text);
            string carreraPre = cboCarreraPre.Text;
            string escala = cboEscalafon.Text;



            if (cantidadEspe == "Seleccionar...")
            {
                ce = 0;
            }
            else if (cantidadEspe == "1")
            {
                ce = 1;
            }
            else if (cantidadEspe == "2")
            {
                ce = 2;
            }

            calculosExtra calculosExtra = new calculosExtra();

            int total = calculosExtra.calculosPuntos(titulo, medicina, tipoPosgrado, ce, carreraEspe, Anho,
                CarreraEjerce, maestria, AnoMaestria, tiempoTEsp, carreraPre, escala);

            return total;
        }

        private void cboMaestríaPos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarRolColegio_Click(object sender, EventArgs e)
        {
            int v = 0;

            string rolCole = cboRolColegios.Text;
            int AnoCol = int.Parse(txtAnosColegio.Text);
            string reint = cboReintegroN.Text;
            string origen = "Col";

            int pts = puntosPorReingreso(reint, origen, AnoCol, rolCole);
            totalPuntos(pts);

            cboRolColegios.SelectedIndex = 0;
            txtAnosColegio.Text = v.ToString();
            cboColegios.SelectedIndex = 0;
        }
        public int totalPuntos(int x)
        {

            suma += x;

            return suma;
        }

        public int puntosPorReingreso(string reintg, string or, int anhos, string tipo)
        {
            int puntos = 0;
            if (reintg == "SI")
            {
                switch (or)
                {
                    case "Col":
                        puntos += anhos * 6;
                        break;
                    case "Uni":
                        puntos += anhos * 4;
                        break;
                    case "Dir":
                        puntos += anhos * 4;
                        break;
                    case "Otro":
                        puntos += anhos * 3;
                        break;
                    default:
                        break;
                }
            }
            else if (reintg == "NO")
            {
                switch (tipo)
                {
                    case "Instructor":
                        puntos += anhos * 3;
                        break;
                    case "Profesor Auxiliar":
                        puntos += anhos * 3;
                        break;
                    case "Instr.Asistente":
                        puntos += anhos * 3;
                        break;
                    case "Prof.Asistente":
                        puntos += anhos * 5;
                        break;
                    case "Prof.Asociado":
                        puntos += anhos * 6;
                        break;
                    case "Prof.Titular":
                        puntos += anhos * 7;
                        break;
                    case "Seleccionar...":
                        puntos += 0;
                        break;
                    default:
                        break;
                }
            }
            return puntos;
        }

        private void btnAgregarRolUniversidad_Click(object sender, EventArgs e)
        {
            int v = 0;
            string rolUni = cboRolUniversidades.Text;
            int AnhoUni = int.Parse(txtAnosUniversidad.Text);
            string reing = cboReintegroN.Text;
            string Origen = "Uni";

            int pts = puntosPorReingreso(reing, Origen, AnhoUni, rolUni);
            totalPuntos(pts);

            cboRolUniversidades.SelectedIndex = 0;
            cboUniversidades.SelectedIndex = 0;
            txtAnosUniversidad.Text = v.ToString();
        }

        private void btnAgregarRolCargoDireccion_Click(object sender, EventArgs e)
        {
            int v = 0;
            string rolDirectivo = cboRolDireccion.Text;
            int AnhosDireccion = int.Parse(txtAnosDireccion.Text);
            string reing = cboReintegroN.Text;
            string Origen = "Dir";

            int pts = puntosPorReingreso(reing, Origen, AnhosDireccion, rolDirectivo);
            totalPuntos(pts);

            cboDireccion.SelectedIndex = 0;
            cboRolDireccion.SelectedIndex = 0;
            txtAnosDireccion.Text = v.ToString();
        }

        private void btnAgregarTrabajoDiferente_Click(object sender, EventArgs e)
        {
            int v = 0;
            string rolDif = cboRolDiferente.Text;
            int AnhosDif = int.Parse(txtAnosDiferentes.Text);
            string reing = cboReintegroN.Text;
            string Origen = "Otro";

            int pts = puntosPorReingreso(reing, Origen, AnhosDif, rolDif);
            totalPuntos(pts);
            cboDiferente.SelectedIndex = 0;
            cboRolDiferente.SelectedIndex = 0;
            txtAnosDiferentes.Text = v.ToString();
        }
    }
}




