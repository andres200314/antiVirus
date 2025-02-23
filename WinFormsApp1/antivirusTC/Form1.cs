using System.Text;
using antivirusTC.modelos;

namespace antivirusTC
{
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _rutaArchivo = openFileDialog1.FileName;
                _adminArchivos = new AdminArchivos(_rutaArchivo);
                lblSeleccionar.Text = _rutaArchivo;
                txtBytes.Text = string.Join("", _adminArchivos.GetBytes());

            }
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            if (lblSeleccionar.Text.Equals(SeleccionarArchivo)) txtResultados.Text = MensajeSinArchivo;
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
