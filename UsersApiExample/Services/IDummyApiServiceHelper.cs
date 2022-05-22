using UsersApiExample.Response;

namespace UsersApiExample.Services
{
    public interface IDummyApiServiceHelper
    {
        public Task<BasePaginationResponse<UserResponse>?> GetUsersAsync(int limit, int page, CancellationToken cancellationToken = default);
        public Task<UserDetailsResponse?> GetByIdAsync(string userId, CancellationToken cancellationToken = default);
    }
}
