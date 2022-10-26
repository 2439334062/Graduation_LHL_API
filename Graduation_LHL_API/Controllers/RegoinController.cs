using Graduation_LHL_API.IServices;
using Graduation_LHL_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Graduation_LHL_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegoinController : ControllerBase
    { 
        private readonly IRegionService _regionService;
        private readonly IHttpContextAccessor _httpContextAccessor;
      
        public RegoinController(IHttpContextAccessor httpContextAccessor,
            IRegionService regionService
            ) { 
            _httpContextAccessor = httpContextAccessor;
            _regionService = regionService;
        }
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPost("add")]
        public async Task<IActionResult> AddRegion([FromBody] String RegionName)
        {
            //获取当前用户
#pragma warning disable CS8602 // 解引用可能出现空引用。
            var userId = _httpContextAccessor
                .HttpContext.User.FindFirst("id").Value;
#pragma warning restore CS8602 // 解引用可能出现空引用。
            var hasRegionName = await _regionService.HasRegionNameByUserIdAsync(int.Parse(userId), RegionName);
           if (hasRegionName)
            {
                return BadRequest("区域名已存在");
            }
            var result = await _regionService.AddRegionAsync(int.Parse(userId), RegionName);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
