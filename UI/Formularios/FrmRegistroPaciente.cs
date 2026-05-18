using CentroMedico.Dominio;
using CentroMedico.Infraestructura.Estructuras;
using MaterialSkin.Controls;

namespace CentroMedico
{
    public partial class frmRegistroPaciente : MaterialForm
    {
        private ListaSimplePaciente listaPacientes;
        private ColaPacientes cola;
        private PilaAcciones pila;

        // Almacena la función que actualizará los indicadores del Dashboard
        private Action actualizarDashboard;

        public frmRegistroPaciente()
        {
            InitializeComponent();
        }

        public frmRegistroPaciente(ListaSimplePaciente lista, ColaPacientes cola, PilaAcciones pila, Action alRegistrar)
        {
            InitializeComponent();
            this.listaPacientes = lista;
            this.cola = cola;
            this.pila = pila;
            this.actualizarDashboard = alRegistrar; // Guardamos la referencia de la acción
            this.Load += frmRegistroPaciente_Load;

 
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtSintomas.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Edad inválida.");
                return;
            }

            Paciente nuevo = new Paciente(txtDNI.Text.Trim(), txtNombre.Text.Trim(), txtEdad.Text.Trim(), txtSintomas.Text.Trim());

            listaPacientes.AgregarAlFinal(nuevo);

            // Encolar en cola de atención
            cola.Encolar(nuevo);

            // Registrar acción en pila
            pila.Apilar(new AccionRealizada("Registro", $"Paciente {nuevo.Nombre} registrado y encolado."));

            MessageBox.Show("Paciente registrado con éxito.");

            // === AJUSTES PARA OPERAR DENTRO DEL TABCONTROL ===

            // 1. Ejecuta de forma segura el refresco del Dashboard principal
            actualizarDashboard?.Invoke();

            // 2. Limpia los TextBox para que quede listo para el siguiente paciente
            txtDNI.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtSintomas.Clear();

            // 3. Actualiza el ListView que está abajo en esta misma pantalla de registro
            MostrarPacientesRegistrados();
        }

        private void MostrarPacientesRegistrados()
        {
            lvRegistrados.Items.Clear();

            foreach (Paciente p in listaPacientes.ListarTodos())
            {
                ListViewItem item = new ListViewItem(new[] {
                    p.DNI,
                    p.Nombre,
                    p.Edad,
                    p.Sintomas
                });

                lvRegistrados.Items.Add(item);
            }
        }

        private void frmRegistroPaciente_Load(object sender, EventArgs e)
        {
            MostrarPacientesRegistrados();
        }
    }
}
