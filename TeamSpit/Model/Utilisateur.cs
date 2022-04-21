using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Model
{
    public class Utilisateur
    {
        #region Properties
        private int _id;

        private string? _name;

        #endregion

        #region Constructors

        public Utilisateur()
        {
        }

        public Utilisateur(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        #endregion

        #region Methods

        public int getId()
        {
            return _id;
        }

        public string getName()
        {
            return _name;
        }

        public void setId(int id)
        {
            this._id = id;
        }

        public void setName(string name)
        {
            this._name = name;
        }

        #endregion
    }
}
