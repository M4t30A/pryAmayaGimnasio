using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAmayaGimnasio
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
            this.Load += frmInscripcion_Load;
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            cboPlan.Items.Clear();
            cboPlan.Items.Add("Musculación");
            cboPlan.Items.Add("Funcional");
            cboPlan.Items.Add("Natación");
            cboPlan.SelectedIndex = 0; 

            cboTurno.Items.Clear();
            cboTurno.Items.Add("Mañana");
            cboTurno.Items.Add("Tarde");
            cboTurno.Items.Add("Noche");
            cboTurno.SelectedIndex = 0;

            txtMeses.Text = "1";
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;

            rbtEfectivo.Checked = true;
            cboCuotas.Items.Clear();
            cboCuotas.Items.Add("1");
            cboCuotas.Items.Add("3");
            cboCuotas.Items.Add("6");
            cboCuotas.Enabled = false;
            cboCuotas.SelectedIndex = -1;

            btnCalcular.Enabled = false;

            txtNombre.TextChanged += txtNombre_TextChanged;
            txtEdad.KeyPress += txtNumero_KeyPress;
            txtMeses.KeyPress += txtNumero_KeyPress;
            txtEdad.TextChanged += ValidarHabilitarCalcular;
            txtMeses.TextChanged += ValidarHabilitarCalcular;
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;
            rbtEfectivo.CheckedChanged += rbtEfectivo_CheckedChanged;
            btnCalcular.Click += btnCalcular_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            int sel = txtNombre.SelectionStart;
            txtNombre.Text = txtNombre.Text.ToUpperInvariant();
            txtNombre.SelectionStart = sel;
            ValidarHabilitarCalcular(null, EventArgs.Empty);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidarHabilitarCalcular(object sender, EventArgs e)
        {
            bool tieneNombre = !string.IsNullOrWhiteSpace(txtNombre.Text);
            bool tieneEdad = !string.IsNullOrWhiteSpace(txtEdad.Text);
            bool tieneMeses = !string.IsNullOrWhiteSpace(txtMeses.Text);
            btnCalcular.Enabled = tieneNombre && tieneEdad && tieneMeses;
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                if (cboCuotas.SelectedIndex == -1 && cboCuotas.Items.Count > 0)
                    cboCuotas.SelectedIndex = 0; 
            }
        }

        private void rbtEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEfectivo.Checked)
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;
            chkEstudiante.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            txtMeses.Text = "1";
            chkCasillero.Checked = false;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (edad < 14)
            {
                MessageBox.Show("Edad mínima 14 años. No puede inscribirse.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!int.TryParse(txtMeses.Text, out int meses))
            {
                MessageBox.Show("Ingrese un número de meses válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("Los meses deben estar entre 1 y 12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal precioPlan = 0m;
            switch (cboPlan.SelectedItem?.ToString())
            {
                case "Musculación": precioPlan = 15000m; break;
                case "Funcional": precioPlan = 18000m; break;
                case "Natación": precioPlan = 22000m; break;
                default: precioPlan = 15000m; break;
            }
            decimal precioCasillero = chkCasillero.Checked ? 3000m : 0m;

            decimal subtotal = (precioPlan + precioCasillero) * meses;

            decimal descuentoPorcentaje = 0m;
            if (edad < 18)
                descuentoPorcentaje = 0.25m;
            else if (edad >= 65)
                descuentoPorcentaje = 0.30m;
            else if (chkEstudiante.Checked)
                descuentoPorcentaje = 0.15m;

            decimal montoDespuesEdad = subtotal * (1 - descuentoPorcentaje);

            decimal montoFinal = montoDespuesEdad;
            string pagoDetalle = "";
            if (rbtEfectivo.Checked)
            {
                montoFinal = montoDespuesEdad * 0.90m; 
                pagoDetalle = "Efectivo (10% desc.)";
            }
            else if (rbtTarjeta.Checked)
            {
                if (cboCuotas.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione la cantidad de cuotas para tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string cuotas = cboCuotas.SelectedItem.ToString();
                if (cuotas == "1")
                {
                    pagoDetalle = "Tarjeta 1 cuota (sin recargo)";
                }
                else if (cuotas == "3")
                {
                    montoFinal = montoDespuesEdad * 1.10m; 
                    pagoDetalle = "Tarjeta 3 cuotas (+10%)";
                }
                else if (cuotas == "6")
                {
                    montoFinal = montoDespuesEdad * 1.20m; 
                    pagoDetalle = "Tarjeta 6 cuotas (+20%)";
                }
            }

            StringBuilder detalle = new StringBuilder();
            detalle.AppendLine($"Nombre: {txtNombre.Text}");
            detalle.AppendLine($"Edad: {edad}");
            detalle.AppendLine($"Plan: {cboPlan.SelectedItem}");
            detalle.AppendLine($"Turno: {cboTurno.SelectedItem}");
            detalle.AppendLine($"Meses: {meses}");
            detalle.AppendLine($"Casillero: {(chkCasillero.Checked ? "Sí" : "No")}");
            detalle.AppendLine($"Precio plan mensual: ${precioPlan:N0}");
            if (precioCasillero > 0) detalle.AppendLine($"Precio casillero mensual: ${precioCasillero:N0}");
            detalle.AppendLine($"Subtotal (plan+casillero) x meses: ${subtotal:N0}");
            detalle.AppendLine($"Descuento por edad/estudiante: {descuentoPorcentaje:P0}");
            detalle.AppendLine($"Monto después de descuento: ${montoDespuesEdad:N0}");
            detalle.AppendLine($"Forma de pago: {pagoDetalle}");
            detalle.AppendLine($"Total a pagar: ${montoFinal:N0}");

            MessageBox.Show(detalle.ToString(), "Detalle de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnLimpiar_Click(null, EventArgs.Empty);
        }

        private void frmInscripcion_Load_1(object sender, EventArgs e)
        {

        }

        private void chkEstudiante_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCasillero_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
