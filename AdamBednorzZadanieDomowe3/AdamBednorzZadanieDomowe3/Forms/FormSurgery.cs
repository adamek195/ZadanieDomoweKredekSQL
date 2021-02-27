using AdamBednorzZadanieDomowe3.Repositories;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AdamBednorzZadanieDomowe3.Forms
{
    public partial class FormSurgery : Form
    {
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Doctors
        /// </summary>
        private readonly DoctorsRepository doctorsRepository;
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Visits
        /// </summary>
        private readonly VisitsRepository visitsRepository;

        public FormSurgery()
        {
            //Zainicjalizowanie repozytorium
            doctorsRepository = new DoctorsRepository();
            visitsRepository = new VisitsRepository();

            InitializeComponent();

            // Ustawienie okna, żeby pojawiło się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// metoda jest wykonywana podczas zaladowania okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Surgery_Load(object sender, EventArgs e)
        {
            labelDoctors.BackColor = Color.Aqua;
            labelFirstName.BackColor = Color.Aqua;
            labelLastName.BackColor = Color.Aqua;
            labelPassword.BackColor = Color.Aqua;
            labelTypeDoctor.BackColor = Color.Aqua;
            labelVisits.BackColor = Color.Aqua;
            buttonVisits.BackColor = Color.Aqua;
            buttonDoctors.BackColor = Color.Aqua;
        }

        /// <summary>
        /// metoda pokazujaca kiedy lekarze są dostępni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDoctors_Click(object sender, EventArgs e)
        {
            //pobierz wszystkich lekarzy z bazy danych
            DataTable doctors = doctorsRepository.GetDoctors();

            //przypisz wszystkich lekarzy do DataGridView
            dataGridViewDoctors.DataSource = doctors;
        }

        /// <summary>
        /// metoda pozwalajaca na umowienie się w systemie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVisits_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;
            string typeDoctor = textBoxTypeDoctor.Text;

            visitsRepository.AddVisit(firstName, lastName, password, typeDoctor);
            MessageBox.Show("Umówiłeś się na wizytę!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //pobierz wszystkie wizyty z bazy danych
            DataTable visits = visitsRepository.GetVisits();
            //przypisz wszystkie umowione wizyty do DataGridView
            dataGridViewVisits.DataSource = visits;

            //czyszczenie
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassword.Text = "";
            textBoxTypeDoctor.Text = "";
        }
    }
}
