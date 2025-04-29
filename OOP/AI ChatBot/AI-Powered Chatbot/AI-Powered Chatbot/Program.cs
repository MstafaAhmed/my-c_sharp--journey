class Program
{
    static void Main()
    {
        ChatBot bot = new ChatBot("AI Assistant");
        bot.StartConversation();

        while (true)
        {
            Console.Write("You: ");
            string userMessage = Console.ReadLine()?.Trim(); // Get input safely

            if (string.IsNullOrEmpty(userMessage)) continue; // Ignore empty input
            if (userMessage.ToLower() == "exit") break;
            if (userMessage.ToLower() == "history")    // display the history
            {
                ChatLogger.ShowChatHistory();
                continue;
            }

            string botResponse = bot.ReceiveMessage(userMessage);
            Console.WriteLine($"{bot.Name}: {botResponse}");

            // Log conversation
            //ChatLogger.LogMessage($"User: {userMessage} | Bot: {botResponse}");
        }

        bot.EndConversation();
    }
}
