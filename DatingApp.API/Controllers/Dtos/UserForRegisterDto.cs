using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Controllers.Dtos
{
    public class UserForRegisterDto
    {
            [Required]
            public string UserName {get; set;}
            
            [Required]
            [StringLength(8,MinimumLength =4, ErrorMessage="You must specify paswword betweenn 4 to 8")]
            public string Password {get;set;}

    }
}