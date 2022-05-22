namespace UsersApiExample.Response
{
    public sealed record UserDetailsAddressResponse(
        string Street,
        string City,
        string State,
        string Country,
        string Timezone
    );
    


    
}
