﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AutoGeneratedSystem.DataAccess.Models
{
    public partial class ApplicationUserApplicationRole
    {
        [Key]
        public long ApplicationUserApplicationRoleId { get; set; }
        public long ApplicationUserId { get; set; }
        public short ApplicationRoleId { get; set; }

        [ForeignKey("ApplicationRoleId")]
        [InverseProperty("ApplicationUserApplicationRole")]
        public virtual ApplicationRole ApplicationRole { get; set; }
        [ForeignKey("ApplicationUserId")]
        [InverseProperty("ApplicationUserApplicationRole")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}