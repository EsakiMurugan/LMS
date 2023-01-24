using LMS.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models
{
   // [Index(nameof(EmployeeId), IsUnique = true)]
    [Index(nameof(UserName), IsUnique = true)]
    public class UserMaster
    {
        [Key]
        public int UserId { get; set; }

        public string UserSh { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]

        public virtual Employee? Employee { get; set; }

        public bool Admin { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public DateTimeOffset UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }


    }
}
