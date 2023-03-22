using System;


namespace Mediateq_AP_SIO2.divers
{
    public class ExceptionSio : Exception
    {
        private string libelleErreur;
        private string messageErreur;

        public ExceptionSio(string unLibelleErreur, string unMessageErreur, string pMessage) : base(pMessage)
        {
            libelleErreur = unLibelleErreur;
            messageErreur = unMessageErreur;
        }

        public string LibelleErreur { get => libelleErreur; set => libelleErreur = value; }
        public string MessageErreur { get => messageErreur; set => messageErreur = value; }
    }
}
