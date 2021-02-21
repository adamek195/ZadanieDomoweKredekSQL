using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdamBednorzZadanieDomowe3.Repositories.Interfaces;

namespace AdamBednorzZadanieDomowe3.Repositories
{
    /// <summary>
    /// Klasa defiunująca metody związane z komunikacją z bazą danych dla tabeli Doctors 
    /// </summary>
    public class DoctorsRepository: Repository, IDoctorsRepository
    {
        /// <summary>
        /// metoda pobierajaca dane z tabeli Doctors
        /// </summary>
        /// <returns></returns>
        public DataTable GetDoctors()
        {
            string queryDoctors = "SELECT* FROM Doctors ;";
            SqlDataAdapter adapter = new SqlDataAdapter(queryDoctors, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
