using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC_EDUHUB.Models;
using MVC_EDUHUB.ViewModel;

namespace MVC_Eduhub.Controllers
{
   public class MaterialController : Controller
{
    private readonly AppDbContext _context; // Database context for accessing material data

    private readonly IMaterialService _materialservice; // Service for material-related operations

    // Constructor to initialize the MaterialController with dependencies
    public MaterialController(AppDbContext context, IMaterialService materialService)
    {
        _materialservice = materialService; // Assigning material service to the private field
        _context = context; // Assigning database context to the private field
    }

    // GET: AddMaterial action to display the form for adding new materials
    public IActionResult AddMaterial()
    {
        return View(); // Returning the view for adding materials
    }

    // POST: AddMaterial action to handle form submission for new materials
    [HttpPost]
    public IActionResult AddMaterial(Material material)
    {
        // Checking if CourseId is stored in TempData and assigning it to the material
        if (TempData.TryGetValue("CourseId", out var courseId))
        {
            material.CourseId = Convert.ToInt32(courseId); // Converting CourseId to integer and assigning it
            TempData.Keep("CourseId"); // Keeping CourseId in TempData for future requests
        }
        
        // Validating the model state before proceeding
        if (ModelState.IsValid)
        {
            _materialservice.Create(material); // Creating a new material using the service
            return RedirectToAction("CourseMaterial", "Material", new { id = material.CourseId }); // Redirecting to CourseMaterial action after creation
        }
        
        return View(); // Returning the view again if model state is invalid
    }

    // GET: CourseMaterial action to display all materials for a specific course
    public IActionResult CourseMaterial(int id)
    {
        TempData["CourseId"] = id; // Storing CourseId in TempData for future use
        TempData.Keep("CourseId"); // Keeping CourseId in TempData
        
        // Fetching materials related to the course using a stored procedure
        var data = _context.MaterialViewModels.FromSqlInterpolated($"dbo.SP_GetMaterialByCourseId {id}");
        
        return View(data); // Returning the view with fetched data
    }

    // GET: Edit action to display the form for editing a specific material by its ID
    public IActionResult Edit(int id)
    {
        var data = _materialservice.GetMaterialByMaterialId(id); // Fetching material data by ID
        
        if (id == 0) // Checking if ID is zero, which may indicate an invalid request
        {
            return View(); // Returning an empty view if ID is zero
        }
        
        return View(data); // Returning the view with fetched material data for editing
    }

    // POST: Edit action to handle form submission for updating a specific material
    [HttpPost]
    public IActionResult Edit(int materialid, Material material)
    {
        var data = _materialservice.GetMaterialByMaterialId(materialid); // Fetching existing material data by ID
        
        if (material == null) // Checking if the submitted material is null, indicating invalid data
        {
            return BadRequest("Invalid material data"); // Returning a bad request response if data is invalid
        }
        
        _materialservice.UpdateMaterial(materialid, material); // Updating the material using the service
        
        return RedirectToAction("CourseMaterial", "Material", new { id = material.CourseId }); // Redirecting to CourseMaterial action after update
    }

    // GET: Delete action to display confirmation for deleting a specific material by its ID
    public IActionResult Delete(int id)
    {
        var data = _materialservice.GetMaterialByMaterialId(id); // Fetching material data by ID
        return View(data); // Returning the view with fetched data for deletion confirmation
    }

    // POST: Delete action to handle deletion of a specific material by its ID
    [HttpPost]
    public IActionResult Delete(int id, Material material)
    {
        var data = _materialservice.GetMaterialByMaterialId(id); // Fetching existing material data by ID
        
        _materialservice.Delete(id); // Deleting the specified material using the service
        
        ViewBag.CourseId = data.CourseId; // Storing CourseId in ViewBag for redirection
        
        return RedirectToAction("CourseMaterial", "Material", new { id = TempData["CourseId"] }); // Redirecting back to CourseMaterial after deletion
    }

    // GET: Details action to display detailed information about a specific material by its ID
    public IActionResult Details(int id)
    {
        var data = _materialservice.GetMaterialByMaterialId(id); // Fetching detailed information of the specified material by ID
        return View(data); // Returning the view with fetched detailed information of the material
    }
}
}