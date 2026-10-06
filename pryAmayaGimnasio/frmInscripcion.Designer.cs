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
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.TabControl();
            this.tbDatos = new System.Windows.Forms.TabPage();
            this.tbPlan = new System.Windows.Forms.TabPage();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.chkCasillero = new System.Windows.Forms.CheckBox();
            this.grpPlan = new System.Windows.Forms.GroupBox();
            this.tbPagos = new System.Windows.Forms.TabPage();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.rbtTarjeta = new System.Windows.Forms.RadioButton();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.Datos.SuspendLayout();
            this.tbDatos.SuspendLayout();
            this.tbPlan.SuspendLayout();
            this.grbDatosPersonales.SuspendLayout();
            this.grpPlan.SuspendLayout();
            this.tbPagos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(62, 71);
            this.txtMeses.MaxLength = 2;
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 20);
            this.txtMeses.TabIndex = 5;
            // 
            // cboPlan
            // 
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Location = new System.Drawing.Point(62, 16);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(121, 21);
            this.cboPlan.TabIndex = 9;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(6, 16);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 4;
            this.lblPlan.Text = "Plan";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(6, 44);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 5;
            this.lblTurno.Text = "Turno";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(6, 70);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(38, 13);
            this.lblMeses.TabIndex = 6;
            this.lblMeses.Text = "Meses";
            // 
            // cboTurno
            // 
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Location = new System.Drawing.Point(62, 44);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(121, 21);
            this.cboTurno.TabIndex = 15;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(187, 102);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(105, 102);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.tbDatos);
            this.Datos.Controls.Add(this.tbPlan);
            this.Datos.Controls.Add(this.tbPagos);
            this.Datos.Location = new System.Drawing.Point(12, 12);
            this.Datos.Name = "Datos";
            this.Datos.SelectedIndex = 0;
            this.Datos.Size = new System.Drawing.Size(316, 169);
            this.Datos.TabIndex = 25;
            // 
            // tbDatos
            // 
            this.tbDatos.Controls.Add(this.grbDatosPersonales);
            this.tbDatos.Location = new System.Drawing.Point(4, 22);
            this.tbDatos.Name = "tbDatos";
            this.tbDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbDatos.Size = new System.Drawing.Size(308, 143);
            this.tbDatos.TabIndex = 0;
            this.tbDatos.Text = "Datos ";
            this.tbDatos.UseVisualStyleBackColor = true;
            // 
            // tbPlan
            // 
            this.tbPlan.Controls.Add(this.grpPlan);
            this.tbPlan.Location = new System.Drawing.Point(4, 22);
            this.tbPlan.Name = "tbPlan";
            this.tbPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tbPlan.Size = new System.Drawing.Size(308, 143);
            this.tbPlan.TabIndex = 1;
            this.tbPlan.Text = "Plan";
            this.tbPlan.UseVisualStyleBackColor = true;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(6, 71);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(57, 13);
            this.lblEstudiante.TabIndex = 25;
            this.lblEstudiante.Text = "Estudiante";
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Location = new System.Drawing.Point(78, 71);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(76, 17);
            this.chkEstudiante.TabIndex = 26;
            this.chkEstudiante.Text = "Estudiante";
            this.chkEstudiante.UseVisualStyleBackColor = true;
            this.chkEstudiante.CheckedChanged += new System.EventHandler(this.chkEstudiante_CheckedChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 44);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 24;
            this.lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(78, 41);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 19);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // grbDatosPersonales
            // 
            this.grbDatosPersonales.Controls.Add(this.txtNombre);
            this.grbDatosPersonales.Controls.Add(this.txtEdad);
            this.grbDatosPersonales.Controls.Add(this.chkEstudiante);
            this.grbDatosPersonales.Controls.Add(this.lblEstudiante);
            this.grbDatosPersonales.Controls.Add(this.lblNombre);
            this.grbDatosPersonales.Controls.Add(this.lblEdad);
            this.grbDatosPersonales.Location = new System.Drawing.Point(6, 6);
            this.grbDatosPersonales.Name = "grbDatosPersonales";
            this.grbDatosPersonales.Size = new System.Drawing.Size(256, 117);
            this.grbDatosPersonales.TabIndex = 29;
            this.grbDatosPersonales.TabStop = false;
            this.grbDatosPersonales.Text = "Datos Personales";
            // 
            // chkCasillero
            // 
            this.chkCasillero.AutoSize = true;
            this.chkCasillero.Location = new System.Drawing.Point(168, 74);
            this.chkCasillero.Name = "chkCasillero";
            this.chkCasillero.Size = new System.Drawing.Size(131, 17);
            this.chkCasillero.TabIndex = 21;
            this.chkCasillero.Text = "Casillero ($ 3000/mes)";
            this.chkCasillero.UseVisualStyleBackColor = true;
            this.chkCasillero.CheckedChanged += new System.EventHandler(this.chkCasillero_CheckedChanged);
            // 
            // grpPlan
            // 
            this.grpPlan.Controls.Add(this.chkCasillero);
            this.grpPlan.Controls.Add(this.lblPlan);
            this.grpPlan.Controls.Add(this.txtMeses);
            this.grpPlan.Controls.Add(this.cboPlan);
            this.grpPlan.Controls.Add(this.lblTurno);
            this.grpPlan.Controls.Add(this.lblMeses);
            this.grpPlan.Controls.Add(this.cboTurno);
            this.grpPlan.Location = new System.Drawing.Point(8, 6);
            this.grpPlan.Name = "grpPlan";
            this.grpPlan.Size = new System.Drawing.Size(294, 107);
            this.grpPlan.TabIndex = 23;
            this.grpPlan.TabStop = false;
            this.grpPlan.Text = "Plan";
            // 
            // tbPagos
            // 
            this.tbPagos.Controls.Add(this.cboCuotas);
            this.tbPagos.Controls.Add(this.btnLimpiar);
            this.tbPagos.Controls.Add(this.rbtTarjeta);
            this.tbPagos.Controls.Add(this.btnCalcular);
            this.tbPagos.Controls.Add(this.rbtEfectivo);
            this.tbPagos.Controls.Add(this.grpPago);
            this.tbPagos.Location = new System.Drawing.Point(4, 22);
            this.tbPagos.Name = "tbPagos";
            this.tbPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tbPagos.Size = new System.Drawing.Size(308, 143);
            this.tbPagos.TabIndex = 2;
            this.tbPagos.Text = "Pagos";
            this.tbPagos.UseVisualStyleBackColor = true;
            // 
            // cboCuotas
            // 
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.FormattingEnabled = true;
            this.cboCuotas.Location = new System.Drawing.Point(116, 53);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(121, 21);
            this.cboCuotas.TabIndex = 27;
            // 
            // rbtTarjeta
            // 
            this.rbtTarjeta.AutoSize = true;
            this.rbtTarjeta.Location = new System.Drawing.Point(116, 30);
            this.rbtTarjeta.Name = "rbtTarjeta";
            this.rbtTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rbtTarjeta.TabIndex = 26;
            this.rbtTarjeta.TabStop = true;
            this.rbtTarjeta.Text = "Tarjeta";
            this.rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Location = new System.Drawing.Point(116, 7);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbtEfectivo.TabIndex = 25;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // grpPago
            // 
            this.grpPago.Location = new System.Drawing.Point(16, 6);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(246, 74);
            this.grpPago.TabIndex = 28;
            this.grpPago.TabStop = false;
            this.grpPago.Text = "Formas de pago";
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 208);
            this.Controls.Add(this.Datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimnasio Siglo - Inscripcion";
            this.Load += new System.EventHandler(this.frmInscripcion_Load_1);
            this.Datos.ResumeLayout(false);
            this.tbDatos.ResumeLayout(false);
            this.tbPlan.ResumeLayout(false);
            this.grbDatosPersonales.ResumeLayout(false);
            this.grbDatosPersonales.PerformLayout();
            this.grpPlan.ResumeLayout(false);
            this.grpPlan.PerformLayout();
            this.tbPagos.ResumeLayout(false);
            this.tbPagos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TabControl Datos;
        private System.Windows.Forms.TabPage tbDatos;
        private System.Windows.Forms.TabPage tbPlan;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.CheckBox chkEstudiante;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grbDatosPersonales;
        private System.Windows.Forms.GroupBox grpPlan;
        private System.Windows.Forms.CheckBox chkCasillero;
        private System.Windows.Forms.TabPage tbPagos;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.RadioButton rbtTarjeta;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.GroupBox grpPago;
    }
}

