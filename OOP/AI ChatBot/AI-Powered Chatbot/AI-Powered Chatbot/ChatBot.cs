using AI_Powered_Chatbot;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Linq;

class ChatBot : ChatUser, IChatService
{
    #region Dictionary to store predefined chatbot responses
    private static Dictionary<string, string> responses = new Dictionary<string, string>
    {
        {"hello,hi", "Hello! How can I assist you today?"},
        {"how are you", "I'm an AI, so I don't have feelings, but thanks for asking!"},
        { "bye,see you soon", "Goodbye! Have a great day!"},
        { "your name", "I'm AI Assistant, your chatbot."},
        { "what can you do,job", "I can answer questions, chat, and assist with inquiries!"},
        { "joke", "Why don't scientists trust atoms? Because they make up everything!"},
        { "weather", "I don't have live weather data, but you can check a weather website!"},
        { "who created you", "I was created by Mostafa Ahmed to assist you!"},
        { "age", "I exist outside of time, so I don't have an age!"},
        { "favorite color", "I like all colors equally!"},
        { "fun fact", "Did you know honey never spoils? Archaeologists found 3000-year-old honey still edible!"},
        { "learn programming", "Start with online tutorials, books, or practice on LeetCode and Codecademy!"},
        { "capital of France", "The capital of France is Paris!"},
        { "movie recommendation", "Try watching 'Inception' if you like mind-bending thrillers!"},
        { "president of USA", "I don't have live updates. Check a news website!"},
        { "languages", "I understand English, but I can learn more with training!"},
        { "emotions", "I simulate understanding, but I don't actually feel emotions!"},
        { "sleep", "Nope! I'm always here to assist you!"},
        { "sing", "I can't produce sound, but I can give you song lyrics!"},
        { "meaning of life", "Some say it's 42, others say it's to find happiness."},
        { "advice", "Always keep learning, stay curious, and be kind to others!"}
   
    };
    #endregion
 
    // Constructor initializing chatbot with a name
    public ChatBot(string name) : base(name) { }

    // Method to send a message
    public void SendMessage(string message)
    {
        //Console.WriteLine($"User: {message}"); // Display user message
        Console.WriteLine($"{Name}: {ReceiveMessage(message)}"); // Display chatbot response
    }

    // Method to receive and process a user message
    public string ReceiveMessage(string message)
    {
        message = message.ToLower().Trim(); // Normalize input

        #region Handle mathematical expressions
        string mathPattern = @"(-?\d+(\.\d+)?)\s*([+\-*/])\s*(-?\d+(\.\d+)?)";
        Match match = Regex.Match(message, mathPattern);
        if (match.Success)
        {
            double num1 = double.Parse(match.Groups[1].Value);
            string op = match.Groups[3].Value;
            double num2 = double.Parse(match.Groups[4].Value);

            double result = op switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num2 != 0 ? num1 / num2 : double.NaN,
                _ => double.NaN
            };

            return double.IsNaN(result) ? "Cannot divide by zero." : $"The result of {num1} {op} {num2} is {result}.";
        }
        #endregion


        // Improved search logic: Match any keyword from the dictionary keys
        #region search by a word
        string words = message.Trim();
        var matchwords = responses.Where(kv => kv.Key.Contains(words)).ToList();
        if (matchwords.Count > 0)
        {
            foreach (var matchs in matchwords)
            {
                return matchs.Value;
            }
        }
        #endregion

        return "I'm not sure how to respond to that. Try asking about the weather, a fun fact, or a joke!";
    }


    // Method to start a conversation
    public void StartConversation()
    {
        Console.WriteLine("ChatBot: Hello! I'm here to assist you. Type 'exit' to end the conversation.");
    }

    // Method to end a conversation
    public void EndConversation()
    {
        Console.WriteLine("ChatBot: Conversation ended. Have a nice day!");
    }
}
