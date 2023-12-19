using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace SchoolService.Models;
[PrimaryKey(nameof(UserSourcedId), nameof(RelationshipUserSourcedId))]
public class Relationship
{
  public int UserSourcedId { get; set; }
  public string? RelationshipUserSourcedId { get; set; }
    public string? RelationshipRole { get; set; }
}
