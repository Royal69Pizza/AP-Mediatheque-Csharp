using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    class Dvd : Document
    {
        private string id;
        private string synopsis;
        private string réalisateur;
        private int duree;


        public Dvd(string unId, string unSynopsis, string unRealisateur, string unTitre, int uneDuree, string uneImage, Categorie uneCategorie) : base(unId, unTitre, uneImage, uneCategorie)
        {
            Id = unId;
            Synopsis = unSynopsis;
            Realisateur = unRealisateur;
            Duree = uneDuree;
        }

        public string Id { get; private set; }
        public string Synopsis { get; private set; }
        public string Realisateur { get; private set; }
        public int Duree { get; private set; }
    }
}
