﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSpit.Model
{
    public class Message
    {
        public int id { get; set; }

        public string description { get; set; }

        public DateTime dateEnvoie { get; set; }

        public Utilisateur? Utilisateur { get; set; }
    }
}