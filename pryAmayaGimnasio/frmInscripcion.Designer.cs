namespace pryAmayaGimnasio
{
    partial class frmInscripcion
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.tabInscripcion = new System.Windows.Forms.TabControl();
            this.tpgDatos = new System.Windows.Forms.TabPage();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.tpgPlan = new System.Windows.Forms.TabPage();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.chkCasillero = new System.Windows.Forms.CheckBox();
            this.tpgPago = new System.Windows.Forms.TabPage();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtTarjeta = new System.Windows.Forms.RadioButton();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tpgConsultar = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lstConsultar = new System.Windows.Forms.ListBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblPaso = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.tabInscripcion.SuspendLayout();
            this.tpgDatos.SuspendLayout();
            this.tpgPlan.SuspendLayout();
            this.tpgPago.SuspendLayout();
            this.grpPago.SuspendLayout();
            this.tpgConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(440, 64);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTitulo.Location = new System.Drawing.Point(14, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(175, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GIMNASIO SIGLO";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(16, 38);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(106, 13);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Inscripción de socios";
            // 
            // tabInscripcion
            // 
            this.tabInscripcion.Controls.Add(this.tpgDatos);
            this.tabInscripcion.Controls.Add(this.tpgPlan);
            this.tabInscripcion.Controls.Add(this.tpgPago);
            this.tabInscripcion.Controls.Add(this.tpgConsultar);
            this.tabInscripcion.Location = new System.Drawing.Point(12, 78);
            this.tabInscripcion.Name = "tabInscripcion";
            this.tabInscripcion.SelectedIndex = 0;
            this.tabInscripcion.Size = new System.Drawing.Size(416, 298);
            this.tabInscripcion.TabIndex = 1;
            this.tabInscripcion.SelectedIndexChanged += new System.EventHandler(this.tabInscripcion_SelectedIndexChanged);
            // 
            // tpgDatos
            // 
            this.tpgDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.tpgDatos.Controls.Add(this.lblNombre);
            this.tpgDatos.Controls.Add(this.txtNombre);
            this.tpgDatos.Controls.Add(this.lblEdad);
            this.tpgDatos.Controls.Add(this.txtEdad);
            this.tpgDatos.Controls.Add(this.chkEstudiante);
            this.tpgDatos.Location = new System.Drawing.Point(4, 22);
            this.tpgDatos.Name = "tpgDatos";
            this.tpgDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDatos.Size = new System.Drawing.Size(408, 272);
            this.tpgDatos.TabIndex = 0;
            this.tpgDatos.Text = "Datos personales";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNombre.Location = new System.Drawing.Point(24, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtNombre.Location = new System.Drawing.Point(110, 29);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(270, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.ValidarDatos_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblEdad.Location = new System.Drawing.Point(24, 72);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtEdad.Location = new System.Drawing.Point(110, 69);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(70, 20);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.TextChanged += new System.EventHandler(this.ValidarDatos_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chkEstudiante.Location = new System.Drawing.Point(110, 108);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(76, 17);
            this.chkEstudiante.TabIndex = 4;
            this.chkEstudiante.Text = "Estudiante";
            this.chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // tpgPlan
            // 
            this.tpgPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.tpgPlan.Controls.Add(this.lblPlan);
            this.tpgPlan.Controls.Add(this.cboPlan);
            this.tpgPlan.Controls.Add(this.lblTurno);
            this.tpgPlan.Controls.Add(this.cboTurno);
            this.tpgPlan.Controls.Add(this.lblMeses);
            this.tpgPlan.Controls.Add(this.txtMeses);
            this.tpgPlan.Controls.Add(this.chkCasillero);
            this.tpgPlan.Location = new System.Drawing.Point(4, 22);
            this.tpgPlan.Name = "tpgPlan";
            this.tpgPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPlan.Size = new System.Drawing.Size(408, 272);
            this.tpgPlan.TabIndex = 1;
            this.tpgPlan.Text = "Plan";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPlan.Location = new System.Drawing.Point(24, 32);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 0;
            this.lblPlan.Text = "Plan";
            // 
            // cboPlan
            // 
            this.cboPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Items.AddRange(new object[] {
            "Musculación",
            "Funcional",
            "Natación"});
            this.cboPlan.Location = new System.Drawing.Point(110, 29);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(180, 21);
            this.cboPlan.TabIndex = 1;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTurno.Location = new System.Drawing.Point(24, 72);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 2;
            this.lblTurno.Text = "Turno";
            // 
            // cboTurno
            // 
            this.cboTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.cboTurno.Location = new System.Drawing.Point(110, 69);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(180, 21);
            this.cboTurno.TabIndex = 3;
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblMeses.Location = new System.Drawing.Point(24, 112);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(38, 13);
            this.lblMeses.TabIndex = 4;
            this.lblMeses.Text = "Meses";
            // 
            // txtMeses
            // 
            this.txtMeses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtMeses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMeses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtMeses.Location = new System.Drawing.Point(110, 109);
            this.txtMeses.MaxLength = 2;
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(70, 20);
            this.txtMeses.TabIndex = 5;
            this.txtMeses.TextChanged += new System.EventHandler(this.ValidarDatos_TextChanged);
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // chkCasillero
            // 
            this.chkCasillero.AutoSize = true;
            this.chkCasillero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chkCasillero.Location = new System.Drawing.Point(110, 148);
            this.chkCasillero.Name = "chkCasillero";
            this.chkCasillero.Size = new System.Drawing.Size(134, 17);
            this.chkCasillero.TabIndex = 6;
            this.chkCasillero.Text = "Casillero ($ 3.000/mes)";
            this.chkCasillero.UseVisualStyleBackColor = true;
            // 
            // tpgPago
            // 
            this.tpgPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.tpgPago.Controls.Add(this.grpPago);
            this.tpgPago.Controls.Add(this.lblAviso);
            this.tpgPago.Controls.Add(this.btnLimpiar);
            this.tpgPago.Controls.Add(this.btnCalcular);
            this.tpgPago.Location = new System.Drawing.Point(4, 22);
            this.tpgPago.Name = "tpgPago";
            this.tpgPago.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPago.Size = new System.Drawing.Size(408, 272);
            this.tpgPago.TabIndex = 2;
            this.tpgPago.Text = "Forma de pago";
            // 
            // grpPago
            // 
            this.grpPago.Controls.Add(this.rbtEfectivo);
            this.grpPago.Controls.Add(this.rbtTarjeta);
            this.grpPago.Controls.Add(this.lblCuotas);
            this.grpPago.Controls.Add(this.cboCuotas);
            this.grpPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.grpPago.Location = new System.Drawing.Point(16, 14);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(376, 104);
            this.grpPago.TabIndex = 0;
            this.grpPago.TabStop = false;
            this.grpPago.Text = "Forma de pago";
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.rbtEfectivo.Location = new System.Drawing.Point(20, 28);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbtEfectivo.TabIndex = 0;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            this.rbtTarjeta.AutoSize = true;
            this.rbtTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.rbtTarjeta.Location = new System.Drawing.Point(20, 62);
            this.rbtTarjeta.Name = "rbtTarjeta";
            this.rbtTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rbtTarjeta.TabIndex = 1;
            this.rbtTarjeta.Text = "Tarjeta";
            this.rbtTarjeta.UseVisualStyleBackColor = true;
            this.rbtTarjeta.CheckedChanged += new System.EventHandler(this.rbtTarjeta_CheckedChanged);
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCuotas.Location = new System.Drawing.Point(150, 64);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(40, 13);
            this.lblCuotas.TabIndex = 2;
            this.lblCuotas.Text = "Cuotas";
            // 
            // cboCuotas
            // 
            this.cboCuotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.Enabled = false;
            this.cboCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCuotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboCuotas.FormattingEnabled = true;
            this.cboCuotas.Items.AddRange(new object[] {
            "1",
            "3",
            "6"});
            this.cboCuotas.Location = new System.Drawing.Point(205, 60);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(80, 21);
            this.cboCuotas.TabIndex = 3;
            // 
            // lblAviso
            // 
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.lblAviso.Location = new System.Drawing.Point(16, 132);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(376, 32);
            this.lblAviso.TabIndex = 1;
            this.lblAviso.Text = "Completá nombre, edad y meses para habilitar el botón Calcular.";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnLimpiar.Location = new System.Drawing.Point(186, 206);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 36);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnCalcular.Location = new System.Drawing.Point(292, 206);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 36);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tpgConsultar
            // 
            this.tpgConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.tpgConsultar.Controls.Add(this.btnConsultar);
            this.tpgConsultar.Controls.Add(this.lstConsultar);
            this.tpgConsultar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tpgConsultar.Location = new System.Drawing.Point(4, 22);
            this.tpgConsultar.Name = "tpgConsultar";
            this.tpgConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tpgConsultar.Size = new System.Drawing.Size(408, 272);
            this.tpgConsultar.TabIndex = 3;
            this.tpgConsultar.Text = "Consultar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(6, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 44);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lstConsultar
            // 
            this.lstConsultar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstConsultar.FormattingEnabled = true;
            this.lstConsultar.Location = new System.Drawing.Point(6, 56);
            this.lstConsultar.Name = "lstConsultar";
            this.lstConsultar.Size = new System.Drawing.Size(386, 212);
            this.lstConsultar.TabIndex = 0;
            this.lstConsultar.SelectedIndexChanged += new System.EventHandler(this.lstConsultar_SelectedIndexChanged);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.Enabled = false;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnAnterior.Location = new System.Drawing.Point(12, 392);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(110, 34);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "< &Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblPaso
            // 
            this.lblPaso.AutoSize = true;
            this.lblPaso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPaso.Location = new System.Drawing.Point(184, 402);
            this.lblPaso.Name = "lblPaso";
            this.lblPaso.Size = new System.Drawing.Size(69, 15);
            this.lblPaso.TabIndex = 3;
            this.lblPaso.Text = "Paso 1 de 4";
            this.lblPaso.Click += new System.EventHandler(this.lblPaso_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnSiguiente.Location = new System.Drawing.Point(318, 392);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(110, 34);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "&Siguiente >";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // frmInscripcion
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(440, 442);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.tabInscripcion);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblPaso);
            this.Controls.Add(this.btnSiguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimnasio Siglo — Inscripción";
            this.Load += new System.EventHandler(this.frmInscripcion_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.tabInscripcion.ResumeLayout(false);
            this.tpgDatos.ResumeLayout(false);
            this.tpgDatos.PerformLayout();
            this.tpgPlan.ResumeLayout(false);
            this.tpgPlan.PerformLayout();
            this.tpgPago.ResumeLayout(false);
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            this.tpgConsultar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TabControl tabInscripcion;
        private System.Windows.Forms.TabPage tpgDatos;
        private System.Windows.Forms.TabPage tpgPlan;
        private System.Windows.Forms.TabPage tpgPago;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.CheckBox chkEstudiante;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.CheckBox chkCasillero;
        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.RadioButton rbtTarjeta;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblPaso;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TabPage tpgConsultar;
        private System.Windows.Forms.ListBox lstConsultar;
        private System.Windows.Forms.Button btnConsultar;
    }
}
