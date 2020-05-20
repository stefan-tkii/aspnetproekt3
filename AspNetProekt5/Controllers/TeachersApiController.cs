using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspNetProekt3.Models;

namespace AspNetProekt3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersApiController : ControllerBase
    {
        private readonly MVCSchoolContext _context;

        public TeachersApiController(MVCSchoolContext context)
        {
            _context = context;
        }

        // GET: api/TeachersApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeacher() // pregled na kursevi tuka nema, poradi redundansa
        {
            return await _context.Teacher.ToListAsync();
        }

        // GET: api/TeachersApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetTeacher(int id) //pregled na kursevi koi gi predava imame samo dokolku pobarame specificen profesor po ID
        {
            var teacher = await _context.Teacher.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            var courses_primary = await _context.Course.Where(s => s.FirstTeacherId == id).ToListAsync();
            foreach(Course crs in courses_primary)
            { teacher.PrimaryWork.Add(crs); }
            var courses_secondary = await _context.Course.Where(s => s.SecondTeacherId == id).ToListAsync();
            foreach(Course crs in courses_secondary) 
            { teacher.SecondaryWork.Add(crs); }

            return teacher;
        }

        // PUT: api/TeachersApi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacher([FromRoute] int id, [FromBody] Teacher teacher)
        {
            if (id != teacher.Id)
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

        // POST: api/TeachersApi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Teacher>> PostTeacher([FromBody] Teacher teacher)
        {
            _context.Teacher.Add(teacher);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeacher", new { id = teacher.Id }, teacher);
        }

        // DELETE: api/TeachersApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Teacher>> DeleteTeacher(int id)
        {
            var teacher = await _context.Teacher.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _context.Teacher.Remove(teacher);
            await _context.SaveChangesAsync();

            return teacher;
        }

        private bool TeacherExists(int id)
        {
            return _context.Teacher.Any(e => e.Id == id);
        }
    }
}
