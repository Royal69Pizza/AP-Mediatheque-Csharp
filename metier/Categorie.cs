using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    class Categorie
    {
        private string id;
        private string libelle;

        public Categorie(string id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public string getLibelleCategorie()
        {
            return this.libelle;
        }

        public string getIdCategorie()
        {
            return this.id;
        }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
