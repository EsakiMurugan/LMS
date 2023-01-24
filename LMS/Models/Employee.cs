using LMS.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models
{
    public class Employee : ModelBase
    {
        public int EmpNumber { get; set; }
        public string EmpFirstName { get; set; }

        public string EmpMiddleName { get; set; }

        public string EmpLastName { get; set; }

        [NotMapped]
        public string FullName => $"{EmpFirstName} {EmpMiddleName} {EmpLastName}";

        public string EmpShortName { get; set; }

        [DataType(DataType.Date)]
        public DateTime EmpDoj { get; set; }

        public int? EmpMgrId { get; set; }
        [ForeignKey(nameof(EmpMgrId))]

        public virtual Employee? EmployeeManager { get; set; }






        // public List<EmpLeaveRegister> employeeLeaveRegister { get; set; }

        //public List<EmpLeaveApplication> employeeLeaveApplication { get; set;}

        //public List<EmpComp_offRequest> employeeComp_offRequest { get; set; }


    }
}
