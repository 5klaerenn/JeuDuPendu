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
            Preferences prefs = new Preferences(this, bdd);
            prefs.ShowDialog();
        }
    }
}
