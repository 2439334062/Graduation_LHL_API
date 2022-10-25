using Graduation_LHL_API.Database;
using Graduation_LHL_API.Dtos;
using Graduation_LHL_API.Entity;
using Graduation_LHL_API.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Graduation_LHL_API.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthenticateController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var loginResult = await _userService.LoginAsync(loginDto.Email,loginDto.Password);
            if (!loginResult)
            {
                return BadRequest();
            }
            return Ok();
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
        [HttpGet]
        public IActionResult GetAll()
        {
            //查询表的所有
            var list = SqlSugarHelper.Db.Queryable<User>().ToList();
            return Ok(list);
        }
    }
}
