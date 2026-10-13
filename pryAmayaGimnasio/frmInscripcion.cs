using System;
using System.Drawing;
using System.Windows.Forms;

namespace pryAmayaGimnasio
{
    public partial class frmInscripcion : Form
    {
       
        const decimal PRECIO_MUSCULACION = 15000m;
        const decimal PRECIO_FUNCIONAL = 18000m;
        const decimal PRECIO_NATACION = 22000m;
        const decimal PRECIO_CASILLERO = 3000m;    

        // Reglas de edad y de meses
        const int EDAD_MINIMA = 14;
        const int EDAD_MENOR = 18;                  
        const int EDAD_SENIOR = 65;                
        const int MESES_MINIMO = 1;
        const int MESES_MAXIMO = 12;

        // Descuentos por edad / estudiante (no se acumulan)
        const decimal DESC_MENOR = 0.25m;
        const decimal DESC_SENIOR = 0.30m;
        const decimal DESC_ESTUDIANTE = 0.15m;

        // Forma de pago
        const decimal DESC_EFECTIVO = 0.10m;
        const decimal RECARGO_3_CUOTAS = 0.10m;
        const decimal RECARGO_6_CUOTAS = 0.20m;

        // Array unidimensional para almacenar los socios y su contador
        const int MAX_SOCIOS = 20;
        SOCIO[] arraySocios = new SOCIO[MAX_SOCIOS];
        int indiceSocios = 0;

        // =====================================================
        //  PALETA DE COLORES 
        // =====================================================
        readonly Color colorFondo = ColorTranslator.FromHtml("#0F172A");            
        readonly Color colorPanel = ColorTranslator.FromHtml("#1E293B");          
        readonly Color colorBorde = ColorTranslator.FromHtml("#334155");           
        readonly Color colorTexto = ColorTranslator.FromHtml("#F8FAFC");            
        readonly Color colorTextoSecundario = ColorTranslator.FromHtml("#94A3B8");  
        readonly Color colorPrimario = ColorTranslator.FromHtml("#38BDF8");         
        readonly Color colorAcento = ColorTranslator.FromHtml("#818CF8");          

        // =====================================================
        //  STRUCT SOCIO
        // =====================================================
        struct SOCIO
        {
            public string nombre;
            public int edad;
            public string categoria;
            public string plan;
            public string horario;
            public int meses;
            public string formaPago;
            public decimal total;
            public decimal valorCuota;
        }

        public frmInscripcion()
        {
            InitializeComponent();
            AplicarPaleta();                   
        }

        private void AplicarPaleta()
        {
            // 1) Botones: el color depende de si están habilitados o no
            PintarBoton(btnCalcular);
            PintarBoton(btnLimpiar);
            PintarBoton(btnAnterior);
            PintarBoton(btnSiguiente);
            btnCalcular.EnabledChanged += Boton_EnabledChanged;
            btnAnterior.EnabledChanged += Boton_EnabledChanged;
            btnSiguiente.EnabledChanged += Boton_EnabledChanged;

            // 2) Solapas del TabControl: las dibujamos nosotros
            tabInscripcion.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabInscripcion.DrawItem += tabInscripcion_DrawItem;

            // 3) Borde y título del GroupBox
            grpPago.Paint += grpPago_Paint;
        }

        // Elige los colores de un botón según su estado
        private void PintarBoton(Button b)
        {
            if (!b.Enabled)
            {
                b.BackColor = colorPanel;               
                b.ForeColor = colorTextoSecundario;     
            }
            else if (b == btnAnterior || b == btnLimpiar)
            {
                b.BackColor = colorBorde;               
                b.ForeColor = colorTexto;
            }
            else
            {
                b.BackColor = colorPrimario;          
                b.ForeColor = colorFondo;               
            }
        }

        // Se ejecuta cada vez que un botón se habilita o se deshabilita
        private void Boton_EnabledChanged(object sender, EventArgs e)
        {
            PintarBoton((Button)sender);
        }

        // Dibuja cada solapa (DrawMode = OwnerDrawFixed)
        private void tabInscripcion_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage pagina = tabInscripcion.TabPages[e.Index];
            bool seleccionada = (e.Index == tabInscripcion.SelectedIndex);
            Rectangle r = e.Bounds;

            // En la última solapa también se pinta la franja vacía que queda a su derecha
            if (e.Index == tabInscripcion.TabCount - 1)
            {
                SolidBrush pincelFranja = new SolidBrush(colorFondo);
                e.Graphics.FillRectangle(pincelFranja, r.Right, 0, tabInscripcion.Width - r.Right, r.Bottom);
                pincelFranja.Dispose();
            }

            // Fondo y texto: la solapa activa usa el color del panel (se funde con la pestaña)
            Color fondo = seleccionada ? colorPanel : colorFondo;
            Color texto = seleccionada ? colorTexto : colorTextoSecundario;

            SolidBrush pincel = new SolidBrush(fondo);
            e.Graphics.FillRectangle(pincel, r);
            pincel.Dispose();

            if (seleccionada)
            {
                // barra de acento arriba de la solapa activa
                SolidBrush pincelAcento = new SolidBrush(colorAcento);
                e.Graphics.FillRectangle(pincelAcento, r.X, r.Y, r.Width, 3);
                pincelAcento.Dispose();
            }
            else
            {
                Pen lapiz = new Pen(colorBorde);
                e.Graphics.DrawRectangle(lapiz, r.X, r.Y, r.Width - 1, r.Height - 1);
                lapiz.Dispose();
            }

            TextRenderer.DrawText(e.Graphics, pagina.Text, e.Font, r, texto,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // Dibuja el borde y el título del GroupBox con la paleta
        private void grpPago_Paint(object sender, PaintEventArgs e)
        {
            GroupBox grupo = (GroupBox)sender;
            Size tamTexto = TextRenderer.MeasureText(grupo.Text, grupo.Font);
            Rectangle marco = new Rectangle(0, tamTexto.Height / 2, grupo.Width - 1, grupo.Height - tamTexto.Height / 2 - 1);

            e.Graphics.Clear(colorPanel);                                       // borra el dibujo de Windows
            ControlPaint.DrawBorder(e.Graphics, marco, colorBorde, ButtonBorderStyle.Solid);
            TextRenderer.DrawText(e.Graphics, grupo.Text, grupo.Font, new Point(8, 0), colorTexto, colorPanel);
        }

        // =====================================================
        //  MÉTODO PROPIO
        // =====================================================
        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            chkEstudiante.Checked = false;
            cboPlan.SelectedIndex = 0;          
            cboTurno.SelectedIndex = 0;         
            txtMeses.Text = "1";
            chkCasillero.Checked = false;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;      
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            lblAviso.Visible = true;
            tabInscripcion.SelectedIndex = 0;   
            ActualizarNavegacion();
            txtNombre.Focus();
        }

        // =====================================================
        //  NAVEGACIÓN ENTRE PESTAÑAS
        //  Actualiza "Anterior", "Siguiente" 
        // =====================================================
        private void ActualizarNavegacion()
        {
            int pestana = tabInscripcion.SelectedIndex;    
            bool puedeAvanzar = false;

            if (pestana == 0)
            {
                // Para pasar a "Plan" hacen falta nombre y edad
                puedeAvanzar = txtNombre.Text.Trim().Length > 0 && txtEdad.Text.Length > 0;
            }
            else if (pestana == 1)
            {
                puedeAvanzar = txtMeses.Text.Length > 0;
            }
            

            btnAnterior.Enabled = pestana > 0;
            btnSiguiente.Enabled = puedeAvanzar;
            lblPaso.Text = "Paso " + (pestana + 1) + " de 4";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            tabInscripcion.SelectedIndex = tabInscripcion.SelectedIndex + 1;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tabInscripcion.SelectedIndex = tabInscripcion.SelectedIndex - 1;
        }

        // Click del label de paso (el diseñador lo conectó). No necesita acción, pero debe existir el método.
        private void lblPaso_Click(object sender, EventArgs e)
        {
            // Intencionalmente vacío para resolver referencia del diseñador.
        }

        // Se ejecuta al cambiar de pestaña (con los botones o haciendo clic en la solapa)
        private void tabInscripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarNavegacion();
        }

        // ----- Evento Load del formulario -----
        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        // ----- Botón Limpiar -----
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        // =====================================================
        //  ETAPA 5.a 
        // =====================================================
        
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        // Edad y Meses (comparten el mismo método): solo dígitos y Backspace
        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;               // la tecla se descarta
            }
        }

        // =====================================================
        //  ETAPA 5.b - HABILITAR / DESHABILITAR "Calcular"
        // =====================================================
        private void ValidarDatos_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 0 && txtEdad.Text.Length > 0 && txtMeses.Text.Length > 0)
            {
                btnCalcular.Enabled = true;
                lblAviso.Visible = false;     
            }
            else
            {
                btnCalcular.Enabled = false;
                lblAviso.Visible = true;        
            }

            ActualizarNavegacion();             
        }


        // =====================================================
        //  ETAPA 8 - Tarjeta: habilitar / deshabilitar las cuotas
        // =====================================================
        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;   
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;  
            }
        }

        // =====================================================
        //  BOTÓN CALCULAR (Etapas 4, 5.c, 6, 7, 8, 9 y 10)
        // =====================================================
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // ----- Etapa 4: variables del cálculo (camelCase, con valor inicial) -----
            string nombre = txtNombre.Text;
            int edad = 0;
            int meses = 0;
            string plan = cboPlan.Text;
            string horario = "";
            decimal precioMensual = 0m;
            decimal subtotal = 0m;
            decimal porcDescuento = 0m;
            decimal descuento = 0m;
            decimal importeConDescuento = 0m;
            decimal porcAjuste = 0m;            
            decimal total = 0m;
            decimal valorCuota = 0m;
            int cuotas = 1;
            bool planValido = true;

            // ----- Etapa 5.c: primero CONVERTIR, después VALIDAR, recién después CALCULAR -----
            if (!int.TryParse(txtEdad.Text, out edad))
            {
                tabInscripcion.SelectedTab = tpgDatos;     
                MessageBox.Show("La edad debe ser un número.", "Datos inválidos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdad.Focus();
                return;
            }

            if (!int.TryParse(txtMeses.Text, out meses))
            {
                tabInscripcion.SelectedTab = tpgPlan;
                MessageBox.Show("Los meses deben ser un número.", "Datos inválidos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMeses.Focus();
                return;
            }

            if (edad < EDAD_MINIMA)
            {
                tabInscripcion.SelectedTab = tpgDatos;
                MessageBox.Show("La edad mínima para inscribirse es de " + EDAD_MINIMA + " años.\nNo se puede inscribir.",
                                "Edad mínima", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdad.Focus();
                return;
            }

            if (meses < MESES_MINIMO || meses > MESES_MAXIMO)   
            {
                tabInscripcion.SelectedTab = tpgPlan;
                MessageBox.Show("Los meses deben estar entre " + MESES_MINIMO + " y " + MESES_MAXIMO + ".",
                                "Meses fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMeses.Focus();
                return;
            }

            // ----- Etapa 6: switch con string (precio según el plan) -----
            switch (plan)
            {
                case "Musculación":
                    precioMensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;
                case "Natación":
                    precioMensual = PRECIO_NATACION;
                    break;
                default:
                    MessageBox.Show("Plan inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    planValido = false;
                    break;
            }

            if (!planValido)
            {
                return;
            }

            // ----- Etapa 6: switch con int (posición del turno, empieza en 0) -----
            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    horario = "Mañana (7 a 12 h)";
                    break;
                case 1:
                    horario = "Tarde (14 a 18 h)";
                    break;
                case 2:
                    horario = "Noche (18 a 23 h)";
                    break;
                default:
                    horario = "Sin turno";
                    break;
            }

            // ----- Etapa 7: if en un solo renglón (sin llaves): suma el casillero -----
            if (chkCasillero.Checked) precioMensual = precioMensual + PRECIO_CASILLERO;

            // 1) Subtotal = (plan + casillero) x meses
            subtotal = precioMensual * meses;

            // ----- Etapa 7: if anidado (los descuentos NO se acumulan) -----
            if (edad < EDAD_MENOR)
            {
                porcDescuento = DESC_MENOR;                 
            }
            else
            {
                if (edad >= EDAD_SENIOR)
                {
                    porcDescuento = DESC_SENIOR;           
                }
                else
                {
                    if (chkEstudiante.Checked)
                    {
                        porcDescuento = DESC_ESTUDIANTE;    
                    }
                    else
                    {
                        porcDescuento = 0m;                 
                    }
                }
            }

            // 2) Se aplica el descuento por edad / estudiante
            descuento = subtotal * porcDescuento;
            importeConDescuento = subtotal - descuento;

            // ----- Etapa 8: if - else (efectivo) y cadena if - else if (cuotas) -----
            if (rbtEfectivo.Checked)
            {
                porcAjuste = -DESC_EFECTIVO;                
            }
            else
            {
                cuotas = int.Parse(cboCuotas.Text);        
                if (cuotas == 1)
                {
                    porcAjuste = 0m;                        
                }
                else if (cuotas == 3)
                {
                    porcAjuste = RECARGO_3_CUOTAS;          
                }
                else if (cuotas == 6)
                {
                    porcAjuste = RECARGO_6_CUOTAS;         
                }
            }




            // 3) Se aplica el descuento o recargo de la forma de pago
            total = importeConDescuento + importeConDescuento * porcAjuste;

            // ----- Etapa 9: operador ternario  (condición ? si es verdadera : si es falsa) -----
            string categoria = edad < EDAD_MENOR ? "Menor" : "Mayor";
            string textoPago = rbtEfectivo.Checked ? "Efectivo" : "Tarjeta en " + cuotas + " cuotas";
            valorCuota = rbtEfectivo.Checked ? total : total / cuotas;

            // ----- Etapa 10: cargar el struct SOCIO con el operador punto -----
            SOCIO socio;
            socio.nombre = nombre;
            socio.edad = edad;
            socio.categoria = categoria;
            socio.plan = plan;
            socio.horario = horario;
            socio.meses = meses;
            socio.formaPago = textoPago;
            socio.total = total;
            socio.valorCuota = valorCuota;


            // ----- Mensaje único con todos los datos (concatenados con +) -----
            string mensaje = "Socio: " + socio.nombre + Environment.NewLine
                + "Edad: " + socio.edad + " años (" + socio.categoria + ")" + Environment.NewLine
                + "Plan: " + socio.plan + Environment.NewLine
                + "Turno: " + socio.horario + Environment.NewLine
                + "Meses: " + socio.meses + Environment.NewLine
                + "Casillero: " + (chkCasillero.Checked ? "Sí" : "No") + Environment.NewLine
                + Environment.NewLine
                + "Subtotal: " + subtotal.ToString("C") + Environment.NewLine
                + "Descuento por edad/estudiante (" + porcDescuento.ToString("P0") + "): -" + descuento.ToString("C") + Environment.NewLine
                + "Forma de pago: " + socio.formaPago + Environment.NewLine
                + Environment.NewLine
                + "TOTAL: " + socio.total.ToString("C") + Environment.NewLine
                + "Valor de cada cuota: " + socio.valorCuota.ToString("C");

            MessageBox.Show(mensaje, "Detalle de la inscripción",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ALMACENAR EL ARRAY - Nueva Etapa
            if (indiceSocios < arraySocios.Length)
            {
                arraySocios[indiceSocios] = socio;
                indiceSocios++;
            }

            // El formulario vuelve al estado inicial
            EstadoInicial();
        }
        // Método para recorrer el array y mostrar los datos en el ListBox
        private void CargarConsulta()
        {
            lstConsultar.Items.Clear();

            for (int i = 0; i < indiceSocios; i++)
            {
                string linea = "Socio: " + arraySocios[i].nombre +
                               " | Plan: " + arraySocios[i].plan +
                               " | Meses: " + arraySocios[i].meses +
                               " | Total: " + arraySocios[i].total.ToString("C");

                lstConsultar.Items.Add(linea);
            }
        }

        private void lstConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarConsulta();

            tabInscripcion.SelectedTab = tpgConsultar;
        }

    }
    }

