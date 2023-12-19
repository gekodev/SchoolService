using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SchoolService.Models;

public class Demographic
{
    [Key]
    public int UserSourcedId { get; set; }
    public string? Sex { get; set; }
    public string? BirthDate { get; set; }
    public string? BirthCity {  get; set; }
    public string? BirthState { get; set; }
    public string? BirthCountry { get; set; }
    public string? EthnicityCodes { get; set; }
    public string? RaceCodes {  get; set; }  
}
