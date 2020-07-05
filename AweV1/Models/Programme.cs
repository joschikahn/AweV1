﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AweV1.Models
{
    public class Programme
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // 1:m Verbindung zu Thesis
        public ICollection<Thesis> thesisList { get; set; }
    }
}