namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            cboTitulo1 = new ComboBox();
            cboMedicina = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboTipoPos = new ComboBox();
            label6 = new Label();
            txtAnoPos = new TextBox();
            label8 = new Label();
            cboCantidadPos = new ComboBox();
            label9 = new Label();
            cboMaestríaPos = new ComboBox();
            label10 = new Label();
            txtAnoMaestríaPos = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            cboCarreraEsp = new ComboBox();
            label15 = new Label();
            cboCarreraEjercePos = new ComboBox();
            label16 = new Label();
            cboCarreraPre = new ComboBox();
            label17 = new Label();
            label18 = new Label();
            cboEscalafon = new ComboBox();
            label19 = new Label();
            cboReintegroN = new ComboBox();
            label20 = new Label();
            label21 = new Label();
            cboColegios = new ComboBox();
            label24 = new Label();
            cboRolColegios = new ComboBox();
            label22 = new Label();
            txtAnosColegio = new TextBox();
            txtAnosUniversidad = new TextBox();
            label23 = new Label();
            cboRolUniversidades = new ComboBox();
            label25 = new Label();
            cboUniversidades = new ComboBox();
            label26 = new Label();
            txtAnosDireccion = new TextBox();
            label27 = new Label();
            cboRolDireccion = new ComboBox();
            label28 = new Label();
            cboDireccion = new ComboBox();
            label29 = new Label();
            txtAnosDiferentes = new TextBox();
            label30 = new Label();
            cboRolDiferente = new ComboBox();
            label31 = new Label();
            cboDiferente = new ComboBox();
            label32 = new Label();
            pictureBox1 = new PictureBox();
            btnSiguiente = new Button();
            btnAgregarRolColegio = new Button();
            btnAgregarRolUniversidad = new Button();
            btnAgregarRolCargoDireccion = new Button();
            btnAgregarTrabajoDiferente = new Button();
            btnPuntaje = new Button();
            txtAnosTotalEspe = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(180, 9);
            label1.Name = "label1";
            label1.Size = new Size(608, 74);
            label1.TabIndex = 0;
            label1.Text = "SIMULA TU SALARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 108);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 1;
            label2.Text = "Título";
            // 
            // cboTitulo1
            // 
            cboTitulo1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTitulo1.FormattingEnabled = true;
            cboTitulo1.Items.AddRange(new object[] { "Seleccionar...", "PREGRADO", "POSGRADO" });
            cboTitulo1.Location = new Point(96, 100);
            cboTitulo1.Name = "cboTitulo1";
            cboTitulo1.Size = new Size(169, 33);
            cboTitulo1.TabIndex = 2;
            cboTitulo1.SelectedIndexChanged += cboTitulo1_SelectedIndexChanged;
            // 
            // cboMedicina
            // 
            cboMedicina.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedicina.FormattingEnabled = true;
            cboMedicina.Items.AddRange(new object[] { "Seleccinar...", "SI", "NO" });
            cboMedicina.Location = new Point(145, 139);
            cboMedicina.Name = "cboMedicina";
            cboMedicina.Size = new Size(118, 33);
            cboMedicina.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 147);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 4;
            label3.Text = "En medicina";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 204);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 5;
            label4.Text = "SI ES POSGRADO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 243);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 6;
            label5.Text = "Tipo";
            // 
            // cboTipoPos
            // 
            cboTipoPos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPos.FormattingEnabled = true;
            cboTipoPos.Items.AddRange(new object[] { "Seleccionar...", "Especilizacion", "Maestría", "Doctorado", "Ph.D" });
            cboTipoPos.Location = new Point(85, 235);
            cboTipoPos.Name = "cboTipoPos";
            cboTipoPos.Size = new Size(178, 33);
            cboTipoPos.TabIndex = 7;
            cboTipoPos.SelectedIndexChanged += cboTipoPos_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 357);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 8;
            label6.Text = "Año";
            // 
            // txtAnoPos
            // 
            txtAnoPos.Location = new Point(87, 351);
            txtAnoPos.Name = "txtAnoPos";
            txtAnoPos.Size = new Size(178, 31);
            txtAnoPos.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(-2, 282);
            label8.Name = "label8";
            label8.Size = new Size(83, 25);
            label8.TabIndex = 12;
            label8.Text = "Cantidad";
            // 
            // cboCantidadPos
            // 
            cboCantidadPos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCantidadPos.FormattingEnabled = true;
            cboCantidadPos.Items.AddRange(new object[] { "Seleccionar...", "1", "2" });
            cboCantidadPos.Location = new Point(85, 274);
            cboCantidadPos.Name = "cboCantidadPos";
            cboCantidadPos.Size = new Size(178, 33);
            cboCantidadPos.TabIndex = 13;
            cboCantidadPos.SelectedIndexChanged += cboCantidadPos_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 436);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 14;
            label9.Text = "Maestría?";
            // 
            // cboMaestríaPos
            // 
            cboMaestríaPos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaestríaPos.FormattingEnabled = true;
            cboMaestríaPos.Items.AddRange(new object[] { "Seleccionar...", "SI", "NO" });
            cboMaestríaPos.Location = new Point(127, 428);
            cboMaestríaPos.Name = "cboMaestríaPos";
            cboMaestríaPos.Size = new Size(136, 33);
            cboMaestríaPos.TabIndex = 15;
            cboMaestríaPos.SelectedIndexChanged += cboMaestríaPos_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 473);
            label10.Name = "label10";
            label10.Size = new Size(45, 25);
            label10.TabIndex = 16;
            label10.Text = "Año";
            // 
            // txtAnoMaestríaPos
            // 
            txtAnoMaestríaPos.Location = new Point(87, 467);
            txtAnoMaestríaPos.Name = "txtAnoMaestríaPos";
            txtAnoMaestríaPos.Size = new Size(178, 31);
            txtAnoMaestríaPos.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(23, 558);
            label11.Name = "label11";
            label11.Size = new Size(242, 28);
            label11.TabIndex = 18;
            label11.Text = "SI ES ESPECIALIZACIÓN";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(45, 590);
            label12.Name = "label12";
            label12.Size = new Size(112, 25);
            label12.TabIndex = 19;
            label12.Text = "Años Totales";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(315, 105);
            label13.Name = "label13";
            label13.Size = new Size(176, 28);
            label13.TabIndex = 21;
            label13.Text = "SI ES PREGRADO";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 321);
            label14.Name = "label14";
            label14.Size = new Size(68, 25);
            label14.TabIndex = 22;
            label14.Text = "Carrera";
            // 
            // cboCarreraEsp
            // 
            cboCarreraEsp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarreraEsp.FormattingEnabled = true;
            cboCarreraEsp.Items.AddRange(new object[] { "Seleccionar...", "Física", "Sistemas", "Inglés" });
            cboCarreraEsp.Location = new Point(85, 313);
            cboCarreraEsp.Name = "cboCarreraEsp";
            cboCarreraEsp.Size = new Size(178, 33);
            cboCarreraEsp.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 396);
            label15.Name = "label15";
            label15.Size = new Size(153, 25);
            label15.TabIndex = 24;
            label15.Text = "Carrera que ejerce";
            // 
            // cboCarreraEjercePos
            // 
            cboCarreraEjercePos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarreraEjercePos.FormattingEnabled = true;
            cboCarreraEjercePos.Items.AddRange(new object[] { "Seleccionar...", "Física", "Sistemas", "Inglés" });
            cboCarreraEjercePos.Location = new Point(167, 388);
            cboCarreraEjercePos.Name = "cboCarreraEjercePos";
            cboCarreraEjercePos.Size = new Size(98, 33);
            cboCarreraEjercePos.TabIndex = 25;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(315, 142);
            label16.Name = "label16";
            label16.Size = new Size(68, 25);
            label16.TabIndex = 26;
            label16.Text = "Carrera";
            // 
            // cboCarreraPre
            // 
            cboCarreraPre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarreraPre.FormattingEnabled = true;
            cboCarreraPre.Items.AddRange(new object[] { "Seleccionar...", "Inglés", "Español", "Sistemas", "Física" });
            cboCarreraPre.Location = new Point(386, 139);
            cboCarreraPre.Name = "cboCarreraPre";
            cboCarreraPre.Size = new Size(167, 33);
            cboCarreraPre.TabIndex = 27;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(315, 204);
            label17.Name = "label17";
            label17.Size = new Size(94, 28);
            label17.TabIndex = 28;
            label17.Text = "ACTUAL";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(315, 238);
            label18.Name = "label18";
            label18.Size = new Size(86, 25);
            label18.TabIndex = 29;
            label18.Text = "Escalafón";
            // 
            // cboEscalafon
            // 
            cboEscalafon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEscalafon.FormattingEnabled = true;
            cboEscalafon.Items.AddRange(new object[] { "Seleccionar...", "Instructor", "Profesor Auxiliar", "Instr.Asistente", "Prof.Asistente", "Prof.Asociado", "Prof.Titular" });
            cboEscalafon.Location = new Point(404, 235);
            cboEscalafon.Name = "cboEscalafon";
            cboEscalafon.Size = new Size(149, 33);
            cboEscalafon.TabIndex = 30;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(314, 282);
            label19.Name = "label19";
            label19.Size = new Size(147, 25);
            label19.TabIndex = 31;
            label19.Text = "Reintegro/Nuevo";
            // 
            // cboReintegroN
            // 
            cboReintegroN.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReintegroN.FormattingEnabled = true;
            cboReintegroN.Items.AddRange(new object[] { "Seleccionar...", "SI", "NO" });
            cboReintegroN.Location = new Point(467, 274);
            cboReintegroN.Name = "cboReintegroN";
            cboReintegroN.Size = new Size(86, 33);
            cboReintegroN.TabIndex = 32;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(315, 380);
            label20.Name = "label20";
            label20.Size = new Size(144, 28);
            label20.TabIndex = 33;
            label20.Text = "EXPERIENCIA";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(314, 417);
            label21.Name = "label21";
            label21.Size = new Size(270, 25);
            label21.TabIndex = 34;
            label21.Text = "Enseñó en colegios o parecidos?";
            // 
            // cboColegios
            // 
            cboColegios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColegios.FormattingEnabled = true;
            cboColegios.Items.AddRange(new object[] { "Seleccionar...", "SI", "NO" });
            cboColegios.Location = new Point(315, 445);
            cboColegios.Name = "cboColegios";
            cboColegios.Size = new Size(68, 33);
            cboColegios.TabIndex = 35;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(404, 448);
            label24.Name = "label24";
            label24.Size = new Size(37, 25);
            label24.TabIndex = 40;
            label24.Text = "Rol";
            // 
            // cboRolColegios
            // 
            cboRolColegios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRolColegios.FormattingEnabled = true;
            cboRolColegios.Items.AddRange(new object[] { "Seleccionar...", "Instructor", "Profesor Auxiliar", "Instr.Asistente", "Prof.Asistente", "Prof.Asociado", "Prof.Titular" });
            cboRolColegios.Location = new Point(447, 445);
            cboRolColegios.Name = "cboRolColegios";
            cboRolColegios.Size = new Size(106, 33);
            cboRolColegios.TabIndex = 41;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(315, 496);
            label22.Name = "label22";
            label22.Size = new Size(53, 25);
            label22.TabIndex = 42;
            label22.Text = "Años";
            // 
            // txtAnosColegio
            // 
            txtAnosColegio.Location = new Point(374, 493);
            txtAnosColegio.Name = "txtAnosColegio";
            txtAnosColegio.Size = new Size(179, 31);
            txtAnosColegio.TabIndex = 43;
            // 
            // txtAnosUniversidad
            // 
            txtAnosUniversidad.Location = new Point(374, 714);
            txtAnosUniversidad.Name = "txtAnosUniversidad";
            txtAnosUniversidad.Size = new Size(179, 31);
            txtAnosUniversidad.TabIndex = 49;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(315, 717);
            label23.Name = "label23";
            label23.Size = new Size(53, 25);
            label23.TabIndex = 48;
            label23.Text = "Años";
            // 
            // cboRolUniversidades
            // 
            cboRolUniversidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRolUniversidades.FormattingEnabled = true;
            cboRolUniversidades.Items.AddRange(new object[] { "Seleccionar...", "Instructor", "Profesor Auxiliar", "Instr.Asistente", "Prof.Asistente", "Prof.Asociado", "Prof.Titular" });
            cboRolUniversidades.Location = new Point(447, 666);
            cboRolUniversidades.Name = "cboRolUniversidades";
            cboRolUniversidades.Size = new Size(106, 33);
            cboRolUniversidades.TabIndex = 47;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(404, 669);
            label25.Name = "label25";
            label25.Size = new Size(37, 25);
            label25.TabIndex = 46;
            label25.Text = "Rol";
            // 
            // cboUniversidades
            // 
            cboUniversidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUniversidades.FormattingEnabled = true;
            cboUniversidades.Items.AddRange(new object[] { "Seleccionar...", "SI", "NO" });
            cboUniversidades.Location = new Point(315, 666);
            cboUniversidades.Name = "cboUniversidades";
            cboUniversidades.Size = new Size(68, 33);
            cboUniversidades.TabIndex = 45;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(314, 638);
            label26.Name = "label26";
            label26.Size = new Size(197, 25);
            label26.TabIndex = 44;
            label26.Text = "Enseñó en universidad?";
            // 
            // txtAnosDireccion
            // 
            txtAnosDireccion.Location = new Point(661, 464);
            txtAnosDireccion.Name = "txtAnosDireccion";
            txtAnosDireccion.Size = new Size(179, 31);
            txtAnosDireccion.TabIndex = 55;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(602, 467);
            label27.Name = "label27";
            label27.Size = new Size(53, 25);
            label27.TabIndex = 54;
            label27.Text = "Años";
            // 
            // cboRolDireccion
            // 
            cboRolDireccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRolDireccion.FormattingEnabled = true;
            cboRolDireccion.Items.AddRange(new object[] { "Seleccionar...", "Instructor", "Profesor Auxiliar", "Instr.Asistente", "Prof.Asistente", "Prof.Asociado", "Prof.Titular" });
            cboRolDireccion.Location = new Point(734, 416);
            cboRolDireccion.Name = "cboRolDireccion";
            cboRolDireccion.Size = new Size(106, 33);
            cboRolDireccion.TabIndex = 53;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(691, 419);
            label28.Name = "label28";
            label28.Size = new Size(37, 25);
            label28.TabIndex = 52;
            label28.Text = "Rol";
            // 
            // cboDireccion
            // 
            cboDireccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDireccion.FormattingEnabled = true;
            cboDireccion.Items.AddRange(new object[] { "Seleccionar...", "SI", "NO" });
            cboDireccion.Location = new Point(602, 416);
            cboDireccion.Name = "cboDireccion";
            cboDireccion.Size = new Size(68, 33);
            cboDireccion.TabIndex = 51;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(602, 388);
            label29.Name = "label29";
            label29.Size = new Size(344, 25);
            label29.TabIndex = 50;
            label29.Text = "Estuvo en cargos de dirección académica?";
            // 
            // txtAnosDiferentes
            // 
            txtAnosDiferentes.Location = new Point(661, 700);
            txtAnosDiferentes.Name = "txtAnosDiferentes";
            txtAnosDiferentes.Size = new Size(179, 31);
            txtAnosDiferentes.TabIndex = 61;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(602, 703);
            label30.Name = "label30";
            label30.Size = new Size(53, 25);
            label30.TabIndex = 60;
            label30.Text = "Años";
            // 
            // cboRolDiferente
            // 
            cboRolDiferente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRolDiferente.FormattingEnabled = true;
            cboRolDiferente.Items.AddRange(new object[] { "Seleccionar...", "Instructor", "Profesor Auxiliar", "Instr.Asistente", "Prof.Asistente", "Prof.Asociado", "Prof.Titular" });
            cboRolDiferente.Location = new Point(734, 652);
            cboRolDiferente.Name = "cboRolDiferente";
            cboRolDiferente.Size = new Size(106, 33);
            cboRolDiferente.TabIndex = 59;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(691, 655);
            label31.Name = "label31";
            label31.Size = new Size(37, 25);
            label31.TabIndex = 58;
            label31.Text = "Rol";
            // 
            // cboDiferente
            // 
            cboDiferente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDiferente.FormattingEnabled = true;
            cboDiferente.Items.AddRange(new object[] { "Seleccionar...", "SI", "NO" });
            cboDiferente.Location = new Point(602, 652);
            cboDiferente.Name = "cboDiferente";
            cboDiferente.Size = new Size(68, 33);
            cboDiferente.TabIndex = 57;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(602, 624);
            label32.Name = "label32";
            label32.Size = new Size(345, 25);
            label32.TabIndex = 56;
            label32.Text = "Tuvo algún trabajo diferente a la docente?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(700, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 254);
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiguiente.Location = new Point(824, 839);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(162, 70);
            btnSiguiente.TabIndex = 63;
            btnSiguiente.Text = "SIGUIENTE";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAgregarRolColegio
            // 
            btnAgregarRolColegio.Location = new Point(374, 547);
            btnAgregarRolColegio.Name = "btnAgregarRolColegio";
            btnAgregarRolColegio.Size = new Size(124, 47);
            btnAgregarRolColegio.TabIndex = 97;
            btnAgregarRolColegio.Text = "Agregar";
            btnAgregarRolColegio.UseVisualStyleBackColor = true;
            btnAgregarRolColegio.Click += btnAgregarRolColegio_Click;
            // 
            // btnAgregarRolUniversidad
            // 
            btnAgregarRolUniversidad.Location = new Point(374, 755);
            btnAgregarRolUniversidad.Name = "btnAgregarRolUniversidad";
            btnAgregarRolUniversidad.Size = new Size(124, 47);
            btnAgregarRolUniversidad.TabIndex = 98;
            btnAgregarRolUniversidad.Text = "Agregar";
            btnAgregarRolUniversidad.UseVisualStyleBackColor = true;
            btnAgregarRolUniversidad.Click += btnAgregarRolUniversidad_Click;
            // 
            // btnAgregarRolCargoDireccion
            // 
            btnAgregarRolCargoDireccion.Location = new Point(691, 518);
            btnAgregarRolCargoDireccion.Name = "btnAgregarRolCargoDireccion";
            btnAgregarRolCargoDireccion.Size = new Size(124, 47);
            btnAgregarRolCargoDireccion.TabIndex = 99;
            btnAgregarRolCargoDireccion.Text = "Agregar";
            btnAgregarRolCargoDireccion.UseVisualStyleBackColor = true;
            btnAgregarRolCargoDireccion.Click += btnAgregarRolCargoDireccion_Click;
            // 
            // btnAgregarTrabajoDiferente
            // 
            btnAgregarTrabajoDiferente.Location = new Point(691, 755);
            btnAgregarTrabajoDiferente.Name = "btnAgregarTrabajoDiferente";
            btnAgregarTrabajoDiferente.Size = new Size(124, 47);
            btnAgregarTrabajoDiferente.TabIndex = 100;
            btnAgregarTrabajoDiferente.Text = "Agregar";
            btnAgregarTrabajoDiferente.UseVisualStyleBackColor = true;
            btnAgregarTrabajoDiferente.Click += btnAgregarTrabajoDiferente_Click;
            // 
            // btnPuntaje
            // 
            btnPuntaje.Location = new Point(41, 820);
            btnPuntaje.Name = "btnPuntaje";
            btnPuntaje.Size = new Size(171, 64);
            btnPuntaje.TabIndex = 101;
            btnPuntaje.Text = "Puntaje";
            btnPuntaje.UseVisualStyleBackColor = true;
            btnPuntaje.Click += btnPuntaje_Click;
            // 
            // txtAnosTotalEspe
            // 
            txtAnosTotalEspe.Location = new Point(158, 590);
            txtAnosTotalEspe.Name = "txtAnosTotalEspe";
            txtAnosTotalEspe.Size = new Size(105, 31);
            txtAnosTotalEspe.TabIndex = 102;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 921);
            Controls.Add(txtAnosTotalEspe);
            Controls.Add(btnPuntaje);
            Controls.Add(btnAgregarTrabajoDiferente);
            Controls.Add(btnAgregarRolCargoDireccion);
            Controls.Add(btnAgregarRolUniversidad);
            Controls.Add(btnAgregarRolColegio);
            Controls.Add(btnSiguiente);
            Controls.Add(pictureBox1);
            Controls.Add(txtAnosDiferentes);
            Controls.Add(label30);
            Controls.Add(cboRolDiferente);
            Controls.Add(label31);
            Controls.Add(cboDiferente);
            Controls.Add(label32);
            Controls.Add(txtAnosDireccion);
            Controls.Add(label27);
            Controls.Add(cboRolDireccion);
            Controls.Add(label28);
            Controls.Add(cboDireccion);
            Controls.Add(label29);
            Controls.Add(txtAnosUniversidad);
            Controls.Add(label23);
            Controls.Add(cboRolUniversidades);
            Controls.Add(label25);
            Controls.Add(cboUniversidades);
            Controls.Add(label26);
            Controls.Add(txtAnosColegio);
            Controls.Add(label22);
            Controls.Add(cboRolColegios);
            Controls.Add(label24);
            Controls.Add(cboColegios);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(cboReintegroN);
            Controls.Add(label19);
            Controls.Add(cboEscalafon);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(cboCarreraPre);
            Controls.Add(label16);
            Controls.Add(cboCarreraEjercePos);
            Controls.Add(label15);
            Controls.Add(cboCarreraEsp);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtAnoMaestríaPos);
            Controls.Add(label10);
            Controls.Add(cboMaestríaPos);
            Controls.Add(label9);
            Controls.Add(cboCantidadPos);
            Controls.Add(label8);
            Controls.Add(txtAnoPos);
            Controls.Add(label6);
            Controls.Add(cboTipoPos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboMedicina);
            Controls.Add(cboTitulo1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboTitulo1;
        private ComboBox cboMedicina;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboTipoPos;
        private Label label6;
        private TextBox txtAnoPos;
        private Label label8;
        private ComboBox cboCantidadPos;
        private Label label9;
        private ComboBox cboMaestríaPos;
        private Label label10;
        private TextBox txtAnoMaestríaPos;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox cboCarreraEsp;
        private Label label15;
        private ComboBox cboCarreraEjercePos;
        private Label label16;
        private ComboBox cboCarreraPre;
        private Label label17;
        private Label label18;
        private ComboBox cboEscalafon;
        private Label label19;
        private ComboBox cboReintegroN;
        private Label label20;
        private Label label21;
        private ComboBox cboColegios;
        private Label label24;
        private ComboBox cboRolColegios;
        private Label label22;
        private TextBox txtAnosColegio;
        private TextBox txtAnosUniversidad;
        private Label label23;
        private ComboBox cboRolUniversidades;
        private Label label25;
        private ComboBox cboUniversidades;
        private Label label26;
        private TextBox txtAnosDireccion;
        private Label label27;
        private ComboBox cboRolDireccion;
        private Label label28;
        private ComboBox cboDireccion;
        private Label label29;
        private TextBox txtAnosDiferentes;
        private Label label30;
        private ComboBox cboRolDiferente;
        private Label label31;
        private ComboBox cboDiferente;
        private Label label32;
        private PictureBox pictureBox1;
        private Button btnSiguiente;
        private Button btnAgregarRolColegio;
        private Button btnAgregarRolUniversidad;
        private Button btnAgregarRolCargoDireccion;
        private Button btnAgregarTrabajoDiferente;
        private Button btnPuntaje;
        private TextBox txtAnosTotalEspe;
    }
}