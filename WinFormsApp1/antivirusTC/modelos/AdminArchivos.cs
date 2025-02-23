namespace antivirusTC.modelos;

/// <summary>
/// Clase encargada de la administración de archivos, permitiendo la lectura de sus bytes.
/// Autores: Andrés Arroyave Cardona, Juan Jerónimo Tabares
/// Nombre del programa: Heimdall
/// Fecha: 23/02/2025
/// </summary>
public class AdminArchivos
{
    private string _rutaArchivo;
    private byte[] _bytesArchivo;
    public AdminArchivos(string rutaArchivo)
    {
        _rutaArchivo = rutaArchivo;
        // Verificar si el archivo existe en la ruta, sino un array vacío
        _bytesArchivo = File.Exists(rutaArchivo) ? File.ReadAllBytes(rutaArchivo) : [];
    }
        
    /// <summary>
    /// Obtiene los bytes del archivo leído.
    /// <returns>Arreglo de bytes del archivo</returns>
    /// </summary>
    public byte[] GetBytes() => _bytesArchivo;
}