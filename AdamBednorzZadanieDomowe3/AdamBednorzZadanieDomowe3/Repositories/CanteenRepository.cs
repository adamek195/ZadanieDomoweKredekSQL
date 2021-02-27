using AdamBednorzZadanieDomowe3.Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace AdamBednorzZadanieDomowe3.Repositories
{
    /// <summary>
    /// Klasa defiunująca metody związane z komunikacją z bazą danych dla tabeli Canteen
    /// </summary>
    class CanteenRepository : Repository, ICanteenRepository
    {
        public DataTable GetDishes()
        {
            string queryDishes = "SELECT* FROM Canteen ;";
            SqlDataAdapter adapter = new SqlDataAdapter(queryDishes, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
