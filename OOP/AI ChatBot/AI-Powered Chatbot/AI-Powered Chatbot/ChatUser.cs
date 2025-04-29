abstract class ChatUser
{
    protected string name; // Allows child classes to access

    public string Name => name; // Read-only property

    public ChatUser(string name)
    {
        this.name = name;

    }
}
