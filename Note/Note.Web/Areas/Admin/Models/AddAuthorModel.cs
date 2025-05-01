using System.ComponentModel.DataAnnotations;

namespace Note.Web.Areas.Admin.Models
{
    public class AddAuthorModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string? Biography { get; set; }
        [Required, Range(1.00,10.00), RegularExpression("^\\d+(\\.\\d{2})$", ErrorMessage = "Rating Should be 2 decimal places")]
        public double Rating { get; set; }
    }
}
