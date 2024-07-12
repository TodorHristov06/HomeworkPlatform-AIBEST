using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HWPlatform.DAL.Models;

public class StudentDetails
{
    // TODO: Add relation to Users (one to one)
    // Make the field named Id and make it the PK

    // TODO: Add relation to Classes (one to many)

    [Required]
    public int ClassNumber { get; set; }
}
