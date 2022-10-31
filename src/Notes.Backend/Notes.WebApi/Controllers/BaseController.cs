#pragma warning disable CS8603 // Possible null reference return.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Notes.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseController : Controller
    {
        private IMediator? _mediator;

        protected IMediator Mediator =>
            _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        internal Guid UserId => !User.Identity.IsAuthenticated
            ? Guid.Empty
            : Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
    }
}
