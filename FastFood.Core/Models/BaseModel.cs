using System.ComponentModel.DataAnnotations;

namespace FastFood.Core.Models
{
    /// <summary>
    /// Base Model
    /// </summary>
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
