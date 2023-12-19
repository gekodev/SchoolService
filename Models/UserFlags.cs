using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SchoolService.Models;

public class UserFlag
{
  [Key]
  public int UserSourcedId { get; set; }
  public string? Flag { get; set; }
}
