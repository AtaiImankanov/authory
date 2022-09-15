using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Authory.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        [Remote(action: "ValidEmail", controller: "Account", ErrorMessage = "This Email already exist")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]", ErrorMessage = "Некорректный пароль")]
        public string Password { get; set; }
        public string Name { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }

    }
}
