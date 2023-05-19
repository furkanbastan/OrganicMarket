namespace OrganicMarket.App.Models;

public class UserSignUpDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool LightingText { get; set; }  //Aydınlatma Metni
    public bool EmailSending { get; set; }  //Tarafınıza elektronik ileti gönderimi
}
