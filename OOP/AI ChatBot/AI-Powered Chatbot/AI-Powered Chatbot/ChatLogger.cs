
// Logs are saved even after the program ends.
// Users can review past conversations.
sealed class ChatLogger
{
    private static List<string> chatHistory = new List<string>(); // Store chat messages
    private static readonly string logFilePath = "chatlog.txt";  // Log file path

    #region Log a chat message
    public static void LogMessage(string message)
    {
        chatHistory.Add(message);
        Console.WriteLine($"Log: {message}");

        // Append to file
        File.AppendAllText(logFilePath, message + Environment.NewLine);
    }
    #endregion

    #region Retrieve chat history
    public static void ShowChatHistory()
    {
        if (File.Exists(logFilePath))
        {
            Console.WriteLine("\nChat History:");
            Console.WriteLine(File.ReadAllText(logFilePath));
        }
        else
        {
            Console.WriteLine("No chat history found.");
        }
    }
    #endregion

}
