using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotacaTruco
{

    public abstract class Archivo
    {
        protected abstract string Extencion { get; }

        /// <summary>
        /// recibe una ruta y verifica que la extencion sea la correspondiente
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        /// <exception cref="ArchivoIncorrectoExcepcion"></exception>
        public bool ValidarExtencion(string ruta)
        {
            if (Path.GetExtension(ruta) == Extencion)//devuelve extencion del archvio ej: .txt
            {
                return true;
            }
            else
            {
                throw new ArchivoIncorrectoExcepcion($"El archivo no tiene la extencion {Extencion}");
            }
        }

        /// <summary>
        /// valida que el archvio ya exista
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        /// <exception cref="ArchivoIncorrectoExcepcion"></exception>
        public bool ValidarSiExisteElArchivo(string ruta)
        {
            if (File.Exists(ruta))//valido que exista el archvio
            {
                return true;
            }
            else
            {
                throw new ArchivoIncorrectoExcepcion("El archivo no se encontro");
            }
        }
    }

}
