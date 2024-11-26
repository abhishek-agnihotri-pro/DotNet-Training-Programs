using JWT_Token_WebAPI.Data;
using JWT_Token_WebAPI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Token_WebAPI.Controllers;


[Route("api/Product")]
[ApiController]
public class ProductController : ControllerBase
{
    private AppDbContext db;
    private IConfiguration config;
    public ProductController(AppDbContext db, IConfiguration _config)
    {
        this.db = db;
        config = _config;
    }

    [Authorize]
    [HttpGet]
    public ActionResult GetAll()
    {
        var product = db.Products.ToList();
        return Ok(product);
    }
}