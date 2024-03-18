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
            label1 = new Label();
            txtValorPunto = new TextBox();
            label2 = new Label();
            txtInflación = new TextBox();
            label3 = new Label();
            cboTipoTesis = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(49, 91);
            label5.Name = "label5";
            label5.Size = new Size(157, 28);
            label5.TabIndex = 34;
            label5.Text = "SALARIO BASE";
            // 
            // txtSalarioBase
            // 
            txtSalarioBase.Location = new Point(49, 122);
            txtSalarioBase.Name = "txtSalarioBase";
            txtSalarioBase.Size = new Size(246, 31);
            txtSalarioBase.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(49, 208);
            label6.Name = "label6";
            label6.Size = new Size(246, 28);
            label6.TabIndex = 36;
            label6.Text = "APORTES ADICIONALES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 236);
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
            cboPonencias.Location = new Point(49, 289);
            cboPonencias.Name = "cboPonencias";
            cboPonencias.Size = new Size(246, 33);
            cboPonencias.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 334);
            label8.Name = "label8";
            label8.Size = new Size(83, 25);
            label8.TabIndex = 39;
            label8.Text = "Cantidad";
            // 
            // txtCantidadPonencias
            // 
            txtCantidadPonencias.Location = new Point(138, 328);
            txtCantidadPonencias.Name = "txtCantidadPonencias";
            txtCantidadPonencias.Size = new Size(157, 31);
            txtCantidadPonencias.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 373);
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
            cboImpactoPonencias.Location = new Point(138, 365);
            cboImpactoPonencias.Name = "cboImpactoPonencias";
            cboImpactoPonencias.Size = new Size(157, 33);
            cboImpactoPonencias.TabIndex = 42;
            // 
            // btnAgregarPonencia
            // 
            btnAgregarPonencia.Location = new Point(110, 423);
            btnAgregarPonencia.Name = "btnAgregarPonencia";
            btnAgregarPonencia.Size = new Size(120, 43);
            btnAgregarPonencia.TabIndex = 43;
            btnAgregarPonencia.Text = "Agregar";
            btnAgregarPonencia.UseVisualStyleBackColor = true;
            btnAgregarPonencia.Click += btnAgregarPonencia_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(49, 486);
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
            cboPublicaciones.Location = new Point(49, 539);
            cboPublicaciones.Name = "cboPublicaciones";
            cboPublicaciones.Size = new Size(183, 33);
            cboPublicaciones.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 584);
            label11.Name = "label11";
            label11.Size = new Size(83, 25);
            label11.TabIndex = 46;
            label11.Text = "Cantidad";
            // 
            // txtCantidadPublicaciones
            // 
            txtCantidadPublicaciones.Location = new Point(138, 578);
            txtCantidadPublicaciones.Name = "txtCantidadPublicaciones";
            txtCantidadPublicaciones.Size = new Size(94, 31);
            txtCantidadPublicaciones.TabIndex = 47;
            // 
            // txtEstudiosPostDoctorales
            // 
            txtEstudiosPostDoctorales.Location = new Point(138, 706);
            txtEstudiosPostDoctorales.Name = "txtEstudiosPostDoctorales";
            txtEstudiosPostDoctorales.Size = new Size(94, 31);
            txtEstudiosPostDoctorales.TabIndex = 51;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(49, 712);
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
            cboEstudiosPosDoctorales.Location = new Point(49, 667);
            cboEstudiosPosDoctorales.Name = "cboEstudiosPosDoctorales";
            cboEstudiosPosDoctorales.Size = new Size(183, 33);
            cboEstudiosPosDoctorales.TabIndex = 49;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(49, 639);
            label14.Name = "label14";
            label14.Size = new Size(305, 25);
            label14.TabIndex = 48;
            label14.Text = "Usted tiene estudios postdoctorales?";
            // 
            // txtCriticasValidas
            // 
            txtCriticasValidas.Location = new Point(604, 159);
            txtCriticasValidas.Name = "txtCriticasValidas";
            txtCriticasValidas.Size = new Size(113, 31);
            txtCriticasValidas.TabIndex = 55;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(515, 165);
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
            cboCriticasValidas.Location = new Point(515, 120);
            cboCriticasValidas.Name = "cboCriticasValidas";
            cboCriticasValidas.Size = new Size(202, 33);
            cboCriticasValidas.TabIndex = 53;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(515, 67);
            label16.Name = "label16";
            label16.Size = new Size(321, 50);
            label16.TabIndex = 52;
            label16.Text = "Usted ha hecho reseñas criticas válidas \r\ny reconocidas?";
            // 
            // txtTradArtiReconocidos
            // 
            txtTradArtiReconocidos.Location = new Point(604, 328);
            txtTradArtiReconocidos.Name = "txtTradArtiReconocidos";
            txtTradArtiReconocidos.Size = new Size(113, 31);
            txtTradArtiReconocidos.TabIndex = 59;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(515, 334);
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
            cboTradArticulos.Location = new Point(515, 289);
            cboTradArticulos.Name = "cboTradArticulos";
            cboTradArticulos.Size = new Size(202, 33);
            cboTradArticulos.TabIndex = 57;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(515, 236);
            label18.Name = "label18";
            label18.Size = new Size(275, 50);
            label18.TabIndex = 56;
            label18.Text = "Usted ha traducido articulos y se \r\nhan reconocido?";
            // 
            // txtTesisIndividuales
            // 
            txtTesisIndividuales.Location = new Point(604, 456);
            txtTesisIndividuales.Name = "txtTesisIndividuales";
            txtTesisIndividuales.Size = new Size(113, 31);
            txtTesisIndividuales.TabIndex = 63;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(515, 462);
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
            cboTesisIndividuales.Location = new Point(515, 417);
            cboTesisIndividuales.Name = "cboTesisIndividuales";
            cboTesisIndividuales.Size = new Size(104, 33);
            cboTesisIndividuales.TabIndex = 61;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(515, 389);
            label20.Name = "label20";
            label20.Size = new Size(321, 25);
            label20.TabIndex = 60;
            label20.Text = "Usted ha dirijido individualmente tesis?";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(716, 712);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(149, 68);
            btnCalcular.TabIndex = 64;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(515, 539);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 65;
            label1.Text = "Valor Punto";
            // 
            // txtValorPunto
            // 
            txtValorPunto.Location = new Point(625, 536);
            txtValorPunto.Name = "txtValorPunto";
            txtValorPunto.Size = new Size(92, 31);
            txtValorPunto.TabIndex = 66;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 599);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 67;
            label2.Text = "Inflación";
            // 
            // txtInflación
            // 
            txtInflación.Location = new Point(604, 596);
            txtInflación.Name = "txtInflación";
            txtInflación.Size = new Size(113, 31);
            txtInflación.TabIndex = 68;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(636, 420);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 69;
            label3.Text = "Tipo";
            // 
            // cboTipoTesis
            // 
            cboTipoTesis.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoTesis.FormattingEnabled = true;
            cboTipoTesis.Items.AddRange(new object[] { "Seleccionar...", "Ph. D", "Doctorado", "Maestría" });
            cboTipoTesis.Location = new Point(689, 417);
            cboTipoTesis.Name = "cboTipoTesis";
            cboTipoTesis.Size = new Size(117, 33);
            cboTipoTesis.TabIndex = 70;
            // 
            // PaginaTres
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 823);
            Controls.Add(cboTipoTesis);
            Controls.Add(label3);
            Controls.Add(txtInflación);
            Controls.Add(label2);
            Controls.Add(txtValorPunto);
            Controls.Add(label1);
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
            Name = "PaginaTres";
            Text = "PaginaTres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label1;
        private TextBox txtValorPunto;
        private Label label2;
        private TextBox txtInflación;
        private Label label3;
        private ComboBox cboTipoTesis;
    }
}