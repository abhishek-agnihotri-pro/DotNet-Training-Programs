using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApplication1.Model;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _context.students.ToList();
            return Ok(data);
        }

        [HttpGet("{id}")]
        // [Route("GetStudent/{id}")]
        public IActionResult Get(int id)
        {
            var data = _context.students.FirstOrDefault(student => student.Id == id);
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post(Student student)
        {
            if (!ModelState.IsValid) return BadRequest("Invalid Model State");
            _context.students.Add(student);
            _context.SaveChanges();
            return CreatedAtAction("Get",new {id = student.Id}, student);
        }
        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update(int id,Student student){
            if(id == 0) return BadRequest();
            else{
                var data = _context.students.FirstOrDefault(s => s.Id == id);
                if(data != null){
                    data.FirstName = student.FirstName;
                    data.LastName = student.LastName;
                    data.DOA = student.DOA;
                    data.DOB = student.DOB;
                    _context.SaveChanges();
                    return NoContent();
                }
                else{
                    return BadRequest("Invalid Id");
                }
            }
        }
        [HttpDelete]
        [Route("RemoveStudent/{id}")]
        public IActionResult RemoveStudent(int? id){
            if(id == 0) return BadRequest();
            var data = _context.students.FirstOrDefault(s => s.Id == id);
            if(data != null){
                _context.students.Remove(data);
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }


    }
}