using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZomatoAPI.Data;
using ZomatoAPI.Entities;

namespace ZomatoAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users  = await context.Users.ToListAsync();

        return Ok(users);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user  = await context.Users.FindAsync(id);

        if(user == null) return NotFound();

        return user;
    }

}
 