
using GenericRepositoryPatternWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{

    private readonly AppDBContext _context;
    public ProductController(AppDBContext context)
    {
        _context = context;
    }
    [HttpGet]
    public ActionResult get()
    {
        var data = _context.Products;
        return Ok(data);
    }
    [HttpGet]
    [Route("GetProduct/{id}")]
    public ActionResult get(int id)
    {
        var data = _context.Products.FirstOrDefault(x => x.ID == id);
        return Ok(data);
    }
    [HttpPost]
    public ActionResult post(Product newproduct)
    {
        _context.Products.Add(newproduct);
        _context.SaveChanges();

        return CreatedAtAction(nameof(post), new { id = newproduct.ID }, newproduct);
    }

    [HttpPut]
    [Route("Update/{id}")]
    public IActionResult Update(int id, Product product)
    {
        if (id == null)
            return BadRequest();
        else
        {
            var data = _context.Products.FirstOrDefault(s => s.ID == id);
            if (data != null)
            {
                data.Name = product.Name;
                data.Price = product.Price;
                _context.SaveChanges();
                return NoContent();

            }
        }
        return NotFound();
    }
    [HttpDelete]
    [Route("RemoveProduct/{id}")]
    public IActionResult RemoveProduct(int id)
    {
        if (id == null)
            return BadRequest();
        var data = _context.Products.FirstOrDefault(s => s.ID == id);
        if (data != null)
        {
            _context.Products.Remove(data);
            _context.SaveChanges();
            return NoContent();
        }
        return NotFound();
    }

}