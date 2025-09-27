using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    public class Discipline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short discipline_id { get; set; }
        [Required]
        public string? discipline_name { get; set; }
        [Required]
        public byte number_of_lessons { get; set; }
    }
}
