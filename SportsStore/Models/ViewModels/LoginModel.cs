using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [UIHint("password")] // this can use the asp-for attribute on the input element in the login razor view, the tag helper will set the type attribute to password, that way the text entered on the screen isn't visible to the user's screen
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = "/";

    }
}
