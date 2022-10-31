using System;
using System.ComponentModel.DataAnnotations;

namespace Ellabit.Models
{
    public class AuthenticationUserModel
    {
        public AuthenticationUserModel()
        {
        }
        [Required(ErrorMessage ="Email address is required")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }
    }
}

