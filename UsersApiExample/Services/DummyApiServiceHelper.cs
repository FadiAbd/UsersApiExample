using UsersApiExample.Extensions;
using UsersApiExample.Globals;
using UsersApiExample.Response;

namespace UsersApiExample.Services
{
    public class DummyApiServiceHelper : IDummyApiServiceHelper
    {
        private readonly ILogger<DummyApiServiceHelper> _logger;
        private readonly HttpClient _httpClient;

        public DummyApiServiceHelper(ILogger<DummyApiServiceHelper> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClient = httpClientFactory.CreateClient("dummy");
        }

        public async Task<BasePaginationResponse<UserResponse>?> GetUsersAsync(int limit, int page, CancellationToken cancellationToken = default)
        {
            try
            {
                var response = await _httpClient.GetAsObjectAsync<BasePaginationResponse<UserResponse>>(UserEndpoints.GetAll(limit, page), cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to get users.");
                throw;
            }
        }

        public async Task<UserDetailsResponse?> GetByIdAsync(string userId, CancellationToken cancellationToken = default)
        {
            try
            {
                var response = await _httpClient.GetAsObjectAsync<UserDetailsResponse>(UserEndpoints.GetById(userId), cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to get user details.");
                throw;
            }
        }
    }
}
