using MediatR;

namespace NotificationService.Api
{

    public class ApiRequest : IRequest<ApiResponse>
    {
        public string Msg {get; set;} = String.Empty;
    }
    public class ApiResponse
    {
        public string Msg {get; set;} = String.Empty;
    }
}