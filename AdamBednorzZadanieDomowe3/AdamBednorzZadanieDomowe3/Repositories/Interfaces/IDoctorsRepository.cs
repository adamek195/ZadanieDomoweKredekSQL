using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe3.Repositories.Interfaces
{
    // <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Doctors
    /// </summary>
    interface IDoctorsRepository
    {
        /// <summary>
        /// abstrakcyjna metoda do pobierania wszystkich dni dostępności lekarzy
        /// </summary>
        DataTable GetDoctors();
    }
}
