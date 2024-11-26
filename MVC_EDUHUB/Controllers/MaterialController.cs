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
        private readonly AppDbContext _context;

        private readonly IMaterialService _materialservice;

        public MaterialController(AppDbContext context, IMaterialService materialService)
        {
            _materialservice = materialService;
            _context = context;
        }

        public IActionResult AddMaterial()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddMaterial(Material material)
        {
            if (TempData.TryGetValue("CourseId", out var courseId))
            {
                material.CourseId = Convert.ToInt32(courseId);
                TempData.Keep("CourseId");
            }
            if (ModelState.IsValid)
            {
                _materialservice.Create(material);
                return RedirectToAction("CourseMaterial", "Material", new { id = material.CourseId });
            }
            return View();

        }

        public IActionResult CourseMaterial(int id)
        {
            TempData["CourseId"] = id;
            TempData.Keep("CourseId");
            // var data = _materialservice.GetMaterialByCourseId(id);
            var data = _context.MaterialViewModels.FromSqlInterpolated($"dbo.SP_GetMaterialByCourseId {id}");
            // return View(data);

            TempData.Keep("CourseId");
            return View(data);
        }

        public IActionResult Edit(int id)
        {
            var data = _materialservice.GetMaterialByMaterialId(id);
            if (id == 0)
            {
                return View();
            }
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(int materialid, Material material)
        {
            var data = _materialservice.GetMaterialByMaterialId(materialid);
            //  
            if (material == null)
            {
                return BadRequest("Invalid material data");
            }
            _materialservice.UpdateMaterial(materialid, material);
            return RedirectToAction("CourseMaterial", "Material", new { id = material.CourseId });
        }

        public IActionResult Delete(int id)
        {
            var data = _materialservice.GetMaterialByMaterialId(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(int id, Material material)
        {
            var data = _materialservice.GetMaterialByMaterialId(id);
            _materialservice.Delete(id);
            ViewBag.CourseId = data.CourseId;
            return RedirectToAction("CourseMaterial", "Material", new { id = TempData["CourseId"] });
        }

        public IActionResult Details(int id)
        {
            var data = _materialservice.GetMaterialByMaterialId(id);
            return View(data);
        }
    }

}