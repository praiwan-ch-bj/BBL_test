using Microsoft.AspNetCore.Mvc;
using System.Collections;
using static test_01.Constants.StatusCode;
using test_01.Data;
using test_01.Models;
using test_01.Wrapper;
using static test_01.Wrapper.ApiResponse;

namespace test_01.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = new User();
            var userList = users.Users.ToList();
            
            return Ok(Response(SUCCESS, userList, "happy"));
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var users = new User();
            var userList = users.Users.Where(u => u.id == id).ToList();

            if (userList.Count == 0)
            {
                return Ok(Response(NOTFOUND, new User(), "Unhappy"));
            }

            return Ok(Response(SUCCESS, userList, "happy"));
        }
    }
}
