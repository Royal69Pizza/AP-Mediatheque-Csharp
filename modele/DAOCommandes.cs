using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Mediateq_AP_SIO2.metier;
using Mediateq_AP_SIO2.divers;
using System.Windows.Forms;

namespace Mediateq_AP_SIO2
{
    class DAOCommandes
    {
        //|-----------------------------------------------------------
        //| Retourne les commandes
        //|-----------------------------------------------------------
        public static List<Commande> GetAllCommandes()
        {
            List<Commande> lesCommandes = new List<Commande>();
            string req = "SELECT cat.id, cat.libelle, c.id, c.nbExemplaire, c.dateCommande, c.montant, d.id, d.titre, d.image, ec.idEtatCommande, ec.libelle FROM commande c";
            req += " JOIN document d ON c.idDoc = d.id";
            req += " JOIN etatcommande ec ON c.idEtatCommande = ec.idEtatCommande";
            req += " JOIN categorie cat ON d.idCategorie = cat.id";

            try
            {
                DAOFactory.Connecter();

                MySqlDataReader reader = DAOFactory.ExecSQLRead(req);

                while (reader.Read())
                {
                    Categorie categorie = new Categorie(reader[0].ToString(), reader[1].ToString());
                    Document document = new Document(reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), categorie);
                    EtatCommande etatCommande = new EtatCommande(reader[9].ToString(), reader[10].ToString());

                    Commande commande = new Commande(reader[2].ToString(), int.Parse(reader[3].ToString()), Convert.ToDateTime(reader[4].ToString()), int.Parse(reader[5].ToString()), document, etatCommande);

                    lesCommandes.Add(commande);
                }

                DAOFactory.Deconnecter();
            }
            catch (Exception e)
            {
                DAOFactory.Deconnecter();
                throw new ExceptionSio("CRUD Commandes - Afficher", "Erreur BDD lors de la création de la commande", e.Message);
            }

            return lesCommandes;
        }

        //|-----------------------------------------------------------
        //| Retourne tous les Documents
        //|-----------------------------------------------------------
        public static List<Document> GetAllDocuments()
        {
            List<Document> lesDocument = new List<Document>();
            string req = "SELECT d.id, d.titre, d.image, c.id, c.libelle FROM document d";
            req += " JOIN categorie c on d.idCategorie = c.id";

            try
            {
                DAOFactory.Connecter();

                MySqlDataReader reader = DAOFactory.ExecSQLRead(req);

                while (reader.Read())
                {
                    Document document = new Document(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), new Categorie(reader[3].ToString(), reader[4].ToString()));

                    lesDocument.Add(document);
                }

                DAOFactory.Deconnecter();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DAOFactory.Deconnecter();
            }

            return lesDocument;
        }

        //|-----------------------------------------------------------
        //| Retourne tous les EtatCommande
        //|-----------------------------------------------------------
        public static List<EtatCommande> GetAllEtatCommandes()
        {
            List<EtatCommande> lesEtatCommande = new List<EtatCommande>();
            string req = "SELECT * FROM etatcommande";

            try
            {
                DAOFactory.Connecter();

                MySqlDataReader reader = DAOFactory.ExecSQLRead(req);

                while (reader.Read())
                {
                    EtatCommande etatCommande = new EtatCommande(reader[0].ToString(), reader[1].ToString());

                    lesEtatCommande.Add(etatCommande);
                }

                DAOFactory.Deconnecter();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DAOFactory.Deconnecter();
            }

            return lesEtatCommande;
        }

        //|-----------------------------------------------------------
        //| Créer une nouvelle Commande
        //|-----------------------------------------------------------
        public static bool SetNouvelleCommande(string ID, int NbExemplaires, DateTime DateCommande, int MontantCommande, Document unNouveauDocumentForCommande, EtatCommande unNouvelEtatCommandeForCommande)
        {
            bool resultat;

            try
            {
                string uneDate = DateCommande.ToString("yyyy-MM-dd");

                string requetePrepareeSurCommande = "INSERT INTO commande (id, nbExemplaire, dateCommande, montant, idDoc, idEtatCommande) VALUES (@id, @nbExemplaire, @dateCommande, @montant, @idDoc, @idEtatCommande);";

                DAOFactory.Connecter();

                using (MySqlCommand requetePrepareeParametreeSurCommande = new MySqlCommand(requetePrepareeSurCommande, DAOFactory.ReturnConnexion()))
                {
                    requetePrepareeParametreeSurCommande.Parameters.AddWithValue("@id", ID);
                    requetePrepareeParametreeSurCommande.Parameters.AddWithValue("@nbExemplaire", NbExemplaires);
                    requetePrepareeParametreeSurCommande.Parameters.AddWithValue("@dateCommande", uneDate);
                    requetePrepareeParametreeSurCommande.Parameters.AddWithValue("@montant", MontantCommande);
                    requetePrepareeParametreeSurCommande.Parameters.AddWithValue("@idDoc", unNouveauDocumentForCommande.IdDoc);
                    requetePrepareeParametreeSurCommande.Parameters.AddWithValue("@idEtatCommande", unNouvelEtatCommandeForCommande.Id);

                    requetePrepareeParametreeSurCommande.ExecuteNonQuery();
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
        //| Modifiaction d'une commande
        //|-----------------------------------------------------------
        public static bool EditCommande(Commande uneCommande, Document unDocument, EtatCommande unEtatCommande)
        {
            bool resultat;

            try
            {
                string uneDate = uneCommande.DateCommande.ToString("yyyy-MM-dd");

                string requetePrepareeSurCommande = "UPDATE commande SET nbExemplaire = @nbExemplaire, dateCommande = @dateCommande, montant = @montant, idDoc = @idDoc, idEtatCommande = @idEtatCommande WHERE id = @id;";

                DAOFactory.Connecter();

                using (MySqlCommand requetePrepareeParametreeSurCommande = new MySqlCommand(requetePrepareeSurCommande, DAOFactory.ReturnConnexion()))
                {
                    requetePrepareeParametreeSurCommande.Parameters.AddWithValue("@nbExemplaire", uneCommande.ExemplairesCommande);
                    requetePrepareeParametreeSurCommande.Parameters.AddWithValue("@dateCommande", uneDate);
                    requetePrepareeParametreeSurCommande.Parameters.AddWithValue("@montant", uneCommande.MontantCommande);
                    requetePrepareeParametreeSurCommande.Parameters.AddWithValue("@idDoc", unDocument.IdDoc);
                    requetePrepareeParametreeSurCommande.Parameters.AddWithValue("@idEtatCommande", unEtatCommande.Id);
                    requetePrepareeParametreeSurCommande.Parameters.AddWithValue("@id", uneCommande.IdCommande);

                    requetePrepareeParametreeSurCommande.ExecuteNonQuery();
                }
                
                //String req = "UPDATE commande SET nbExemplaire = '" + uneCommande.ExemplairesCommande + "', dateCommande = '" + uneDate + "', montant = '" + uneCommande.MontantCommande + "', idDoc = '" + unDocument.IdDoc + "', idEtatCommande = '" + unEtatCommande.Id + "' WHERE id = '" + uneCommande.IdCommande + "';";

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
        //| Supprimer une commande
        //|-----------------------------------------------------------
        public static bool DeleteCommande(Commande uneCommande)
        {
            bool resultat;

            try
            {
                String req = "DELETE FROM commande WHERE id = '" + uneCommande.IdCommande + "';";

                DAOFactory.Connecter();

                DAOFactory.ExecSQLWrite(req);

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
    }
}

