using OrganicMarket.Domain.Entities.Identity;

namespace OrganicMarket.Application.DTOs.Users;

public class UserAddDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Guid RoleId { get; set; }  = Guid.Parse("EDF6C246-41D8-475F-8D92-41DDDAC3AEFB");
    public Guid ImageId { get; set; } =  Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA");
    
    //public List<AppRole> Roles { get; set; }
}
