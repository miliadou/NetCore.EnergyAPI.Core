using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace NetCore.Energy.Core.Controllers
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("/error-local-development")]
        public IActionResult ErrorLocalDevelopment()
        {    
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            return ValidationProblem(new ValidationProblemDetails
            {
                Title = context.Error.Message,
                Detail = context.Error.StackTrace
            });
        }

        [Route("/error")]
        public IActionResult Error() => ValidationProblem();

    }
}
