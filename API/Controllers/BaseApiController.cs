using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    // attributes that decorate the controller
    [ApiController]
    [Route("api/[controller]")]
    

    public class BaseApiController : ControllerBase
    {
        
    }
}