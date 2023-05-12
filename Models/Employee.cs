using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace baithuchanhexcels.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FacultyID { get; set; }
        [ForeignKey("FacultyID")]
        public Faculty? Faculty { get; set; }
        
    }
}