﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Entities
{
    // POCO CLass  (Plain OLd C# Object) : 
    // DTO Data Type Object
    public class Cliente
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String CF { get; set; }
        public String Username { get; set; }
        public ContoCorrente mioConto { get; set; }
    }
}
