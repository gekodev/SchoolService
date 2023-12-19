using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolService.Models;

public class Teacher
{
    [Key]
    public int SisId { get; set;  }
    public int SchoolSisId { get; set; }
    public String? FirstName { get; set; }
    public String? LastName { get; set; }
    public String? UserName { get; set; }
    public String? password { get; set; }
    public String? StateId { get; set; }
    public int TeacherNumber { get; set; }
    public String? Status { get; set; }
    public String? MiddleName { get; set; }
    public String? SecondaryEmail { get; set; }
    public String? Title { get; set; }
    public String? Qualification { get; set; }

}
