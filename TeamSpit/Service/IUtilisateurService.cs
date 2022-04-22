using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;

namespace TeamSpit.Services
{
    public interface IUtilisateurService
    {
        public Utilisateur findById();
    }
}
