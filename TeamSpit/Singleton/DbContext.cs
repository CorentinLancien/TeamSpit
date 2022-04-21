using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSpit.Model;

namespace TeamSpit.Singleton
{
    public class DbContext
    {
        private DbContext()
        {
        }

        private static DbContext? _instance;

        public static DbContext GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DbContext();
            }
            return _instance;
        }
    }
}
