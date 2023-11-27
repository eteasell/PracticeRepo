using MediatR;

namespace NotificationService.Api
{
    public class ApiHandler : IRequestHandler<ApiRequest, ApiResponse>
    {
        public Task<ApiResponse> Handle(ApiRequest request, CancellationToken cancellationToken)
        {
            // TODO: implement handler
            throw new NotImplementedException();
        }
    }
}
