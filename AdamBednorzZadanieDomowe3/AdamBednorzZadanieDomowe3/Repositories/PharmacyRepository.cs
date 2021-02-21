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
    /// Klasa defiunująca metody związane z komunikacją z bazą danych dla tabeli Pharmacy 
    /// </summary>
    public class PharmacyRepository: Repository, IPharmacyRepository
    {
        public DataTable GetPharmacies()
        {
            string queryPharmacies = "SELECT* FROM Pharmacy ;";
            SqlDataAdapter adapter = new SqlDataAdapter(queryPharmacies, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
