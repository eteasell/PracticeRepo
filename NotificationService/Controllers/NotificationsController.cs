using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Text.Json;
using NotificationService.Api;

namespace NotificationService.Controllers 
{
    [ApiController]
    [Route("api/notifications")]
    public class NotificationsController : ApiController
    {
        private readonly ILogger<NotificationsController> _logger;

        public NotificationsController(ILogger<NotificationsController> logger, HttpClient client, IMediator mediator) : base(logger, mediator, client)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public ActionResult<ApiResponse> GetBaseUrl() 
        {
            var query = new ApiRequest {Msg = "hi"};
            var result = Mediator.Send(query);

            _logger.LogInformation($" Request Status: {Ok(result).StatusCode.ToString()}");
            
            return Ok(result);
        }

        //  [HttpPost("Notify")]
        // public async Task<ActionResult> Notify() 
        // {
        //     return Ok();
        // }
    }
}