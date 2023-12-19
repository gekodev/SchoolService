using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SchoolService.Models;

public class Rol
{
  [Key]
  public int UserSourcedId { get; set; }
  public int OrgSourcedId { get; set; }
  public string? Role { get; set; }
  public string? SessionSourcedId { get; set; }
  public int Grade { get; set; }
  public bool IsPrimary { get; set; }
  public string? RoleStartDate { get; set; }
  public string? RoleEndDate { get; set; }
}
