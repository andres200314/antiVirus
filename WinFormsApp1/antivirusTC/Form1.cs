using System.Text;
using antivirusTC.modelos;

namespace antivirusTC
{
    public partial class Form1 : Form
    {
        private Analizador _analizador = new Analizador();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblSeleccionar.Text = openFileDialog1.FileName;
            }
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            const string seleccionarArchivo = "Seleccionar Archivo";
            const string mensajeSinArchivo = "Por favor seleccione un archivo";
            const string mensajeSinVirus = "No se ha encontrado ningun virus";
            const byte cero = 0;
            
            if (lblSeleccionar.Text.Equals(seleccionarArchivo)) txtResultados.Text = mensajeSinArchivo;
            else
            {
                AdminArchivos adminArchivos = new AdminArchivos(openFileDialog1.FileName);
                List<Virus> virusEncontrados = _analizador.BuscarVirus(adminArchivos.GetBytes());
                StringBuilder mensajeFinal = new StringBuilder();
                
                if (virusEncontrados.Count == cero) mensajeFinal.Append(mensajeSinVirus);
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
