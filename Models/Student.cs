using System.ComponentModel.DataAnnotations;

namespace SchoolService.Models;

public class Student
{
    [Key]
    public int SisId { get; set; }
    public int SchoolSisId { get; set; }
    public string? FirstName {  get; set; }
    public string? LastName { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? StateId { get; set; }
    public string? SecondaryEmail { get; set; }
    public int StudentNumber { get; set; }
    public string? MiddleName { get; set; }
    public string? Grade { get; set; }
    public string? Status { get; set; }
    public string? Birthdate { get; set; }
    public int GraduationYear { get; set; }
}
