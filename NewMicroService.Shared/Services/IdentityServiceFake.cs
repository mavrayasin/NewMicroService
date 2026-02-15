namespace NewMicroService.Shared.Services;

public class IdentityServiceFake : IIdentityService
{
    public Guid UserId => Guid.Parse("4af20000-006d-2892-fde6-08de6c1886d0");
    public string UserName => "Ahmet Y.";
    public List<string> Roles => [];
}