using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace MatchmakingServer.Controllers;

[ApiController]
[Route("[controller]")]
public class TransformController : ControllerBase
{
    // GET
    [HttpGet]
    public NetworkTransform Get()
    {
        return new NetworkTransform();
    }

    [HttpPost]
    public NetworkTransform Post(NetworkTransform treTransform)
    {
        return treTransform;
    }
}