using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Powered_Chatbot
{
    // Interface for chatbot functionality
    internal interface IChatService
    {
        void SendMessage(string message);
        string ReceiveMessage(string message);
        void StartConversation();
        void EndConversation();

    }
}
