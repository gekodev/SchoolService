using System.ComponentModel.DataAnnotations;

namespace SchoolService.Models;

public class School
{
  [Key]
  public int SisId { get; set; }
  public string? Name { get; set; }
  public int SchoolNumber { get; set; }
  public int SchoolNcesId {  get; set; }
  public string? StateId {  get; set; }
   public int GradeLow { get; set; }
  public int GradeHigh {  get; set; }
  public int PrincipalSisId {  get; set; }
  public string? PrincipalName { get; set; }
  public string? PrincipalSecondaryEmail { get; set; }
  public string? Address { get; set; }
  public string? City { get; set; }
  public string? State {  get; set; }
  public string? Country { get; set; }
  public string? Zip {  get; set; }
  public string? Phone { get; set; }
  public int Zone {  get; set; }
}
