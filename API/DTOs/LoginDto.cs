using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class LoginDto
    {
        [Required] // data annotation
        public string Username { get; set;}

        [Required] // data annotation
        public string Password { get; set;}
        
    }
}