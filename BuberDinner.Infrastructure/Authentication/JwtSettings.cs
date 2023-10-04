
namespace BuberDinner.Infrastructure.Authentication;

public class JwtSettings
{
    public const string SectionName = "JwtSettings";
    public required string Secret { get; init; }
    public int ExpiryMinutes { get; init; }
    public string? Issuer { get; init; }
    public string? Audience { get; init; }

}
