using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using CoreApp.Data.Interfaces;
using CoreApp.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApp.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public string FullName { get; set; }

        public DateTime? BirthDay { set; get; }

        public decimal Balance { get; set; }

        public string Avatar { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Status Status { get; set; }
    }
}
