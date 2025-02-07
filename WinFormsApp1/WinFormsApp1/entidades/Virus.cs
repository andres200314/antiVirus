using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.entidades
{
    internal class Virus
    {
        private string NombreVirus;
        private byte[] SecuenciaVirus;

        public Virus(string nombreVirus, byte[] secuenciaVirus)
        {
            NombreVirus = nombreVirus;
            SecuenciaVirus = secuenciaVirus;
        }
        
        public string getNombreVirus(){return NombreVirus;}
        public void setNombreVirus(string nombreVirus){NombreVirus = nombreVirus;}
        
        public byte[] getSecuenciaVirus(){return SecuenciaVirus;}
        public void setSecuenciaVirus(byte[] secuenciaVirus){SecuenciaVirus = secuenciaVirus;}

        
        
        
    }
}
