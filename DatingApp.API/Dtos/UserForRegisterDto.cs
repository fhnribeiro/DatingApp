using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage="Senha deve ter no mímino 4 caracteres e no máximo 8")]
        public string Password { get; set; }
    }
}