using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SchoolService.Models;

public class TimeBlock

{
    [Key]
    public int SisId { get; set;  }
    public string? Name { get; set; }
    public string? Comment { get; set; }
    public DateTime StartTime {  get; set; }
    public DateTime EndTime { get; set; }
    public int Minutes { get; set; }

}
