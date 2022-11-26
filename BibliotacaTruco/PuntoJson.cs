using BibliotacaTruco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace BibliotecaTruco
{
    /// <summary>
    /// hereda de archivo e implementa la interfaz IArchivo. Es generico
    /// </summary>
    public class PuntoJson<T> : Archivo, IArchivo<T>
        where T : class//restrinjo el tipo t y que sea de referncia
    {
        #region PROPIEDADES
        /// <summary>
        /// retorna la extencion
        /// </summary>
        protected override string Extencion
        {
            get
            {
                return ".json";
            }
        }
        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// Guarda el archivo en caso de que exista
        /// </summary>
        /// <param name="ruta"> ruta del archivo</param>
        /// <param name="contenido"> contenido a serializar</param>
        /// <returns>True fue guardado y false si no fue guardado</returns>
        public bool Guardar(string ruta, T contenido)
        {
            bool retorno = false;
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtencion(ruta))
            {
                this.Serializar(ruta,contenido);
                retorno = true;
            }
            return retorno;  
        }
        /// <summary>
        /// Guarda archivo por primera vez
        /// </summary>
        /// <param name="ruta">Ruta donde se guardara el archivo</param>
        /// <param name="contenido">Contenido a guardar</param>
        /// <returns></returns>
        public bool GuardarComo(string ruta, T contenido)
        {
            bool retorno = false;
            if (ValidarExtencion(ruta))//valido que la ruta sea valida
            {
                retorno = true;
                Serializar(ruta, contenido);
            }
            return retorno;
        }
        /// <summary>
        /// Serializa y escribe archivo
        /// </summary>
        /// <param name="ruta">Ruta deonde se escribira el archivo</param>
        /// <param name="contenido">Conteniudo a serializar y escribir en archivo</param>
        private void Serializar(string ruta, T contenido)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();

            //opciones.WriteIndented = true;
            using (StreamWriter Writer = new StreamWriter(ruta,true))//recibe ruta dionde guardo archivo para optimizar recursos, true porque indico que se sobreescribira
            {
                //string json = JsonSerializer.Serialize(contenido);//invoco metodo estatico para serializar y serializo. Guardo en string
                string json = JsonSerializer.Serialize(contenido );//invoco metodo estatico para serializar y serializo. Guardo en string
                Writer.Write(json);//paso contenido a serilizar y lo escribo en archivo
            }
        }
        /// <summary>
        /// Lee un archivo serializado
        /// </summary>
        /// <param name="ruta">Ruta la cual se leera</param>
        /// <returns>Retorna el contenido deserializado del archivo</returns>
        public T Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtencion(ruta))//valido rutas
            {
                using StreamReader streamReader = new StreamReader(ruta);//instancia stream reader 
                {
                    string json = streamReader.ReadToEnd();//leo la ruta hasta el final y la guardo en string json

                    T contenido = JsonSerializer.Deserialize<T>(json);//invoco metodo para deserializar, paso el archivo leido
                    return contenido;
                }

            }
            return null;
        }
        #endregion METODOS
    }
}