using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    public class Human
    {
        [Required]
        [Display(Name ="Фамилия", Order =-9,Prompt ="Введите фамилию")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string last_name { get; set; }
        [Required]
        public string first_name { get; set; }
        [Required]
        public string? middle_name { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateOnly birth_date { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? phone { get; set; }
    }
}
