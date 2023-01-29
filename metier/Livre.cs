using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    class Livre : Document
    {
        private string ISBN;
        private string laCollection;
        private string auteurDuLivre;

        public Livre(string unId, string unTitre, string unISBN, string unAuteur, string uneCollection, string uneImage, Categorie uneCategorie) : base(unId, unTitre, uneImage, uneCategorie)
        {
            ISBN1 = unISBN;
            LaCollection = uneCollection;
            auteurDuLivre = unAuteur;
        }

        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string LaCollection { get => laCollection; set => laCollection = value; }
        public string AuteurDuLivre { get => auteurDuLivre; set => auteurDuLivre = value; }
    }
}
