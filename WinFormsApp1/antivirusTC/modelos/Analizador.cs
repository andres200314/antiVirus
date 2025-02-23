using System.Text;

namespace antivirusTC.modelos;

public class Analizador
{
    private List<Virus> _listaVirus = LlenarListaVirus();


    public string[] BuscarVirus(byte[] bytesArchivo)
    {
        try
        {
            string[] mensaje = new string[2];
            mensaje[0] = "";
            mensaje[1] = "q0";

            for (int i = 0; i < bytesArchivo.Length - 3; i++) {

                //Usama
                if (bytesArchivo[i] == _listaVirus[0].GetSecuenciaVirus()[0]) {
                    mensaje[1] = "q1";
                    if (bytesArchivo[i + 1] == _listaVirus[0].GetSecuenciaVirus()[1]) {
                        mensaje[1] = "q2";
                        if (bytesArchivo[i + 2] == _listaVirus[0].GetSecuenciaVirus()[2]) {
                            mensaje[1] = "q1";
                            if (bytesArchivo[i + 3] == _listaVirus[0].GetSecuenciaVirus()[3]) {
                                mensaje[1] = "q3";
                                // System.out.println("Usama");//OK para usama
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
                                // System.out.println("ah1n1");//OK para ah1n1
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
                                // System.out.println("ebola");//OK para ebola
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
                                //System.out.println("Covid19");//OK para covid19
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