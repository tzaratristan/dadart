﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model.Product
{
    class Profile
    {
        public Guid ProfileId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}