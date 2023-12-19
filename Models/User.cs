using System.ComponentModel.DataAnnotations;

namespace SchoolService.Models;

public class User
{
  [Key]
  public int SourcedId { get; set; }
  public string? UserName { get; set; }
  public string? GivenName { get; set; }
  public string? FamilyName { get; set; }
  public string? Password { get; set; }
  public string? ActiveDirectoryMatchId { get; set; }
  public string? Email { get; set; }
  public string? phone { get; set; }
  public string? Sms { get; set; }
}
