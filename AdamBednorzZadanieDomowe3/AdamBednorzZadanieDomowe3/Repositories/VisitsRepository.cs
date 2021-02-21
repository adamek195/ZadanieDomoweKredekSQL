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
    /// Klasa defiunująca metody związane z komunikacją z bazą danych dla tabeli Visits
    /// </summary>
    public class VisitsRepository: Repository, IVisitsRepository
    {
        /// <summary>
        /// metoda pobierajaca dane z tabeli Visits
        /// </summary>
        /// <returns></returns>
        public DataTable GetVisits()
        {
            string queryVisits = "SELECT* FROM Visits ;";
            SqlDataAdapter adapter = new SqlDataAdapter(queryVisits, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        /// <summary>
        /// metoda dodajaca nowa wizyte w systemie u lekarza
        /// </summary>
        /// <param name="idPatient"></param>
        /// <param name="idDoctor"></param>
        public void AddVisit(string firstName, string lastName, string password, string typeDoctor)
        {
            string queryGetPatientId = "SELECT Id FROM Patients WHERE FirstName='" + firstName + "' AND LastName='" + lastName + "' AND Password= '" + password + "';";
            string queryGetDoctorId = "SELECT Id from Doctors WHERE Type='" + typeDoctor + "';";

            Connection.Open();

            SqlCommand commandGetPatientId = new SqlCommand(queryGetPatientId, Connection);
            int patientId = (int)commandGetPatientId.ExecuteScalar();

            SqlCommand commandGetDoctorId = new SqlCommand(queryGetDoctorId, Connection);
            int doctorId = (int)commandGetDoctorId.ExecuteScalar();


            string insertVisitQuery = "INSERT INTO Visits VALUES ('" + patientId + "'," + doctorId + ");";
            SqlCommand commandInsertVisit = new SqlCommand(insertVisitQuery, Connection);
            commandInsertVisit.ExecuteNonQuery();

            Connection.Close();
        }
    }
}
