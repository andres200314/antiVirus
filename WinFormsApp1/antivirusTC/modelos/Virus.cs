namespace antivirusTC.modelos
{
    public class Virus
    {
        private string _nombreVirus;
        private byte[] _secuenciaVirus;

        public Virus(string nombreVirus, byte[] secuenciaVirus)
        {
            _nombreVirus = nombreVirus;
            _secuenciaVirus = secuenciaVirus;
        }
        
        public string GetNombreVirus(){return _nombreVirus;}
        
        public byte[] GetSecuenciaVirus(){return _secuenciaVirus;}
        
    }
}
