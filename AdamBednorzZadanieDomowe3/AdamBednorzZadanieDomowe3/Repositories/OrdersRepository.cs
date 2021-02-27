using AdamBednorzZadanieDomowe3.Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace AdamBednorzZadanieDomowe3.Repositories
{
    class OrdersRepository: Repository, IOrdersRepository
    {
        /// <summary>
        /// metoda pobierajaca nam dane od pacjentów jakie zamówili dania
        /// </summary>
        /// <returns></returns>
        public DataTable GetOrders()
        {
            string queryOrders = "SELECT* FROM Orders ;";
            SqlDataAdapter adapter = new SqlDataAdapter(queryOrders, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// metoda pozwalajaca dodac zamowienie konretnego dania do bazy danych zamówien od pacjenta
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="dish"></param>
        public void AddOrder(string firstName, string lastName, string password, string dish)
        {
            string queryGetPatientId = "SELECT Id FROM Patients WHERE FirstName='" + firstName + "' AND LastName='" + lastName + "' AND Password= '" + password + "';";
            string queryGetDishId = "SELECT Id from Canteen WHERE Dish='" + dish + "';";

            Connection.Open();

            SqlCommand commandGetPatientId = new SqlCommand(queryGetPatientId, Connection);
            int patientId = (int)commandGetPatientId.ExecuteScalar();

            SqlCommand commandGetDishId = new SqlCommand(queryGetDishId, Connection);
            int dishId = (int)commandGetDishId.ExecuteScalar();


            string insertOrderQuery = "INSERT INTO ORDERS VALUES ('" + patientId + "'," + dishId + ");";
            SqlCommand commandInsertOrder = new SqlCommand(insertOrderQuery, Connection);
            commandInsertOrder.ExecuteNonQuery();

            Connection.Close();
        }
    }
}
