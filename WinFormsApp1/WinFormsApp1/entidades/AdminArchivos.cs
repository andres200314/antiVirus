namespace WinFormsApp1.entidades;

public class AdminArchivos
{
    private string RutaArchivo;
    private byte[] BytesArchivo;

    public AdminArchivos(string rutaArchivo)
    {
        RutaArchivo = rutaArchivo;
        BytesArchivo = File.ReadAllBytes(RutaArchivo);
    }
    
    public byte[] GetBytes()
    {
        return BytesArchivo;
    }
}