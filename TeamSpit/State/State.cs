using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;

namespace TeamSpit.State
{
    public abstract class State
    {
        protected UtilisateurActuel _utilisateurActuel;

        public void SetContext(UtilisateurActuel utilisateurActuel)
        {
            this._utilisateurActuel = utilisateurActuel;
        }

        public abstract void Connecte(Utilisateur utilisateur);

        public abstract void Deconnecte(Utilisateur utilisateur);
    }
}
