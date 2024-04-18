namespace Acromyms;

public class MessageSender
{
    public void SendMessage(Message message)
    {
        // send message algorithm utilising the message 
        // and mobile number

        MessageStorage.SaveMessage(message);
    }
}

public class MessageStorage
{
    public static void SaveMessage(Message message) { 
        // save message to storage option
    }
}

public class Message
{
    public string MobileNumber { get; set; }
    public string MessageContents { get; set; }

    public Message(string mobileNumber, string messageContents)
    {
        MobileNumber = mobileNumber;
        MessageContents = messageContents;
    }
}
