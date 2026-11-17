
using System.Collections.ObjectModel;
using System.Windows;

namespace Dolgozatok
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Dolgozo> dolgozok = new ObservableCollection<Dolgozo>();

        public MainWindow()
        {
            InitializeComponent();

            dgDolgozatok.ItemsSource = dolgozok;

            AlapAdatok();
        }

        private void AlapAdatok()
        {
            dolgozok.Add(new Dolgozo("Kiss Péter", 16, 87));
            dolgozok.Add(new Dolgozo("Nagy Anna", 17, 92));
            dolgozok.Add(new Dolgozo("Szabó Tamás", 16, 78));
            dolgozok.Add(new Dolgozo("Tóth Éva", 18, 95));
            dolgozok.Add(new Dolgozo("Varga Bence", 17, 81));
            dolgozok.Add(new Dolgozo("Horváth Zsolt", 16, 65));
            dolgozok.Add(new Dolgozo("Molnár Réka", 18, 89));
            dolgozok.Add(new Dolgozo("Lakatos Dániel", 17, 72));
        }


        private void btnHozzaadas_Click(object sender, RoutedEventArgs e)
        {
            string nev = txtNev.Text.Trim();

            if (string.IsNullOrWhiteSpace(nev))
            {
                MessageBox.Show("Add meg a nevet!");
                return;
            }

            if (!int.TryParse(txtEletkor.Text, out int eletkor))
            {
                MessageBox.Show("Az életkor csak szám lehet!");
                return;
            }

            if (!int.TryParse(txtPontszam.Text, out int pontszam))
            {
                MessageBox.Show("A pontszám csak szám lehet!");
                return;
            }

            if (eletkor <= 0 || eletkor > 120)
            {
                MessageBox.Show("Érvénytelen életkor!");
                return;
            }

            if (pontszam < 0 || pontszam > 100)
            {
                MessageBox.Show("A pontszám 0 és 100 között lehet!");
                return;
            }

            dolgozok.Add(new Dolgozo(nev, eletkor, pontszam));

            txtNev.Clear();
            txtEletkor.Clear();
            txtPontszam.Clear();

            MessageBox.Show("A dolgozó sikeresen hozzáadva!");
        }

    }

    public class Dolgozo
    {
        public string Nev { get; set; }
        public int Eletkor { get; set; }
        public int Pontszam { get; set; }

        public Dolgozo(string nev, int eletkor, int pontszam)
        {
            Nev = nev;
            Eletkor = eletkor;
            Pontszam = pontszam;
        }
    }
}
