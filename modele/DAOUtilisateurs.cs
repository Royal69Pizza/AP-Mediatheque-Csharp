using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mediateq_AP_SIO2.metier;
using System.Windows.Forms;
using System.Data.SqlClient;
using Mediateq_AP_SIO2.divers;

namespace Mediateq_AP_SIO2
{
    class DAOUtilisateurs
    {
        //|-----------------------------------------------------------
        //| Retoune le mdp de l'utilisazteur selon le login
        //|-----------------------------------------------------------
        public static string getMdpByLogin(string unLogin)
        {
            string resultat = null;
            string req = "SELECT u.mdp FROM utilisateur u WHERE u.login = '" + unLogin + "'";

            try
            {
                DAOFactory.connecter();

                MySqlDataReader reader = DAOFactory.execSQLRead(req);

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
                    throw new ExceptionSio(1, "getMdpByLogin", "Mot de passe introuvable, connexion impossible.");
                }

                DAOFactory.deconnecter();
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show("Niveau d'erreur : " + ex.NiveauExc + "\nLocalisation : " + ex.LibelleExc + "\nInfo : " + ex.Message + " ", "Mediateq", MessageBoxButtons.OK);
                DAOFactory.deconnecter();
            }
            return resultat;
        }

        //|-----------------------------------------------------------
        //| Retoune un Utilisateur selon le login
        //|-----------------------------------------------------------
        public static Utilisateur getUtilisateurByLogin(String unLogin)
        {
            Utilisateur resultat;
            string req = "SELECT * FROM utilisateur u WHERE u.login = '" + unLogin + "'";

            try
            {
                DAOFactory.connecter();

                MySqlDataReader reader = DAOFactory.execSQLRead(req);

                //|
                //| Création de l'objet Utilisateur
                //|
                if (reader.Read())
                {
                    resultat = new Utilisateur(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                }
                else
                {
                    //|
                    //| Si on le trouve pas
                    //|
                    resultat = null;
                    throw new ExceptionSio(1, "getUtilisateurByLogin", "Utilisateur introuvable.");
                }

                DAOFactory.deconnecter();

                return resultat;
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show("Niveau d'erreur : " + ex.NiveauExc + "\nLocalisation : " + ex.LibelleExc + "\nInfo : " + ex.Message + " ", "Mediateq", MessageBoxButtons.OK);
                DAOFactory.deconnecter();

                return null;
            }
        }

        //|-----------------------------------------------------------
        //| Retoune le service de l'utilisazteur selon le login
        //|-----------------------------------------------------------
        public static String getServiceByLogin(String unLogin)
        {
            string resultat = "";
            string req = "SELECT u.service FROM utilisateur u WHERE u.login = '" + unLogin + "'";

            try
            {
                DAOFactory.connecter();

                MySqlDataReader reader = DAOFactory.execSQLRead(req);

                if(reader.Read())
                {
                    resultat = reader[0].ToString();
                }
                else
                {
                    resultat = null;
                    throw new ExceptionSio(1, "getServiceByLogin", "Service de l'utilisateur introuvable.");
                }

                DAOFactory.deconnecter();
            }
            catch (ExceptionSio ex)
            {
                MessageBox.Show("Niveau d'erreur : " + ex.NiveauExc + "\nLocalisation : " + ex.LibelleExc + "\nInfo : " + ex.Message + " ", "Mediateq", MessageBoxButtons.OK);
                DAOFactory.deconnecter();
            }
            return resultat;
        }
    }
}

