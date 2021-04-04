using AdamBednorzZadanieDomowe3.Forms;
using AdamBednorzZadanieDomowe3.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdamBednorzZadanieDomowe3
{
    public partial class Hospital : Form
    {
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Patients
        /// </summary>
        private readonly PatientsRepository patientsRepository;

        /// <summary>
        /// Konstruktor do okna recepcji szpitalnej
        /// </summary>
        public Hospital()
        {
            //Zainicjalizowanie repozytorium
            patientsRepository = new PatientsRepository();

            InitializeComponent();

            //Ustawienie okna, żeby pojawiło się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// metoda wywoływana podczas ładowania okna recepcji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hospital_Load(object sender, EventArgs e)
        {
            //ustawiamy tło komponentów
            labelFirstName.BackColor = Color.Aqua;
            labelLastName.BackColor = Color.Aqua;
            labelPassword.BackColor = Color.Aqua;
            labelReception.BackColor = Color.Red;
            labelNewPassword.BackColor = Color.Aqua;
            buttonSignIn.BackColor = Color.Aqua;
            buttonDeletePatient.BackColor = Color.Aqua;
            buttonSetPassword.BackColor = Color.Aqua;
            buttonAddPatient.BackColor = Color.Aqua;
            buttonSetPassword.BackColor = Color.Aqua;
            buttonPharmacy.BackColor = Color.Aqua;
            buttonCanteen.BackColor = Color.Aqua;
        }

        /// <summary>
        /// przycisk służący do logowania się do systemu szpitalnego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            //zczytujemy dane z textBoxow
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;

            //zmienna sprawdzajaca czy istnieje taki pacjent w bazie
            bool logged = patientsRepository.Login(firstName, lastName, password);

            //jezeli udało się zalogować
            if (logged)
            {
                MessageBox.Show("Udalo Ci sie zalogowac");
                //tworzymy okno
                FormSurgery surgery = new FormSurgery();
                //wyswietlamy okno
                surgery.Show();
                //czyscimy dane
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPassword.Text = "";
            }
            else
            {
                //czyscimy dane
                MessageBox.Show("Niepoprawny login lub hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPassword.Text = "";
            }
        }

        /// <summary>
        /// metoda pozwalajaca dodac nowe konto do bazy danych pacjentów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            //wczytujemy dane
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;

            //dodajemy pacjentów do bazy
            patientsRepository.AddPatient(firstName, lastName, password);
            MessageBox.Show("Stowrzyłeś nowe konto w systemie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //czyścimy dane
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassword.Text = "";
        }

        //przycisk usuwajacy konto z bazy danych pacjentów
        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            //wczytujemy dane z textboxow
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;

            //zmienna sprawdzajaca czy istnieje taki pacjent w bazie
            bool logged = patientsRepository.Login(firstName, lastName, password);

            //jezeli udało się zalogować
            if (logged)
            {
                //usuwamy konto jesli istnieje takie konto
                patientsRepository.DeletePatient(firstName, lastName, password);
                MessageBox.Show("Usunąłeś swoje konto!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //czyscimy dane
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPassword.Text = "";
            }
            else
            {
                //jesli nie udalo sie zalogowac
                MessageBox.Show("Nie ma takiego konta w systemie!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //czyscimy dane
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPassword.Text = "";
            }

        }
        /// <summary>
        /// metoda zmieniajaca haslo użytkownika w szpitalu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetPassword_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;
            string newPassword = textBoxNewPassword.Text;

            patientsRepository.ChangePassword(firstName, lastName, password, newPassword);

            MessageBox.Show("Zmieniłeś hasło!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //czyscimy dane
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassword.Text = "";
            textBoxNewPassword.Text = "";
        }

        /// <summary>
        /// metoda przenosząca nas do apteki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPharmacy_Click(object sender, EventArgs e)
        {
            //tworzymy okno
            FormPharmacy pharmacy = new FormPharmacy();
            //pokazujemy okno
            pharmacy.Show();
        }

        /// <summary>
        /// metoda przenoszaca nas do kantyny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCanteen_Click(object sender, EventArgs e)
        {
            //tworzymy okno
            FormCanteen canteen = new FormCanteen();
            //pokazujemy okno
            canteen.Show();
        }
    }
}
