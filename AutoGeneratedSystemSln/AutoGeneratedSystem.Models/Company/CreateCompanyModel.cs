﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AutoGeneratedSystem.Models.Company
{
    public class CreateCompanyModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Country { get; set; }
        public int NumberOfEmployees { get; set; }
    }
}
