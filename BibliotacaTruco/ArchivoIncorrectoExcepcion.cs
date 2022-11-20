using System.Runtime.Serialization;

namespace BibliotacaTruco
{
    [Serializable]
    public class ArchivoIncorrectoExcepcion : Exception
    {
        public ArchivoIncorrectoExcepcion()
        {
        }      

        public ArchivoIncorrectoExcepcion(string? message) : base(message)
        {
        }


    }
}