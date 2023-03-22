using System;

namespace Mediateq_AP_SIO2.metier
{
    class Commande
    {
        private int idCommande;
        private int nbExemplaires;
        private DateTime dateCommande;
        private int montant;
        private Document document;
        private EtatCommande etatCommande;

        public Commande(int unIdCommande, int unNbExemplaires, DateTime uneDate, int unMontant, Document unDocument, EtatCommande unEtatCommande)
        {
            this.idCommande = unIdCommande;
            this.nbExemplaires = unNbExemplaires;
            this.dateCommande = uneDate;
            this.montant = unMontant;
            this.document = unDocument;
            this.etatCommande = unEtatCommande;
        }

        public int IdCommande { get => idCommande; set => idCommande = value; }
        public int ExemplairesCommande { get => nbExemplaires; set => nbExemplaires = value; }
        public DateTime DateCommande { get => dateCommande; set => dateCommande = value; }
        public int MontantCommande { get => montant; set => montant = value; }
        internal Document Document { get => document; set => document = value; }
        internal EtatCommande EtatCommande { get => etatCommande; set => etatCommande = value; }
    }
}
