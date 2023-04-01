using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using UserInformationAPI.Models;
using UserInformationAPI.Data;

namespace UserInformationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApiContext _context;

        public UserController(ApiContext context)
        {
            _context = context;
        }
    }
}
