using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Model
{
    public class Message
    {
        #region Properties
        private int _id { get; set; }

        private string _description { get; set; }

        private DateTime _dateEnvoie { get; set; }

        private Utilisateur? _utilisateur { get; set; }

        #endregion

        #region Constructors
        public Message(int id, string description, DateTime dateEnvoi, Utilisateur utilisateur)
        {
            this._id = id;
            this._description = description;
            this._dateEnvoie = dateEnvoi;
            this._utilisateur = utilisateur;
        }

        #endregion

        #region Setters and Getters

        public int getId()
        {
            return this._id;
        }

        public string getDescription()
        {
            return this._description;
        }

        public DateTime getDateEnvoie()
        {
            return this._dateEnvoie;
        }

        public Utilisateur getUtilisateur()
        {
            return this._utilisateur;
        }

        public void setId(int id)
        {
            this._id = id;
        }

        public void setDescription(string description)
        {
            this._description = description;
        }

        public void setDateEnvoie(DateTime dateEnvoie)
        {
            this._dateEnvoie= dateEnvoie;
        }

        public void setUtilisateur(Utilisateur utilisateur)
        {
            this._utilisateur = utilisateur;
        }

        #endregion
    }
}
