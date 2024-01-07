using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GettingStartedApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
// GET: api/Users
[HttpGet]
public IEnumerable<string> Get()
{
    return new string[] { "value1", "value2" };
}

// GET api/Users/5
[HttpGet("{id}")]
public string Get(int id)
{
    return "value";
}

// POST api/Users
[HttpPost]
public void Post([FromBody] string value)
{
}
//Uff new commit
// PUT api/Users/5
[HttpPut("{id}")]
public void Put(int id, [FromBody] string value)
{
}

    //DELETE deletes a record
    // DELETE api/Users/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        //comment in delete
        //another commnet
    }
}
