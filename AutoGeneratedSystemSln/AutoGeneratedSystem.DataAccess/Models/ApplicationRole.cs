﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AutoGeneratedSystem.DataAccess.Models
{
    public partial class ApplicationRole
    {
        public ApplicationRole()
        {
            ApplicationUserApplicationRole = new HashSet<ApplicationUserApplicationRole>();
        }

        [Key]
        public short ApplicationRoleId { get; set; }
        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }
        [Required]
        [StringLength(50)]
        public string RoleDescription { get; set; }

        [InverseProperty("ApplicationRole")]
        public virtual ICollection<ApplicationUserApplicationRole> ApplicationUserApplicationRole { get; set; }
    }
}