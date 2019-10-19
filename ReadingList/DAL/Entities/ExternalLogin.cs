﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ExternalLogin
    {
        private User _user;

        public virtual string LoginProvider { get; set; }
        public virtual string ProviderKey { get; set; }
        public virtual int UserId { get; set; }

        public virtual User User
        {
            get { return _user; }
            set
            {
                _user = value;
                UserId = value.UserId;
            }
        }
    }
}