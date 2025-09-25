using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    public class Teacher:Human
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short teacher_id { get; set; }
        [Required]
        public DateOnly work_since { get; set; }
        [Required]
        //[Display(Name = )]
        public decimal rate { get; set; }
        //[Required]
        //public string last_name { get; set; }
        //[Required]
        //public string first_name { get; set; }
        //[Required]
        //public string middle_name { get; set; }
        //[Required]
        //[DataType(DataType.Time)]
        //public DateOnly birth_date { get; set; }
        //[Required]
        //public string email { get; set; }
        //[Required]
        //public string phone { get; set; }
        //[Required]
        //[DataType(DataType.Time)]
        //public DateOnly work_since { get; set; }
        //[Required]
        //public string rate { get; set; }
    }

}
