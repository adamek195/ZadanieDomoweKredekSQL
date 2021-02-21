using AdamBednorzZadanieDomowe3.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe3.Repositories
{
    /// <summary>
    /// Klasa defiunująca metody związane z komunikacją z bazą danych dla tabeli Purchases
    /// </summary>
    public class PurchasesRepository : Repository, IPurchasesRepository
    {
        /// <summary>
        /// metoda pobierajaca dane z tabeli Purchases
        /// </summary>
        /// <returns></returns>
        public DataTable GetPurchases()
        {
            string queryPurchases = "SELECT* FROM Purchases ;";
            SqlDataAdapter adapter = new SqlDataAdapter(queryPurchases, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        /// <summary>
        /// metoda dodajaca do bazy Purchase zamówienia pacjentów na lekarstwa
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="medicine"></param>
        public void AddPurchase(string firstName, string lastName, string password, string medicine)
        {
            string queryGetPatientId = "SELECT Id FROM Patients WHERE FirstName='" + firstName + "' AND LastName='" + lastName + "' AND Password= '" + password + "';";
            string queryGetPharmacyId = "SELECT Id from Pharmacy WHERE Medicine='" + medicine + "';";

            Connection.Open();

            SqlCommand commandGetPatientId = new SqlCommand(queryGetPatientId, Connection);
            int patientId = (int)commandGetPatientId.ExecuteScalar();

            SqlCommand commandGetPharmacyId = new SqlCommand(queryGetPharmacyId, Connection);
            int pharmacyId = (int)commandGetPharmacyId.ExecuteScalar();


            string insertPurchaseQuery = "INSERT INTO Purchases VALUES ('" + patientId + "'," + pharmacyId + ");";
            SqlCommand commandInsertPurchase = new SqlCommand(insertPurchaseQuery, Connection);
            commandInsertPurchase.ExecuteNonQuery();

            Connection.Close();
        }
    }
}
