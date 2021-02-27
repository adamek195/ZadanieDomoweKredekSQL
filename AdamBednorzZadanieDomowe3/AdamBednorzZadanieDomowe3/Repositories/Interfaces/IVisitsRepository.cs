using System.Data;


namespace AdamBednorzZadanieDomowe3.Repositories.Interfaces
{
    interface IVisitsRepository
    {
        /// <summary>
        /// abstrakcyjna metoda do pobierania wszystkich wizyt lekarskich umowionych z pacjentami
        /// </summary>
        DataTable GetVisits();
        /// <summary>
        /// ///abstrakcyjna metoda dodajaca nowa wizyte w systemie
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="typeDoctor"></param>
        void AddVisit(string firstName, string lastName, string password, string typeDoctor);
    }
}
