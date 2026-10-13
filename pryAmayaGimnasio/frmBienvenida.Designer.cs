namespace pryAmayaGimnasio
{
    partial class frmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            this.pnlAcento = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlLinea = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.lblPie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlAcento
            // 
            this.pnlAcento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.pnlAcento.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAcento.Location = new System.Drawing.Point(0, 0);
            this.pnlAcento.Name = "pnlAcento";
            this.pnlAcento.Size = new System.Drawing.Size(14, 380);
            this.pnlAcento.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTitulo.Location = new System.Drawing.Point(48, 56);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(408, 62);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "GIMNASIO SIGLO";
            // 
            // pnlLinea
            // 
            this.pnlLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.pnlLinea.Location = new System.Drawing.Point(54, 128);
            this.pnlLinea.Name = "pnlLinea";
            this.pnlLinea.Size = new System.Drawing.Size(90, 4);
            this.pnlLinea.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(52, 144);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(283, 25);
            this.lblSubtitulo.TabIndex = 3;
            this.lblSubtitulo.Text = "Sistema de inscripción de socios";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBienvenida.Location = new System.Drawing.Point(54, 190);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(520, 56);
            this.lblBienvenida.TabIndex = 4;
            this.lblBienvenida.Text = "¡Bienvenido! Elegí tu plan y tu turno, y en pocos pasos vas a ver el detalle de t" +
    "u inscripción.";
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnComenzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComenzar.FlatAppearance.BorderSize = 0;
            this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnComenzar.Location = new System.Drawing.Point(54, 268);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(250, 52);
            this.btnComenzar.TabIndex = 5;
            this.btnComenzar.Text = "Comenzar inscripción";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // lblPie
            // 
            this.lblPie.AutoSize = true;
            this.lblPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPie.Location = new System.Drawing.Point(54, 346);
            this.lblPie.Name = "lblPie";
            this.lblPie.Size = new System.Drawing.Size(149, 13);
            this.lblPie.TabIndex = 6;
            this.lblPie.Text = "Laboratorio de Programación I";
            // 
            // frmBienvenida
            // 
            this.AcceptButton = this.btnComenzar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(620, 380);
            this.Controls.Add(this.lblPie);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.pnlLinea);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlAcento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimnasio Siglo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlLinea;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label lblPie;
    }
}
