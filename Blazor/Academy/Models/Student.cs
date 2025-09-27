//using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    public class Student : Human
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stud_id { get; set; }
        [Required]
        [Display(Name = "Группа")]
        public int group {  get; set; }
    }
    //public class Student
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int stud_id { get; set; }
    //    [Required]
    //    public string last_name { get; set; }
    //    [Required]
    //    public string first_name { get; set; }
    //    [Required]
    //    public string middle_name { get; set; }
    //    [Required]
    //    [DataType(DataType.Time)]
    //    public DateOnly birth_date { get; set; }
    //    [Required]
    //    public string email { get; set; }
    //    [Required]
    //    public int group {  get; set; }
    //}

}
