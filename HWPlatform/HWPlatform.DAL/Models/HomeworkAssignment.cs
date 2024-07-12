using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HWPlatform.DAL.Models;

public class HomeworkAssignment
{
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public DateTime Deadline { get; set; }

    [Required]
    public int MaxPoints { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Description { get; set; } = string.Empty;

    // TODO: Create a relation to Teachers named TeacherId (one to many)

    // TODO: Create a relation to Subjects named SubjectName (one to many)
}
