﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial10.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Prescription = new HashSet<Prescription>();
        }
        public int IdDoctor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Prescription> Prescription { get; set; }
    }
}