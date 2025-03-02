using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Route("api/[controller]")]

public class BaseApiController
{
    [NonAction]
    public virtual NotFoundResult NotFound()
        => new NotFoundResult();
}
