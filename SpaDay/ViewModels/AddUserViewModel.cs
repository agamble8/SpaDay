using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5-15 characters")]
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters")]
        public string Password { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6)]
        [Compare("Password", ErrorMessage = "Passwords entered must match")]
        public string Verify { get; set; }
    }
}



