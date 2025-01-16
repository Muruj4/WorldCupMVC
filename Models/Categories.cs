using System.ComponentModel.DataAnnotations;

namespace WorldCup.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter category name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter category description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter category icon")]
        public string Icon { get; set; }
        [Required(ErrorMessage = "Please enter category url")]
        public string Url { get; set; }

    }



}
