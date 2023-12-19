  using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolService.Models;

[PrimaryKey(nameof(SectionSisId), nameof(SisId))]
public class StudentEnrollment
{
  public int SectionSisId { get; set; }
  public int SisId { get; set; }
}
