using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JeuPendu {
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class Accueil : Window {

        penduEntities bdd;

        public Accueil() {
            InitializeComponent();
            bdd = new penduEntities();

        }

        private void btn_historique_Click(object sender, RoutedEventArgs e) {
            Historique historique = new Historique(this, bdd);
            historique.ShowDialog();
        }

        private void btn_prefs_Click(object sender, RoutedEventArgs e) {
            PrefsJeu prefs = new PrefsJeu(this, bdd);
            prefs.ShowDialog();
        }

        private void bnt_jouer_Click(object sender, RoutedEventArgs e) {
            NouveauJeu jeu = new NouveauJeu(this, bdd);
            jeu.ShowDialog();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e) {
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
