using System;
using MySql.Data.MySqlClient;
using Mediateq_AP_SIO2.metier;
using System.Windows.Forms;
using System.Data.SqlClient;
using Mediateq_AP_SIO2.divers;
using System.Collections.Generic;

namespace Mediateq_AP_SIO2
{
    class DAOUtilisateurs
    {
        //|-----------------------------------------------------------
        //| Retourne tous les utilisateurs
        //|-----------------------------------------------------------
        public static List<Utilisateur> GetAllUtilisateurs()
        {
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();
            string req = "SELECT * FROM utilisateur";

            try
            {
                DAOFactory.Connecter();

                MySqlDataReader reader = DAOFactory.ExecSQLRead(req);

                while (reader.Read())
                {
                    Utilisateur unUtilisateur = new Utilisateur(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());

                    lesUtilisateurs.Add(unUtilisateur);
                }

                DAOFactory.Deconnecter();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DAOFactory.Deconnecter();
            }

            return lesUtilisateurs;
        }
        //|-----------------------------------------------------------
        //| Retoune le mdp de l'utilisazteur selon le login
        //|-----------------------------------------------------------
        public static string GetMdpByLogin(string unLogin)
        {
            string resultat = null;
            string req = "SELECT u.mdp FROM utilisateur u WHERE u.login = '" + unLogin + "'";

            try
            {
                DAOFactory.Connecter();

                MySqlDataReader reader = DAOFactory.ExecSQLRead(req);

                //|
                //| return le mdp
                //|
                if (reader.Read())
                {
                    resultat = reader[0].ToString();
                }
                else 
                {
                    //|
                    //| Si on le trouve pas
                    //|
                    resultat = null;
                    throw new ExceptionSio("getMdpByLogin", "Mot de passe introuvable, connexion impossible.", "");
                }

                DAOFactory.Deconnecter();
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
                DAOFactory.Deconnecter();
            }
            return resultat;
        }

        //|-----------------------------------------------------------
        //| Retoune un Utilisateur selon le login
        //|-----------------------------------------------------------
        public static Utilisateur GetUtilisateurByLogin(String unLogin)
        {
            Utilisateur resultat;
            string req = "SELECT * FROM utilisateur u WHERE u.login = '" + unLogin + "'";

            try
            {
                DAOFactory.Connecter();

                MySqlDataReader reader = DAOFactory.ExecSQLRead(req);

                //|
                //| Création de l'objet Utilisateur
                //|
                if (reader.Read())
                {
                    resultat = new Utilisateur(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                }
                else
                {
                    //|
                    //| Si on le trouve pas
                    //|
                    resultat = null;
                    throw new ExceptionSio("getUtilisateurByLogin", "Utilisateur introuvable.", "");
                }

                DAOFactory.Deconnecter();

                return resultat;
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
                DAOFactory.Deconnecter();

                return null;
            }
        }

        //|-----------------------------------------------------------
        //| Retoune le service de l'utilisazteur selon le login
        //|-----------------------------------------------------------
        public static String GetServiceByLogin(String unLogin)
        {
            string resultat = "";
            string req = "SELECT u.service FROM utilisateur u WHERE u.login = '" + unLogin + "'";

            try
            {
                DAOFactory.Connecter();

                MySqlDataReader reader = DAOFactory.ExecSQLRead(req);

                if(reader.Read())
                {
                    resultat = reader[0].ToString();
                }
                else
                {
                    resultat = null;
                    throw new ExceptionSio("getServiceByLogin", "Service de l'utilisateur introuvable.", "");
                }

                DAOFactory.Deconnecter();
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
                DAOFactory.Deconnecter();
            }
            return resultat;
        }

        //|-----------------------------------------------------------
        //| Modifie le mot de passe
        //|-----------------------------------------------------------
        public static bool SetNouveauMDP(string login, string mdp)
        {
            bool resultat;

            try
            {
                String req1 = "UPDATE utilisateur SET mdp = '" + mdp + "' WHERE login = '" + login + "';";

                DAOFactory.Connecter();

                DAOFactory.ExecSQLWrite(req1);

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

