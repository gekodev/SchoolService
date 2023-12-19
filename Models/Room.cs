using System.ComponentModel.DataAnnotations;

namespace SchoolService.Models;

public class Room
{
  [Key]
  public int SisId { get; set; }
  public string? Code { get; set; }
  [Required]
  public string? Name { get; set; }
  public decimal Size { get; set; }
  public int Capacity { get; set; }
  public string? Number {  get; set; }

}
