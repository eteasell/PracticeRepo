using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Text.Json;

namespace NotificationService.Controllers 
{
    [ApiController]
    [Route("api/notifications")]
    public class NotificationsController : ControllerBase 
    {
        private readonly ILogger<NotificationsController> _logger;
        private readonly HttpClient _client;

        public NotificationsController(ILogger<NotificationsController> logger, HttpClient client)
        {
            _client =  client;
            _logger = logger;
        }

        [HttpGet("")]
        public ActionResult GetBaseUrl() 
        {
            return StatusCode(200);
        }
    }
}