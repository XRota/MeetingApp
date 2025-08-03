namespace MEETINGAPP.Models;

public class Repository
{
    private static List<UserInfo> _users = new();
    static Repository()
    {
        // Initialize with some dummy data
        _users.Add(new UserInfo { Name = "John Doe", Email = "john@example.com", Phone = "1234567890", WillAttend = true });
        _users.Add(new UserInfo { Name = "Jane Smith", Email = "jane@example.com", Phone = "0987654321", WillAttend = false });
        _users.Add(new UserInfo { Name = "Alice Johnson", Email = "alice@example.com", Phone = "5555555555", WillAttend = true });
    }

    public static List<UserInfo> Users
    {
        get
        {
            return _users;
        }
    }
    public static void CreateUser(UserInfo user)
    {
        _users.Add(user);
    }
}