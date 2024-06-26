using Freelasync.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Freelasync.API.Controllers;

[Route("api/users")]
public class UsersController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] CreateUserModel createUserModel)
    {
        return CreatedAtAction(nameof(GetById), new { id = 1}, createUserModel);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id) 
    {
        return Ok();
    }

    [HttpPut("{id}/login")]
    public IActionResult Login(int id, [FromBody] LoginModel loginModel)
    {
        return NoContent();
    }
}
