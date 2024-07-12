using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HWPlatform.DAL.Models;

public class Teacher
{
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    // TODO: Add a relation to Users named UserId (one to one)

    // TODO: Add a relation to Subjects named SubjectName (one to many)

    // TODO: Add a relation to Classes named ClassId (one to many)
}
