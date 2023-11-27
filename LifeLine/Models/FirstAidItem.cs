using System.ComponentModel.DataAnnotations;

namespace LifeLine.Models
{
    public class FirstAidItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        public int DisplayOrder { get; set; }
    }
}
