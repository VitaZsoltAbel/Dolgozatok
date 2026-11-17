
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
