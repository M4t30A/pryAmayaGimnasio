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
            frmInscripcion frm = new frmInscripcion();  
            this.Hide();                               
            frm.ShowDialog();                           
            this.Close();                            
        }
    }
}
