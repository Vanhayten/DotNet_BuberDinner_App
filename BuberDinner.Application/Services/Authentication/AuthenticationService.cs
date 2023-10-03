namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    AuthenticationResult IAuthenticationService.Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(), 
            firstName, 
            lastName, 
            email, 
            "token");
    }

    AuthenticationResult IAuthenticationService.Login(string email, string password)
    {
        return new AuthenticationResult(
           Guid.NewGuid(),
           "firstName",
           "lastName",
           email,
           "token");
    }
}