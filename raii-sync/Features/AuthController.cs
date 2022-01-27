using Microsoft.AspNetCore.Mvc;

namespace raii_sync.Features
{
    [ApiController]
    public class AuthController : Controller
    {
        [HttpGet("/auth")]
        public string Index()
        {
            return "auth";
        }
    }
}
