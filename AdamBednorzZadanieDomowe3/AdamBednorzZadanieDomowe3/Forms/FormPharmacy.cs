using AdamBednorzZadanieDomowe3.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamBednorzZadanieDomowe3.Forms
{
    public partial class FormPharmacy : Form
    {
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Pharmacy
        /// </summary>
        private readonly PharmacyRepository pharmacyRepository;
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Purchases
        /// </summary>
        private readonly PurchasesRepository purchasesRepository;
        public FormPharmacy()
        {
            ////Zainicjalizowanie repozytorium
            pharmacyRepository = new PharmacyRepository();
            purchasesRepository = new PurchasesRepository();

            InitializeComponent();

            //Ustawienie okna, żeby pojawiło się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// metoda która jest uruchamiana podczas ładowania okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pharmacy_Load(object sender, EventArgs e)
        {
            //ustawiamy tła komponentów
            buttonPharmacy.BackColor = Color.Aqua;
            buttonPurchaseMedicine.BackColor = Color.Aqua;
            labelFirstName.BackColor = Color.Aqua;
            labelLastName.BackColor = Color.Aqua;
            labelMedicine.BackColor = Color.Aqua;
            labelPassword.BackColor = Color.Aqua;
            labelPharmacies.BackColor = Color.Aqua;
            labelPurchases.BackColor = Color.Aqua;
        }

        /// <summary>
        /// metoda wyświetlająca liste lekarstw z tabeli Pharmacy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPharmacy_Click(object sender, EventArgs e)
        {
            //pobierz wszystkie lekarstwa z bazy danych
            DataTable pharmacies = pharmacyRepository.GetPharmacies();

            //przypisz wszystkie lekarstwa do DataGridView
            dataGridViewPharmacies.DataSource = pharmacies;
        }

        /// <summary>
        /// metoda pozwalajaca dodac lekarstwa do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPurchaseMedicine_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;
            string medicine = textBoxMedicine.Text;

            purchasesRepository.AddPurchase(firstName, lastName, password, medicine);
            MessageBox.Show("Zamówiłeś lekarstwo!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //pobierz wszystkie zamówienia z bazy danych
            DataTable purchases = purchasesRepository.GetPurchases();
            //przypisz wszystkie umowione zmówienia do DataGridView
            dataGridViewPurchases.DataSource = purchases;

            //czyszczenie
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassword.Text = "";
            textBoxMedicine.Text = "";
        }
    }
}
