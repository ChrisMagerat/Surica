using Microsoft.AspNetCore.Mvc;

namespace Surica.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorsController : ControllerBase
{
     private readonly ILogger<AuthorsController> _logger;

    public AuthorsController(ILogger<AuthorsController> logger)
    {
        _logger = logger;
    }

    [HttpGet("AuthorId")]
    public IEnumerable<Authors> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Authors
        {
            AuthorName= "Tolkien",
            ActiveFrom= new DateTime(1892,01,02),
            ActiveTo= new DateTime(1973,09,03)
        })
        .ToArray();
    }
}
