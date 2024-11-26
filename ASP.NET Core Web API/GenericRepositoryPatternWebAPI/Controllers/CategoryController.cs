using Microsoft.AspNetCore.Mvc;
using GenericRepositoryPatternWebAPI.Models;
using GenericRepositoryPatternWebAPI.Repository;
using GenericRepositoryPatternWebAPI.UnitOfWork;


namespace GenericRepositoryPatternWebAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CategoryController:ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    IRepository<Category> categoryRepository;
    public CategoryController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        categoryRepository = new CategoryRepository(_unitOfWork);
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
    {
        var Categories = await categoryRepository.Get();
        return Categories;
    }
}