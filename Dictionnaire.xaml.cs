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
    /// Logique d'interaction pour Dictionnaire.xaml
    /// </summary>
    public partial class Dictionnaire : Window {

        Accueil acc;
        penduEntities bdd;

        public Dictionnaire(Accueil acc, penduEntities bdd) {
            InitializeComponent();
            this.acc = acc;
            this.bdd = bdd;
            cboLangue.DataContext = bdd.Langues.ToList();
            cboNiveau.DataContext = bdd.Niveaux.ToList();
            lstMots.ItemsSource = bdd.DictionnaireTables.ToList();
        }

        private void cboLangue_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            updateListe();
        }

        private void cboNiveau_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            updateListe();
        }

        private void btnFindAll_Click(object sender, RoutedEventArgs e) {
            lstMots.ItemsSource = bdd.DictionnaireTables.ToList();
        }

        private void updateListe() {

            Langue lan = cboLangue.SelectedItem as Langue;
            Niveau niv = cboNiveau.SelectedItem as Niveau;

            if (lan != null && niv != null) {
                var query = from d in bdd.DictionnaireTables
                            where d.idLangue == lan.id && d.idNiveau == niv.id
                            select d;

                lstMots.ItemsSource = query.ToList();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e) {
            Langue lan = cboLangue.SelectedItem as Langue;
            Niveau niv = cboNiveau.SelectedItem as Niveau;

            DictionnaireTable mot = new DictionnaireTable();
            mot.mot = txtMot.Text.Trim();
            mot.idLangue = lan.id;
            mot.idNiveau = niv.id;

            bdd.DictionnaireTables.Add(mot);

            try {
                bdd.SaveChanges();
                MessageBox.Show(mot.mot + " ajouté avec succès du dictionnaire!",
                   "Ajouter un mot",
                   MessageBoxButton.OK,
                   MessageBoxImage.Information);
                updateListe();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnSupprimer_Click(object sender, RoutedEventArgs e) {
          
            DictionnaireTable sMot = lstMots.SelectedItem as DictionnaireTable;
            bdd.DictionnaireTables.Remove(sMot);

            try {
                bdd.SaveChanges();
                MessageBox.Show(sMot.mot + " supprimé avec succès du dictionnaire!", 
                    "Supprimer un mot", 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Information);
                updateListe();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message); ;
            }
            
        }

        private void btnHome_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = 
                MessageBox.Show("Voulez-vous vraiment retourner à l'accueil ?",
                                 "Information",
                                 MessageBoxButton.YesNo,
                                 MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes) {
                acc.Show();
                this.Hide();
            }
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = 
                MessageBox.Show("Voulez-vous vraiment quitter ?",
                                  "Information",
                                  MessageBoxButton.YesNo,
                                  MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes) {
                Application.Current.Shutdown();
            }
        }
    }
}
