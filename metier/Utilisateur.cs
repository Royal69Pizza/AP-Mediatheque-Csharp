using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    class Utilisateur
    {
        private string prenom;
        private string nom;
        private string service;
        private string login;
        private string mdp;

        public Utilisateur(string unPrenom, string unNom, string unService, string unLogin, string unMdp)
        {
            this.prenom = unPrenom;
            this.nom = unNom;
            this.service = unService;
            this.login = unLogin;
            this.mdp = unMdp;
        }

        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Service { get => service; set => service = value; }
    }
}
