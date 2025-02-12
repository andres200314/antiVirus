namespace antivirusTC.modelos;

public class Analizador
{
    private List<Virus> _listaVirus = LlenarListaVirus();


    public List<Virus> BuscarVirus(byte[] bytesArchivo)
    {
        try
        {
            List<Virus> listaVirusEncontrados = new List<Virus>();

            byte[] bytesVirus;
            int coincidencias;

            foreach (var virus in _listaVirus)
            {
                bytesVirus = virus.GetSecuenciaVirus();
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
    
    private static List<Virus> LlenarListaVirus()
    {
        List<Virus> listaVirus = new List<Virus>();
        StreamReader sr = new StreamReader("..\\..\\..\\files\\firmas.txt");
        var linea = sr.ReadLine();
            
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