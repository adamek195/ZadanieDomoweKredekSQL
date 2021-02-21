using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe3.Repositories.Interfaces
{
    // <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Pharmacy
    /// </summary>
    interface IPharmacyRepository
    {
        /// <summary>
        /// abstrakcyjna metoda do pobierania wszystkich leków w aptece dostępnych
        /// </summary>
        /// <returns></returns>
        DataTable GetPharmacies();
    }
}
