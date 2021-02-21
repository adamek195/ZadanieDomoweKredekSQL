using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe3.Repositories.Interfaces
{
    interface IOrdersRepository
    {
        /// <summary>
        /// abstrakcyjna metoda do pobierania wszystkich zamówień od pacjentów
        /// </summary>
        DataTable GetOrders();
        /// <summary>
        /// abstrakcyjna ktora dodaje nowe zamowienie dania od pacjenta
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="dish"></param>
        void AddOrder(string firstName, string lastName, string password, string dish);
    }
}
