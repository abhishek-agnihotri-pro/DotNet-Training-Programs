
class User
{
    public long UserID {get; }
    public string Username {get; set; }
    public string Password {get; set; }
    public string Role {get; set; }
    public string Email {get; set; }
    public string MobileNumber {get; set; }
    public string ProfileImage {get; set; }

    public User(long userID, string username,string password,string role,string email,string mobileNumber,string profileImage){
        UserID = userID;
        Username = username;
        Password = password;
        Role = role;
        Email = email;
        MobileNumber = mobileNumber;
        ProfileImage = profileImage;
    }

}