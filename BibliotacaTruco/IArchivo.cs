using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotacaTruco
{
    public interface IArchivo<T>
    {
        /// <summary>
        /// comprobará que el archivo exista, en cuyo caso guardará el contenido en el archivo.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="contenido"></param>
        bool Guardar(string ruta, T contenido);

        /// <summary>
        /// guardará el contenido en un nuevo archivo, sólamente comprobando que la extensión sea la correcta.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="contenido"></param>
        bool GuardarComo(string ruta, T contenido);

        /// <summary>
        /// comprobará que el archivo existe, en cuyo caso retornará su contenido.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="contenido"></param>
        /// <returns></returns>
        
         //T Leer(string ruta);

        List<T> Leer(string ruta);
    }
}
