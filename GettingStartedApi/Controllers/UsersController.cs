using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GettingStartedApi.Controllers;

//GET, POST, PUT, PATCH, DELETE
//https://www.iamtimcorey.com  -- GET


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

    //POST creates a new record
    // POST api/Users
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    //PUT updates a whole record (or possibly creates)
    // PUT api/Users/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
            //CNP, Email, PhoneNumber sensitive data
    }

    //PATCH updates part of a record
    //PATCH api/Users/5
    [HttpPatch("{id}")]
    public void Patch(int id, [FromBody] string emailAddress)
    {

    }

    //DELETE deletes a record
    // DELETE api/Users/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        //comment in delete
    }
}
