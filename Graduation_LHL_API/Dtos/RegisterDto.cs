using System.ComponentModel.DataAnnotations;

namespace Graduation_LHL_API.Dtos
{
    public class RegisterDto
    {
        [Required]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "请输入正确的邮箱")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]//必填
        [Compare(nameof(Password), ErrorMessage = "密码输入不一致")]
        public string ConfirmPassword { get; set; }
    }
}
