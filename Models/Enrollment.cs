using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace SchoolService.Models;

[PrimaryKey(nameof(ClassSourcedId), nameof(UserSourcedId))]
public class Enrollment
{
    public int ClassSourcedId { get; set; }
  public int UserSourcedId { get; set; }
    public string? Role { get; set; }
}
