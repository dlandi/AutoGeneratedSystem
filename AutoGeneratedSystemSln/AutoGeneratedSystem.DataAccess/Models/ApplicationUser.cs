﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AutoGeneratedSystem.DataAccess.Models
{
    public partial class ApplicationUser
    {
        public ApplicationUser()
        {
            ApplicationUserApplicationRole = new HashSet<ApplicationUserApplicationRole>();
        }

        [Key]
        public long ApplicationUserId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        [Required]
        [StringLength(500)]
        public string ProfileImageUrl { get; set; }

        [InverseProperty("ApplicationUser")]
        public virtual ICollection<ApplicationUserApplicationRole> ApplicationUserApplicationRole { get; set; }
    }
}