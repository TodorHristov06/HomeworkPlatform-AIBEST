using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HWPlatform.DAL.Models;

public class StudentDetails
{
    // FK property to Users
    [Key]
    public int UserId { get; set; }

    [Required] 
    public User User { get; set; } = null!;

    // FK property to Classes
    public int ClassId { get; set; }

    [Required]
    public Class Class { get; set; } = null!;

    [Required]
    public int ClassNumber { get; set; }

    // Reference navigation to HomeworkSubmission
    public HomeworkSubmission? HomeworkSubmission { get; set; }
}
