using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.Server;
using MVC_Code_First_Approach_EF.Models;

namespace MVC_Layout_Demo.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Users;
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User newStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(newStudent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            if (id == 0) return View();
            else
            {
                var data = _context.Users.FirstOrDefault(y => y.UserID == id);
                return View(data);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0) return View();
            else
            {
                var data = _context.Users.FirstOrDefault(x => x.UserID == id);
                if (data == null) return NotFound();
                return View(data);
            }
        }
        [HttpPost]
        public IActionResult Edit(int id, User modified)
        {
            var data = _context.Users.FirstOrDefault(y => y.UserID == id);
            if (data == null)
            {
                return NotFound();
            }
            data.FirstName = modified.FirstName;
            data.LastName = modified.LastName;
            data.Age = modified.Age;
            data.Password = modified.Password;
            data.PhoneNumber = modified.PhoneNumber;
            data.URL = modified.URL;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Users.FirstOrDefault(y => y.UserID == id);
            if (data == null) return NotFound();
            else
            {
                _context.Users.Remove(data);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
}