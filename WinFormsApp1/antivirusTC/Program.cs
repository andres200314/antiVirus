using antivirusTC.entidades;

namespace antivirusTC
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // lista virus
            List<Virus> listaVirus = llenarListaVirus(new List<Virus>());
            
            // Form
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(listaVirus));
            
        }

        public static List<Virus> llenarListaVirus(List<Virus> listaVirus)
        {
            StreamReader sr = new StreamReader("..\\..\\..\\files\\firmas.txt");
            string linea = sr.ReadLine();
            
            while (linea != null)
            {
                listaVirus.Add(new Virus(
                    linea.Split(':')[0],  // Nombre del virus
                    linea.Split(':')[1].Split(';')  // Firma
                        .Select(byte.Parse)  // Convertir cada valor a byte
                        .ToArray()  // Convertir a byte[]
                ));
                linea = sr.ReadLine();
            }

            return listaVirus;
        }

        
    }
}