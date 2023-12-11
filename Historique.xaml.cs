using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Application = System.Windows.Application;
using MessageBox = System.Windows.MessageBox;

namespace JeuPendu {
    /// <summary>
    /// Logique d'interaction pour Historique.xaml
    /// </summary>
    public partial class Historique : Window {

        Accueil acc;
        penduEntities bdd;
 
        public Historique(Accueil accueil, penduEntities bdd) {
            InitializeComponent();
            acc = accueil;
            this.bdd = bdd;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            var query =
                from h in bdd.HistoriqueTables
                select new { h.mot, h.score, h.erreurs, h.temps, h.date, h.reussi };
                dgHistorique.DataContext = query.ToList();
        }

        private void bnt_accueil_Click(object sender, RoutedEventArgs e) {
                acc.Show();
                this.Hide();
        }

        private void bnt_quit_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", 
                                                            "Information", 
                                                            MessageBoxButton.YesNo, 
                                                            MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes) {
                Application.Current.Shutdown();
            }
        }
    }
}
