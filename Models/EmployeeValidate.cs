using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppUsingEFCore.Models
{
    public class EmployeeValidate
    {
        [Key]
        [DisplayName("Employee ID")]
        public int Eid {set; get;}

        [DisplayName("Employee Name")]
        [DataType(DataType.Text)]
        public string EName { set; get; }

        [DisplayName("Employee Mail ID")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Mail ID entered is Not Valid")]
        public string MailID { set; get; }

        [DisplayName("Date Of Joining")]
        [DataType(DataType.Date)]
        public DateTime Doj { set; get; }

        [DisplayName("Salary")]
        [Range(minimum:1000, maximum:10000000, ErrorMessage = "Salary is Not Valid")]
        public float Salary { set; get; }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string password { set; get; }

        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage= "Password and confirm Password should be same")]
        public string cpassword { set; get; }
    }
}
