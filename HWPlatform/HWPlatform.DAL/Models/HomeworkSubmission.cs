using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HWPlatform.DAL.Models;

public class HomeworkSubmission
{
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string FilePath { get; set; } = string.Empty;

    [Required]
    public DateTime SubmissionDate {  get; set; }

    [Required]
    public string Comment { get; set; } = string.Empty;

    // TODO: Create a relation to Students named StudentId (one to one)

    // TODO: Create a relation to HomeworkAssignments named AssignmentId (one to many)
}
