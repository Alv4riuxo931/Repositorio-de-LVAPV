namespace Primer_Parcial
{
    partial class frmUno
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUno));
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.lblTelefonoF = new System.Windows.Forms.Label();
            this.lblTelefonoM = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.txtTelefonoF = new System.Windows.Forms.TextBox();
            this.txtTelefonoM = new System.Windows.Forms.TextBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbN = new System.Windows.Forms.RadioButton();
            this.rdbE = new System.Windows.Forms.RadioButton();
            this.grpFotografia = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDatosCarrera = new System.Windows.Forms.GroupBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.chcServicio = new System.Windows.Forms.CheckBox();
            this.grpDocumentos = new System.Windows.Forms.GroupBox();
            this.chcSolicitud = new System.Windows.Forms.CheckBox();
            this.chcCartaCompromiso = new System.Windows.Forms.CheckBox();
            this.chcCurriculum = new System.Windows.Forms.CheckBox();
            this.chcEntrevista = new System.Windows.Forms.CheckBox();
            this.chcEmpresas = new System.Windows.Forms.CheckBox();
            this.chcCartaAceptacion = new System.Windows.Forms.CheckBox();
            this.chcSeguroMedico = new System.Windows.Forms.CheckBox();
            this.chcCartaPresentacion = new System.Windows.Forms.CheckBox();
            this.chcCartaLiberacion = new System.Windows.Forms.CheckBox();
            this.grpDatosEmpresa = new System.Windows.Forms.GroupBox();
            this.grpDatosPersonales.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.grpFotografia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpDatosCarrera.SuspendLayout();
            this.grpDocumentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.txtTelefonoM);
            this.grpDatosPersonales.Controls.Add(this.txtTelefonoF);
            this.grpDatosPersonales.Controls.Add(this.txtApellidoM);
            this.grpDatosPersonales.Controls.Add(this.txtApellidoP);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblTelefonoM);
            this.grpDatosPersonales.Controls.Add(this.lblTelefonoF);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoM);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoP);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(427, 199);
            this.grpDatosPersonales.TabIndex = 0;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoP.Location = new System.Drawing.Point(12, 62);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoP.TabIndex = 1;
            this.lblApellidoP.Text = "Apellido Paterno:";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(12, 96);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoM.TabIndex = 2;
            this.lblApellidoM.Text = "Apellido Materno:";
            // 
            // lblTelefonoF
            // 
            this.lblTelefonoF.AutoSize = true;
            this.lblTelefonoF.Location = new System.Drawing.Point(12, 131);
            this.lblTelefonoF.Name = "lblTelefonoF";
            this.lblTelefonoF.Size = new System.Drawing.Size(71, 13);
            this.lblTelefonoF.TabIndex = 3;
            this.lblTelefonoF.Text = "Teléfono Fijo:";
            // 
            // lblTelefonoM
            // 
            this.lblTelefonoM.AutoSize = true;
            this.lblTelefonoM.Location = new System.Drawing.Point(12, 161);
            this.lblTelefonoM.Name = "lblTelefonoM";
            this.lblTelefonoM.Size = new System.Drawing.Size(80, 13);
            this.lblTelefonoM.TabIndex = 4;
            this.lblTelefonoM.Text = "Teléfono Móbil:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(142, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(142, 59);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(276, 20);
            this.txtApellidoP.TabIndex = 5;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(142, 93);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(276, 20);
            this.txtApellidoM.TabIndex = 6;
            // 
            // txtTelefonoF
            // 
            this.txtTelefonoF.Location = new System.Drawing.Point(142, 128);
            this.txtTelefonoF.Name = "txtTelefonoF";
            this.txtTelefonoF.Size = new System.Drawing.Size(276, 20);
            this.txtTelefonoF.TabIndex = 7;
            // 
            // txtTelefonoM
            // 
            this.txtTelefonoM.Location = new System.Drawing.Point(142, 158);
            this.txtTelefonoM.Name = "txtTelefonoM";
            this.txtTelefonoM.Size = new System.Drawing.Size(276, 20);
            this.txtTelefonoM.TabIndex = 8;
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbF);
            this.grpGenero.Controls.Add(this.rdbM);
            this.grpGenero.Location = new System.Drawing.Point(448, 12);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(62, 89);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            this.grpGenero.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rdbE);
            this.grpTipo.Controls.Add(this.rdbN);
            this.grpTipo.Location = new System.Drawing.Point(448, 122);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(62, 89);
            this.grpTipo.TabIndex = 2;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(7, 28);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(34, 17);
            this.rdbM.TabIndex = 0;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(7, 62);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(31, 17);
            this.rdbF.TabIndex = 3;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbN
            // 
            this.rdbN.AutoSize = true;
            this.rdbN.Location = new System.Drawing.Point(7, 29);
            this.rdbN.Name = "rdbN";
            this.rdbN.Size = new System.Drawing.Size(33, 17);
            this.rdbN.TabIndex = 0;
            this.rdbN.TabStop = true;
            this.rdbN.Text = "N";
            this.rdbN.UseVisualStyleBackColor = true;
            // 
            // rdbE
            // 
            this.rdbE.AutoSize = true;
            this.rdbE.Location = new System.Drawing.Point(7, 64);
            this.rdbE.Name = "rdbE";
            this.rdbE.Size = new System.Drawing.Size(32, 17);
            this.rdbE.TabIndex = 3;
            this.rdbE.TabStop = true;
            this.rdbE.Text = "E";
            this.rdbE.UseVisualStyleBackColor = true;
            // 
            // grpFotografia
            // 
            this.grpFotografia.Controls.Add(this.pictureBox1);
            this.grpFotografia.Location = new System.Drawing.Point(516, 12);
            this.grpFotografia.Name = "grpFotografia";
            this.grpFotografia.Size = new System.Drawing.Size(221, 199);
            this.grpFotografia.TabIndex = 4;
            this.grpFotografia.TabStop = false;
            this.grpFotografia.Text = "Fotografía";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // grpDatosCarrera
            // 
            this.grpDatosCarrera.Controls.Add(this.chcServicio);
            this.grpDatosCarrera.Controls.Add(this.txtPromedio);
            this.grpDatosCarrera.Controls.Add(this.cmbSemestre);
            this.grpDatosCarrera.Controls.Add(this.cmbCarrera);
            this.grpDatosCarrera.Controls.Add(this.lblPromedio);
            this.grpDatosCarrera.Controls.Add(this.lblSemestre);
            this.grpDatosCarrera.Controls.Add(this.lblCarrera);
            this.grpDatosCarrera.Location = new System.Drawing.Point(12, 217);
            this.grpDatosCarrera.Name = "grpDatosCarrera";
            this.grpDatosCarrera.Size = new System.Drawing.Size(725, 123);
            this.grpDatosCarrera.TabIndex = 5;
            this.grpDatosCarrera.TabStop = false;
            this.grpDatosCarrera.Text = "Datos Carrera";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(12, 28);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(44, 13);
            this.lblCarrera.TabIndex = 6;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(12, 60);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(54, 13);
            this.lblSemestre.TabIndex = 7;
            this.lblSemestre.Text = "Semestre:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(12, 94);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(51, 13);
            this.lblPromedio.TabIndex = 8;
            this.lblPromedio.Text = "Promedio";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.IntegralHeight = false;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Mecatrónica",
            "Industrial",
            "Software",
            "IT"});
            this.cmbCarrera.Location = new System.Drawing.Point(142, 25);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(577, 21);
            this.cmbCarrera.TabIndex = 9;
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Items.AddRange(new object[] {
            "Sexto Semestre",
            "Séptimo Semestre",
            "Octavo Semestre",
            "Noveno Semestre"});
            this.cmbSemestre.Location = new System.Drawing.Point(142, 60);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(577, 21);
            this.cmbSemestre.TabIndex = 10;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(142, 91);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(148, 20);
            this.txtPromedio.TabIndex = 11;
            // 
            // chcServicio
            // 
            this.chcServicio.AutoSize = true;
            this.chcServicio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcServicio.Location = new System.Drawing.Point(583, 94);
            this.chcServicio.Name = "chcServicio";
            this.chcServicio.Size = new System.Drawing.Size(136, 17);
            this.chcServicio.TabIndex = 6;
            this.chcServicio.Text = "Servicio Social Incluido";
            this.chcServicio.UseVisualStyleBackColor = true;
            // 
            // grpDocumentos
            // 
            this.grpDocumentos.Controls.Add(this.chcCartaLiberacion);
            this.grpDocumentos.Controls.Add(this.chcCartaPresentacion);
            this.grpDocumentos.Controls.Add(this.chcSeguroMedico);
            this.grpDocumentos.Controls.Add(this.chcCartaAceptacion);
            this.grpDocumentos.Controls.Add(this.chcEmpresas);
            this.grpDocumentos.Controls.Add(this.chcEntrevista);
            this.grpDocumentos.Controls.Add(this.chcCurriculum);
            this.grpDocumentos.Controls.Add(this.chcCartaCompromiso);
            this.grpDocumentos.Controls.Add(this.chcSolicitud);
            this.grpDocumentos.Location = new System.Drawing.Point(12, 346);
            this.grpDocumentos.Name = "grpDocumentos";
            this.grpDocumentos.Size = new System.Drawing.Size(725, 91);
            this.grpDocumentos.TabIndex = 6;
            this.grpDocumentos.TabStop = false;
            this.grpDocumentos.Text = "Documentos Entregados";
            // 
            // chcSolicitud
            // 
            this.chcSolicitud.AutoSize = true;
            this.chcSolicitud.Location = new System.Drawing.Point(15, 19);
            this.chcSolicitud.Name = "chcSolicitud";
            this.chcSolicitud.Size = new System.Drawing.Size(173, 17);
            this.chcSolicitud.TabIndex = 0;
            this.chcSolicitud.Text = "Solicitud Práticas Profesionales";
            this.chcSolicitud.UseVisualStyleBackColor = true;
            // 
            // chcCartaCompromiso
            // 
            this.chcCartaCompromiso.AutoSize = true;
            this.chcCartaCompromiso.Location = new System.Drawing.Point(15, 42);
            this.chcCartaCompromiso.Name = "chcCartaCompromiso";
            this.chcCartaCompromiso.Size = new System.Drawing.Size(111, 17);
            this.chcCartaCompromiso.TabIndex = 1;
            this.chcCartaCompromiso.Text = "Carta Compromiso";
            this.chcCartaCompromiso.UseVisualStyleBackColor = true;
            // 
            // chcCurriculum
            // 
            this.chcCurriculum.AutoSize = true;
            this.chcCurriculum.Location = new System.Drawing.Point(15, 65);
            this.chcCurriculum.Name = "chcCurriculum";
            this.chcCurriculum.Size = new System.Drawing.Size(104, 17);
            this.chcCurriculum.TabIndex = 2;
            this.chcCurriculum.Text = "Currículum Vitae";
            this.chcCurriculum.UseVisualStyleBackColor = true;
            // 
            // chcEntrevista
            // 
            this.chcEntrevista.AutoSize = true;
            this.chcEntrevista.Location = new System.Drawing.Point(282, 19);
            this.chcEntrevista.Name = "chcEntrevista";
            this.chcEntrevista.Size = new System.Drawing.Size(161, 17);
            this.chcEntrevista.TabIndex = 3;
            this.chcEntrevista.Text = "Entrevista por Competencias";
            this.chcEntrevista.UseVisualStyleBackColor = true;
            // 
            // chcEmpresas
            // 
            this.chcEmpresas.AutoSize = true;
            this.chcEmpresas.Location = new System.Drawing.Point(282, 42);
            this.chcEmpresas.Name = "chcEmpresas";
            this.chcEmpresas.Size = new System.Drawing.Size(137, 17);
            this.chcEmpresas.TabIndex = 4;
            this.chcEmpresas.Text = "Selección de Empresas";
            this.chcEmpresas.UseVisualStyleBackColor = true;
            // 
            // chcCartaAceptacion
            // 
            this.chcCartaAceptacion.AutoSize = true;
            this.chcCartaAceptacion.Location = new System.Drawing.Point(282, 65);
            this.chcCartaAceptacion.Name = "chcCartaAceptacion";
            this.chcCartaAceptacion.Size = new System.Drawing.Size(123, 17);
            this.chcCartaAceptacion.TabIndex = 5;
            this.chcCartaAceptacion.Text = "Carta de Aceptación";
            this.chcCartaAceptacion.UseVisualStyleBackColor = true;
            // 
            // chcSeguroMedico
            // 
            this.chcSeguroMedico.AutoSize = true;
            this.chcSeguroMedico.Location = new System.Drawing.Point(519, 19);
            this.chcSeguroMedico.Name = "chcSeguroMedico";
            this.chcSeguroMedico.Size = new System.Drawing.Size(154, 17);
            this.chcSeguroMedico.TabIndex = 6;
            this.chcSeguroMedico.Text = "Seguro de Gastos Médicos";
            this.chcSeguroMedico.UseVisualStyleBackColor = true;
            // 
            // chcCartaPresentacion
            // 
            this.chcCartaPresentacion.AutoSize = true;
            this.chcCartaPresentacion.Location = new System.Drawing.Point(519, 42);
            this.chcCartaPresentacion.Name = "chcCartaPresentacion";
            this.chcCartaPresentacion.Size = new System.Drawing.Size(131, 17);
            this.chcCartaPresentacion.TabIndex = 7;
            this.chcCartaPresentacion.Text = "Carta de Presentación";
            this.chcCartaPresentacion.UseVisualStyleBackColor = true;
            // 
            // chcCartaLiberacion
            // 
            this.chcCartaLiberacion.AutoSize = true;
            this.chcCartaLiberacion.Location = new System.Drawing.Point(519, 65);
            this.chcCartaLiberacion.Name = "chcCartaLiberacion";
            this.chcCartaLiberacion.Size = new System.Drawing.Size(118, 17);
            this.chcCartaLiberacion.TabIndex = 8;
            this.chcCartaLiberacion.Text = "Carta de Liberación";
            this.chcCartaLiberacion.UseVisualStyleBackColor = true;
            // 
            // grpDatosEmpresa
            // 
            this.grpDatosEmpresa.Location = new System.Drawing.Point(12, 443);
            this.grpDatosEmpresa.Name = "grpDatosEmpresa";
            this.grpDatosEmpresa.Size = new System.Drawing.Size(725, 200);
            this.grpDatosEmpresa.TabIndex = 7;
            this.grpDatosEmpresa.TabStop = false;
            this.grpDatosEmpresa.Text = "Datos Empresa";
            // 
            // frmUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 655);
            this.Controls.Add(this.grpDatosEmpresa);
            this.Controls.Add(this.grpDocumentos);
            this.Controls.Add(this.grpDatosCarrera);
            this.Controls.Add(this.grpFotografia);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpDatosPersonales);
            this.Name = "frmUno";
            this.Text = "Asignación Práctica Profesional";
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.grpFotografia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpDatosCarrera.ResumeLayout(false);
            this.grpDatosCarrera.PerformLayout();
            this.grpDocumentos.ResumeLayout(false);
            this.grpDocumentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.TextBox txtTelefonoM;
        private System.Windows.Forms.TextBox txtTelefonoF;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefonoM;
        private System.Windows.Forms.Label lblTelefonoF;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbE;
        private System.Windows.Forms.RadioButton rdbN;
        private System.Windows.Forms.GroupBox grpFotografia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpDatosCarrera;
        private System.Windows.Forms.CheckBox chcServicio;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.GroupBox grpDocumentos;
        private System.Windows.Forms.CheckBox chcCartaLiberacion;
        private System.Windows.Forms.CheckBox chcCartaPresentacion;
        private System.Windows.Forms.CheckBox chcSeguroMedico;
        private System.Windows.Forms.CheckBox chcCartaAceptacion;
        private System.Windows.Forms.CheckBox chcEmpresas;
        private System.Windows.Forms.CheckBox chcEntrevista;
        private System.Windows.Forms.CheckBox chcCurriculum;
        private System.Windows.Forms.CheckBox chcCartaCompromiso;
        private System.Windows.Forms.CheckBox chcSolicitud;
        private System.Windows.Forms.GroupBox grpDatosEmpresa;
    }
}

