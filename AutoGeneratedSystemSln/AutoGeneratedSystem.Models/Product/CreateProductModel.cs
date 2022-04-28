﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoGeneratedSystem.Common.CustomAttributes;
using System.ComponentModel.DataAnnotations;

namespace AutoGeneratedSystem.Models.Product
{
    public class CreateProductModel
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(500)]
        [ImageUrl]
        public string? ImageUrl { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
