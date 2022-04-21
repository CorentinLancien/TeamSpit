using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Model
{
    public class Conversation
    {
        #region Properties

        private string _titre;

        private List<Utilisateur> _utilisateurs;

        private List<Message> _messages;

        #endregion

        #region Constructors
        public Conversation(string titre, List<Utilisateur> utilisateurs)
        {
            this._titre = titre;
            this._utilisateurs = utilisateurs;
            this._messages = new List<Message>();
        }

        #endregion

        #region Getters and Setters

        public string GetTitre()
        { 
            return _titre; 
        }

        public List<Utilisateur> GetUtilisateurs()
        {
            return this._utilisateurs;
        }

        public List<Message> GetMessages()
        {
            return this._messages;
        }

        public void SetTitre(string titre)
        {
            this._titre = titre;
        }

        public void SetUtilisateurs(List<Utilisateur> utilisateurs)
        {
            this._utilisateurs = utilisateurs;
        }

        public void GetMessages(List<Message> messages)
        {
            this._messages = messages;
        }

        #endregion

        #region Methods

        public void AddMessage(Message message)
        {
            this._messages.Add(message);
        }

        public void AddUtilisateur(Utilisateur utilisateur)
        {
            this._utilisateurs.Add(utilisateur);
        }

        #endregion
    }
}
