using AdamBednorzZadanieDomowe3.Repositories;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AdamBednorzZadanieDomowe3.Forms
{
    public partial class FormCanteen : Form
    {
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Canteen
        /// </summary>
        private readonly CanteenRepository canteenRepository;
        /// <summary>
        /// Klasa do przetwarzania danych związanych z tabelą Purchases
        /// </summary>
        private readonly OrdersRepository ordersRepository;
        public FormCanteen()
        {
            //Zainicjalizowanie repozytorium
            canteenRepository = new CanteenRepository();
            ordersRepository = new OrdersRepository();

            InitializeComponent();

            // Ustawienie okna, żeby pojawiło się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// metoda uruchamiana podczas zaladowania okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Canteen_Load(object sender, EventArgs e)
        {
            buttonCanteen.BackColor = Color.Red;
            labelDish.BackColor = Color.Red;
            labelFirstName.BackColor = Color.Red;
            labelLastName.BackColor = Color.Red;
            labelMenu.BackColor = Color.Red;
            labelPassword.BackColor = Color.Red;
            buttonOrder.BackColor = Color.Red;
        }

        /// <summary>
        /// metoda pokazujaca nam menu z kantyny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCanteen_Click(object sender, EventArgs e)
        {
            //pobierz menu z bazy danych
            DataTable dishes = canteenRepository.GetDishes();

            //przypisz menu do DataGridView
            dataGridViewCanteen.DataSource = dishes;
        }

        /// <summary>
        /// metoda pozwalajaca zamowic danie przez pacjenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;
            string dish = textBoxDish.Text;

            ordersRepository.AddOrder(firstName, lastName, password, dish);
            MessageBox.Show("Zamówiłeś danie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //pobierz wszystkie zamówienia z bazy danych
            DataTable orders = ordersRepository.GetOrders();
            //przypisz wszystkie umowione zmówienia do DataGridView
            dataGridViewOrders.DataSource = orders;

            //czyszczenie 
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassword.Text = "";
            textBoxDish.Text = "";
        }
    }
}
