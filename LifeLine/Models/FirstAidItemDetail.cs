using System.ComponentModel.DataAnnotations;

namespace LifeLine.Models
{
    public class FirstAidItemDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string TitleStatement { get; set; }
        [Required]
        public string ContentStatement { get; set; }
        [Required]
        public string TitleReason { get; set; }
        [Required]
        public string ContentReason { get; set; }
        [Required]
        public string TitleSTEP { get; set; }
        [Required]
        public string TitlePrevent { get; set; }
        [Required]
        public string ContentPrevent { get; set; }
        public string TitleSymtoms { get; set; }
        public string ContentSymtoms { get; set; }
        public string TitleConsc { get; set; }
        public string ContentConsc { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
