using System;
using MySql.Data.MySqlClient;
using Mediateq_AP_SIO2.divers;

namespace Mediateq_AP_SIO2
{
    class DAOFactory
    {
        private static MySqlConnection connexion;

        public static void CreerConnection()
        {
            string serverIp = "127.0.0.1";
            string username = "root";
            string password = "";
            string databaseName = "mediateq_csharp";

            string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", serverIp, username, password, databaseName);

            try
            {
                connexion = new MySqlConnection(dbConnectionString);
            }
            catch (Exception e)
            {
                throw new ExceptionSio("Connexion générale à la BDD impossible.", "Configurez ou reconnectez la connexion au server.", e.Message);
            }

        }

        public static void Connecter()
        {
            try
            {
                connexion.Open();
            }
            catch (Exception e)
            {
                throw new ExceptionSio("Connexion locale à la BDD impossible.", "Configurez ou reconnectez la connexion au server.", e.Message);
            }
        }

        public static void Deconnecter()
        {
            connexion.Close();
        }


        // Exécution d'une requête de lecture ; retourne un Datareader
        public static MySqlDataReader ExecSQLRead(string requete)
        {
            MySqlCommand command;
            MySqlDataAdapter adapter;
            command = new MySqlCommand();
            command.CommandText = requete;
            command.Connection = connexion;

            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            MySqlDataReader dataReader;

            try
            {
                dataReader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                throw new ExceptionSio("Erreur de lecture dans la BDD", "Configurez ou reconnectez la connexion au server.", e.Message);
            }

            return dataReader;
        }

        // Exécution d'une requete d'écriture (Insert ou Update) ; ne retourne rien
        public static void ExecSQLWrite(string requete)
        {
            MySqlCommand command;
            command = new MySqlCommand();
            command.CommandText = requete;
            command.Connection = connexion;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new ExceptionSio("Erreur d'écriture dans la BDD", "Configurez ou reconnectez la connexion au server.", e.Message);
            }
            
        }
    }
}
