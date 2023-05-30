using System;

namespace WindowsFormsAppTaskFinal.DataModels
{
    [Serializable]
    public class Message
    {
        public static int MessageCounter { get; private set; }
        public int MessageCode { get; set; }
        public string Sender { get; } // Sender of the message

        public string Receiver { get; } // Receiver of the message

        public string Title { get; } // Message title

        public string Content { get; } // Message content

        public DateTime Date { get; } // Message date (using the built-in DateTime class)

        // Constructor
        public Message(string sender, string receiver, string title, string content, DateTime date)
        {
            Sender = sender;
            Receiver = receiver;
            Title = title;
            Content = content;
            Date = date;
            MessageCode = MessageCounter;
            MessageCounter++;
        }
        public override bool Equals(object obj)
        {
            if (obj is Message other)
            {
                return Sender.Equals(other.Sender) &&
                       Receiver.Equals(other.Receiver) &&
                       Title.Equals(other.Title) &&
                       Content.Equals(other.Content) &&
                       Date.Equals(other.Date);
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + (Sender != null ? Sender.GetHashCode() : 0);
                hash = hash * 23 + (Receiver != null ? Receiver.GetHashCode() : 0);
                hash = hash * 23 + (Title != null ? Title.GetHashCode() : 0);
                hash = hash * 23 + (Content != null ? Content.GetHashCode() : 0);
                hash = hash * 23 + Date.GetHashCode();
                return hash;
            }
        }

        public override string ToString()
        {
            return $"Message: {Title}\n" +
                   $"From: {Sender}\n" +
                   $"To: {Receiver}\n" +
                   $"Date: {Date:MM/dd/yyyy}\n" +
                   $"Content:\n{Content}";
        }
    }
}