
using ASM.Share.Interfaces;
using cty.Models;
using cty.Share.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace cty.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public Istudent StudentSvc;
        public IConfiguration configuration;
        public TokenController(IConfiguration con , Istudent hang)
        {
            StudentSvc = hang;
            configuration = con;
        }
        [HttpPost]
        public async Task<IActionResult> Post(ViewLogin viewLogin)
        {
            if (viewLogin != null && !string.IsNullOrEmpty(viewLogin.UserName)
                && !string.IsNullOrEmpty(viewLogin.Password))
            {
                var student = StudentSvc.Login(viewLogin);
                if (student != null)
                {
                    if (student != null)
                    {
                        var claims = new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Sub, configuration["Jwt:Subject"]),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),

                            new Claim("Id", student.ID_Student.ToString()),
                            new Claim("FullName", student.Name),
                            new Claim("Email", student.Email)
                        };

                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
                        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Audience"],
                            claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                        ViewToken viewToken = new ViewToken()
                        {
                            Token = new JwtSecurityTokenHandler().WriteToken(token),
                            student = student
                        };
                        return Ok(viewToken);
                    }
                    else
                    {
                        return BadRequest("Invalid credentials");
                    }
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }


    }
}
