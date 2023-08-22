using Microsoft.AspNetCore.Mvc;

namespace Surica.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{
    public Guid UserID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
