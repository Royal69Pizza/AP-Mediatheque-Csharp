using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Mediateq_AP_SIO2.divers;
using Mediateq_AP_SIO2.metier;

namespace Mediateq_AP_SIO2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //|
            //| Création de la connection
            //|
            DAOFactory.creerConnection();
        }

        //|-----------------------------------------------------------
        //| Login
        //|-----------------------------------------------------------
        private void buttonConnexionUser_Click(object sender, EventArgs e)
        {
            string Login = inputLoginUser.Text;
            string MDP = inputMDPUser.Text;

            //|
            //| Pour le login on autorise juste les chiffres et les lettres
            //|
            Regex regexLogin = new Regex(@"^[\wéèàùëêöôâäüûïî]+$");
            //|
            //| Pour le mot de passe on autorise certain caractères spéciaux
            //|
            Regex regexMdp = new Regex(@"^[\w@&()!_$*€£+=\/;?#éèàùëêöôâäüûïî]+$");

            Match LoginTest = regexLogin.Match(Login);
            Match MdpTest = regexMdp.Match(MDP);

            try
            {
                if (Login == "" || MDP == "")
                {
                    throw new ExceptionSio(0, "buttonConnexionUser_Click", "Login ou MDP vide.");
                }
                else
                {
                    if(!LoginTest.Success || !MdpTest.Success)
                    {
                        throw new ExceptionSio(0, "buttonConnexionUser_Click", "Caractères illégaux détéctés");
                    }
                    else
                    {
                        //|
                        //| Cryptage des données rentrées par l'utilisateur, le login de l'user sert de clé
                        //|
                        string userMdpHashed = XORCipher(MDP, Login);

                        //|
                        //| Récupération du mdp de l'utilisateur par son login
                        //|
                        string bddUserMdpHashed = DAOUtilisateurs.getMdpByLogin(Login);

                        //|
                        //| Si le mdp rentré crypté est le meme que celui dans la base de données
                        //|
                        if (userMdpHashed == bddUserMdpHashed)
                        {
                            Utilisateur unUtilisateur = DAOUtilisateurs.getUtilisateurByLogin(Login);

                            //|
                            //| On lance l'appli médiateq
                            //|
                            FrmMediateq Mediateq = new FrmMediateq();

                            //|
                            //| On envoie à l'application l'utilisateur qui c'est connecté
                            //|
                            Mediateq.UtilisateurLogged = unUtilisateur;

                            Mediateq.Show();

                            this.Hide();
                        }
                        else
                        {
                            throw new ExceptionSio(0, "buttonConnexionUser_Click", "Mot de passe incorrect.");
                        }
                    }
                }
            } catch (ExceptionSio ex)
            {
                MessageBox.Show("Niveau d'erreur : " + ex.NiveauExc + "\nLocalisation : " + ex.LibelleExc + "\nInfo : " + ex.Message + " ", "Mediateq", MessageBoxButtons.OK);
            }
        }

        /** [CRYPTAGE XOR] Cryptage en XOR
         * @param data (mdp)
         * @param key (clé de chiffrement)
         * **/
        public string XORCipher(string data, string key)
        {
            int dataLen = data.Length;
            int keyLen = key.Length;
            char[] output = new char[dataLen];

            for (int i = 0; i < dataLen; ++i)
            {
                output[i] = (char)(data[i] ^ key[i % keyLen]);
            }
            return new string(output);
        }
    }
}
