namespace EventEaseApp.Services;
public class UserSessionService
{
    public string? UserName { get; private set; }
    public string? UserEmail { get; private set; }

    public bool IsLoggedIn => !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(UserEmail);

    public void StartSession(string name, string email)
    {
        UserName = name;
        UserEmail = email;
    }

    public void EndSession()
    {
        UserName = null;
        UserEmail = null;
    }
}