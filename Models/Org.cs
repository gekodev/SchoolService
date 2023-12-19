using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SchoolService.Models;

public class Org
{
    [Key]
    public int SourcedId { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? parentSourcedId { get; set; }
}
