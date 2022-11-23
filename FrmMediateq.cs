using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mediateq_AP_SIO2.metier;

namespace Mediateq_AP_SIO2
{
    public partial class FrmMediateq : Form
    {
        #region Variables globales
        
        static List<Categorie> lesCategories;
        static List<Descripteur> lesDescripteurs;
        static List<Revue> lesTitres;
        static List<Livre> lesLivres;
        static List<Dvd> lesDvd;

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
            DAOFactory.creerConnection();

            //|
            //| Chargement des objets
            //|
            lesDescripteurs = DAODocuments.getAllDescripteurs();
            lesTitres = DAOPresse.getAllTitre();
            lesCategories = DAODocuments.getAllCategories();
            lesLivres = DAODocuments.getAllLivres();
            lesDvd = DAODocuments.getAllDvd();

            //|
            //| Chargement des comboboxes
            //|
            setComboboxCategorieForLivreAndDvd();
            setComboboxLivreForLivre();
            setComboboxDvdForDvd();

            //|
            //| Chargement des datagridview
            //|
            setAllDataOfLivres();
            setAllDataOfDvd();
        }

        #endregion

        #region Comboboxes

        //|
        //| Comboboxes Livres dans Livre
        //|
        private void setComboboxLivreForLivre()
        {
            selectLivreForEdit.DataSource = lesLivres;
            selectLivreForEdit.DisplayMember = "titre";

            selectLivreForDelete.DataSource = lesLivres;
            selectLivreForDelete.DisplayMember = "titre";
        }

        //|
        //| Comboboxes Dvd dans Dvd
        //|
        private void setComboboxDvdForDvd()
        {
            selectDvdForEdit.DataSource = lesDvd;
            selectDvdForEdit.DisplayMember = "titre";

            selectDvdForDelete.DataSource = lesDvd;
            selectDvdForDelete.DisplayMember = "titre";
        }

        //|
        //| Comboboxes Catégorie dans Livre & Dvd
        //|
        private void setComboboxCategorieForLivreAndDvd()
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

        #endregion

        #region Parutions
        //-----------------------------------------------------------
        // ONGLET "PARUTIONS"
        //-----------------------------------------------------------
        private void tabParutions_Enter(object sender, EventArgs e)
        {
            cbxTitres.DataSource = lesTitres;
            cbxTitres.DisplayMember = "titre";
        }

        private void cbxTitres_SelectedIndexChanged(object sender, EventArgs e)
        {
                List<Parution> lesParutions;

                Revue titreSelectionne = (Revue)cbxTitres.SelectedItem;
                lesParutions = DAOPresse.getParutionByTitre(titreSelectionne);

                // ré-initialisation du dataGridView
                dgvParutions.Rows.Clear();

                // Parcours de la collection des titres et alimentation du datagridview
                foreach (Parution parution in lesParutions)
                {
                    dgvParutions.Rows.Add(parution.Numero, parution.DateParution, parution.Photo);
                }
            
        }
        #endregion

        #region Revues
        //-----------------------------------------------------------
        // ONGLET "TITRES"
        //-----------------------------------------------------------
        private void tabTitres_Enter(object sender, EventArgs e)
        {
            cbxDomaines.DataSource = lesDescripteurs;
            cbxDomaines.DisplayMember = "libelle";
        }

        private void cbxDomaines_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Objet Domaine sélectionné dans la comboBox
            Descripteur domaineSelectionne = (Descripteur)cbxDomaines.SelectedItem;

            // ré-initialisation du dataGridView
            dgvTitres.Rows.Clear();

            // Parcours de la collection des titres et alimentation du datagridview
            foreach (Revue revue in lesTitres)
            {
                if (revue.IdDescripteur==domaineSelectionne.Id)
                {
                    dgvTitres.Rows.Add(revue.Id, revue.Titre, revue.Empruntable, revue.DateFinAbonnement, revue.DelaiMiseADispo);
                }
            }
        }
        #endregion

        #region Livres
        //-----------------------------------------------------------
        // ONGLET "LIVRES"
        //-----------------------------------------------------------

        private void tabLivres_Enter(object sender, EventArgs e)
        {
            // Chargement des objets en mémoire
            lesCategories = DAODocuments.getAllCategories();
            lesDescripteurs = DAODocuments.getAllDescripteurs();
            lesLivres = DAODocuments.getAllLivres();
            //DAODocuments.setDescripteurs(lesLivres);
        }
   
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            // On réinitialise les labels
            lblNumero.Text = "";
            lblTitre.Text = "";
            lblAuteur.Text = "";
            lblCollection.Text = "";
            lblISBN.Text = "";
            lblImage.Text = "";
            lblCategorie.Text = "";

            // On recherche le livre correspondant au numéro de document saisi.
            // S'il n'existe pas: on affiche un popup message d'erreur
            bool trouve = false;
            foreach (Livre livre in lesLivres)
            {
                if (livre.IdDoc==txbNumDoc.Text)
                {
                    lblNumero.Text = livre.IdDoc;
                    lblTitre.Text = livre.Titre;
                    lblAuteur.Text = livre.Auteur;
                    lblCollection.Text = livre.LaCollection;
                    lblISBN.Text = livre.ISBN1;
                    lblImage.Text = livre.Image;
                    lblCategorie.Text = livre.LaCategorie.Libelle;
                    trouve = true;
                }
            }
            if (!trouve)
                MessageBox.Show("Document non trouvé dans les livres");
        }

        private void txbTitre_TextChanged(object sender, EventArgs e)
        {
            dgvLivres.Rows.Clear();

            // On parcourt tous les livres. Si le titre matche avec la saisie, on l'affiche dans le datagrid.
            foreach (Livre livre in lesLivres)
            {
                // on passe le champ de saisie et le titre en minuscules car la méthode Contains
                // tient compte de la casse.
                string saisieMinuscules;
                saisieMinuscules = txbTitre.Text.ToLower();
                string titreMinuscules;
                titreMinuscules = livre.Titre.ToLower();

                //on teste si le titre du livre contient ce qui a été saisi
                if (titreMinuscules.Contains(saisieMinuscules))
                {
                    dgvLivres.Rows.Add(livre.IdDoc,livre.Titre,livre.Auteur,livre.ISBN1,livre.LaCollection);
                }
            }
        }
        #endregion

        #region Gestion des Livres

        //|-----------------------------------------------------------
        //| Affichage de tous les livres dans le datagridview
        //|-----------------------------------------------------------
        public void setAllDataOfLivres()
        {
            dataOfLivre.Rows.Clear();

            foreach (Livre unLivre in lesLivres)
            {
                dataOfLivre.Rows.Add(unLivre.IdDoc, unLivre.Titre, unLivre.Image, unLivre.LaCategorie.Libelle, unLivre.ISBN1, unLivre.Auteur, unLivre.LaCollection);
            }
        }

        //|-----------------------------------------------------------
        //| Crétion des Livres
        //|-----------------------------------------------------------
        private void buttonCreerLivre_Click(object sender, EventArgs e)
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
            
            Categorie uneNouvelleCategorie = (Categorie)selectCategorieLivreForCreate.SelectedItem;

            //|
            //| Si les champs ID et categorie sont vides 
            //|
            if (ID == null || uneNouvelleCategorie == null)
            {
                textAlertEvent.Text = "{CRUD LIVRE}-{Créer} Le champ ID et la catégorie est obligatoire";
                textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            }
            else
            {
                if (ID.Length > 10)
                {
                    textAlertEvent.Text = "{CRUD LIVRE}-{Créer} Le champ ID est trop long (Max 10 caractères)";
                    textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
                }
                else
                {
                    //|
                    //| Création de l'objet Livre
                    //|
                    Livre unNouveauLivre = new Livre(ID, Titre, ISBN, Auteur, Collection, Image, uneNouvelleCategorie);

                    //|
                    //| Appel de la base de données
                    //|
                    bool resultat;

                    resultat = DAODocuments.setNouveauLivre(ID, Titre, ISBN, Auteur, Collection, Image, uneNouvelleCategorie.Id);

                    if (resultat)
                    {
                        textAlertEvent.Text = "{CRUD LIVRE}-{Créer} Un livre à été créé";
                        textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);

                        //|
                        //| On met à jour la combobox de la modif et suppression des livres & le datagridview des livres
                        //|
                        lesLivres = DAODocuments.getAllLivres();

                        setAllDataOfLivres();

                        setComboboxLivreForLivre();
                    }
                    else
                    {
                        textAlertEvent.Text = "{CRUD LIVRE}-{Créer} Erreur BDD lors de la création du livre";
                        textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
                    }
                }
            }
        }

        //|-----------------------------------------------------------
        //| Affichage des infos du livre séléctionné dans modification
        //|-----------------------------------------------------------
        private void selectLivreForEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //|
            //| On recupère les infos de l'objet livre séléctionné
            //|
            Livre leLivreForEdit = (Livre)selectLivreForEdit.SelectedItem;

            inputIDLivreForEdit.Text = leLivreForEdit.IdDoc;
            inputTitreLivreForEdit.Text = leLivreForEdit.Titre;
            inputAuteurLivreForEdit.Text = leLivreForEdit.Auteur;
            inputISBNLivreForEdit.Text = leLivreForEdit.ISBN1;
            inputCollectionLivreForEdit.Text = leLivreForEdit.LaCollection;
            inputImageLivreForEdit.Text = leLivreForEdit.Image;
        }

        //|-----------------------------------------------------------
        //| Modification des livres
        //|-----------------------------------------------------------
        private void buttonEditLivre_Click(object sender, EventArgs e)
        {
            //|
            //| Récupération des infos des input
            //|
            String ID = inputIDLivreForEdit.Text;
            String Titre = inputTitreLivreForEdit.Text;
            String Auteur = inputAuteurLivreForEdit.Text;
            String ISBN = inputISBNLivreForEdit.Text;
            String Collection = inputCollectionLivreForEdit.Text;
            String Image = inputImageLivreForEdit.Text;

            Categorie uneNouvelleCategorie = (Categorie)selectCategorieForEdit.SelectedItem;

            //|
            //| Si les champs ID et categorie sont vides 
            //|
            if (ID == null || uneNouvelleCategorie == null)
            {
                textAlertEvent.Text = "{CRUD LIVRE}-{Modifier} Le champ ID et la catégorie est obligatoire";
                textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
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

                resultat = DAODocuments.editLivre(leLivreForEdit, uneNouvelleCategorie);

                if (resultat)
                {
                    textAlertEvent.Text = "{CRUD LIVRE}-{Modifier} Le livre à été modifié";
                    textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);

                    //|
                    //| On met à jour la combobox de la modif et suppression des livres & le datagridview des livres
                    //|
                    lesLivres = DAODocuments.getAllLivres();

                    setAllDataOfLivres();

                    setComboboxLivreForLivre();
                }
                else
                {
                    textAlertEvent.Text = "{CRUD LIVRE}-{Modifier} Erreur BDD lors de la modification du livre";
                    textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
                }

                //|
                //| Création de l'objet Livre
                //|
                Livre unNouveauLivre = new Livre(ID, Titre, ISBN, Auteur, Collection, Image, uneNouvelleCategorie);
            }
        }

        //|-----------------------------------------------------------
        //| Suppression des livres
        //|-----------------------------------------------------------
        private void buttonDeleteLivre_Click(object sender, EventArgs e)
        {
            bool resultat;
            Livre leLivreForEdit = (Livre)selectLivreForDelete.SelectedItem;

            //|
            //| Si la combobox est séléctionnée
            //|
            if (leLivreForEdit != null )
            {
                resultat = DAODocuments.deleteLivre(leLivreForEdit);

                if (resultat)
                {
                    textAlertEvent.Text = "{CRUD LIVRE}-{Supprimer} Le livre à bien été supprimé";
                    textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);

                    //|
                    //| On met à jour la combobox de la modif et suppression des livres
                    //|
                    lesLivres = DAODocuments.getAllLivres();

                    setComboboxLivreForLivre();
                }
                else
                {
                    textAlertEvent.Text = "{CRUD LIVRE}-{Supprimer} Erreur BDD lors de la suppression du livre";
                    textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
                }
            }
            else
            {
                textAlertEvent.Text = "{CRUD LIVRE}-{Supprimer} Aucun livre séléctionné";
                textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            }
        }

        #endregion

        #region Gestion des Dvd

        //|-----------------------------------------------------------
        //| Affichage de tous les dvd dans le datagridview
        //|-----------------------------------------------------------
        public void setAllDataOfDvd()
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
        private void buttonCreerDvd_Click(object sender, EventArgs e)
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

            //|
            //| Si les champs ID et categorie sont vides 
            //|
            if (ID == null || uneNouvelleCategorie == null)
            {
                textAlertEvent.Text = "{CRUD DVD}-{Créer} Le champ ID et la catégorie est obligatoire";
                textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            }
            else
            {
                if (ID.Length > 10)
                {
                    textAlertEvent.Text = "{CRUD DVD}-{Créer} Le champ ID est trop long (Max 10 caractères)";
                    textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
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

                    resultat = DAODocuments.setNouveauDvd(unNouveauDvd, uneNouvelleCategorie);

                    if (resultat)
                    {
                        textAlertEvent.Text = "{CRUD DVD}-{Créer} Un dvd à été créé";
                        textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);

                        //|
                        //| On met à jour la combobox de la modif et suppression des dvd & le datagridview des dvd
                        //|
                        lesDvd = DAODocuments.getAllDvd();

                        setAllDataOfDvd();

                        setComboboxDvdForDvd();
                    }
                    else
                    {
                        textAlertEvent.Text = "{CRUD DVD}-{Créer} Erreur BDD lors de la création du dvd";
                        textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
                    }
                }
            }
        }

        //|-----------------------------------------------------------
        //| Affichage des infos du dvd séléctionné dans modification
        //|-----------------------------------------------------------
        private void selectDvdForEdit_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        //|-----------------------------------------------------------
        //| Modification des Dvd
        //|-----------------------------------------------------------
        private void buttonEditDvd_Click(object sender, EventArgs e)
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

            //|
            //| Si les champs ID et categorie sont vides 
            //|
            if (ID == null || uneNouvelleCategorie == null)
            {
                textAlertEvent.Text = "{CRUD DVD}-{Modifier} Le champ ID et la catégorie est obligatoire";
                textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
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

                resultat = DAODocuments.editDvd(leDvdForEdit, uneNouvelleCategorie);

                if (resultat)
                {
                    textAlertEvent.Text = "{CRUD DVD}-{Modifier} Le dvd à été modifié";
                    textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);

                    //|
                    //| On met à jour la combobox de la modif et suppression des dvd & le datagridview des dvd
                    //|
                    lesDvd = DAODocuments.getAllDvd();

                    setAllDataOfDvd();

                    setComboboxDvdForDvd();
                }
                else
                {
                    textAlertEvent.Text = "{CRUD DVD}-{Modifier} Erreur BDD lors de la modification du dvd";
                    textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
                }

                //|
                //| Création de l'objet Livre
                //|
                Dvd unNouveauDvd = new Dvd(ID, Synopsis, Realisateur, Titre, Duree, Image, uneNouvelleCategorie);
            }
        }

        //|-----------------------------------------------------------
        //| Supprimer les Dvd
        //|-----------------------------------------------------------
        private void buttonDeleteDvd_Click(object sender, EventArgs e)
        {
            bool resultat;
            Dvd leDvdForDelete = (Dvd)selectDvdForDelete.SelectedItem;

            //|
            //| Si la combobox est séléctionnée
            //|
            if (leDvdForDelete != null)
            {
                resultat = DAODocuments.deleteDvd(leDvdForDelete);

                if (resultat)
                {
                    textAlertEvent.Text = "{CRUD DVD}-{Supprimer} Le dvd à bien été supprimé";
                    textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0);

                    //|
                    //| On met à jour la combobox de la modif et suppression des dvd
                    //|
                    lesDvd = DAODocuments.getAllDvd();

                    setComboboxDvdForDvd();
                }
                else
                {
                    textAlertEvent.Text = "{CRUD DVD}-{Supprimer} Erreur BDD lors de la suppression du dvd";
                    textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
                }
            }
            else
            {
                textAlertEvent.Text = "{CRUD DVD}-{Supprimer} Aucun livre séléctionné";
                textAlertEvent.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            }
        }

        #endregion
    }
}
