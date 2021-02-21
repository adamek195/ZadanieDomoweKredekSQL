using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //Inicjalizacja połączenia z bazą danych
            Connection = new SqlConnection(Properties.Resources.ConnectionString);
        }
    }
}
