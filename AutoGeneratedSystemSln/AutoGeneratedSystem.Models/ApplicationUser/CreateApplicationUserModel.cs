﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGeneratedSystem.Models.ApplicationUser
{
    public class CreateApplicationUserModel
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(50)]
        public string? Lastname { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string? Email { get; set; }
        //[Required]
        //public DateTimeOffset BirthDate { get; set; }
        [Required]
        public int? TestIntId { get; set; }
        [Required]
        public long? TestLongId { get; set; }
        [Required]
        public double TestDoubleId { get; set; }
        [Required]
        public decimal TestDecimalId { get; set; }

        [Required]
        public bool IsApproved { get; set; }
        [Url]
        [Required]
        public string? ProfileImageUrl { get; set; }
    }
}
