using Graduation_LHL_API.Database;
using Graduation_LHL_API.Dtos;
using Graduation_LHL_API.Entity;
using Graduation_LHL_API.Helpers;
using Graduation_LHL_API.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Graduation_LHL_API.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly JwtHelper _jwtHelper;
        public AuthenticateController(IUserService userService,JwtHelper jwtHelper)
        {
            _userService = userService;
            _jwtHelper = jwtHelper;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var loginResult = await _userService.LoginAsync(loginDto.Email,loginDto.Password);
            if (!loginResult)
            {
                return BadRequest();
            }
            var user = await  _userService.FindByEmailAsync(loginDto.Email);
            // 1. 定义需要使用到的Claims
            //    var claims = new[]
            //    {
            //    new Claim(ClaimTypes.Name, "u_admin"), //HttpContext.User.Identity.Name
            //    new Claim(ClaimTypes.Role, "r_admin"), //HttpContext.User.IsInRole("r_admin")
            //    new Claim(JwtRegisteredClaimNames.Jti, "admin"),
            //    new Claim("Username", "Admin"),
            //    new Claim("Name", "超级管理员")
            //};
            var clams = new List<Claim>  
            {
                new Claim("Id",user.Id.ToString()),
                new Claim("SecurityStamp",user.SecurityStamp)
            };
            var result= _jwtHelper.CreateToken(clams);
            
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            var user = new User()
            {
                Email = registerDto.Email,
                UserName = registerDto.Email
            };
            var result = await _userService.CreateAsync(user, registerDto.Password);
            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            //查询表的所有
            var list = SqlSugarHelper.Db.Queryable<User>().ToList();
            return Ok(list);
        }
    }
}
