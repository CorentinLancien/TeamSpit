using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;

namespace TeamSpit.Memento
{
    public class MessageMemento
	{
		public int id;
		public string description;
		public DateTime dateEnvoie;
		public Utilisateur? utilisateur;

		public MessageMemento(Message message)
		{
			this.id = message.getId();
			this.description = message.getDescription();
			this.dateEnvoie = message.getDateEnvoie();
			this.utilisateur = message.getUtilisateur();
		}

		public void restore(Message message)
		{
			message.setId(this.id);
			message.setDescription(this.description);
			message.setDateEnvoie(this.dateEnvoie);
			message.setUtilisateur(this.utilisateur);
		}
	}
}
