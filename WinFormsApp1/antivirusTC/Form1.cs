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
        private const string seleccionarArchivo = "Seleccionar Archivo";
        private const string mensajeSinArchivo = "Por favor seleccione un archivo";
        private const string mensajeSinVirus = "No se ha encontrado ningun virus";
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
            
            
            if (lblSeleccionar.Text.Equals(seleccionarArchivo)) txtResultados.Text = mensajeSinArchivo;
            else
            {
                _rutaArchivo = openFileDialog1.FileName;
                _adminArchivos = new AdminArchivos(_rutaArchivo);
                List<Virus> virusEncontrados = _analizador.BuscarVirus(_adminArchivos.GetBytes());
                StringBuilder mensajeFinal = new StringBuilder();
                
                if (virusEncontrados.Count == Cero) mensajeFinal.Append(mensajeSinVirus);
                else
                {
                    for (int i = 0; i < virusEncontrados.Count; i++)
                    {
                        mensajeFinal.Append($"{i+1}: {virusEncontrados[i].GetNombreVirus()}\n");
                    }
                }
                txtResultados.Text = mensajeFinal.ToString();
            }
        }

        
        
    }
}
