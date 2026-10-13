using System;
using System.Windows.Forms;

namespace pryAmayaGimnasio
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        // Botón "Comenzar inscripción": conecta la bienvenida con el formulario de inscripción
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            frmInscripcion frm = new frmInscripcion();  // 1) se crea el formulario de inscripción
            this.Hide();                                // 2) se oculta la bienvenida
            frm.ShowDialog();                           // 3) se muestra la inscripción y se espera a que se cierre
            this.Close();                               // 4) al cerrarla, termina la aplicación
        }
    }
}
