using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace NotificationService.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : ControllerBase 
    {
        ILogger<ApiController> _logger;
        IMediator _mediator;
        HttpClient _client;

// TODO why is it angry about this
// tbh why would i even do it this way
        protected HttpClient Client => _client ?? (_client = base.HttpContext.RequestServices.GetService<HttpClient>());
        protected IMediator Mediator => _mediator ?? (_mediator = base.HttpContext.RequestServices.GetService<IMediator>());

// TODO: there is an issue with accessing the mediator --> i think fixed in program.cs
        public ApiController(ILogger<ApiController> logger, IMediator mediator, HttpClient client)
        {
            _client = client;
            _logger = logger;
            _mediator = mediator;
        }
    }
}