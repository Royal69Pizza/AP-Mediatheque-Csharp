namespace Mediateq_AP_SIO2.metier
{
    class Utilisateur
    {
        private int id;
        private string prenom;
        private string nom;
        private string service;
        private string login;
        private string mdp;

        public Utilisateur(int unID, string unPrenom, string unNom, string unService, string unLogin, string unMdp)
        {
            this.id = unID;
            this.prenom = unPrenom;
            this.nom = unNom;
            this.service = unService;
            this.login = unLogin;
            this.mdp = unMdp;
        }

        public int ID { get => id; set => id = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Service { get => service; set => service = value; }
        public string Login { get => login; set => login = value; }
    }
}
