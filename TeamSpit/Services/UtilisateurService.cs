using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;

namespace TeamSpit.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        public Utilisateur findById()
        {
            throw new NotImplementedException();
        }

        public Utilisateur findByName(string name)
        {
            Utilisateur utilisateur = null;

            if (name == "corentin")
            {
                utilisateur = new Utilisateur(1, "corentin");
            }
            else if (name == "erwan")
            {
                utilisateur = new Utilisateur(2, "erwan");
            }

            return utilisateur;
        }
    }
}
