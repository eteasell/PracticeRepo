using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace NotificationService.Api
{
    public class ApiHandler : IRequestHandler<ApiRequest, ApiResponse>
    {
        public async Task<ApiResponse> Handle(ApiRequest request, CancellationToken cancellationToken)
        {
            // TODO: implement handler
            ApiResponse response = new ApiResponse {Msg = "hello"};
            return response;
        }
    }
}
