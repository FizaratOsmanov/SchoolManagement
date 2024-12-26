using School.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Entities
{
    public class Student : BaseAuditableEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public DateTime EnrolledDate { get; set; }
    }
}
