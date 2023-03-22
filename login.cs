using System;
using System.Security.Cryptography;
using System.Text;
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

        private void Login_Load(object sender, EventArgs e)
        {
            //|
            //| Création de la connection
            //|
            DAOFactory.CreerConnection();
        }

        //|-----------------------------------------------------------
        //| Login
        //|-----------------------------------------------------------
        private void ButtonConnexionUser_Click(object sender, EventArgs e)
        {
            string Login = inputLoginUser.Text;
            string MDP = inputMDPUser.Text;

            //|
            //| Pour le login on autorise juste les chiffres et les lettres
            //|
            Regex regexLogin = new Regex(@"^[\w]+$");

            Match LoginTest = regexLogin.Match(Login);

            try
            {
                if (Login == "" || MDP == "")
                {
                    throw new ExceptionSio("Connexion à Mediateq", "Login ou MDP vide.", "");
                }
                else
                {
                    if (!LoginTest.Success)
                    {
                        throw new ExceptionSio("Connexion à Mediateq", "Caractères illégaux détéctés.", "");
                    }
                    else
                    {
                        //|
                        //| Cryptage des données rentrées par l'utilisateur, le login de l'user sert de clé
                        //|
                        string userMdpHashed = MD5(MDP);

                        //|
                        //| Récupération du mdp de l'utilisateur par son login
                        //|
                        string bddUserMdpHashed = DAOUtilisateurs.GetMdpByLogin(Login);

                        //|
                        //| Si le mdp rentré crypté est le meme que celui dans la base de données
                        //|
                        if (userMdpHashed == bddUserMdpHashed)
                        {
                            Utilisateur unUtilisateur = DAOUtilisateurs.GetUtilisateurByLogin(Login);

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
                            throw new ExceptionSio("Connexion à Mediateq", "Mot de passe incorrect.", "");
                        }
                    }
                }
            } catch (ExceptionSio ex)
            {
                MessageBox.Show(ex.MessageErreur, ex.LibelleErreur, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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
    }
}
