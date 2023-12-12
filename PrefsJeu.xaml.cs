using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Xaml;

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

        private void btnSave_Click(object sender, RoutedEventArgs e) {

            if (rbFrancais.IsChecked == true || rbAnglais.IsChecked == true) {

                if (rbFacile.IsChecked == true || rbMoyen.IsChecked == true || rbDifficile.IsChecked == true) {
                    int lang = rbAnglais.IsChecked == true ? 2 : 1;
                    int lvl = rbFacile.IsChecked == true ? 1 : (rbMoyen.IsChecked == true ? 2 : 3);


                    /*
                     * Puisqu'on veut que les préférences restent même après la fermeture de la session, j'ai choisi ici 
                     * de me limiter à juste updater l'entrée unique de la base de données. 
                    */
                    Parametre pref = bdd.Parametres.Find(1);
                    pref.idLangue = lang;
                    pref.idNiveau = lvl;

                    try {
                        bdd.SaveChanges();
                        MessageBox.Show("Préférences mises à jour. \nRetournez à l'accueil pour commencer une partie.",
                          "Information",
                          MessageBoxButton.OK,
                          MessageBoxImage.Information);
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex);
                        MessageBox.Show(ex.Message);
                    }

                }
                else {
                    MessageBox.Show("Vous devez choisir une difficulté.",
                    "Attention",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            else {
                MessageBox.Show("Vous devez choisir une langue.",
                "Attention",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
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

        private void btnHome_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment retourner à l'accueil ?",
                                                            "Information",
                                                            MessageBoxButton.YesNo,
                                                            MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes) {
                this.Close();
                acc.Show();

            }
        }
    }
}
