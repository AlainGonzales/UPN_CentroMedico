using CentroMedico.Services;
using CentroMedico.Utils;

using CentroMedico.Dominio;
using CentroMedico.Infraestructura.Estructuras;

namespace CentroMedico
{
    public partial class frmDashboard : Form
    {
        private ListaSimplePaciente pacientesRegistrados;

        private ColaPacientes colaEspera;

        private ListaDobleHistorial historialAtenciones;

        private ListaCircularMedicos medicosEnTurno;

        private PilaAcciones pilaAcciones;

        private bool datosPrecargados = false;

        private MedicoService medicoService;
        private List<Medico> listaMedicos;

        private GraphUtils graph;

        public frmDashboard()
        {
            InitializeComponent();

            // Inicializa cada estructura
            pacientesRegistrados = new ListaSimplePaciente();
            colaEspera = new ColaPacientes();
            historialAtenciones = new ListaDobleHistorial();
            medicosEnTurno = new ListaCircularMedicos();
            pilaAcciones = new PilaAcciones();

            // Opcional: precarga tus m�dicos en la lista circular
            //medicosEnTurno.Agregar(new Medico("11111111", "Dr. Gregory House"));
            PrecargarMedicos();
            AgregarTurnosMedicos();


            // Precargar pacientes solo una vez
            if (!datosPrecargados)
            {
                PrecargarPacientes();
                datosPrecargados = true;
            }

            // Actualiza UI inicial
            RefrescarDashboard();
        }

        public void PrecargarMedicos()
        {
            medicoService = new MedicoService();
            listaMedicos = medicoService.ObtenerMedicos();
        }

        public void AgregarTurnosMedicos()
        {
            foreach (Medico medico in listaMedicos)
            {
                medicosEnTurno.Agregar(medico);
            }
        }

        private void PrecargarPacientes()
        {
            Paciente p1 = new Paciente("12345678", "Ana Torres", "28", "Dolor de cabeza");
            Paciente p2 = new Paciente("87654321", "Luis Ch�vez", "34", "Fiebre y escalofr�os");
            Paciente p3 = new Paciente("11223344", "Mar�a Paredes", "45", "Dolor abdominal");
            Paciente p4 = new Paciente("44332211", "Carlos Vela", "60", "Presi�n alta");

            // Lista simple
            pacientesRegistrados.AgregarAlFinal(p1);
            pacientesRegistrados.AgregarAlFinal(p2);
            pacientesRegistrados.AgregarAlFinal(p3);
            pacientesRegistrados.AgregarAlFinal(p4);

            // Cola de atenci�n
            colaEspera.Encolar(p1);
            colaEspera.Encolar(p2);
            colaEspera.Encolar(p3);
            colaEspera.Encolar(p4);

            // Pila de acciones
            pilaAcciones.Apilar(new AccionRealizada("Precarga", "Se registraron 4 pacientes por defecto"));
        }


        private void RefrescarDashboard()
        {
            lblDoctorTurno.Text = $"Médico en turno: {medicosEnTurno.ObtenerActual().Nombre}";

            lblPacientesEnCola.Text = $"Pacientes en cola: {colaEspera.Contar()}";

            lblUltimaAccion.Text = pilaAcciones.EstaVacia()
                ? "Última acción: "
                : $"Última acción: {pilaAcciones.Tope()}";

            lvColaPacientes.Items.Clear();
            foreach (Paciente p in colaEspera.ObtenerTodos())
            {
                var item = new ListViewItem(new[] { p.DNI, p.Nombre, p.Edad.ToString(), p.Sintomas });
                lvColaPacientes.Items.Add(item);
            }
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            frmRegistroPaciente form = new frmRegistroPaciente(pacientesRegistrados, colaEspera, pilaAcciones, RefrescarDashboard);
            form.ShowDialog();
            RefrescarDashboard();
        }

        private void btnAtenderPaciente_Click(object sender, EventArgs e)
        {
            frmAtencionPaciente form = new frmAtencionPaciente(
                                                                colaEspera,
                                                                medicosEnTurno,
                                                                historialAtenciones,
                                                                pilaAcciones
                                                            );

            form.ShowDialog();
            RefrescarDashboard();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmHistorialPaciente form = new frmHistorialPaciente(historialAtenciones);
            form.ShowDialog();
        }

        private void btnRotacion_Click(object sender, EventArgs e)
        {
            frmRotacionMedico ventana = new frmRotacionMedico(medicosEnTurno, pilaAcciones);
            ventana.ShowDialog();
            RefrescarDashboard();
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            frmDeshacerAccion ventana = new frmDeshacerAccion(pilaAcciones);
            ventana.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTopInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphUtils.Instancia.MostrarGrafo();
        }
    }
}
