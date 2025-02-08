using System.Text;
using antivirusTC.modelos;

namespace antivirusTC
{
    public partial class Form1 : Form
    {
        private List<Virus> ListaVirus { get; set; }
        private Analizador analizador { get; set; }
        
        public Form1(List<Virus> listaVirus)
        {
            ListaVirus = listaVirus;
            analizador = new Analizador();
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
            if (lblSeleccionar.Text.Equals("Seleccionar Archivo")) txtResultados.Text = "Por favor seleccione un archivo";
            else
            {
                AdminArchivos adminArchivos = new AdminArchivos(openFileDialog1.FileName);
                List<Virus> virusEncontrados = analizador.buscarVirus(adminArchivos.GetBytes(), ListaVirus);
                StringBuilder mensajeFinal = new StringBuilder();
                
                if (virusEncontrados.Count == 0) mensajeFinal.Append("No se ha encontrado ningun virus");
                else
                {
                    for (int i = 0; i < virusEncontrados.Count; i++)
                    {
                        mensajeFinal.Append($"{i+1}: {virusEncontrados[i].getNombreVirus()}\n");
                    }
                }
                txtResultados.Text = mensajeFinal.ToString();
            }
        }

        
        
    }
}
