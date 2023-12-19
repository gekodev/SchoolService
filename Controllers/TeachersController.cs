using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolService.Data;
using SchoolService.Models;

namespace SchoolService.Controllers;

[Route("api/[controller]")]
  [ApiController]
  public class TeachersController : ControllerBase
  {
      private readonly AppDbContext _context;

      public TeachersController(AppDbContext context)
      {
          _context = context;
      }

      // GET: api/Teachers
      [HttpGet]
      public async Task<ActionResult<IEnumerable<Teacher>>> GetTeacher()
      {
          return await _context.Teacher.ToListAsync();
      }

      // GET: api/Teachers/5
      [HttpGet("{id}")]
      public async Task<ActionResult<Teacher>> GetTeacher(int id)
      {
          var teacher = await _context.Teacher.FindAsync(id);

          if (teacher == null)
          {
              return NotFound();
          }

          return teacher;
      }

      // PUT: api/Teachers/5
      // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
      [HttpPut("{id}")]
      public async Task<IActionResult> PutTeacher(int id, Teacher teacher)
      {
          if (id != teacher.SisId)
          {
              return BadRequest();
          }

          _context.Entry(teacher).State = EntityState.Modified;

          try
          {
              await _context.SaveChangesAsync();
          }
          catch (DbUpdateConcurrencyException)
          {
              if (!TeacherExists(id))
              {
                  return NotFound();
              }
              else
              {
                  throw;
              }
          }

          return NoContent();
      }

      // POST: api/Teachers
      // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
      [HttpPost]
      public async Task<ActionResult<Teacher>> PostTeacher(Teacher teacher)
      {
          _context.Teacher.Add(teacher);
          await _context.SaveChangesAsync();

          return CreatedAtAction("GetTeacher", new { id = teacher.SisId }, teacher);
      }

      // DELETE: api/Teachers/5
      [HttpDelete("{id}")]
      public async Task<IActionResult> DeleteTeacher(int id)
      {
          var teacher = await _context.Teacher.FindAsync(id);
          if (teacher == null)
          {
              return NotFound();
          }

          _context.Teacher.Remove(teacher);
          await _context.SaveChangesAsync();

          return NoContent();
      }

      private bool TeacherExists(int id)
      {
          return _context.Teacher.Any(e => e.SisId == id);
      }
  }
