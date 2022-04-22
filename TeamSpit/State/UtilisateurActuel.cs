using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;

namespace TeamSpit.State
{
    public class UtilisateurActuel
    {
        private State _state = null;

        private Utilisateur _utilisateur;

        public UtilisateurActuel(State state, Utilisateur utilisateur)
        {
            _state = state;
            _utilisateur = utilisateur;
            this._state.SetContext(this);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: {_utilisateur.getName()} Transition vers {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        public void Connecte()
        {
            this._state.Connecte(_utilisateur);
        }

        public void Deconnecte()
        {
            this._state.Deconnecte(_utilisateur);
        }

    }
}
