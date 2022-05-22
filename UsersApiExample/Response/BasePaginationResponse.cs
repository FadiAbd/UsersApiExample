namespace UsersApiExample.Response
{
    public sealed record BasePaginationResponse<T>(
        IReadOnlyList<T> Data,
    int Total,
    int Page,
    int Limit
    
    );
    
    
}
