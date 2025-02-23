namespace antivirusTC
{
    /// <summary>
    /// Clase principal del programa que inicializa la aplicación.
    /// Autores: Andrés Arroyave Cardona, Juan Jerónimo Tabares
    /// Nombre del programa: Heimdall
    /// Fecha: 23/02/2025
    /// </summary>
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}