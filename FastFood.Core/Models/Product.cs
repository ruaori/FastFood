using System.ComponentModel.DataAnnotations;

namespace FastFood.Core.Models
{
    public class Product : BaseModel
    {
        [Required(ErrorMessage = "{0} is Required!")]
        [StringLength(255, ErrorMessage = "{0} maximum is {1} characters!")]
        public string? ProductName { get; set; }

        [Required(ErrorMessage = "{0} is Required!")]
        [StringLength(1024, ErrorMessage = "{0} maximum is {1} characters!")]
        public string? ShortDescription { get; set; }

        [Required(ErrorMessage = "{0} is Required!")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "{0} is Required!")]
        public string? UrlSlug { get; set; }

        public Guid CategoryID { get; set; }
        public Category? Category { get; set; }
    }
}
