using System.ComponentModel.DataAnnotations;

namespace FastFood.Core.Models
{
    public class Category : BaseModel
    {
        [Required(ErrorMessage = "{0} is Required!")]
        [StringLength(255,ErrorMessage = "{0} maximum is {1} characters!")]
        public string? CategoryName { get; set; }

        [Required(ErrorMessage = "{0} is Required!")]
        [StringLength(1024, ErrorMessage = "{0} maximum is {1} characters!")]
        public string? ShortDescription { get; set; }

        [Required(ErrorMessage = "{0} is Required!")]
        public string? UrlSlug { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
