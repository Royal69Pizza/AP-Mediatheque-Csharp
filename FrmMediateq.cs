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
            tabGestionDesUsers.Enabled = false;
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
            selectDvdForEdit.DataSource = lesDvd;
            selectDvdForEdit.DisplayMember = "titre";

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

            try
            {
                //|
                //| Si les champs ID, Titre et categorie sont vides
                //|
                if (ID == "" || Titre == "" || uneNouvelleCategorie == null)
                {
                    throw new ExceptionSio("CRUD LIVRE - Créer", "Le champ ID, Titre, Catégorie et Auteur sont obligatoires", "");
                }
                else
                {
                    if (ID.Length > 5)
                    {
                        throw new ExceptionSio("CRUD LIVRE - Créer", "Le champ ID est trop long (Max 5 caractères)", "");
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

            try
            {
                //|
                //| Si les champs ID, Titre et categorie sont vides
                //|
                if (ID == "" || Titre == "" || uneNouvelleCategorie == null)
                {
                    throw new ExceptionSio("CRUD LIVRE - Modifier", "Le champ ID, Titre et la catégorie sont obligatoires", "");
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

                    //|
                    //| Création de l'objet Livre
                    //|
                    Livre unNouveauLivre = new Livre(ID, Titre, ISBN, Auteur, Collection, Image, uneNouvelleCategorie);

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
        private void ButtonDeleteLivre_Click_1(object sender, EventArgs e)
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
        private void ButtonCreerDvd_Click(object sender, EventArgs e)
        {
            //|
            //| Récupération des infos des input
            //|
            String ID = inputIdDvd.Text;
            String Titre = inputTitreDvd.Text;
            String Image = inputImageDvd.Text;
            String Realisateur = inputRealisateurDvd.Text;
            int Duree = int.Parse(inputDureeDvd.Text);
            String Synopsis = inputSynopsisDvd.Text;

            Categorie uneNouvelleCategorie = (Categorie)selectCategorieDvdForCreate.SelectedItem;

            try
            {
                //|
                //| Si les champs ID, Titre et categorie sont vides
                //|
                if (ID == "" || Titre == "" || uneNouvelleCategorie == null)
                {
                    throw new ExceptionSio("CRUD DVD - Créer", "Le champ ID, Titre et la catégorie sont obligatoires", "");
                }
                else
                {
                    if (ID.Length > 5)
                    {
                        throw new ExceptionSio("CRUD DVD - Créer", "Le champ ID est trop long (Max 5 caractères)", "");
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
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //|-----------------------------------------------------------
        //| Affichage des infos du dvd séléctionné dans modification
        //|-----------------------------------------------------------
        private void SelectDvdForEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //|
            //| On recupère les infos de l'objet dvd séléctionné
            //|
            Dvd leDvdForEdit = (Dvd)selectDvdForEdit.SelectedItem;

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
        private void ButtonEditDvd_Click(object sender, EventArgs e)
        {
            //|
            //| Récupération des infos des input
            //|
            String ID = inputIdDvdForEdit.Text;
            String Titre = inputTitreDvdForEdit.Text;
            String Image = inputImageDvdForEdit.Text;
            String Synopsis = inputSynopsisDvdForEdit.Text;
            String Realisateur = inputRealisateurDvdForEdit.Text;
            int Duree = int.Parse(inputDureeDvdForEdit.Text);

            Categorie uneNouvelleCategorie = (Categorie)selectCategorieDvdForEdit.SelectedItem;

            try
            {
                //|
                //| Si les champs ID, Titre et categorie sont vides 
                //|
                if (ID == "" || Titre == "" || uneNouvelleCategorie == null)
                {
                    throw new ExceptionSio("CRUD DVD - Modifier", "Le champ ID, Titre et la catégorie sont obligatoires", "");
                }
                else
                {
                    //|
                    //| On supprime l'ancien objet et on le recrée avec les nouveaux trucs
                    //|
                    Dvd leDvdForEdit = (Dvd)selectDvdForEdit.SelectedItem;
                    leDvdForEdit = null;
                    leDvdForEdit = new Dvd(ID, Synopsis, Realisateur, Titre, Duree, Image, uneNouvelleCategorie);

                    //|
                    //| Appel de la base de données
                    //|
                    bool resultat;

                    resultat = DAODocuments.EditDvd(leDvdForEdit, uneNouvelleCategorie);

                    //|
                    //| Création de l'objet Livre
                    //|
                    Dvd unNouveauDvd = new Dvd(ID, Synopsis, Realisateur, Titre, Duree, Image, uneNouvelleCategorie);

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
        private void ButtonDeleteDvd_Click(object sender, EventArgs e)
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
