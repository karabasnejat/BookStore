using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAppRazor_Temp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Category Name is required")]
        [DisplayName("Category Name")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Category Name must be between 2 and 30 characters")]
        public string? Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
