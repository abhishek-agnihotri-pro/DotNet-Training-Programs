using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebAPI_Flight.Model;
using Microsoft.EntityFrameworkCore;


namespace WebAPI_Flight.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly AppDbContext _context;
        public FlightController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight>>> Getflight()
        {
            return await _context.flight.ToListAsync();
   
        }

        [HttpGet("{id}")]
        // [Route("GetStudent/{id}")]
        public async Task<ActionResult<Flight>> GetFlight(int id)
        {
            var data = await _context.flight.FindAsync(id); //FirstOrDefaultAsync(s => s.id == id);
            if(data == null) return NotFound();
            return data;
        }
        [HttpPost]
        public async Task<ActionResult<Flight>> PostFlight(Flight flight)
        {
            // if (!ModelState.IsValid) return BadRequest("Invalid Model State");
            Console.WriteLine("Post method reached in backend");
            Console.WriteLine(flight.Start + "flight came");
            await _context.flight.AddAsync(flight);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetFlight",new {id = flight.FlightId}, flight);
        }
        [HttpPut]
        [Route("Update/{id}")]
        public async Task<ActionResult<Flight>> Update(int id,Flight flight){
            if(id != flight.FlightId) return BadRequest();

            _context.Entry(flight).State = EntityState.Modified;
            try{
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException){
                if(!FlightExists(id)){
                    return NotFound();
                }
                else{
                    throw;
                }
            }
            return NoContent();
            // if(id == 0) return BadRequest();
            // else{
            //     var data = await _context.flight.FirstOrDefaultAsync(s => s.FlightId == id);
            //     if(data != null){
            //         data.Start = flight.Start;
            //         data.Destination = flight.Destination;
            //         data.Start_time = flight.Start_time;
            //         data.Destination_time = flight.Destination_time;
            //         await _context.SaveChangesAsync();
            //         return NoContent();
            //     }
            //     else{
            //         return BadRequest("Invalid Id");
            //     }
            // }
        }
        private bool FlightExists(int id){
            return _context.flight.Any(e => e.FlightId == id);
        }
        [HttpDelete]
        [Route("RemoveFlight/{id}")]
        public async Task<IActionResult> RemoveFlight(int? id){
            if(id == 0) return BadRequest();
            var data = await _context.flight.FirstOrDefaultAsync(s => s.FlightId == id);
            if(data != null){
                _context.flight.Remove(data);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            return NotFound();
        }


    }
}