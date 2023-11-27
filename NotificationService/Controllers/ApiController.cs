using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace NotificationService.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : ControllerBase 
    {
        private ILogger<ApiController> _logger;
        private IMediator _mediator;
        private HttpClient _client;

// TODO why is it angry about this
// tbh why would i even do it this way
        protected HttpClient Client => _client ?? (_client = HttpContext.RequestServices.GetService<HttpClient>());
        protected IMediator Mediator => _mediator ?? (_mediator = base.HttpContext.RequestServices.GetService<IMediator>());

// TODO: there is an issue with accessing the mediator
        public ApiController(ILogger<ApiController> logger, IMediator mediator, HttpClient client)
        {
            _client = client;
            _logger = logger;
            _mediator = mediator;
        }
    }
}