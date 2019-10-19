﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    //I'm thinking that models in the business layer can have non-mapped
    //properties and other sorts of things not seen in the data layer
    class Author
    {
        public int AuthorId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime CreateDate { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
