﻿using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Seller> Sallers { get; set; } = new List<Seller>();
    }
}
