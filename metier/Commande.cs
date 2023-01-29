using System;

namespace Mediateq_AP_SIO2.metier
{
    class Commande
    {
        private int idCommande;
        private int nbExemplaires;
        private DateTime dateCommande;
        private int montant;
        private string titreDoc;
        private string libelleEtatCommande;

        public Commande(int unIdCommande, int unNbExemplaires, DateTime uneDate, int unMontant, string unTitreDoc, string unLibelleEtatCommande)
        {
            this.idCommande = unIdCommande;
            this.nbExemplaires = unNbExemplaires;
            this.dateCommande = uneDate;
            this.montant = unMontant;
            this.titreDoc = unTitreDoc;
            this.libelleEtatCommande = unLibelleEtatCommande;
        }

        public int IdCommande { get => idCommande; set => idCommande = value; }
        public int ExemplairesCommande { get => nbExemplaires; set => nbExemplaires = value; }
        public DateTime DateCommande { get => dateCommande; set => dateCommande = value; }
        public int MontantCommande { get => montant; set => montant = value; }
        public string TitreDocumentCommande { get => titreDoc; set => titreDoc = value; }
        public string IdDEtatCommande { get => libelleEtatCommande; set => libelleEtatCommande = value; }
    }
}
