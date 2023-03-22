using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BirdsBank.Models.Bird;

public class Bird : IBird
{
    [Key]
    public int Id { get; set; }

    
    [Required]
    [Column(TypeName = "VARCHAR")]
    [StringLength(250)]
    public string Name { get; set; } = "Unknown";


    [Column(TypeName = "VARCHAR")]
    [StringLength(250)]
    public string Description { get; set; } = "No Description";

    [Required]
    [Column(TypeName = "VARCHAR")]
    [StringLength(250)]
    public string Place { get; set; } = "Unknown";
}