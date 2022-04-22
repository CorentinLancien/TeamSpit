using TeamSpit.Model;
using TeamSpit.Observer;
using TeamSpit.Services;
using TeamSpit.Singleton;
using TeamSpit.State;

var UtilisateurActuel = new UtilisateurActuel(new Present(), new Utilisateur(1, "erwan"));
UtilisateurActuel.Deconnecte();
UtilisateurActuel.Connecte();