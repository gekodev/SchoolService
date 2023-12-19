using System.ComponentModel.DataAnnotations;

namespace SchoolService.Models;

public class Clazz
{
  [Key]
  public int SourcedId { get; set; }
  public int OrgSourcedId { get; set; }
  public string? Title { get; set; }
  public string? sessionSourcedIds { get; set; }
  public string? CourseSourcedId { get; set; }
}
