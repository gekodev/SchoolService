using System.ComponentModel.DataAnnotations;

namespace SchoolService.Models;

public class Subject
{
  [Key]
  public int SourcedId { get; set; }
  public string? Code { get; set; }
  public string? Name { get; set; }
}
