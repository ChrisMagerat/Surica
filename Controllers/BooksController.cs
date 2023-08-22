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
            BookName= "Lord of the Rings",
            DatePublished =new DateTime( 1970,01,01),
            Publisher= "Harpercollins",
            CopiesSold= 10000
        })
        .ToArray();
    }
}
