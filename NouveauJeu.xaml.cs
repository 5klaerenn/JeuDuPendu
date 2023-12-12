using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Packaging;
using System.Linq;
using System.Net.NetworkInformation;
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
    /// Logique d'interaction pour JeuPendu.xaml
    /// </summary>
    public partial class NouveauJeu : Window {

        Accueil acc;
        penduEntities bdd;

        string mot, motcache;
        int choixLangue, choixNiveau;
        int essais = 0;
        int score = 0;
        DateTime heureDebut;
        DateTime heureFin;

        public NouveauJeu(Accueil accueil, penduEntities bdd) {
            InitializeComponent();

            acc = accueil;
            this.bdd = bdd;
            genererBouttons();
            genererParametres();
            imgJeu.Source = new BitmapImage(new Uri(@"/img/accueil.jpg", UriKind.Relative));

        }

        private void btnStart_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = MessageBox.Show("Nouvelle partie ?",
                                                         "Information",
                                                         MessageBoxButton.YesNo,
                                                         MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes) {
                imgJeu.Source = new BitmapImage(new Uri(@"/img/accueil.jpg", UriKind.Relative));
                essais = 0;
                genererBouttons();
                mot = choisirMot();
                motcache = remplacerMot(mot);
                lblMot.Content = motcache;
                lblScore.Content = score;
                heureDebut = DateTime.Now;
            }
        }

        private void genererBouttons() {
            for (char lettre = 'A'; lettre <= 'Z'; lettre++) { 
                //Pour chaque lettre de l'alphabet, generer un nouveau boutton dans la grid 
                Button btn = new Button();
                btn.Content = lettre.ToString();
                btn.Width = 30; 
                btn.Height = 30;
                btn.Click += AlphabetButton_Click; 
                alphabet.Children.Add(btn);

                // Mappage des lettres dans la grille relativement à la position de la lettre A 
                int columnIndex = (lettre - 'A') % 8;
                int rowIndex = (lettre - 'A') / 8;
                Grid.SetColumn(btn, columnIndex);
                Grid.SetRow(btn, rowIndex);
            }
        }

        private void genererParametres() {
            Parametre param = bdd.Parametres.Find(1);
            choixLangue = param.idLangue;
            choixNiveau = param.idNiveau;
            lblLangue.Content = bdd.Langues.Find(param.idLangue).langue1;
            lblNiveau.Content = bdd.Niveaux.Find(param.idNiveau).niveau1;   
        }

        private void AlphabetButton_Click(object sender, RoutedEventArgs e) {
            Button clickedButton = (Button)sender;
            char selectedLetter = clickedButton.Content.ToString()[0];
            clickedButton.IsEnabled = false; 

            motcache = verifierLettre(selectedLetter, mot, motcache);
            lblMot.Content = motcache;
            lblScore.Content = score;

            bool continuer = validerScore(essais, mot, motcache);

            if(!continuer) {
                heureFin = DateTime.Now;
                TimeSpan tempsEcoule = heureFin - heureDebut;
                desactiverBouttons();

                    HistoriqueTable table = new HistoriqueTable();
                    table.mot = mot;
                    table.score = score;
                    table.erreurs = essais;
                    table.temps = (int)tempsEcoule.TotalSeconds;
                    table.date = heureFin;
                    table.reussi = essais == 6 ?  "ECHEC" : table.reussi = "SUCCES";

                    bdd.HistoriqueTables.Add(table);

                try {
                    bdd.SaveChanges();
                    MessageBox.Show(table.reussi + "!");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void desactiverBouttons() {
            foreach (Button b in alphabet.Children) {
                b.IsEnabled = false;
            }
        }

        private bool validerScore(int essais, string mot, string motcache) { // Verifier si la partie continue (true) ou s'arrete (false)
            if (essais > 0 && essais < 6) {
                imgJeu.Source = new BitmapImage(new Uri($"/img/err0{essais}.jpg", UriKind.Relative));
                if (motcache == mot) {
                    lblResult.Content = "VICTOIRE !";
                    return false;
                }
                return true;
            }
            else if (essais == 6) {
                imgJeu.Source = new BitmapImage(new Uri($"/img/err0{essais}.jpg", UriKind.Relative));
                lblResult.Content = "PERDU";
                return false;
            } 
            else {
                return true;
            }
        }

        private string choisirMot() {
            
            string motChoisi;

            var query = from d in bdd.DictionnaireTables
                        where d.idLangue == choixLangue && d.idNiveau == choixNiveau
                        select d;
            var listeMots = query.ToList();

            try {
                Random random = new Random();
                int numTirage = random.Next(listeMots.Count);
                motChoisi = listeMots[numTirage].mot;
                return motChoisi.Trim().ToUpper();
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }

        private string remplacerMot(string mot) {
            char[] listeC = mot.ToCharArray();
            string result = new string('#', listeC.Length); // Remplacement de chaque caractère par #
            return result;
        }

        private string verifierLettre(char lettre, string mot, string motcache) {
            int changement = 0;
            char[] test = motcache.ToCharArray(); // Déconstruction de la chaine de caractères pour passer à travers 

            for (int i = 0; i < test.Length; i++) { 
                    if(lettre == mot[i] && test[i] == '#') {
                        test[i] = lettre;
                        Console.WriteLine("trouve");
                        changement++;
                    }
            }
            if (changement == 0) {
                essais++;
            } else {
                score += changement;
            }
            return new string(test); // Reconstruction de la chaine de caractères 
        }
        
        private void btnPrefs_Click(object sender, RoutedEventArgs e) {
            PrefsJeu prefs = new PrefsJeu(acc, bdd);
            this.Hide();
            prefs.ShowDialog();
        }

        private void btnHistorique_Click(object sender, RoutedEventArgs e) {
            Historique historique = new Historique(acc, bdd);
            this.Hide();
            historique.ShowDialog();
            
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
