using System.Data.SqlClient;

namespace AdamBednorzZadanieDomowe3.Repositories
{
    /// <summary>
    /// Klasa abstrakcyjna mająca zmienne i/lub metody, które każde repzoytorium powinno zawierać
    /// </summary>
    public abstract class Repository
    {
        /// <summary>
        /// Zmienna przechowująca połączenie z bazą danych
        /// </summary>
        protected readonly SqlConnection Connection;

        protected Repository()
        {
            //inicjalizacja połączenia z bazą danych
            Connection = new SqlConnection(Properties.Resources.ConnectionString);
        }
    }
}
