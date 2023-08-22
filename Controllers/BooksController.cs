using Microsoft.AspNetCore.Mvc;

namespace Surica.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
     private readonly ILogger<BooksController> _logger;

    public BooksController(ILogger<BooksController> logger)
    {
        _logger = logger;
    }

    [HttpGet("AuthorId")]
    public IEnumerable<Books> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Books
        {
            
        })
        .ToArray();
    }
}
