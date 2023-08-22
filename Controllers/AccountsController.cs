using Microsoft.AspNetCore.Mvc;

namespace Surica.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{
     private readonly ILogger<AccountsController> _logger;

    public AccountsController(ILogger<AccountsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetUserData")]
    public IEnumerable<Accounts> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Accounts
        {
            UserName = "Admin", 
            Password = "1q2w#E"
        })
        .ToArray();
    }
}
