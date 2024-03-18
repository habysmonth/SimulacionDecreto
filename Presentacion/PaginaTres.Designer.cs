namespace Presentacion
{
    partial class PaginaTres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label13 = new Label();
            label1 = new Label();
            cboCargosOcupados = new ComboBox();
            label2 = new Label();
            txtAnosCargosOcupados = new TextBox();
            btnAgregarCargo = new Button();
            label3 = new Label();
            cboTomarPuntos = new ComboBox();
            label4 = new Label();
            txtAñosEnCargoDirectivo = new TextBox();
            btnAgregarCargoOcupado = new Button();
            label5 = new Label();
            txtSalarioBase = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cboPonencias = new ComboBox();
            label8 = new Label();
            txtCantidadPonencias = new TextBox();
            label9 = new Label();
            cboImpactoPonencias = new ComboBox();
            btnAgregarPonencia = new Button();
            label10 = new Label();
            cboPublicaciones = new ComboBox();
            label11 = new Label();
            txtCantidadPublicaciones = new TextBox();
            txtEstudiosPostDoctorales = new TextBox();
            label12 = new Label();
            cboEstudiosPosDoctorales = new ComboBox();
            label14 = new Label();
            txtCriticasValidas = new TextBox();
            label15 = new Label();
            cboCriticasValidas = new ComboBox();
            label16 = new Label();
            txtTradArtiReconocidos = new TextBox();
            label17 = new Label();
            cboTradArticulos = new ComboBox();
            label18 = new Label();
            txtTesisIndividuales = new TextBox();
            label19 = new Label();
            cboTesisIndividuales = new ComboBox();
            label20 = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(12, 29);
            label13.Name = "label13";
            label13.Size = new Size(126, 28);
            label13.TabIndex = 23;
            label13.Text = "ADICIONAL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(365, 25);
            label1.TabIndex = 24;
            label1.Text = "Ha ocupado alguno de los siguientes cargos";
            // 
            // cboCargosOcupados
            // 
            cboCargosOcupados.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargosOcupados.FormattingEnabled = true;
            cboCargosOcupados.Items.AddRange(new object[] { "Ninguno...", "Rector de la Universidad", "Los Vicerrectores", "Secretario General", "Director Administrativo General", "Los Decanos", "Director o jefe de división", "Jefes de oficina", "Directores de oficinas de investigación", "Vicedecano", "Director administrativos de Sede", "Director de Departamento", "Director de escuela", "Director de instituto" });
            cboCargosOcupados.Location = new Point(12, 97);
            cboCargosOcupados.Name = "cboCargosOcupados";
            cboCargosOcupados.Size = new Size(246, 33);
            cboCargosOcupados.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 26;
            label2.Text = "Años en el cargo";
            // 
            // txtAnosCargosOcupados
            // 
            txtAnosCargosOcupados.Location = new Point(163, 136);
            txtAnosCargosOcupados.Name = "txtAnosCargosOcupados";
            txtAnosCargosOcupados.Size = new Size(95, 31);
            txtAnosCargosOcupados.TabIndex = 27;
            // 
            // btnAgregarCargo
            // 
            btnAgregarCargo.Location = new Point(73, 192);
            btnAgregarCargo.Name = "btnAgregarCargo";
            btnAgregarCargo.Size = new Size(120, 43);
            btnAgregarCargo.TabIndex = 28;
            btnAgregarCargo.Text = "Agregar";
            btnAgregarCargo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 261);
            label3.Name = "label3";
            label3.Size = new Size(334, 50);
            label3.TabIndex = 29;
            label3.Text = "En esos años que estuvo en dicho cargo\r\ntomo puntos como docente o directivo?";
            // 
            // cboTomarPuntos
            // 
            cboTomarPuntos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTomarPuntos.FormattingEnabled = true;
            cboTomarPuntos.Items.AddRange(new object[] { "Docente", "Directivo" });
            cboTomarPuntos.Location = new Point(12, 329);
            cboTomarPuntos.Name = "cboTomarPuntos";
            cboTomarPuntos.Size = new Size(246, 33);
            cboTomarPuntos.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 374);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 31;
            label4.Text = "Años";
            // 
            // txtAñosEnCargoDirectivo
            // 
            txtAñosEnCargoDirectivo.Location = new Point(73, 368);
            txtAñosEnCargoDirectivo.Name = "txtAñosEnCargoDirectivo";
            txtAñosEnCargoDirectivo.Size = new Size(187, 31);
            txtAñosEnCargoDirectivo.TabIndex = 32;
            // 
            // btnAgregarCargoOcupado
            // 
            btnAgregarCargoOcupado.Location = new Point(73, 422);
            btnAgregarCargoOcupado.Name = "btnAgregarCargoOcupado";
            btnAgregarCargoOcupado.Size = new Size(120, 43);
            btnAgregarCargoOcupado.TabIndex = 33;
            btnAgregarCargoOcupado.Text = "Agregar";
            btnAgregarCargoOcupado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 521);
            label5.Name = "label5";
            label5.Size = new Size(157, 28);
            label5.TabIndex = 34;
            label5.Text = "SALARIO BASE";
            // 
            // txtSalarioBase
            // 
            txtSalarioBase.Location = new Point(12, 552);
            txtSalarioBase.Name = "txtSalarioBase";
            txtSalarioBase.Size = new Size(246, 31);
            txtSalarioBase.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 638);
            label6.Name = "label6";
            label6.Size = new Size(246, 28);
            label6.TabIndex = 36;
            label6.Text = "APORTES ADICIONALES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 666);
            label7.Name = "label7";
            label7.Size = new Size(350, 50);
            label7.TabIndex = 37;
            label7.Text = "Usted ha realizado alguna ponencia en los \r\naños anteriores?";
            // 
            // cboPonencias
            // 
            cboPonencias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPonencias.FormattingEnabled = true;
            cboPonencias.Items.AddRange(new object[] { "Seleccionar...", "SI", "NO" });
            cboPonencias.Location = new Point(12, 719);
            cboPonencias.Name = "cboPonencias";
            cboPonencias.Size = new Size(246, 33);
            cboPonencias.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 764);
            label8.Name = "label8";
            label8.Size = new Size(83, 25);
            label8.TabIndex = 39;
            label8.Text = "Cantidad";
            // 
            // txtCantidadPonencias
            // 
            txtCantidadPonencias.Location = new Point(101, 758);
            txtCantidadPonencias.Name = "txtCantidadPonencias";
            txtCantidadPonencias.Size = new Size(157, 31);
            txtCantidadPonencias.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 803);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 41;
            label9.Text = "Impacto";
            // 
            // cboImpactoPonencias
            // 
            cboImpactoPonencias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboImpactoPonencias.FormattingEnabled = true;
            cboImpactoPonencias.Items.AddRange(new object[] { "Seleccionar...", "Internacional", "Nacional", "Regional" });
            cboImpactoPonencias.Location = new Point(101, 795);
            cboImpactoPonencias.Name = "cboImpactoPonencias";
            cboImpactoPonencias.Size = new Size(157, 33);
            cboImpactoPonencias.TabIndex = 42;
            // 
            // btnAgregarPonencia
            // 
            btnAgregarPonencia.Location = new Point(73, 853);
            btnAgregarPonencia.Name = "btnAgregarPonencia";
            btnAgregarPonencia.Size = new Size(120, 43);
            btnAgregarPonencia.TabIndex = 43;
            btnAgregarPonencia.Text = "Agregar";
            btnAgregarPonencia.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(532, 69);
            label10.Name = "label10";
            label10.Size = new Size(328, 50);
            label10.TabIndex = 44;
            label10.Text = "Usted ha hecho publicaciones impresas \r\nUniversitarias de impacto?";
            // 
            // cboPublicaciones
            // 
            cboPublicaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPublicaciones.FormattingEnabled = true;
            cboPublicaciones.Items.AddRange(new object[] { "Seleccionar...", "SI", "NO" });
            cboPublicaciones.Location = new Point(532, 122);
            cboPublicaciones.Name = "cboPublicaciones";
            cboPublicaciones.Size = new Size(183, 33);
            cboPublicaciones.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(532, 167);
            label11.Name = "label11";
            label11.Size = new Size(83, 25);
            label11.TabIndex = 46;
            label11.Text = "Cantidad";
            // 
            // txtCantidadPublicaciones
            // 
            txtCantidadPublicaciones.Location = new Point(621, 161);
            txtCantidadPublicaciones.Name = "txtCantidadPublicaciones";
            txtCantidadPublicaciones.Size = new Size(94, 31);
            txtCantidadPublicaciones.TabIndex = 47;
            // 
            // txtEstudiosPostDoctorales
            // 
            txtEstudiosPostDoctorales.Location = new Point(621, 289);
            txtEstudiosPostDoctorales.Name = "txtEstudiosPostDoctorales";
            txtEstudiosPostDoctorales.Size = new Size(94, 31);
            txtEstudiosPostDoctorales.TabIndex = 51;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(532, 295);
            label12.Name = "label12";
            label12.Size = new Size(83, 25);
            label12.TabIndex = 50;
            label12.Text = "Cantidad";
            // 
            // cboEstudiosPosDoctorales
            // 
            cboEstudiosPosDoctorales.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstudiosPosDoctorales.FormattingEnabled = true;
            cboEstudiosPosDoctorales.Items.AddRange(new object[] { "Seleccionar...", "SI", "NO" });
            cboEstudiosPosDoctorales.Location = new Point(532, 250);
            cboEstudiosPosDoctorales.Name = "cboEstudiosPosDoctorales";
            cboEstudiosPosDoctorales.Size = new Size(183, 33);
            cboEstudiosPosDoctorales.TabIndex = 49;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(532, 222);
            label14.Name = "label14";
            label14.Size = new Size(305, 25);
            label14.TabIndex = 48;
            label14.Text = "Usted tiene estudios postdoctorales?";
            // 
            // txtCriticasValidas
            // 
            txtCriticasValidas.Location = new Point(621, 448);
            txtCriticasValidas.Name = "txtCriticasValidas";
            txtCriticasValidas.Size = new Size(94, 31);
            txtCriticasValidas.TabIndex = 55;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(532, 454);
            label15.Name = "label15";
            label15.Size = new Size(83, 25);
            label15.TabIndex = 54;
            label15.Text = "Cantidad";
            // 
            // cboCriticasValidas
            // 
            cboCriticasValidas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCriticasValidas.FormattingEnabled = true;
            cboCriticasValidas.Items.AddRange(new object[] { "Seleccionar...", "SI", "NO" });
            cboCriticasValidas.Location = new Point(532, 409);
            cboCriticasValidas.Name = "cboCriticasValidas";
            cboCriticasValidas.Size = new Size(183, 33);
            cboCriticasValidas.TabIndex = 53;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(532, 356);
            label16.Name = "label16";
            label16.Size = new Size(321, 50);
            label16.TabIndex = 52;
            label16.Text = "Usted ha hecho reseñas criticas válidas \r\ny reconocidas?";
            // 
            // txtTradArtiReconocidos
            // 
            txtTradArtiReconocidos.Location = new Point(621, 614);
            txtTradArtiReconocidos.Name = "txtTradArtiReconocidos";
            txtTradArtiReconocidos.Size = new Size(94, 31);
            txtTradArtiReconocidos.TabIndex = 59;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(532, 620);
            label17.Name = "label17";
            label17.Size = new Size(83, 25);
            label17.TabIndex = 58;
            label17.Text = "Cantidad";
            // 
            // cboTradArticulos
            // 
            cboTradArticulos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTradArticulos.FormattingEnabled = true;
            cboTradArticulos.Items.AddRange(new object[] { "Seleccionar...", "SI", "NO" });
            cboTradArticulos.Location = new Point(532, 575);
            cboTradArticulos.Name = "cboTradArticulos";
            cboTradArticulos.Size = new Size(183, 33);
            cboTradArticulos.TabIndex = 57;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(532, 522);
            label18.Name = "label18";
            label18.Size = new Size(275, 50);
            label18.TabIndex = 56;
            label18.Text = "Usted ha traducido articulos y se \r\nhan reconocido?";
            // 
            // txtTesisIndividuales
            // 
            txtTesisIndividuales.Location = new Point(621, 758);
            txtTesisIndividuales.Name = "txtTesisIndividuales";
            txtTesisIndividuales.Size = new Size(94, 31);
            txtTesisIndividuales.TabIndex = 63;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(532, 764);
            label19.Name = "label19";
            label19.Size = new Size(83, 25);
            label19.TabIndex = 62;
            label19.Text = "Cantidad";
            // 
            // cboTesisIndividuales
            // 
            cboTesisIndividuales.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTesisIndividuales.FormattingEnabled = true;
            cboTesisIndividuales.Items.AddRange(new object[] { "Seleccionar...", "SI", "NO" });
            cboTesisIndividuales.Location = new Point(532, 719);
            cboTesisIndividuales.Name = "cboTesisIndividuales";
            cboTesisIndividuales.Size = new Size(183, 33);
            cboTesisIndividuales.TabIndex = 61;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(532, 691);
            label20.Name = "label20";
            label20.Size = new Size(321, 25);
            label20.TabIndex = 60;
            label20.Text = "Usted ha dirijido individualmente tesis?";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(781, 845);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(149, 68);
            btnCalcular.TabIndex = 64;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // PaginaTres
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 939);
            Controls.Add(btnCalcular);
            Controls.Add(txtTesisIndividuales);
            Controls.Add(label19);
            Controls.Add(cboTesisIndividuales);
            Controls.Add(label20);
            Controls.Add(txtTradArtiReconocidos);
            Controls.Add(label17);
            Controls.Add(cboTradArticulos);
            Controls.Add(label18);
            Controls.Add(txtCriticasValidas);
            Controls.Add(label15);
            Controls.Add(cboCriticasValidas);
            Controls.Add(label16);
            Controls.Add(txtEstudiosPostDoctorales);
            Controls.Add(label12);
            Controls.Add(cboEstudiosPosDoctorales);
            Controls.Add(label14);
            Controls.Add(txtCantidadPublicaciones);
            Controls.Add(label11);
            Controls.Add(cboPublicaciones);
            Controls.Add(label10);
            Controls.Add(btnAgregarPonencia);
            Controls.Add(cboImpactoPonencias);
            Controls.Add(label9);
            Controls.Add(txtCantidadPonencias);
            Controls.Add(label8);
            Controls.Add(cboPonencias);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtSalarioBase);
            Controls.Add(label5);
            Controls.Add(btnAgregarCargoOcupado);
            Controls.Add(txtAñosEnCargoDirectivo);
            Controls.Add(label4);
            Controls.Add(cboTomarPuntos);
            Controls.Add(label3);
            Controls.Add(btnAgregarCargo);
            Controls.Add(txtAnosCargosOcupados);
            Controls.Add(label2);
            Controls.Add(cboCargosOcupados);
            Controls.Add(label1);
            Controls.Add(label13);
            Name = "PaginaTres";
            Text = "PaginaTres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private Label label1;
        private ComboBox cboCargosOcupados;
        private Label label2;
        private TextBox txtAnosCargosOcupados;
        private Button btnAgregarCargo;
        private Label label3;
        private ComboBox cboTomarPuntos;
        private Label label4;
        private TextBox txtAñosEnCargoDirectivo;
        private Button btnAgregarCargoOcupado;
        private Label label5;
        private TextBox txtSalarioBase;
        private Label label6;
        private Label label7;
        private ComboBox cboPonencias;
        private Label label8;
        private TextBox txtCantidadPonencias;
        private Label label9;
        private ComboBox cboImpactoPonencias;
        private Button btnAgregarPonencia;
        private Label label10;
        private ComboBox cboPublicaciones;
        private Label label11;
        private TextBox txtCantidadPublicaciones;
        private TextBox txtEstudiosPostDoctorales;
        private Label label12;
        private ComboBox cboEstudiosPosDoctorales;
        private Label label14;
        private TextBox txtCriticasValidas;
        private Label label15;
        private ComboBox cboCriticasValidas;
        private Label label16;
        private TextBox txtTradArtiReconocidos;
        private Label label17;
        private ComboBox cboTradArticulos;
        private Label label18;
        private TextBox txtTesisIndividuales;
        private Label label19;
        private ComboBox cboTesisIndividuales;
        private Label label20;
        private Button btnCalcular;
    }
}