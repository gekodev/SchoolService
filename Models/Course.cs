using System.ComponentModel.DataAnnotations;

namespace SchoolService.Models;

public class Course
{
  [Key]
  public int SourcedId { get; set; }
  public int OrgSourcedId { get; set; }
  public string? Title { get; set; }
  public string? Code { get; set; }
  public string? FamilyName { get; set; }
  public string? SchoolYearSourcedId { get; set; }
  public int Subject { get; set; }
  public string? Grade { get; set; }
}
  
