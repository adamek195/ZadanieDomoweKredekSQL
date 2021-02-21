using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe3.Repositories.Interfaces
{
    // <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Canteen
    /// </summary>
    interface ICanteenRepository
    {
        /// <summary>
        /// abstrakcyjna metoda do pobierania wszystkich dań dostępnych w kantynie
        /// </summary>
        DataTable GetDishes();
    }
}
