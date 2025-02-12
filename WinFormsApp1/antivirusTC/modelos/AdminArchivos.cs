namespace antivirusTC.modelos;

public class AdminArchivos
{
    private string _rutaArchivo;
    private byte[] _bytesArchivo;

    public AdminArchivos(string rutaArchivo)
    {
        _rutaArchivo = rutaArchivo;
        _bytesArchivo = File.ReadAllBytes(_rutaArchivo);
    }
    
    public byte[] GetBytes()
    {
        return _bytesArchivo;
    }
}