using System;

namespace AdamBednorzZadanieDomowe3.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Patients
    /// </summary>
    public interface IPatientsRepository
    {
        /// <summary>
        /// Abstrakcyjna metoda do logowania z tabeli Patients na podstawie danych i hasła
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Login(string firstName, string lastName,string password);
        /// <summary>
        /// Abstrakcyjna metoda do dodawania nowych pacjentow do bazy
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        void AddPatient(string firstName, string lastName, string password);
        /// <summary>
        /// abstrakcyjna metoda pozwalajace usunac konto pacjenta z bazy danych
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        void DeletePatient(string firstName,string lastName, string password);
        /// <summary>
        /// abstrakcyjna metoda pozwalajaca na zmiane hasla w systemie
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        void ChangePassword(string firstName, string lastName, string password, string newPassword);

    }
}
