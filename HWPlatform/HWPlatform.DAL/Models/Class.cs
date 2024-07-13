using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HWPlatform.DAL.Models;

[PrimaryKey(nameof(ClassName), nameof(Year))]
public class Class
{
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string ClassName { get; set; } = string.Empty;

    [Required]
    public int Year { get; set; }

    // Collection navigation to StudentDetails
    public ICollection<StudentDetails> Students { get; } = new List<StudentDetails>();

    // FK property to Teachers
    public int TeacherId { get; set; }

    [Required]
    public Teacher Teacher { get; set; } = null!;
}
