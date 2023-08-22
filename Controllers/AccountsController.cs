using Microsoft.AspNetCore.Mvc;

namespace Surica.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{
    public string Get() {
            return "Welcome To Web API";
        }
}
