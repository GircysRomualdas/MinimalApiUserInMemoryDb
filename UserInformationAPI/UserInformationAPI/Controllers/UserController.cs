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

        [HttpPost]
        public JsonResult CreateEdit(Users user)
        {
            if(user.Id == 0)
            {
                _context.Info.Add(user);
            }
            else
            {
                var UserDb = _context.Info.Find(user.Id);

                if(UserDb == null)
                    return new JsonResult(NotFound());

                UserDb = user;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(user));
        }

        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.Info.Find(id);

            if(result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }
    }
}
