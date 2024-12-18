using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JWT_Token_WebAPI.Data;
using JWT_Token_WebAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;

namespace JWT_Token_WebAPI.Controllers;

[Route("api/Auth")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private AppDbContext db;
    private IConfiguration config;
    public AuthenticationController(AppDbContext db, IConfiguration _config)
    {
        this.db = db;
        config = _config;
    }

    [HttpPost]
    [Route("Login")]
    public ActionResult<dynamic> Login(LogInModel model)
    {
        TryValidateModel(model);
        if (ModelState.IsValid)
        {
            var user = db.Users.SingleOrDefault(s => s.Username == model.Username && s.Password == model.Password);

            if (user != null)
            {
                var token = GenerateToken(user);
                return Ok(new { user.Fullname, user.Email, user.Username, user.Role, Token = token });
            }
            else
            {
                return Unauthorized();// status code 403
            }
        }
        else
        {
            return BadRequest(ModelState);
        }
    }
    [NonAction]
    private string GenerateToken(User user)
    {
        //This is a claims list that defined who are the subject, what is to be checked and 
        //who are the audience for the claim

        var claims = new List<Claim>
     {
         new Claim(JwtRegisteredClaimNames.Sub, user.Fullname),
         new Claim(JwtRegisteredClaimNames.Email, user.Email),
         new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
         new Claim(ClaimTypes.Role, user.Role)
     };

        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetValue<string>("Jwt:secret")));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            issuer: config.GetValue<string>("Jwt:issuer"),
            audience: config.GetValue<string>("Jwt:audience"),
            claims: claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: credentials
        );
        string tokenString = new JwtSecurityTokenHandler().WriteToken(token);
        return tokenString;
    }

}