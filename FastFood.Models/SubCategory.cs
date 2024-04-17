using System.ComponentModel.DataAnnotations;

namespace FastFood.Models;

public class SubCategory
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
