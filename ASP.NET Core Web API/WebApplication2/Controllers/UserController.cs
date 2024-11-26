using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.services;

namespace WebApplication2.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetUser(int userId){
        var user = await _userService.GetUserAsync(userId);
        if(user == null) return NotFound();
        return Ok(user);
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetAllStudents(){
        var students = await _userService.GetAllStudentAsync();
        return Ok(students);
    }


}