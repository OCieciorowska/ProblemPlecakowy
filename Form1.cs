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

                // Tutaj b�dzie wywo�anie klasy Problem i jego metody Solve()
                MessageBox.Show($"Uruchamiam algorytm z danymi:\nSeed: {seed}\nIlo�� przedmiot�w: {numItems}\nPojemno��: {capacity}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("B��d: " + ex.Message);
            }
        }
    }
}

