using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mediateq_AP_SIO2.metier;
using Mediateq_AP_SIO2.divers;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace Mediateq_AP_SIO2
{
    public partial class FrmMediateq : Form
    {
        #region Variables globales

        //|
        //| Listes qui contiennent des objets
        //|
        static List<Categorie> lesCategories;
        static List<Livre> lesLivres;
        static List<Dvd> lesDvd;
        static List<Utilisateur> lesUtilisateurs;
        static List<Document> lesDocuments;
        static List<Commande> lesCommandes;
        static List<EtatCommande> lesEtatCommande;

        internal Utilisateur UtilisateurLogged;

        #endregion

        #region Procédures évènementielles

        public FrmMediateq()
        {
            InitializeComponent();
        }

        private void FrmMediateq_Load(object sender, EventArgs e)
        {
            //|
            //| Création de la connection
            //|
            DAOFactory.CreerConnection();

            //|
            //| Chargement des objets
            //|
            //lesDescripteurs = DAODocuments.getAllDescripteurs();
            //lesTitres = DAOPresse.getAllTitre();
            lesCategories = DAODocuments.GetAllCategories();
            lesLivres = DAODocuments.GetAllLivres();
            lesDvd = DAODocuments.GetAllDvd();
            lesUtilisateurs = DAOUtilisateurs.GetAllUtilisateurs();
            lesDocuments = DAOCommandes.GetAllDocuments();
            lesCommandes = DAOCommandes.GetAllCommandes();
            lesEtatCommande = DAOCommandes.GetAllEtatCommandes();

            //|
            //| Chargement des comboboxes
            //|
            SetComboboxLivreForLivre();
            SetComboboxDvdForDvd();
            SetComboboxCategorieForLivreAndDvd();
            SetComboboxDocumentForCommande();
            SetComboboxEtatForCommande();
            SetComboboxCommandeForCommande();


            //|
            //| Chargement des datagridview
            //|
            SetAllDataOfLivres();
            SetAllDataOfDvd();
            SetAllDataOfUser();
            SetAllDataOfCommandes();

            //|
            //| Affichage des données sur la page Utilisateur
            //|
            prenomUtilisateurAlert.Text = UtilisateurLogged.Prenom;
            prenomUtilisateurProfil.Text = UtilisateurLogged.Prenom;
            nomUtilisateurProfil.Text = UtilisateurLogged.Nom;
            serviceUtilisateurProfil.Text = UtilisateurLogged.Service;
            loginUtilisateurProfil.Text = UtilisateurLogged.Login;

            //|
            //| Accès aux différentes parties de l'appli delon le service
            //|
            TabPage TabGestionDesUsers = tabGestionDesUsers;
            TabPage TabGestionDesLivres = tabGestionDesLivres;
            TabPage TabGestionDesDvdO = tabGestionDesDvdO;
            TabPage TabGestionDesCommandes = tabGestionDesCommandes;

            if (UtilisateurLogged.Service == "Administrateur")
            {
                textRoles.Text = "Vous avez accès à tous les onglets.";
            }
            else
            {
                if (UtilisateurLogged.Service == "Administratif")
                {
                    textRoles.Text = "Vous avez accès à la gestion des DVD et des Livres, ainsi qu'a la gestion des commandes.";
                    tabOngletsApplication.TabPages.Remove(TabGestionDesUsers);
                }
                else
                {
                    if (UtilisateurLogged.Service == "Prêts")
                    {
                        textRoles.Text = "Vous avez accès en consultation sur les Livres et les DVD.";

                        tabOngletsApplication.TabPages.Remove(TabGestionDesUsers);

                        //| Consultation de livres
                        groupCreerLivre.Visible = false;
                        groupModifierLivre.Visible = false;
                        groupSuprLivre.Visible = false;

                        //| Consultation de Dvd
                        groupCreerDvd.Visible = false;
                        groupModifierDvd.Visible = false;
                        groupSuprDvd.Visible = false;

                        tabOngletsApplication.TabPages.Remove(TabGestionDesCommandes);
                    }
                    else
                    {
                        if (UtilisateurLogged.Service == "Culture")
                        {
                            textRoles.Text = "Vous avez accès à l'onglet profil uniquement";
                            tabOngletsApplication.TabPages.Remove(TabGestionDesUsers);
                            tabOngletsApplication.TabPages.Remove(TabGestionDesLivres);
                            tabOngletsApplication.TabPages.Remove(tabGestionDesDvd);
                            tabOngletsApplication.TabPages.Remove(TabGestionDesCommandes);
                        }
                    }
                }
            }
        }

        #endregion

        #region Comboboxes

        //|
        //| Comboboxes Livres dans l'onglet Livre
        //|
        private void SetComboboxLivreForLivre()
        {
            selectLivreForEdit.DataSource = lesLivres;
            selectLivreForEdit.DisplayMember = "titre";

            selectLivreForDelete.DataSource = lesLivres;
            selectLivreForDelete.DisplayMember = "titre";
        }

        //|
        //| Comboboxes Dvd dans l'onglet Dvd
        //|
        private void SetComboboxDvdForDvd()
        {
            SelectDvdForEdit.DataSource = lesDvd;
            SelectDvdForEdit.DisplayMember = "titre";

            selectDvdForDelete.DataSource = lesDvd;
            selectDvdForDelete.DisplayMember = "titre";
        }

        //|
        //| Comboboxes Catégorie dans les onglets Livre & Dvd
        //|
        private void SetComboboxCategorieForLivreAndDvd()
        {
            selectCategorieForEdit.DataSource = lesCategories;
            selectCategorieForEdit.DisplayMember = "libelle";

            selectCategorieLivreForCreate.DataSource = lesCategories;
            selectCategorieLivreForCreate.DisplayMember = "libelle";

            selectCategorieDvdForCreate.DataSource = lesCategories;
            selectCategorieDvdForCreate.DisplayMember = "libelle";

            selectCategorieDvdForEdit.DataSource = lesCategories;
            selectCategorieDvdForEdit.DisplayMember = "libelle";
        }

        //|
        //| Comboboxes pour documets dans commandes
        //|
        private void SetComboboxDocumentForCommande()
        {
            selectDocumentForCreateCommande.DataSource = lesDocuments;
            selectDocumentForCreateCommande.DisplayMember = "titre";

            selectDocumentForEditCommande.DataSource = lesDocuments;
            selectDocumentForEditCommande.DisplayMember = "titre";
        }

        //|
        //| Comboboxes pour état dans commandes
        //|
        private void SetComboboxEtatForCommande()
        {
            selectEtatForCreateCommande.DataSource = lesEtatCommande;
            selectEtatForCreateCommande.DisplayMember = "libelle";

            selectEtatForEditCommande.DataSource = lesEtatCommande;
            selectEtatForEditCommande.DisplayMember = "libelle";
        }

        //|
        //| Comboboxes pour commande dans commandes
        //|
        private void SetComboboxCommandeForCommande()
        {
            SelectCommandeForEdit.DataSource = lesCommandes;
            SelectCommandeForEdit.DisplayMember = "idCommande";

            selectCommandeForDelete.DataSource = lesCommandes;
            selectCommandeForDelete.DisplayMember = "idCommande";
        }

        #endregion

        #region Profil
        //-----------------------------------------------------------
        // ONGLET "PROFIL"
        //-----------------------------------------------------------

        //-----------------------------------------------------------
        // changer de mdp
        //-----------------------------------------------------------
        private void ButtonModifierMDP_Click(object sender, EventArgs e)
        {
            string login = loginUtilisateurProfil.Text;
            string ancienMDP = inputAncienMDP.Text;
            string nouveauMDP = inputNouveauMDP.Text;

            //|
            //| On créé les regex
            //|
            Regex regexAncienMDP = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{10,}$");
            Regex regexNouveauMDP = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{10,}$");

            Match regexAncienMDPTest = regexAncienMDP.Match(ancienMDP);
            Match regexNouveauMDPTest = regexNouveauMDP.Match(nouveauMDP);

            try
            {
                if (ancienMDP == "" || nouveauMDP == "")
                {
                    throw new ExceptionSio("Modifier le mot de passe", "Un des champs MDP est vide.", "");
                }
                else
                {
                    if (!regexAncienMDPTest.Success || !regexNouveauMDPTest.Success)
                    {
                        throw new ExceptionSio("Modifier le mot de passe", "Le MDP ne respecte pas les contraintes de sécurité.", "");
                    }
                    else
                    {
                        //|
                        //| Cryptage de l'ancien mdp pour voir si il est pareil que celui déja enregistré
                        //|
                        string userMdpHashed = MD5(ancienMDP);

                        //|
                        //| Récupération du mdp de l'utilisateur par son login
                        //|
                        string bddUserMdpHashed = DAOUtilisateurs.GetMdpByLogin(login);

                        if (userMdpHashed != bddUserMdpHashed)
                        {
                            throw new ExceptionSio("Modifier le mot de passe", "L'ancien mot de passe ne correspond pas.", "");
                        }
                        else
                        {
                            string userMdpHashedNEW = MD5(nouveauMDP);

                            bool resultat = DAOUtilisateurs.SetNouveauMDP(UtilisateurLogged.Login, userMdpHashedNEW);

                            if (resultat)
                            {
                                confirmationNouveauMDP.Text = "Nouveau mot de passe enregistré !";
                            }
                            else
                            {
                                throw new ExceptionSio("Modifier le mot de passe", "Une erreur c'est produite lors de la modification. Veuillez réessayer.", "");
                            }
                        }
                    }
                }
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Gestion des utilisateurs

        //|-----------------------------------------------------------
        //| Affichage de tous les utilisateurs dans le datagridview
        //|-----------------------------------------------------------
        public void SetAllDataOfUser()
        {
            dataOfUser.Rows.Clear();

            foreach (Utilisateur unUser in lesUtilisateurs)
            {
                dataOfUser.Rows.Add(unUser.ID, unUser.Prenom, unUser.Nom, unUser.Service, unUser.Login);
            }
        }

        #endregion

        #region Gestion des Documents

        #region Gestion des Livres

        //|-----------------------------------------------------------
        //| Affichage de tous les livres dans le datagridview
        //|-----------------------------------------------------------
        public void SetAllDataOfLivres()
        {
            dataOfLivre.Rows.Clear();

            foreach (Livre unLivre in lesLivres)
            {
                dataOfLivre.Rows.Add(unLivre.IdDoc, unLivre.Titre, unLivre.Image, unLivre.LaCategorie.Libelle, unLivre.ISBN1, unLivre.AuteurDuLivre, unLivre.LaCollection);
            }
        }

        //|-----------------------------------------------------------
        //| Création des Livres
        //|-----------------------------------------------------------
        private void ButtonCreerLivre_Click(object sender, EventArgs e)
        {
            //|
            //| Récupération des infos des input
            //|
            String ID = inputIDLivre.Text;
            String Titre = inputTitreLivre.Text;
            String Auteur = inputAuteurLivre.Text;
            String ISBN = inputISBNLivre.Text;
            String Collection = inputCollectionLivre.Text;
            String Image = inputImageLivre.Text;

            //|
            //| Récupération de la catégorie séléctionnée et de l'auteur
            //|
            Categorie uneNouvelleCategorie = (Categorie)selectCategorieLivreForCreate.SelectedItem;

            //|
            //| Regex
            //|
            Regex regexID = new Regex(@"^[0-9]{5}$");
            Match IDTest = regexID.Match(ID);

            Regex regexTitre = new Regex(@"^[a-zA-ZÀ-ÿ \-\']+$");
            Match TitreTest = regexTitre.Match(Titre);

            Regex regexAuteur = new Regex(@"^[a-zA-ZÀ-ÿ \-\']+$");
            Match AuteurTest = regexAuteur.Match(Auteur);

            Regex regexISBN = new Regex(@"^[0-9]{5}$");
            Match ISBNTest = regexISBN.Match(ISBN);

            Regex regexImage = new Regex(@"^([a-zA-Z_]+)(\.)([a-z]{3}|[a-z]{4})$");
            Match ImageTest = regexImage.Match(Image);

            Regex regexCollection = new Regex(@"^[a-zA-ZÀ-ÿ \-\']+$");
            Match CollectionTest = regexCollection.Match(Collection);

            try
            {
                //|
                //| Test des regex
                //|
                if (!IDTest.Success || !TitreTest.Success || !AuteurTest.Success || !ISBNTest.Success || !ImageTest.Success || !CollectionTest.Success || uneNouvelleCategorie == null)
                {
                    throw new ExceptionSio("CRUD LIVRE - Créer", "Un ou plusieurs regex se sont déclenchés.", "");
                }
                else
                {
                    //|
                    //| Création de l'objet Livre
                    //|
                    Livre unNouveauLivre = new Livre(ID, Titre, ISBN, Auteur, Collection, Image, uneNouvelleCategorie);

                    //|
                    //| Appel de la base de données qui donnera le résultat True ou False si ça a bien fonctionné ou non
                    //|
                    bool resultat;

                    resultat = DAODocuments.SetNouveauLivre(ID, Titre, ISBN, Auteur, Collection, Image, uneNouvelleCategorie.Id);

                    if (resultat)
                    {
                        //|
                        //| Mise à jour de la liste des objets Livre
                        //|
                        lesLivres = DAODocuments.GetAllLivres();

                        //|
                        //| Mise à jour du Datagridview
                        //|
                        SetAllDataOfLivres();

                        //|
                        //| Mise à jour des combobox dans l'onglet Livres
                        //|
                        SetComboboxLivreForLivre();

                        textEventLivres.Text = "Le livre à bien été créé.";
                        textEventLivres.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    }
                    else
                    {
                        throw new ExceptionSio("CRUD LIVRE - Créer", "Erreur BDD lors de la création du livre", "");
                    }
                }
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //|-----------------------------------------------------------
        //| Affichage des infos du livre séléctionné dans modification
        //|-----------------------------------------------------------
        private void SelectLivreForEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //|
            //| On recupère les infos de l'objet livre séléctionné
            //|
            Livre leLivreForEdit = (Livre)selectLivreForEdit.SelectedItem;

            inputIDLivreForEdit.Text = leLivreForEdit.IdDoc;
            inputTitreLivreForEdit.Text = leLivreForEdit.Titre;
            inputISBNLivreForEdit.Text = leLivreForEdit.ISBN1;
            inputCollectionLivreForEdit.Text = leLivreForEdit.LaCollection;
            inputImageLivreForEdit.Text = leLivreForEdit.Image;
            selectCategorieForEdit.Text = leLivreForEdit.LaCategorie.Libelle;
        }

        //|-----------------------------------------------------------
        //| Modification des livres
        //|-----------------------------------------------------------
        private void ButtonEditLivre_Click(object sender, EventArgs e)
        {
            //|
            //| Récupération des infos des input
            //|
            String ID = inputIDLivreForEdit.Text;
            String Titre = inputTitreLivreForEdit.Text;
            String ISBN = inputISBNLivreForEdit.Text;
            String Auteur = inputAuteurLivreForEdit.Text;
            String Collection = inputCollectionLivreForEdit.Text;
            String Image = inputImageLivreForEdit.Text;

            Categorie uneNouvelleCategorie = (Categorie)selectCategorieForEdit.SelectedItem;

            //|
            //| Regex
            //|
            Regex regexID = new Regex(@"^[0-9]{5}$");
            Match IDTest = regexID.Match(ID);

            Regex regexTitre = new Regex(@"^[a-zA-Z0-9_ ]+$");
            Match TitreTest = regexTitre.Match(Titre);

            Regex regexAuteur = new Regex(@"^[a-zA-Z_ ]+$");
            Match AuteurTest = regexAuteur.Match(Auteur);

            Regex regexISBN = new Regex(@"^[0-9]{5}$");
            Match ISBNTest = regexISBN.Match(ISBN);

            Regex regexImage = new Regex(@"^([a-zA-Z_]+)(\.)([a-z]{3}|[a-z]{4})$");
            Match ImageTest = regexImage.Match(Image);

            try
            {
                //|
                //| Test des regex
                //|
                if (!IDTest.Success || !TitreTest.Success || !AuteurTest.Success || !ISBNTest.Success || !ImageTest.Success || uneNouvelleCategorie == null)
                {
                    throw new ExceptionSio("CRUD LIVRE - Modifier", "Un ou plusieurs regex se sont déclenchés.", "");
                }
                else
                {
                    //|
                    //| On supprime l'ancien objet et on le recrée avec les nouveaux trucs
                    //|
                    Livre leLivreForEdit = (Livre)selectLivreForEdit.SelectedItem;
                    leLivreForEdit = null;
                    leLivreForEdit = new Livre(ID, Titre, ISBN, Auteur, Collection, Image, uneNouvelleCategorie);

                    //|
                    //| Appel de la base de données
                    //|
                    bool resultat;

                    resultat = DAODocuments.EditLivre(leLivreForEdit, uneNouvelleCategorie);

                    if (resultat)
                    {
                        //|
                        //| On met à jour la combobox de la modif et suppression des livres & le datagridview des livres
                        //|
                        lesLivres = DAODocuments.GetAllLivres();

                        SetAllDataOfLivres();

                        SetComboboxLivreForLivre();

                        textEventLivres.Text = "Le livre à été modifié";
                        textEventLivres.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    }
                    else
                    {
                        throw new ExceptionSio("CRUD LIVRE - Modifier", "Erreur BDD lors de la modification du livre", "");
                    }
                }
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //|-----------------------------------------------------------
        //| Suppression des livres
        //|-----------------------------------------------------------
        private void ButtonDeleteLivre_Click(object sender, EventArgs e)
        {
            bool resultat;
            Livre leLivreForDelete = (Livre)selectLivreForDelete.SelectedItem;

            try
            {
                //|
                //| Si la combobox est séléctionnée
                //|
                if (leLivreForDelete != null)
                {
                    resultat = DAODocuments.DeleteLivre(leLivreForDelete);

                    if (resultat)
                    {
                        //|
                        //| On met à jour la combobox de la modif et suppression des livres
                        //|
                        lesLivres = DAODocuments.GetAllLivres();

                        SetAllDataOfLivres();

                        SetComboboxLivreForLivre();

                        textEventLivres.Text = "Le livre à bien été supprimé";
                        textEventLivres.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    }
                    else
                    {
                        throw new ExceptionSio("CRUD LIVRE - Supprimer", "Erreur BDD lors de la suppression du livre", "");
                    }
                }
                else
                {
                    throw new ExceptionSio("CRUD LIVRE - Supprimer", "Aucun livre séléctionné", "");
                }
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Gestion des Dvd

        //|-----------------------------------------------------------
        //| Affichage de tous les dvd dans le datagridview
        //|-----------------------------------------------------------
        public void SetAllDataOfDvd()
        {
            dataOfDvd.Rows.Clear();

            foreach (Dvd unDvd in lesDvd)
            {
                dataOfDvd.Rows.Add(unDvd.IdDoc, unDvd.Titre, unDvd.Image, unDvd.LaCategorie.Libelle, unDvd.Synopsis, unDvd.Realisateur, unDvd.Duree);
            }
        }

        //|-----------------------------------------------------------
        //| Créer un Dvd
        //|-----------------------------------------------------------
        private void ButtonCreerDvd_Click_1(object sender, EventArgs e)
        {
            //|
            //| Récupération des infos des input
            //|
            String ID = inputIdDvd.Text;
            String Titre = inputTitreDvd.Text;
            String Image = inputImageDvd.Text;
            String Realisateur = inputRealisateurDvd.Text;
            string DureeString = inputDureeDvd.Text;
            int Duree = int.Parse(inputDureeDvd.Text);
            String Synopsis = inputSynopsisDvd.Text;

            Categorie uneNouvelleCategorie = (Categorie)selectCategorieDvdForCreate.SelectedItem;

            //|
            //| Regex
            //|
            Regex regexID = new Regex(@"^[0-9]{5}$");
            Match IDTest = regexID.Match(ID);

            Regex regexTitre = new Regex(@"^[a-zA-ZÀ-ÿ \-\']+$");
            Match TitreTest = regexTitre.Match(Titre);

            Regex regexImage = new Regex(@"^([a-zA-Z_]+)(\.)([a-z]{3}|[a-z]{4})$");
            Match ImageTest = regexImage.Match(Image);

            Regex regexRealisateur = new Regex(@"^[a-zA-ZÀ-ÿ \-\']+$");
            Match RealisateurTest = regexRealisateur.Match(Realisateur);

            Regex regexDuree = new Regex(@"^[0-9]+$");
            Match DureeTest = regexDuree.Match(DureeString);

            try
            {
                //|
                //| Test des regex
                //|
                if (!IDTest.Success || !TitreTest.Success || !RealisateurTest.Success || !DureeTest.Success || !ImageTest.Success || uneNouvelleCategorie == null)
                {
                    throw new ExceptionSio("CRUD DVD - Créer", "Un ou plusieurs regex se sont déclenchés.", "");
                }
                else
                {
                    //|
                    //| Création de l'objet Dvd
                    //|
                    Dvd unNouveauDvd = new Dvd(ID, Synopsis, Realisateur, Titre, Duree, Image, uneNouvelleCategorie);

                    //|
                    //| Appel de la base de données
                    //|
                    bool resultat;

                    resultat = DAODocuments.SetNouveauDvd(unNouveauDvd, uneNouvelleCategorie);

                    if (resultat)
                    {
                        //|
                        //| On met à jour la combobox de la modif et suppression des dvd & le datagridview des dvd
                        //|
                        lesDvd = DAODocuments.GetAllDvd();

                        SetAllDataOfDvd();

                        SetComboboxDvdForDvd();

                        textEventDvd.Text = "Un dvd à été créé";
                        textEventDvd.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    }
                    else
                    {
                        throw new ExceptionSio("CRUD DVD - Créer", "Erreur BDD lors de la création du dvd", "");
                    }
                }
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //|-----------------------------------------------------------
        //| Affichage des infos du dvd séléctionné dans modification
        //|-----------------------------------------------------------
        private void SelectDvdForEdit_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //|
            //| On recupère les infos de l'objet dvd séléctionné
            //|
            Dvd leDvdForEdit = (Dvd)SelectDvdForEdit.SelectedItem;

            inputIdDvdForEdit.Text = leDvdForEdit.IdDoc;
            inputTitreDvdForEdit.Text = leDvdForEdit.Titre;
            inputImageDvdForEdit.Text = leDvdForEdit.Image;
            inputSynopsisDvdForEdit.Text = leDvdForEdit.Synopsis;
            inputRealisateurDvdForEdit.Text = leDvdForEdit.Realisateur;
            inputDureeDvdForEdit.Text = leDvdForEdit.Duree.ToString();
            selectCategorieDvdForEdit.Text = leDvdForEdit.LaCategorie.Libelle;
        }

        //|-----------------------------------------------------------
        //| Modification des Dvd
        //|-----------------------------------------------------------
        private void ButtonEditDvd_Click_1(object sender, EventArgs e)
        {
            //|
            //| Récupération des infos des input
            //|
            String ID = inputIdDvdForEdit.Text;
            String Titre = inputTitreDvdForEdit.Text;
            String Image = inputImageDvdForEdit.Text;
            String Synopsis = inputSynopsisDvdForEdit.Text;
            String Realisateur = inputRealisateurDvdForEdit.Text;
            string DureeString = inputDureeDvdForEdit.Text;
            int Duree = int.Parse(inputDureeDvdForEdit.Text);

            Categorie uneNouvelleCategorie = (Categorie)selectCategorieDvdForEdit.SelectedItem;

            //|
            //| Regex
            //|
            Regex regexID = new Regex(@"^[0-9]{5}$");
            Match IDTest = regexID.Match(ID);

            Regex regexTitre = new Regex(@"^[a-zA-ZÀ-ÿ \-\']+$");
            Match TitreTest = regexTitre.Match(Titre);

            Regex regexImage = new Regex(@"^([a-zA-Z_]+)(\.)([a-z]{3}|[a-z]{4})$");
            Match ImageTest = regexImage.Match(Image);

            Regex regexRealisateur = new Regex(@"^[a-zA-ZÀ-ÿ \-\']+$");
            Match RealisateurTest = regexRealisateur.Match(Realisateur);

            Regex regexSynopsis = new Regex(@"^[a-zA-ZÀ-ÿ \-\']+$");
            Match SynopsisTest = regexSynopsis.Match(Synopsis);

            Regex regexDuree = new Regex(@"^[0-9]+$");
            Match DureeTest = regexDuree.Match(DureeString);

            try
            {
                //|
                //| Test des regex
                //|
                if (!IDTest.Success || !TitreTest.Success || !RealisateurTest.Success || !DureeTest.Success || !ImageTest.Success || !SynopsisTest.Success || uneNouvelleCategorie == null)
                {
                    throw new ExceptionSio("CRUD DVD - Modifier", "Un ou plusieurs regex se sont déclenchés.", "");
                }
                else
                {
                    //|
                    //| On supprime l'ancien objet et on le recrée avec les nouveaux trucs
                    //|
                    Dvd leDvdForEdit = (Dvd)SelectDvdForEdit.SelectedItem;
                    leDvdForEdit = null;
                    leDvdForEdit = new Dvd(ID, Synopsis, Realisateur, Titre, Duree, Image, uneNouvelleCategorie);

                    //|
                    //| Appel de la base de données
                    //|
                    bool resultat;

                    resultat = DAODocuments.EditDvd(leDvdForEdit, uneNouvelleCategorie);

                    if (resultat)
                    {
                        //|
                        //| On met à jour la combobox de la modif et suppression des dvd & le datagridview des dvd
                        //|
                        lesDvd = DAODocuments.GetAllDvd();

                        SetAllDataOfDvd();

                        SetComboboxDvdForDvd();

                        textEventDvd.Text = "Le dvd à été modifié";
                        textEventDvd.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    }
                    else
                    {
                        throw new ExceptionSio("CRUD DVD - Modifier", "Erreur BDD lors de la modification du dvd", "");
                    }
                }
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //|-----------------------------------------------------------
        //| Supprimer les Dvd
        //|-----------------------------------------------------------
        private void ButtonDeleteDvd_Click_1(object sender, EventArgs e)
        {
            bool resultat;
            Dvd leDvdForDelete = (Dvd)selectDvdForDelete.SelectedItem;

            try
            {
                //|
                //| Si la combobox est séléctionnée
                //|
                if (leDvdForDelete != null)
                {
                    resultat = DAODocuments.DeleteDvd(leDvdForDelete);

                    if (resultat)
                    {
                        textEventDvd.Text = "Le dvd à bien été supprimé";
                        textEventDvd.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);

                        //|
                        //| On met à jour la combobox de la modif et suppression des dvd
                        //|
                        lesDvd = DAODocuments.GetAllDvd();

                        SetAllDataOfDvd();

                        SetComboboxDvdForDvd();
                    }
                    else
                    {
                        throw new ExceptionSio("CRUD DVD - Supprimer", "Erreur BDD lors de la suppression du dvd", "");
                    }
                }
                else
                {
                    throw new ExceptionSio("CRUD DVD - Supprimer", "Aucun livre séléctionné", "");
                }
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #endregion

        #region Gestion des Commandes

        //|-----------------------------------------------------------
        //| Affichage de toutes les commandes dans le datagridview
        //|-----------------------------------------------------------
        public void SetAllDataOfCommandes()
        {
            dataOfCommande.Rows.Clear();

            foreach (Commande uneCommande in lesCommandes)
            {
                dataOfCommande.Rows.Add(uneCommande.IdCommande, uneCommande.ExemplairesCommande, uneCommande.DateCommande, uneCommande.MontantCommande, uneCommande.Document.Titre, uneCommande.EtatCommande.Libelle);
            }
        }

        //|-----------------------------------------------------------
        //| Créer une commande
        //|-----------------------------------------------------------
        private void ButtonCreateCommande_Click(object sender, EventArgs e)
        {
            //| Récupération des variables
            string ID = inputIdCommande.Text;
            int NbExemplaires = int.Parse(inputNbExemplairesCommande.Text);
            string NbExemplairesString = inputNbExemplairesCommande.Text;
            DateTime DateCommande = inputDateCommande.Value;
            int MontantCommande = int.Parse(inputMontantCommande.Text);
            string MontantCommandeString = inputMontantCommande.Text;

            Document unNouveauDocumentForCommande = (Document)selectDocumentForCreateCommande.SelectedItem;
            EtatCommande unNouvelEtatCommandeForCommande = (EtatCommande)selectEtatForCreateCommande.SelectedItem;

            //| Regex
            Regex regexID = new Regex(@"^([A-Z]{2})(\-)([0-9]{5})$");
            Match IDTest = regexID.Match(ID);

            Regex regexNbExemplaires = new Regex(@"^[0-9]+$");
            Match NbExemplairesTest = regexNbExemplaires.Match(NbExemplairesString);

            Regex regexMontantCommande = new Regex(@"^[0-9]+$");
            Match MontantCommandeTest = regexMontantCommande.Match(MontantCommandeString);

            try
            {
                //| Test des entrées
                if (!IDTest.Success || !NbExemplairesTest.Success || !MontantCommandeTest.Success ||  DateCommande == null || unNouveauDocumentForCommande == null || unNouvelEtatCommandeForCommande == null)
                {
                    throw new ExceptionSio("CRUD COMMANDE - Créer", "Un ou plusieurs regex se sont déclenchés.", "");
                }
                else
                {
                    //| On créer un nouvel objet commande
                    Commande unNouvelleCommande = new Commande(ID, NbExemplaires, DateCommande, MontantCommande, unNouveauDocumentForCommande, unNouvelEtatCommandeForCommande);

                    //| On envoie la commande à la bdd
                    bool resultat = DAOCommandes.SetNouvelleCommande(ID, NbExemplaires, DateCommande, MontantCommande, unNouveauDocumentForCommande, unNouvelEtatCommandeForCommande);

                    //| Si ça a marché
                    if (resultat)
                    {
                        //| On reset la collection de commandes
                        lesCommandes = DAOCommandes.GetAllCommandes();

                        //| On reset le datagridview
                        SetAllDataOfCommandes();

                        //| On reset les combobox
                        SetComboboxCommandeForCommande();

                        textEventCommande.Text = "La commande à bien étée créé";
                        textEventCommande.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    }
                    else
                    {
                        throw new ExceptionSio("CRUD COMMANDE - Créer", "Erreur BDD lors de la création de la commande.", "");
                    }
                }
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //|-----------------------------------------------------------
        //| Affiche les infos d'une commande
        //|-----------------------------------------------------------
        private void SelectCommandeForEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //|
            //| On recupère les infos de l'objet commande séléctionné
            //|
            Commande laCommandeForEdit = (Commande)SelectCommandeForEdit.SelectedItem;

            inputIdCommandeForEdit.Text = laCommandeForEdit.IdCommande.ToString();
            inputNbExemplairesCommandeForEdit.Text = laCommandeForEdit.ExemplairesCommande.ToString();
            inputDateCommandeForEdit.Value = laCommandeForEdit.DateCommande;
            inputMontantCommandeForEdit.Text = laCommandeForEdit.MontantCommande.ToString();
            selectDocumentForEditCommande.Text = laCommandeForEdit.Document.Titre;
            selectEtatForEditCommande.Text = laCommandeForEdit.EtatCommande.Libelle;
        }

        //|-----------------------------------------------------------
        //| Modification des Commandes
        //|-----------------------------------------------------------
        private void ButtonModifierCommande_Click(object sender, EventArgs e)
        {
            string ID = inputIdCommandeForEdit.Text;
            int NbExemplaires = int.Parse(inputNbExemplairesCommandeForEdit.Text);
            string NbExemplairesString = inputNbExemplairesCommandeForEdit.Text;
            DateTime DateCommande = inputDateCommandeForEdit.Value;
            int Montant = int.Parse(inputMontantCommandeForEdit.Text);
            string MontantString = inputMontantCommandeForEdit.Text;

            Document uneNouveauDocument = (Document)selectDocumentForEditCommande.SelectedItem;
            EtatCommande unNouvelEtatCommande = (EtatCommande)selectEtatForEditCommande.SelectedItem;

            //| Regex
            Regex regexID = new Regex(@"^([A-Z]{2})(\-)([0-9]{5})$");
            Match IDTest = regexID.Match(ID);

            Regex regexNbExemplaires = new Regex(@"^[0-9]+$");
            Match NbExemplairesTest = regexNbExemplaires.Match(NbExemplairesString);

            Regex regexMontantCommande = new Regex(@"^[0-9]+$");
            Match MontantCommandeTest = regexMontantCommande.Match(MontantString);

            try
            {
                if (!IDTest.Success || !NbExemplairesTest.Success || !MontantCommandeTest.Success || DateCommande == null || uneNouveauDocument == null || unNouvelEtatCommande == null)
                {
                    throw new ExceptionSio("CRUD COMMANDE - Modifier", "Un ou plusieurs regex se sont déclenchés.", "");
                }
                else
                {
                    //| Création de l'objet commande
                    Commande laCommandeForEdit = (Commande)SelectCommandeForEdit.SelectedItem;
                    laCommandeForEdit = null;
                    laCommandeForEdit = new Commande(ID, NbExemplaires, DateCommande, Montant, uneNouveauDocument, unNouvelEtatCommande);

                    //| Appel de la base de données pour modifier la commande selon son ID
                    bool resultat;

                    resultat = DAOCommandes.EditCommande(laCommandeForEdit, uneNouveauDocument, unNouvelEtatCommande);

                    if (resultat)
                    {
                        //| On met à jour la combobox de la modif et suppression des dvd & le datagridview des dvd
                        lesCommandes = DAOCommandes.GetAllCommandes();

                        SetAllDataOfCommandes();

                        SetComboboxCommandeForCommande();

                        textEventCommande.Text = "La commande à été modifiée";
                        textEventCommande.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);
                    }
                    else
                    {
                        throw new ExceptionSio("CRUD COMMANDE - Modifier", "Erreur BDD lors de la modification de la commande", "");
                    }
                }
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //|-----------------------------------------------------------
        //| Suppression des Commandes
        //|-----------------------------------------------------------
        private void ButtonDeleteCommande_Click(object sender, EventArgs e)
        {
            bool resultat;
            Commande laCommandeForDelete = (Commande)selectCommandeForDelete.SelectedItem;

            if (laCommandeForDelete == null)
            {
                throw new ExceptionSio("CRUD COMMANDE - Supprimer", "Aucune commande séléctionnée.", "");
            }
            else
            {
                resultat = DAOCommandes.DeleteCommande(laCommandeForDelete);

                if (resultat)
                {
                    textEventCommande.Text = "La commande à bien été supprimée";
                    textEventCommande.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);

                    //| On met à jour la combobox de la modif et suppression des dvd
                    lesCommandes = DAOCommandes.GetAllCommandes();

                    SetAllDataOfCommandes();

                    SetComboboxCommandeForCommande();
                }
                else
                {
                    throw new ExceptionSio("CRUD COMMANDE - Supprimer", "Erreur BDD lors de la suppression de la commande", "");
                }
            }
        }

        #endregion

        /** [CRYPTAGE MD5] Cryptage en MD5
         * @param text (mdp)
         * **/
        public string MD5(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
