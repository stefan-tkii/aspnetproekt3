using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspNetProekt3.Models;
using Microsoft.AspNetCore.Connections.Features;

namespace AspNetProekt3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesApiController : ControllerBase
    {
        private readonly MVCSchoolContext _context;

        public CoursesApiController(MVCSchoolContext context)
        {
            _context = context;
        }

        // GET: api/CoursesApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourse() 
        {
            return await _context.Course.ToListAsync();
        }

        // GET: api/CoursesApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id) // pregled na site studenti i profesori asocirani samo pri filtriranje po ID 
        {
            var course = await _context.Course.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            var first = await _context.Teacher.Where(s => s.Id == course.FirstTeacherId).FirstOrDefaultAsync();
            var second = await _context.Teacher.Where(s => s.Id == course.SecondTeacherId).FirstOrDefaultAsync();
            course.FirstTeacher = first;
            course.SecondTeacher = second;
            var enrolls = await _context.Enrollment.Where(s => s.CourseId == id).Include(s=>s.Student).ToListAsync();
            foreach(Enrollment enr in enrolls)
            { course.AreEnrolled.Add(enr); }

            return course;
        }

        // PUT: api/CoursesApi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse([FromRoute]int id, [FromBody] Course course)
        {
            if (id != course.Id)
            {
                return BadRequest();
            }

            _context.Entry(course).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseExists(id))
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

        // POST: api/CoursesApi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Course>> PostCourse([FromBody] Course course)
        {
            _context.Course.Add(course);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourse", new { id = course.Id }, course);
        }

        // DELETE: api/CoursesApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Course>> DeleteCourse(int id)
        {
            var course = await _context.Course.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            _context.Course.Remove(course);
            await _context.SaveChangesAsync();

            return course;
        }

        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.Id == id);
        }
    }
}
