using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; } //Дата поступления
        
        //Navigation property
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
