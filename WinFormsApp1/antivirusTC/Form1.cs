using antivirusTC.modelos;

namespace antivirusTC
{
    /// <summary>
    /// Clase principal del formulario que permite la interacción con el usuario.
    /// Autores: Andrés Arroyave Cardona, Juan Jerónimo Tabares
    /// Nombre del programa: Heimdall
    /// Fecha: 23/02/2025
    /// </summary>
    public partial class Form1 : Form
    {
        private Analizador _analizador = new Analizador();
        private AdminArchivos _adminArchivos;
        private string _rutaArchivo;
        
        // Constantes de clase
        private const string SeleccionarArchivo = "Seleccionar Archivo";
        private const string MensajeSinArchivo = "Por favor seleccione un archivo";
        private const string MensajeSinVirus = "No se ha encontrado ningun virus";
        private const byte Cero = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de selección de archivo.
        /// Abre un cuadro de diálogo para seleccionar un archivo y muestra su ruta.
        /// </summary>
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _rutaArchivo = openFileDialog1.FileName;
                _adminArchivos = new AdminArchivos(_rutaArchivo);
                lblSeleccionar.Text = _rutaArchivo;
                txtBytes.Text = string.Join("", _adminArchivos.GetBytes());
                txtResultados.Clear();
                txtEstado.Clear();
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de escaneo de archivo.
        /// Analiza el archivo seleccionado en busca de virus y muestra los resultados.
        /// </summary>
        private void btnEscanear_Click(object sender, EventArgs e)
        {
            if (lblSeleccionar.Text.Equals(SeleccionarArchivo)) 
                txtResultados.Text = MensajeSinArchivo;
            else
            {
                _rutaArchivo = openFileDialog1.FileName;
                _adminArchivos = new AdminArchivos(_rutaArchivo);
                string[] mensajeFinal = _analizador.BuscarVirus(_adminArchivos.GetBytes());

                if (mensajeFinal[0].Length == Cero) mensajeFinal[0] = MensajeSinVirus;
                txtResultados.Text = mensajeFinal[0];
                txtEstado.Text = mensajeFinal[1];
            } 
        }
    }
}
