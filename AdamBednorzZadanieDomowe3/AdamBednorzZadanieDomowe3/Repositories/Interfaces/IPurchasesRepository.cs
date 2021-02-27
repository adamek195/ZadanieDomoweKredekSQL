using System.Data;


namespace AdamBednorzZadanieDomowe3.Repositories.Interfaces
{
    interface IPurchasesRepository
    {
        /// <summary>
        /// abstrakcyjna metoda do pobierania wszystkich zamówień na lekarstwa od pacjentów
        /// </summary>
        /// <returns></returns>
        DataTable GetPurchases();
        /// <summary>
        /// abstrakcyjna metoda dodajaca zamówienie lekarstwa od pacjenta
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="medicine"></param>
        void AddPurchase(string firstName, string lastName, string password, string medicine);
    }
}
