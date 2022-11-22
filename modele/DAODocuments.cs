using Mediateq_AP_SIO2.metier;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediateq_AP_SIO2
{
    class DAODocuments
    {
        public static List<Categorie> getAllCategories()
        {
            List<Categorie> lesCategories = new List<Categorie>();
            string req = "Select * from categorie";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Categorie categorie = new Categorie(reader[0].ToString(), reader[1].ToString());
                lesCategories.Add(categorie);
            }
            DAOFactory.deconnecter();
            return lesCategories;
        }

        public static List<Descripteur> getAllDescripteurs()
        {
            List<Descripteur> lesDescripteurs = new List<Descripteur>();
            string req = "Select * from descripteur";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Descripteur genre = new Descripteur(reader[0].ToString(), reader[1].ToString());
                lesDescripteurs.Add(genre);
            }
            DAOFactory.deconnecter();
            return lesDescripteurs;
        }
        
        public static List<Livre> getAllLivres()
        {
            List<Livre> lesLivres = new List<Livre>();
            string req = "Select l.id, l.ISBN, l.auteur, d.titre, d.image, l.collection, d.idCategorie, c.libelle from livre l ";
            req += " join document d on l.id=d.id";
            req += " join categorie c on d.idCategorie = c.id";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            while (reader.Read())
            {
                Livre livre = new Livre(reader[0].ToString(), reader[3].ToString(), reader[1].ToString(),
                reader[2].ToString(), reader[5].ToString(), reader[4].ToString(),new Categorie(reader[6].ToString(),reader[7].ToString()));
  
                lesLivres.Add(livre);
                
            }

            DAOFactory.deconnecter();

            return lesLivres;
        }

        public static void setDescripteurs(List<Livre> lesLivres)
        {
            DAOFactory.connecter();

            foreach (Livre livre in lesLivres)
            {
                List<Descripteur> lesDescripteursDuLivre = new List<Descripteur>(); ;
                string req = "Select de.id, de.libelle from descripteur de ";
                req += " join est_decrit_par e on de.id = e.idDesc";
                req += " join document do on do.id = '" + livre.IdDoc + "'";
                             
                MySqlDataReader reader = DAOFactory.execSQLRead(req);
                while (reader.Read())
                {
                    lesDescripteursDuLivre.Add(new Descripteur(reader[0].ToString(), reader[1].ToString()));
                }
                livre.LesDescripteurs = lesDescripteursDuLivre;
            }
            DAOFactory.deconnecter();
        }

        public static Categorie getCategorieByLivre(Livre pLivre)
        {
            Categorie categorie;
            string req = "Select c.id,c.libelle from categorie c,document d where c.id = d.idCategorie and d.id='";
            req += pLivre.IdDoc + "'";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            if (reader.Read())
            {
                categorie = new Categorie(reader[0].ToString(), reader[1].ToString());
            }
            else
            {
                categorie = null;
            }
            DAOFactory.deconnecter();
            return categorie;
        }



        //|-----------------------------------------------------------
        //| Créer un nouveau livre
        //|-----------------------------------------------------------
        public static bool setNouveauLivre(String ID, String Titre, String ISBN, String Auteur, String Collection, String Image, String unIdCategorie)
        {
            bool resultat;

            try
            {
                String req1 = "INSERT INTO document (id, titre, image, idCategorie) VALUES ('" + ID + "', '" + Titre + "', '" + Image + "', '" + unIdCategorie + "');";
                
                String req2 = "INSERT INTO livre (id, ISBN, auteur, collection) VALUES ('" + ID + "', '" + ISBN + "', '" + Auteur + "', '" + Collection + "');";

                DAOFactory.connecter();

                DAOFactory.execSQLWrite(req1);

                DAOFactory.execSQLWrite(req2);

                DAOFactory.deconnecter();

                resultat = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                resultat = false;
            }
            
            return resultat;
        }

        //|-----------------------------------------------------------
        //| Récupération des infos pour la modif des livres
        //|-----------------------------------------------------------
        public static Livre getLivreByLibelleForEdit(String unId)
        {
            Livre resultat;
            String req = "Select l.id, l.ISBN, l.auteur, d.titre, d.image, l.collection, d.idCategorie, c.libelle from livre l ";
            req += " join document d on l.id=d.id";
            req += " join categorie c on d.idCategorie = c.id WHERE d.id = '" + unId + "'";

            DAOFactory.connecter();

            MySqlDataReader reader = DAOFactory.execSQLRead(req);

            if (reader.Read())
            {
                resultat = new Livre(reader[0].ToString(), reader[3].ToString(), reader[1].ToString(),
                reader[2].ToString(), reader[5].ToString(), reader[4].ToString(), new Categorie(reader[6].ToString(), reader[7].ToString()));
            }
            else
            {
                resultat = null;
            }

            DAOFactory.deconnecter();

            return resultat;
        }

        //|-----------------------------------------------------------
        //| Modifiaction d'un livre
        //|-----------------------------------------------------------
        public static bool editLivre(Livre unLivre, Categorie uneCategorie)
        {
            bool resultat;

            try
            {
                String req1 = "UPDATE document SET titre = '" + unLivre.Titre + "', image = '" + unLivre.Image + "', idCategorie = '" + uneCategorie.Id + "' WHERE id = '" + unLivre.IdDoc + "';";

                String req2 = "UPDATE livre SET ISBN = '" + unLivre.ISBN1 + "', auteur = '" + unLivre.Auteur + "', collection = '" + unLivre.LaCollection + "' WHERE id = '" + unLivre.IdDoc + "';";

                DAOFactory.connecter();

                DAOFactory.execSQLWrite(req1);

                DAOFactory.execSQLWrite(req2);

                DAOFactory.deconnecter();

                resultat = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                resultat = false;
            }

            return resultat;
        }

        //|-----------------------------------------------------------
        //| Supprimer un livre
        //|-----------------------------------------------------------
        public static bool deleteLivre(Livre unLivre)
        {
            bool resultat;

            try
            {
                String req1 = "DELETE FROM livre WHERE id = '" + unLivre.IdDoc + "';";

                String req2 = "DELETE FROM document WHERE id = '" + unLivre.IdDoc + "';";

                DAOFactory.connecter();

                DAOFactory.execSQLWrite(req1);

                DAOFactory.execSQLWrite(req2);

                DAOFactory.deconnecter();

                resultat = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                resultat = false;
            }
            return resultat;
        }
    }
}
