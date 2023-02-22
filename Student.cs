using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feb22Api;

public class Student
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int StudentId { get; set; }
    public string? StudentName { get; set; }
}
