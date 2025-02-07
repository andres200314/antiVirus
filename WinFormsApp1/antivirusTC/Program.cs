using antivirusTC.entidades;

namespace antivirusTC
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // ApplicationConfiguration.Initialize();
            // Application.Run(new Form1());
            
            // lista virus
            List<Virus> listaVirus = llenarListaVirus(new List<Virus>());
            
            // Analizador
            Analizador analizador = new Analizador();
            
            

        }

        public static List<Virus> llenarListaVirus(List<Virus> listaVirus)
        {
            StreamReader sr = new StreamReader("..\\..\\..\\files\\firmas.txt");
            string line = sr.ReadLine();
            
            while (line != null)
            {
                listaVirus.Add(new Virus(
                    line.Split(':')[0],  // Nombre del virus
                    line.Split(':')[1].Split(';')  // Firma
                        .Select(byte.Parse)  // Convertir cada valor a byte
                        .ToArray()  // Convertir a byte[]
                ));
                line = sr.ReadLine();
            }

            return listaVirus;
        }

        public static void crearArchivosPrueba()
        {
            // Definir firmas en bytes
            byte[] firmaInicio = { 15, 30, 15, 49 };  // Firma de "Usama"
            byte[] firmaFinal = { 30, 25, 20, 19 };   // Firma de "Covid19"

            // Crear datos aleatorios
            byte[] datosAleatorios = new byte[100]; // 100 bytes de relleno
            new Random().NextBytes(datosAleatorios); // Llenar con valores aleatorios

            // Archivo con la firma al inicio
            File.WriteAllBytes("inicio.bin", firmaInicio.Concat(datosAleatorios).ToArray());
            Console.WriteLine("Archivo 'inicio.bin' creado con la firma al inicio.");

            // Archivo con la firma al final
            File.WriteAllBytes("final.bin", datosAleatorios.Concat(firmaFinal).ToArray());
            Console.WriteLine("Archivo 'final.bin' creado con la firma al final.");
        }
    }
}