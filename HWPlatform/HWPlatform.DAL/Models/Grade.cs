using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HWPlatform.DAL.Models;

public class Grade
{
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int Percentage { get; set; }

    [Required]
    public string Feedback { get; set; } = string.Empty;

    // TODO: Add a relation to HomeworkSubmissions named SubmissionId (one to one)
}
