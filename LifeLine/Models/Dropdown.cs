using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeLine.Models
{
    public class Dropdown
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int FirstAidDetailId { get; set; }
        [Required]
        public string StepLine { get; set; }
    }
}
