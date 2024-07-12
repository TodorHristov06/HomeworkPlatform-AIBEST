using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HWPlatform.DAL.Models;

public class Class
{
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string ClassName { get; set; } = string.Empty;

    [Required]
    public int Year { get; set; }
    
    // TODO: Create a composite PK from ClassName and Year
}
