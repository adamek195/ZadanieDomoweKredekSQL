using System.Data.SqlClient;
using AdamBednorzZadanieDomowe3.Repositories.Interfaces;

namespace AdamBednorzZadanieDomowe3.Repositories
{
    /// <summary>
    /// Klasa defiunująca metody związane z komunikacją z bazą danych dla tabeli Patients 
    /// </summary>
    public class PatientsRepository : Repository, IPatientsRepository
    {
        public bool Login(string firstName, string lastName, string password)
        {
            //tworzymy zapytanie Sql wyszukujące nam rekord czy taki pacjent istnieje w systemie
            string query = "SELECT COUNT(*) FROM Patients WHERE FirstName='" + firstName + "' AND LastName='" + lastName + "' AND Password='" + password + "';";

            //otwieramy połączenie
            Connection.Open();

            SqlCommand command = new SqlCommand(query, Connection);
            int foundPatients = (int)command.ExecuteScalar();

            //zamykamy połączenie
            Connection.Close();

            //jezli istnieje taki rekord w bazie z podanymi danymi
            if (foundPatients >= 1)
                return true;

            return false;
        }

        /// <summary>
        /// Metoda dodajaca do bazy danych pacjentów konto nowego pacjenta
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        public void AddPatient(string firstName, string lastName, string password)
        {
            string insertPatientQuery = "INSERT INTO Patients(FirstName, LastName, Password) VALUES ('" + firstName + "', '" + lastName + "', '" + password + "');";

            //otwieramy polaczenie
            Connection.Open();

            SqlCommand commandInsertPatient = new SqlCommand(insertPatientQuery, Connection);
            commandInsertPatient.ExecuteNonQuery();

            //zamykamy polaczenie
            Connection.Close();
        }

        /// <summary>
        /// Metoda ktora usuwa konto pacjenta z bazy danych
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        public void DeletePatient(string firstName, string lastName, string password)
        {
            string queryDeletePatient = "DELETE FROM Patients WHERE FirstName = '" + firstName + "' AND LastName = '" + lastName + "' AND Password = '" + password + "';";

            Connection.Open();

            SqlCommand commandDeletePatient = new SqlCommand(queryDeletePatient, Connection);
            commandDeletePatient.ExecuteNonQuery();

            Connection.Close();
        }

        /// <summary>
        /// metoda pozwalajaca na zmiane hasla w bazie danych
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        public void ChangePassword(string firstName, string lastName, string password, string newPassword)
        {
            string querySetPassword = "UPDATE patients SET Password = '" + newPassword + "' WHERE FirstName = '" + firstName + "' AND LastName = '" + lastName + "' AND Password = '" + password + "';";

            Connection.Open();

            SqlCommand commandSetPassword = new SqlCommand(querySetPassword, Connection);
            commandSetPassword.ExecuteNonQuery();

            Connection.Close();
        }
    }
}
