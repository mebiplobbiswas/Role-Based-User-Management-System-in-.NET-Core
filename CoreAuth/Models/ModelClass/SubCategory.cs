using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreAuth.Models.ModelClass
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SubCateName { get; set; } = "";
        public string Description { get; set; } = "";

        // Foreign Key for Category
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        // Navigation Property
        public virtual required Category Category { get; set; } 
    }
}
