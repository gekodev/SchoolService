using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolService.Data;
using SchoolService.Models;

namespace SchoolService.Controllers;

[Route("api/[controller]")]
[ApiController]
  public class ImportsController : ControllerBase
  {
      private readonly AppDbContext _context;

      public ImportsController(AppDbContext context)
      {
          _context = context;
      }

    
      // POST: api/Teachers
      // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
      [HttpPost]
      public async Task<ActionResult<Teacher>> Post(Teacher teacher)
      {
          _context.Teacher.Add(teacher);
          await _context.SaveChangesAsync();

          return CreatedAtAction("GetTeacher", new { id = teacher.SisId }, teacher);
      }

  }
