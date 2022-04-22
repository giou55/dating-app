using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    // this is the object which returned when the user login or register
    public class UserDto
    {
        public string Username { get; set;}
        public string Token { get; set;}
    }
}