using System.ComponentModel.DataAnnotations;

namespace SchoolService.Models;

public class AcademicSession
{
  [Key]
  public int SourcedId { get; set; }
  public string? Title { get; set; }
  public int Type { get; set; }
  public string? StartDate { get; set; }
  public string? EndDate{ get; set; }
}
