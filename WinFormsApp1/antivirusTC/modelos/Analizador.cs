namespace antivirusTC.modelos;

/// <summary>
/// Clase encargada de analizar archivos en busca de firmas de virus conocidas.
/// Autores: Andrés Arroyave Cardona, Juan Jerónimo Tabares
/// Nombre del programa: Heimdall
/// Fecha: 23/02/2025
/// </summary>
public class Analizador
{
    /// <summary>
    /// Lista que almacena los virus.
    /// </summary>
    private List<Virus> _listaVirus = LlenarListaVirus();

    /// <summary>
    /// Busca los virus en un archivo a partir de su secuencia de bytes.
    /// <param>bytesArchivo= Arreglo de bytes que representa el contenido del archivo a analizar.</param>
    /// <returns> Mensaje= Un arreglo de strings con el resultado del análisis. mensaje[0] contiene los nombres de los virus encontrados y mensaje[1] el estado final del analisis.</returns>
    /// </summary>
    public string[] BuscarVirus(byte[] bytesArchivo)
    {
        try
        {
            string[] mensaje = new string[2];
            mensaje[0] = "";
            mensaje[1] = "q0";

            for (int i = 0; i < bytesArchivo.Length-1; i++) {
                
                // Comparación de secuencias de bytes con firmas de virus almacenadas
                 if (bytesArchivo[i] == _listaVirus[0].GetSecuenciaVirus()[0]) {
                    mensaje[1] = "q1";
                    if (bytesArchivo[i + 1] == _listaVirus[0].GetSecuenciaVirus()[1]) {
                        mensaje[1] = "q2";
                        if (bytesArchivo[i + 2] == _listaVirus[0].GetSecuenciaVirus()[2]) {
                            mensaje[1] = "q1";
                            if (bytesArchivo[i + 3] == _listaVirus[0].GetSecuenciaVirus()[3]) {
                                mensaje[1] = "q3";
                                mensaje[0] += Environment.NewLine + "Usama ";
                            }
                        }
                    }
                }
                //amtrax
                if (bytesArchivo[i] == _listaVirus[1].GetSecuenciaVirus()[0]) {
                    mensaje[1] = "q4";
                    if (bytesArchivo[i + 1] == _listaVirus[1].GetSecuenciaVirus()[1]) {
                        mensaje[1] = "q4";
                        if (bytesArchivo[i + 2] == _listaVirus[1].GetSecuenciaVirus()[2]) {
                            mensaje[1] = "q1";
                            if (bytesArchivo[i + 3] == _listaVirus[1].GetSecuenciaVirus()[3]) {
                                mensaje[1] = "q5";
                                mensaje[0] += Environment.NewLine + "Amtrax ";
                            }
                        }
                    }
                }
                //ebola
                if (bytesArchivo[i] == _listaVirus[2].GetSecuenciaVirus()[0]) {
                    mensaje[1] = "q5";
                    if (bytesArchivo[i + 1] == _listaVirus[2].GetSecuenciaVirus()[1]) {
                        mensaje[1] = "q6";
                        if (bytesArchivo[i + 2] == _listaVirus[2].GetSecuenciaVirus()[2]) {
                            mensaje[1] = "q7";
                            if (bytesArchivo[i + 3] == _listaVirus[2].GetSecuenciaVirus()[3]) {
                                mensaje[1] = "q5";
                                mensaje[0] += Environment.NewLine + "Ah1n1 ";
                            }
                        }
                    }
                }
                //ah1n1
                if (bytesArchivo[i] == _listaVirus[3].GetSecuenciaVirus()[0]) {
                    mensaje[1] = "q4";
                    if (bytesArchivo[i + 1] == _listaVirus[3].GetSecuenciaVirus()[1]) {
                        mensaje[1] = "q6";
                        if (bytesArchivo[i + 2] == _listaVirus[3].GetSecuenciaVirus()[2]) {
                            mensaje[1] = "q6";
                            if (bytesArchivo[i + 3] == _listaVirus[3].GetSecuenciaVirus()[3]) {
                                mensaje[1] = "q8";
                                mensaje[0] += Environment.NewLine + "Ebola ";
                            }
                        }
                    }
                }
                //Covid19
                if (bytesArchivo[i] == _listaVirus[4].GetSecuenciaVirus()[0]) {
                    mensaje[1] = "q2";
                    if (bytesArchivo[i + 1] == _listaVirus[4].GetSecuenciaVirus()[1]) {
                        mensaje[1] = "q10";
                        if (bytesArchivo[i + 2] == _listaVirus[4].GetSecuenciaVirus()[2]) {
                            mensaje[1] = "q8";
                            if (bytesArchivo[i + 3] == _listaVirus[4].GetSecuenciaVirus()[3]) {
                                mensaje[1] = "q9";
                                mensaje[0] += Environment.NewLine + "Covid19 ";
                            }
                        }
                    }
                }

                
            }
            
            return mensaje;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Error inesperado");
        }
    }
    
    /// <summary>
    /// Llena la lista de virus con las firmas almacenadas desde un archivo de texto.
    /// <returns>listaVirus= Lista de objetos Virus con sus nombres y secuencias de bytes.</returns>
    /// </summary>
    
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
