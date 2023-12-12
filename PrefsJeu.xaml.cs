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
using System.Windows.Shapes;

namespace JeuPendu {
    /// <summary>
    /// Logique d'interaction pour Preferences.xaml
    /// </summary>
    public partial class PrefsJeu : Window {

        Accueil acc;
        penduEntities bdd;

        public PrefsJeu(Accueil acc, penduEntities bdd) {
            InitializeComponent();
            this.acc = acc;
            this.bdd = bdd;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment retourner à l'accueil ?",
                                                            "Information",
                                                            MessageBoxButton.YesNo,
                                                            MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes) {
                acc.ShowDialog();
                this.Close();
            }
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

        private void btnDico_Click(object sender, RoutedEventArgs e) {
            Dictionnaire dico = new Dictionnaire(acc, bdd);
            this.Hide();
            dico.ShowDialog();
        }
    }
}
