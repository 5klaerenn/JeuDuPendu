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

                    Parametre pref = findParam(lang, lvl);
                    Parametre nPref = pref ?? new Parametre();

                    if (pref == null) {
                        nPref.idLangue = lang;
                        nPref.idNiveau = lvl;
                        bdd.Parametres.Add(nPref);

                        try {
                            bdd.SaveChanges();
                            MessageBox.Show("Préférences sauvegardées.",
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
                        nPref = pref;
                    }


                    Application.Current.Properties["langue"] = nPref.idLangue;
                    Application.Current.Properties["niveau"] = nPref.idNiveau;

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

        private Parametre findParam(int langue, int difficulty) {
            Parametre param = bdd.Parametres.SingleOrDefault(s => s.idLangue == langue && s.idNiveau == difficulty);
            return param;
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
