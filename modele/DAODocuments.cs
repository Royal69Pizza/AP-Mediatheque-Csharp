using Mediateq_AP_SIO2.metier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mediateq_AP_SIO2
{
    class DAODocuments
    {

        #region Gestion Générale

        public static List<Categorie> GetAllCategories()
        {
            List<Categorie> lesCategories = new List<Categorie>();
            string req = "Select * from categorie";

            try
            {
                DAOFactory.Connecter();

                MySqlDataReader reader = DAOFactory.ExecSQLRead(req);

                while (reader.Read())
                {
                    Categorie categorie = new Categorie(reader[0].ToString(), reader[1].ToString());
                    lesCategories.Add(categorie);
                }
                DAOFactory.Deconnecter();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DAOFactory.Deconnecter();
            }

            return lesCategories;
        }

        public static List<Descripteur> GetAllDescripteurs()
        {
            List<Descripteur> lesDescripteurs = new List<Descripteur>();
            string req = "Select * from descripteur";

            try
            {
                DAOFactory.Connecter();

                MySqlDataReader reader = DAOFactory.ExecSQLRead(req);

                while (reader.Read())
                {
                    Descripteur genre = new Descripteur(reader[0].ToString(), reader[1].ToString());
                    lesDescripteurs.Add(genre);
                }
                DAOFactory.Deconnecter();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DAOFactory.Deconnecter();
            }
            
            return lesDescripteurs;
        }
        
        public static List<Livre> GetAllLivres()
        {
            List<Livre> lesLivres = new List<Livre>();
            string req = "Select l.id, d.titre, l.ISBN, l.auteur, l.collection, d.image, d.idCategorie, c.libelle from livre l ";
            req += " join document d on l.id=d.id";
            req += " join categorie c on d.idCategorie = c.id";

            try
            {
                DAOFactory.Connecter();

                MySqlDataReader reader = DAOFactory.ExecSQLRead(req);

                while (reader.Read())
                {
                    Livre livre = new Livre(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), new Categorie(reader[6].ToString(), reader[7].ToString()));

                    lesLivres.Add(livre);
                }

                DAOFactory.Deconnecter();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DAOFactory.Deconnecter();
            }
            
            return lesLivres;
        }

        //|-----------------------------------------------------------
        //| Retourne une collection d'objets DVD
        //|-----------------------------------------------------------
        public static List<Dvd> GetAllDvd()
        {
            List<Dvd> lesDvd = new List<Dvd>();
            string req = "Select d.id, d.synopsis, d.réalisateur, doc.titre, d.duree, doc.image, doc.idCategorie, c.libelle from dvd d";
            req += " join document doc on d.id = doc.id";
            req += " join categorie c on doc.idCategorie = c.id";

            try
            {
                DAOFactory.Connecter();

                MySqlDataReader reader = DAOFactory.ExecSQLRead(req);

                while (reader.Read())
                {
                    Dvd dvd = new Dvd(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString()), reader[5].ToString(), new Categorie(reader[6].ToString(), reader[7].ToString()));

                    lesDvd.Add(dvd);
                }

                DAOFactory.Deconnecter();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DAOFactory.Deconnecter();
            }

            return lesDvd;
        }

        //|-----------------------------------------------------------
        //| Créer un genre
        //|-----------------------------------------------------------
        public static void SetDescripteurs(List<Livre> lesLivres)
        {
            try
            {
                DAOFactory.Connecter();

                foreach (Livre livre in lesLivres)
                {
                    List<Descripteur> lesDescripteursDuLivre = new List<Descripteur>(); ;
                    string req = "Select de.id, de.libelle from descripteur de ";
                    req += " join est_decrit_par e on de.id = e.idDesc";
                    req += " join document do on do.id = '" + livre.IdDoc + "'";

                    MySqlDataReader reader = DAOFactory.ExecSQLRead(req);
                    while (reader.Read())
                    {
                        lesDescripteursDuLivre.Add(new Descripteur(reader[0].ToString(), reader[1].ToString()));
                    }
                    livre.LesDescripteurs = lesDescripteursDuLivre;
                }
                DAOFactory.Deconnecter();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DAOFactory.Deconnecter();
            }
        }

        #endregion

        #region Gestion des Livres

        //|-----------------------------------------------------------
        //| Créer un nouveau livre
        //|-----------------------------------------------------------
        public static bool SetNouveauLivre(String ID, String Titre, String ISBN, String unAuteur, String Collection, String Image, String unIdCategorie)
        {
            bool resultat;

            try
            {
                //| Requètes préparées
                string requetePrepareeSurDocument = "INSERT INTO document (id, titre, image, idCategorie) VALUES (@ID, @Titre, @Image, @unIdCategorie)";
                string requetePrepareeSurLivre = "INSERT INTO livre (id, ISBN, auteur, collection) VALUES (@ID, @ISBN, @unAuteur, @Collection);";

                DAOFactory.Connecter();

                //| Requètes paramétrées
                using (MySqlCommand requetePrepareeParametreeSurDocument = new MySqlCommand(requetePrepareeSurDocument, DAOFactory.ReturnConnexion()))
                {
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@ID", ID);
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@Titre", Titre);
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@Image", Image);
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@unIdCategorie", unIdCategorie);

                    requetePrepareeParametreeSurDocument.ExecuteNonQuery();
                }

                using (MySqlCommand requetePrepareeParametreeSurLivre = new MySqlCommand(requetePrepareeSurLivre, DAOFactory.ReturnConnexion()))
                {
                    requetePrepareeParametreeSurLivre.Parameters.AddWithValue("@ID", ID);
                    requetePrepareeParametreeSurLivre.Parameters.AddWithValue("@ISBN", ISBN);
                    requetePrepareeParametreeSurLivre.Parameters.AddWithValue("@unAuteur", unAuteur);
                    requetePrepareeParametreeSurLivre.Parameters.AddWithValue("@Collection", Collection);

                    requetePrepareeParametreeSurLivre.ExecuteNonQuery();
                }

                DAOFactory.Deconnecter();

                resultat = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                resultat = false;
                DAOFactory.Deconnecter();
            }
            
            return resultat;
        }

        //|-----------------------------------------------------------
        //| Récupération des infos pour la modif des livres
        //|-----------------------------------------------------------
        public static Livre GetLivreByLibelleForEdit(String unId)
        {
            Livre resultat;
            string req = "Select l.id, d.titre, l.ISBN, l.auteur, l.collection, d.image, d.idCategorie, c.libelle from livre l ";
            req += " join document d on l.id=d.id";
            req += " join categorie c on d.idCategorie = c.id WHERE d.id = '" + unId + "'";

            DAOFactory.Connecter();

            MySqlDataReader reader = DAOFactory.ExecSQLRead(req);

            if (reader.Read())
            {
                resultat = new Livre(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), new Categorie(reader[6].ToString(), reader[7].ToString()));
            }
            else
            {
                resultat = null;
            }

            DAOFactory.Deconnecter();

            return resultat;
        }

        //|-----------------------------------------------------------
        //| Modifiaction d'un livre
        //|-----------------------------------------------------------
        public static bool EditLivre(Livre unLivre, Categorie uneCategorie)
        {
            bool resultat;

            try
            {
                string requetePrepareeSurDocument = "UPDATE document SET titre = @titre, image = @image, idCategorie = @idCategorie WHERE id = @idDoc";
                string requetePrepareeSurLivre = "UPDATE livre SET ISBN = @ISBN, auteur = @auteur, collection = @collection WHERE id = @idDoc;";

                DAOFactory.Connecter();

                using (MySqlCommand requetePrepareeParametreeSurDocument = new MySqlCommand(requetePrepareeSurDocument, DAOFactory.ReturnConnexion()))
                {
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@titre", unLivre.Titre);
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@image", unLivre.Image);
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@idCategorie", uneCategorie.Id);
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@idDoc", unLivre.IdDoc);

                    requetePrepareeParametreeSurDocument.ExecuteNonQuery();
                }

                using (MySqlCommand requetePrepareeParametreeSurLivre = new MySqlCommand(requetePrepareeSurLivre, DAOFactory.ReturnConnexion()))
                {
                    requetePrepareeParametreeSurLivre.Parameters.AddWithValue("@ISBN", unLivre.ISBN1);
                    requetePrepareeParametreeSurLivre.Parameters.AddWithValue("@auteur", unLivre.AuteurDuLivre);
                    requetePrepareeParametreeSurLivre.Parameters.AddWithValue("@collection", unLivre.LaCollection);
                    requetePrepareeParametreeSurLivre.Parameters.AddWithValue("@idDoc", unLivre.IdDoc);

                    requetePrepareeParametreeSurLivre.ExecuteNonQuery();
                }

                String req1 = "UPDATE document SET titre = '" + unLivre.Titre + "', image = '" + unLivre.Image + "', idCategorie = '" + uneCategorie.Id + "' WHERE id = '" + unLivre.IdDoc + "';";

                String req2 = "UPDATE livre SET ISBN = '" + unLivre.ISBN1 + "', auteur = '" + unLivre.AuteurDuLivre + "', collection = '" + unLivre.LaCollection + "' WHERE id = '" + unLivre.IdDoc + "';";

                DAOFactory.Deconnecter();

                resultat = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                resultat = false;
                DAOFactory.Deconnecter();
            }

            return resultat;
        }

        //|-----------------------------------------------------------
        //| Supprimer un livre
        //|-----------------------------------------------------------
        public static bool DeleteLivre(Livre unLivre)
        {
            bool resultat;

            try
            {
                String req1 = "DELETE FROM livre WHERE id = '" + unLivre.IdDoc + "';";

                String req2 = "DELETE FROM document WHERE id = '" + unLivre.IdDoc + "';";

                DAOFactory.Connecter();

                DAOFactory.ExecSQLWrite(req1);

                DAOFactory.ExecSQLWrite(req2);

                DAOFactory.Deconnecter();

                resultat = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                resultat = false;
                DAOFactory.Deconnecter();
            }
            return resultat;
        }

        #endregion

        #region Gestion des Dvd

        //|-----------------------------------------------------------
        //| Créer un nouveau Dvd
        //|-----------------------------------------------------------
        public static bool SetNouveauDvd(Dvd unDvd, Categorie uneCategorie)
        {
            bool resultat;

            try
            {
                string requetePrepareeSurDocument = "INSERT INTO document (id, titre, image, idCategorie) VALUES (@id, @titre, @image, @idCategorie);";
                string requetePrepareeSurDvd = "INSERT INTO dvd (id, synopsis, réalisateur, duree) VALUES (@id, @synopsis, @réalisateur, @duree);";

                DAOFactory.Connecter();

                using (MySqlCommand requetePrepareeParametreeSurDocument = new MySqlCommand(requetePrepareeSurDocument, DAOFactory.ReturnConnexion()))
                {
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@id", unDvd.IdDoc);
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@titre", unDvd.Titre);
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@image", unDvd.Image);
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@idCategorie", uneCategorie.Id);

                    requetePrepareeParametreeSurDocument.ExecuteNonQuery();
                }

                using (MySqlCommand requetePrepareeParametreeSurDvd = new MySqlCommand(requetePrepareeSurDvd, DAOFactory.ReturnConnexion()))
                {
                    requetePrepareeParametreeSurDvd.Parameters.AddWithValue("@id", unDvd.IdDoc);
                    requetePrepareeParametreeSurDvd.Parameters.AddWithValue("@synopsis", unDvd.Synopsis);
                    requetePrepareeParametreeSurDvd.Parameters.AddWithValue("@réalisateur", unDvd.Realisateur);
                    requetePrepareeParametreeSurDvd.Parameters.AddWithValue("@duree", unDvd.Duree);

                    requetePrepareeParametreeSurDvd.ExecuteNonQuery();
                }

                DAOFactory.Deconnecter();

                resultat = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                resultat = false;
                DAOFactory.Deconnecter();
            }

            return resultat;
        }

        //|-----------------------------------------------------------
        //| Modification d'un Dvd
        //|-----------------------------------------------------------
        public static bool EditDvd(Dvd unDvd, Categorie uneCategorie)
        {
            bool resultat;

            try
            {
                string requetePrepareeSurDocument = "UPDATE document SET titre = @titre, image = @image, idCategorie = @idCategorie WHERE id = @idDoc;";
                string requetePrepareeSurDvd = "UPDATE dvd SET synopsis = @synopsis, réalisateur = @réalisateur, duree = @duree WHERE id = @idDoc;";

                DAOFactory.Connecter();

                using (MySqlCommand requetePrepareeParametreeSurDocument = new MySqlCommand(requetePrepareeSurDocument, DAOFactory.ReturnConnexion()))
                {
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@titre", unDvd.Titre);
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@image", unDvd.Image);
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@idCategorie", uneCategorie.Id);
                    requetePrepareeParametreeSurDocument.Parameters.AddWithValue("@idDoc", unDvd.IdDoc);

                    requetePrepareeParametreeSurDocument.ExecuteNonQuery();
                }

                using (MySqlCommand requetePrepareeParametreeSurDvd = new MySqlCommand(requetePrepareeSurDvd, DAOFactory.ReturnConnexion()))
                {
                    requetePrepareeParametreeSurDvd.Parameters.AddWithValue("@synopsis", unDvd.Synopsis);
                    requetePrepareeParametreeSurDvd.Parameters.AddWithValue("@réalisateur", unDvd.Realisateur);
                    requetePrepareeParametreeSurDvd.Parameters.AddWithValue("@duree", unDvd.Duree);
                    requetePrepareeParametreeSurDvd.Parameters.AddWithValue("@idDoc", unDvd.IdDoc);

                    requetePrepareeParametreeSurDvd.ExecuteNonQuery();
                }

                //String req1 = "UPDATE document SET titre = '" + unDvd.Titre + "', image = '" + unDvd.Image + "', idCategorie = '" + uneCategorie.Id + "' WHERE id = '" + unDvd.IdDoc + "';";

                //String req2 = "UPDATE dvd SET synopsis = '" + unDvd.Synopsis + "', réalisateur = '" + unDvd.Realisateur + "', duree = '" + unDvd.Duree + "' WHERE id = '" + unDvd.IdDoc + "';";

                DAOFactory.Deconnecter();

                resultat = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                resultat = false;
                DAOFactory.Deconnecter();
            }

            return resultat;
        }

        //|-----------------------------------------------------------
        //| Supprimer un dvd
        //|-----------------------------------------------------------
        public static bool DeleteDvd(Dvd unDvd)
        {
            bool resultat;

            try
            {
                String req1 = "DELETE FROM dvd WHERE id = '" + unDvd.IdDoc + "';";

                String req2 = "DELETE FROM document WHERE id = '" + unDvd.IdDoc + "';";

                DAOFactory.Connecter();

                DAOFactory.ExecSQLWrite(req1);

                DAOFactory.ExecSQLWrite(req2);

                DAOFactory.Deconnecter();

                resultat = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                resultat = false;
                DAOFactory.Deconnecter();
            }
            return resultat;
        }

        #endregion
    }
}
