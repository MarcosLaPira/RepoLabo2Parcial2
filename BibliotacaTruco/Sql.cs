using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotacaTruco
{
    public class Sql
    {
        #region ATRIBUTOS
        private static string conectionString;
        private static SqlConnection conection;
        private static SqlCommand comand;
        #endregion ATRIBUTOS

        #region METODOS
        static Sql()
        {

            // Sql.conectionString = "Server = \\MARCOS ; Database = Cartas ; Trusted_Connection = True; ";// Server = MARCOS nombre del servidor // Database = Clientes nombre de base de datos
            Sql.conectionString = "Server=.;Database=Cartas;User Id=sa;Trusted_Connection=True;TrustServerCertificate=True";
            // Sql.conectionString = $"Data Source = .; Initial Catalog = Cartas; Integrated Security = True";
            Sql.conection = new SqlConnection(Sql.conectionString);//instancio puente entre programa y base de datos

            Sql.comand = new SqlCommand();//instancio el comando encargado de llevar la coneccion

            Sql.comand.Connection = Sql.conection;//le paso la coneccion
            Sql.comand.CommandType = CommandType.Text;//indico el tipo de comando, comadno de texto osea que  esto comand.CommandText = "SELECT * FROM Clientes"; va a ser string
        }
        /// <summary>
        /// Obtiene cartas de la base de datos
        /// </summary>
        /// <returns> lista de cartas</returns>
        public List<Carta> ObtenerCartas()
        {
            List<Carta> cartas = new List<Carta>();

            Sql.conection.Open();//abro coneccion

            Sql.comand.CommandText = "SELECT * FROM TablaCartas";//introduzco LA QERY  a traer

            SqlDataReader reader;//obj donde leo tabla

            reader = comand.ExecuteReader();//leo toda la info de la tabla y la almaceno en reader

            while (reader.Read())//propiedad read, devuelve true si hay una fila por leer
            {
                //indico donde voy a almacenar cada campo
                int bufferIndiceCarta = reader.GetInt32(0); //Convert.ToInt32(reader["id"]); reader.GetInt32(0);
                int bufferPalo = reader.GetInt32(1);
                int bufferIndiceValor = reader.GetInt32(2); //reader.IsDBNull(2) ?;

                Carta cartaLeida = new Carta(bufferIndiceCarta, (EPalo)bufferPalo, (EIndiceValor)bufferIndiceValor);//INSTANCIO EL CLIENTE
                if (cartaLeida != null)
                {
                    cartas.Add(cartaLeida);
                }
            }
            if (Sql.conection.State == ConnectionState.Open)//Verifico si el estado de la coneccion esta abierto, de ser asi lo cierro
            {
                Sql.conection.Close();//Cierro coneccion
            }

            return cartas;
        }

        /// <summary>
        /// recibe una carta y la guarda en la base
        /// </summary>
        /// <param name="carta"></param>
        public void AgregarCarta(Carta carta)
        {
            try
            {
                Sql.conection.Open();

                Sql.comand.CommandText = "INSERT INTO TablaCartas VALUES (@numeroCarta, @palo, @indiceCarta)";//parametrizo con el @, la arroba me indica que es una variable

                //@se usa para prevenir inyeccion de sql, es decir donde espero un string no me pueda ingresar un UPDATE y robarme datos
                //agrego informacion a la variable
                Sql.comand.Parameters.AddWithValue("@numeroCarta", carta.NumeroCarta);
                Sql.comand.Parameters.AddWithValue("@palo", (int)carta.Palo);
                Sql.comand.Parameters.AddWithValue("@indiceCarta", (int)carta.IndiceCarta);

                //ejecutar la query, ejecuta el comando de texto
                Sql.comand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Sql.comand.Parameters.Clear();//limpio los parametros actuales lineas 77 y 78

                if (Sql.conection.State == ConnectionState.Open)//Verifico si el estado de la coneccion esta abierto, de ser asi lo cierro
                {
                    Sql.conection.Close();//Cierro coneccion
                }
            }
        }
        #endregion METODOS
    }

}
