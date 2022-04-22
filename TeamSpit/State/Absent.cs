using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;

namespace TeamSpit.State
{
    public class Absent : State
    {
        public override void Deconnecte(Utilisateur utilisateur)
        {
            Console.WriteLine($"{utilisateur.getName()} est déjà absent");
        }

        public override void Connecte(Utilisateur utilisateur)
        {
            Console.WriteLine($"Absent => changement d'état vers présent pour {utilisateur.getName()} ");
            this._utilisateurActuel.TransitionTo(new Present());
        }
    }
}
