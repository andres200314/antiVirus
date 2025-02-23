namespace antivirusTC.modelos
{
    /// <summary>
    /// Clase que representa un virus con su nombre y su secuencia de bytes.
    /// Autores: Andrés Arroyave Cardona, Juan Jerónimo Tabares
    /// Nombre del programa: Heimdall
    /// Fecha: 23/02/2025
    /// </summary>
    public class Virus
    {
        private string _nombreVirus;
        private byte[] _secuenciaVirus;
        public Virus(string nombreVirus, byte[] secuenciaVirus)
        {
            _nombreVirus = nombreVirus;
            _secuenciaVirus = secuenciaVirus;
        }
        
        /// <summary>
        /// Obtiene el nombre del virus.
        /// <returns>Nombre del virus.</returns>
        /// </summary>
        
        public string GetNombreVirus(){return _nombreVirus;}
        
        /// <summary>
        /// Obtiene la secuencia de bytes del virus.
        /// <returns>Arreglo de bytes que representa la firma del virus.</returns>
        /// </summary>
        public byte[] GetSecuenciaVirus(){return _secuenciaVirus;}
        
    }
}