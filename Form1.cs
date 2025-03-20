using System;
using System.Windows.Forms;

namespace AppProblemPlecakowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                int seed = int.Parse(txtSeed.Text);
                int numItems = int.Parse(txtNumItems.Text);
                int capacity = int.Parse(txtCapacity.Text);

                // Tworzymy obiekt Problem z wygenerowanymi przedmiotami
                Problem problem = new Problem(numItems, seed);

                // Rozwiązujemy problem plecakowy dla danej pojemności
                Result result = problem.Solve(capacity);

                // Czyszczenie list przed dodaniem nowych wartości
                lstResults.Items.Clear();
                lstInstance.Items.Clear();

                // Wyświetlanie wszystkich przedmiotów w instancji
                foreach (var item in problem.Items)
                {
                    lstInstance.Items.Add($"Przedmiot: Waga {item.Waga} kg, Wartość {item.Wartosc} zł");
                }

                // Wyświetlanie wybranych przedmiotów w rozwiązaniu
                foreach (var item in result.SelectedItems)
                {
                    lstResults.Items.Add($"Przedmiot: Waga {item.Waga} kg, Wartość {item.Wartosc} zł");
                }

                if (result.SelectedItems.Count == 0)
                {
                    lstResults.Items.Add("Brak możliwego rozwiązania.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }
    }
}
