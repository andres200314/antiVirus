namespace antivirusTC.modelos;

public class Analizador
{
    public Analizador(){}

    public List<Virus> buscarVirus(byte[] bytesArchivo, List<Virus> listaVirus)
    {
        try
        {
            List<Virus> listaVirusEncontrados = new List<Virus>();

            byte[] bytesVirus = new byte[0];
            int coincidencias = 0;

            foreach (var virus in listaVirus)
            {
                bytesVirus = virus.getSecuenciaVirus();
                coincidencias = 0;


                for (int i = bytesVirus.Length - 1; i < bytesArchivo.Length; i++)
                {
                    if (bytesArchivo[i] == bytesVirus[^1])
                    {
                        coincidencias++;
                        for (int j = 1; j < bytesVirus.Length; j++)
                        {
                            if (bytesArchivo[i - j] == bytesVirus[bytesVirus.Length - 1 - j])
                            {
                                coincidencias++;
                            }
                            else
                            {
                                coincidencias = 0;
                                break;
                            }
                        }

                        if (coincidencias == bytesVirus.Length) listaVirusEncontrados.Add(virus);
                        coincidencias = 0;
                    }
                }
            }

            return listaVirusEncontrados;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Error inesperado");
        }
    }
}