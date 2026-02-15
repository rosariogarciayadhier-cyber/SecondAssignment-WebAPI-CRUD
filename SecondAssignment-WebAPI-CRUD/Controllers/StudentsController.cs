using Microsoft.AspNetCore.Mvc;
using SecondAssignment_WebAPI_CRUD.Data;
using SecondAssignment_WebAPI_CRUD.Models;
using SecondAssignment_WebAPI_CRUD.DTOs;

namespace SecondAssignment_WebAPI_CRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Students.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Post(studentDTO dto)
        {
            var student = new Student
            {
                Name = dto.Name,
                Age = dto.Age,
                career = dto.career
            };

            _context.Students.Add(student);
            _context.SaveChanges();

            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, studentDTO dto)
        {
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();

            student.Name = dto.Name;
            student.Age = dto.Age;
            student.career = dto.career;

            _context.SaveChanges();
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();

            _context.Students.Remove(student);
            _context.SaveChanges();

            return Ok("Deleted successfully");
        }
    }
}
