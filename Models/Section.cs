using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SchoolService.Models;

public class Section
{
    [Key]
    public int SisId { get; set; }
    public int SchoolSisId { get; set; }
    public string? SectionName { get; set; }
    public int SectionNumber {  get; set; }
    public int TermSisId { get; set; }
    public string? TermName { get; set; }
    public string? TermStartDate { get; set; }
    public string? TermEndate {  get; set; }  
    public int CourseSisId { get; set; }
    public string? CourseName {  get; set; }
    public int CourseNumber {  get; set; } 
    public string? CourseDescription {  get; set; }
    public string? CourseSubject {  get; set; }
    public int Periods {  get; set; } 
    public string? Status {  get; set; }
}
