using SqlSugar;

namespace Graduation_LHL_API.Entity
{
    [SugarTable("users")]
    public class User
    {
        [SugarColumn(IsPrimaryKey =true,IsIdentity =true)]
        public int Id { get; set; }
        public string UserName { get; set; }

        public string? Email { get; set; }
        public int EmailConfirme { get; set; }

        public string PasswordHash  { get; set; }

        public string SecurityStamp { get; set; }

        public string? PhoneNumber { get; set; }

        public int PhoneNumberConfirmed { get; set; }
    }
}
