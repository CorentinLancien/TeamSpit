using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;

namespace TeamSpit.State
{
    public class Present : State
    {

        public override void Deconnecte(Utilisateur utilisateur)
        {
            Console.WriteLine($"Present => changement d'état vers absent pour {utilisateur.getName()}");
            this._utilisateurActuel.TransitionTo(new Absent());
        }

        public override void Connecte(Utilisateur utilisateur)
        {
            Console.WriteLine($"{utilisateur.getName()} est déjà présent");
        }
    }
}
